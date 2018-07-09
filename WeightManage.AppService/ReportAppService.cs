using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppService.DbContext;
using SqlSugar;
using Utils;
using WeightManage.Models;
using WeightManage.Models.Db;
using WeightManage.Models.Dto;
using YIEternalMIS.Common;

namespace WeightManage.AppService
{
    public class ReportAppService
    {
        /// <summary>
        /// 查询已完成的称重批次
        /// </summary>
        /// <param name="time"></param>
        /// <param name="name"></param>
        /// <param name="idnumber"></param>
        /// <returns></returns>
        public List<WeightBatchDto> GetWeightBatch(DateTime time, string name, string idnumber)
        {
            var list = new List<WeightBatchDto>();
            try
            {
                var yearNum = time.ToString("yyyyMMdd").ToInt();
                using (var sql = SugarDbContext.GetInstance())
                {
                    list= sql.Queryable<Batches>()
                        .Where(s => s.yearNum==yearNum && s.flag ==true)
                        .WhereIF(!string.IsNullOrEmpty(name), s => s.hostName.Contains(name))
                        .WhereIF(!string.IsNullOrEmpty(idnumber), s => s.PIN.Contains(idnumber))
                        .OrderBy(s => s.sort, OrderByType.Desc)
                        .Select(s=>new WeightBatchDto(){batchId = s.batchId,hostName = s.hostName,PIN = s.PIN,weighingBeginTime = s.weighingBeginTime}).ToList();

                    if (list.Any())
                    {
                        list.ForEach(s =>
                        {
                            s.Num = sql.Queryable<WeighingsRaw>().Where(a => a.batchId == s.batchId)
                                .Sum<int>(a => a.hooksCount);
                        });
                    }
                }

                
            }
            catch (Exception e)
            {
                LogNHelper.Exception(e);
            }

            return list;
        }

        /// <summary>
        /// 获取称重报表数据
        /// </summary>
        /// <param name="batchId"></param>
        /// <returns></returns>
        public List<WeightGridDto> GetWeightReport(WeightBatchDto dto)
        {
            var list=new List<WeightGridDto>();
            try
            {
                string batchId = dto.batchId.Trim();
                using (var sql=SugarDbContext.GetInstance())
                {
                    list = sql.Queryable<WeighingsRaw>().Where(s => s.batchId == batchId).Select(s =>
                        new WeightGridDto()
                        {
                            BatchId = s.batchId,
                            Num = s.hooksCount,
                            MaoWeight = s.grossWeights,
                            PiWeight = s.hookWeights,
                            ProductName = s.productName,
                            Price = s.ProductPrice,
                            WeightTime = s.weighingTime
                        }).OrderBy(s=>s.WeightTime).ToList();
                }

                if (list.Any())
                {
                    //int sort = 1;
                    foreach (var s in list)
                    {
                        //s.SerialNum = sort;
                        s.Name = dto.hostName;
                        s.IdNumber = dto.PIN;
                        s.NetWeight = s.MaoWeight - s.PiWeight;
                        s.TotalPrice = s.NetWeight * s.Num;
                       // sort++;
                    }
                }

                return list;
            }
            catch (Exception e)
            {
                LogNHelper.Exception(e);

            }

            return new List<WeightGridDto>();
        }
    }
}
