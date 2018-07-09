using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AppService.DbContext;
using SqlSugar;
using Utils;
using WeightManage.Models;
using WeightManage.Models.Db;
using WeightManage.Models.Dto;
using WeightManage.Models.SqliteModel;
using YIEternalMIS.Common;

namespace WeightManage.AppService
{
    public class WeightAppService
    {
        /// <summary>
        /// 窗口数据初始化
        /// </summary>
        /// <returns></returns>
        public WeightInitDto GetInitData()
        {
            var model=new WeightInitDto();
            try
            {
                var nowTime = DateTime.Now.AddDays(-1);
                using (var sql=SugarDbContext.GetInstance())
                {
                    model.BatchInfo = sql.Queryable<Batches>().Where(s =>s.weighingBeginTime>nowTime&&s.flag == false).First();
                    model.Products = sql.Queryable<AnimalTypes>().Where(s=>s.price>0).ToList();
                    var param = sql.Queryable<Params>().OrderBy(s => s.factoryId).First();
                    if (param != null)
                    {
                        model.HookCount = param.hookCount;
                        model.HooksWeight = param.hooksWeight;
                    }
                }
            }
            catch (Exception ex)
            {
                LogNHelper.Exception(ex);
                return null;
            }

            return model;
        }

        /// <summary>
        /// 刷新货物列表
        /// </summary>
        /// <returns></returns>
        public List<AnimalTypes> GetProduct()
        {
            var list = new List<AnimalTypes>();
            try
            {
                using (var sql = SugarDbContext.GetInstance())
                {
                    list = sql.Queryable<AnimalTypes>().Where(s => s.price > 0).ToList();
                }
            }
            catch (Exception ex)
            {
                LogNHelper.Exception(ex);
            }

            return list;
        }
        /// <summary>
        /// 开始称重
        /// </summary>
        /// <returns></returns>
        public string SaveBatchInfo(Batches dto)
        {
            dto.originalPlace = string.Empty;
            dto.istrace = false;
            dto.upload = false;
            dto.weighingBeginTime = DateTime.Now;
            dto.weighingFinishedTime=TimeHelper.GetMinDateTime();

            try
            {
                var stime=new DateTime(dto.weighingBeginTime.Year, dto.weighingBeginTime.Month, dto.weighingBeginTime.Day);
                using (var sql = SugarDbContext.GetInstance())
                {
                    int sort = sql.Queryable<Batches>().Where(s => s.weighingBeginTime > stime)
                        .OrderBy(s => s.sort, OrderByType.Desc).Select(s => s.sort).First();
                    sort +=1;
                    dto.sort = sort;
                    string sortNum = sort.ToString().PadLeft(2, '0');
                    dto.batchId = dto.yearNum +"-"+sortNum;
                    sql.Insertable(dto).ExecuteCommand();
                }

                return dto.batchId;
            }
            catch (Exception e)
            {
               LogNHelper.Exception(e);
            }

            return string.Empty;
        }

        /// <summary>
        /// 完成称重
        /// </summary>
        /// <param name="batchId"></param>
        /// <returns></returns>
        public bool CompleteWeight(string batchId)
        {
            try
            {

                var stime = DateTime.Now;
                using (var sql = SugarDbContext.GetInstance())
                {
                   sql.Updateable<Batches>()
                        .UpdateColumns(s => new Batches() {flag = true, weighingFinishedTime = stime})
                        .Where(s => s.batchId == batchId).ExecuteCommand();
                }

                return true;
            }
            catch (Exception e)
            {
                LogNHelper.Exception(e);
            }

            return false;
        }
        /// <summary>
        /// 保存数据到服务器
        /// </summary>
        /// <param name="hooks"></param>
        /// <param name="isTrace"></param>
        /// <param name="weightTime"></param>
        /// <returns></returns>
        public bool SaveDataToServer(List<string> hooks,bool isTrace, WeightGridDto dto)
        {

            try
            {
                var hookDt = new DataTable("Hooks");
                hookDt.Columns.Add("hookId", typeof(string));
                hookDt.Columns.Add("attachTime", typeof(DateTime));
                hookDt.Columns.Add("animalId", typeof(string));

                if (isTrace)
                {
                    foreach (var hook in hooks)
                    {
                        DataRow dr = hookDt.NewRow();
                        dr["hookId"] = hook;
                        dr["attachTime"] = dto.WeightTime;
                        dr["animalId"] = "";
                        hookDt.Rows.Add(dr);
                    }
                }
                else
                {
                    foreach (var hook in hooks)
                    {
                        DataRow dr = hookDt.NewRow();
                        dr["hookId"] = hook;
                        dr["attachTime"] = dto.WeightTime;
                        dr["animalId"] = "";
                        hookDt.Rows.Add(dr);
                    }
                }

                SqlParameter[] parameters =
                {
                    new SqlParameter("@batchId", SqlDbType.Char),
                    new SqlParameter("@hooksToSave", SqlDbType.Structured),
                    new SqlParameter("@grossWeights", SqlDbType.Decimal),
                    new SqlParameter("@productName", SqlDbType.VarChar),
                    new SqlParameter("@ProductPrice", SqlDbType.Decimal)
                };

                parameters[0].Value = dto.BatchId;
                parameters[1].Value = hookDt;
                parameters[2].Value = dto.MaoWeight;
                parameters[3].Value = dto.ProductName;
                parameters[4].Value = dto.Price;

               int rowsAffected =  DbHelperSQL.ExcuteProcedure("SaveWeighingInfo", parameters);
                //int rowsAffected = ExecuteProcedure("SaveWeighingInfo", parameters);
               // LogNHelper.Info("rowsAffected1:" + rowsAffected);

                //删除本地勾号
                if (rowsAffected > 0)
                {
                    var stime=new DateTime(dto.WeightTime.Year, dto.WeightTime.Month, dto.WeightTime.Day);
                    using (var sql=SqliteDbContext.GetInstance())
                    {
                        sql.Deleteable<WeightHooks>().Where(s => s.ReadTime > stime && hooks.Contains(s.HookNumber))
                            .ExecuteCommand();
                        sql.Updateable<WeightGridDto>().UpdateColumns(s => new WeightGridDto() {Uploadflag = 1})
                            .Where(s => s.Id == dto.Id).ExecuteCommand();
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
              LogNHelper.Exception(e);

            }
            
            return false;
        }


        /// <summary>
        ///未提交的数据批量提交到服务器
        /// </summary>
        /// <param name="hooks"></param>
        /// <param name="isTrace"></param>
        /// <param name="weightTime"></param>
        /// <returns></returns>
        public bool BatchSaveDataToServer(List<string> hooks, bool isTrace, List<WeightGridDto> localWeights)
        {

            try
            {
                List<Weighings> weights=new List<Weighings>();
                List<WeighingsRaw> weighingsRaws=new List<WeighingsRaw>();
                int index = 0;
                foreach (var dto in localWeights)
                {
                    List<string> tempHooks = hooks.Skip(0).Take(dto.Num).ToList();
                    if (isTrace)
                    {
                        List<string> hookIds =new List<string>();
                        foreach (var hook in tempHooks)
                        {
                            hookIds.Add(hook);
                             var weight = new Weighings();
                            weight.batchId = dto.BatchId;
                            weight.animalId = "";
                            weight.attachTime = dto.WeightTime;
                            weight.weighingTime = dto.WeightTime;
                            weight.hookId = hook;
                            weight.netWeight =decimal.Round(dto.NetWeight / dto.Num,2);
                            weights.Add(weight);
                        }

                        var weightRaw=new WeighingsRaw();
                        weightRaw.batchId = dto.BatchId;
                        weightRaw.productName = dto.ProductName;
                        weightRaw.hooksCount = dto.Num;
                        weightRaw.hookIds = string.Join(",", hookIds);
                        weightRaw.grossWeights = dto.MaoWeight;
                        weightRaw.hookWeights = dto.PiWeight;
                        weightRaw.weighingTime = dto.WeightTime;
                        weightRaw.ProductPrice = dto.Price;
                        weighingsRaws.Add(weightRaw);
                    }
                    else
                    {
                        List<string> hookIds = new List<string>();
                        foreach (var hook in tempHooks)
                        {
                            hookIds.Add(hook);
                            var weight = new Weighings();
                            weight.batchId = dto.BatchId;
                            weight.animalId = "";
                            weight.attachTime = dto.WeightTime;
                            weight.weighingTime = dto.WeightTime;
                            weight.hookId = hook;
                            weight.netWeight = decimal.Round(dto.NetWeight / dto.Num, 2);
                            weights.Add(weight);
                        }

                        var weightRaw = new WeighingsRaw();
                        weightRaw.batchId = dto.BatchId;
                        weightRaw.productName = dto.ProductName;
                        weightRaw.hooksCount = dto.Num;
                        weightRaw.hookIds = string.Join(",", hookIds);
                        weightRaw.grossWeights = dto.MaoWeight;
                        weightRaw.hookWeights = dto.PiWeight;
                        weightRaw.weighingTime = dto.WeightTime;
                        weightRaw.ProductPrice = dto.Price;
                        weighingsRaws.Add(weightRaw);
                    }
                    index++;
                }

                //try
                //{
                //    var sql = SugarDbContext.GetInstance();
                //    sql.Ado.BeginTran();
                //    var cutting=sql.Queryable<cutting>()
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine(e);
                //    throw;
                //}
                //if (rowsAffected > 0)
                //{
                //    var stime = new DateTime(dto.WeightTime.Year, dto.WeightTime.Month, dto.WeightTime.Day);
                //    using (var sql = SqliteDbContext.GetInstance())
                //    {
                //        sql.Deleteable<WeightHooks>().Where(s => s.ReadTime > stime && hooks.Contains(s.HookNumber))
                //            .ExecuteCommand();
                //        sql.Updateable<WeightGridDto>().UpdateColumns(s => new WeightGridDto() { Uploadflag = 1 })
                //            .Where(s => s.Id == dto.Id).ExecuteCommand();
                //    }
                //    return true;
                //}
            }
            catch (Exception e)
            {
                LogNHelper.Exception(e);

            }

            return false;
        }



        
        private int ExecuteProcedure(string procName, SqlParameter[] myPar)
        {

            int affectRow = 0;
            SqlCommand sqlCmd = null;
            SqlConnection sqlCon = new SqlConnection(DbHelperSQL.connectionString);
            try
            {


                sqlCmd = new SqlCommand(procName, sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure; //设置调用的类型为存储过程
                if (myPar != null)
                {
                    foreach (SqlParameter spar in myPar)
                    {
                        sqlCmd.Parameters.Add(spar);
                    }

                }
                sqlCon.Open();
                affectRow = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
                if (sqlCmd != null)
                {
                    sqlCmd.Dispose();
                }
            }

            return affectRow;

        }
    }
}
