using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppService.DbContext;
using Models;
using Models.SqliteModel;
using SqlSugar;
using YIEternalMIS.Common;

namespace AppService
{
   public class SqliteAppService
    {

        /// <summary>
        /// 称重数据插入本地数据
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public WeightGridDto InsertWeightGrid(WeightGridDto dto)
        {
            var model=new WeightGridDto();
            try
            {
                using (var sql=SqliteDbContext.GetInstance())
                {
                    //获取上一条未提交到服务器的数据
                    var localLastWeight = sql.Queryable<WeightGridDto>().Where(s => s.BatchId == dto.BatchId)
                        .OrderBy(s => s.WeightTime, OrderByType.Desc).First();
                    //插入本条数据
                    sql.Insertable(dto).ExecuteCommand();
                    if (localLastWeight != null)
                    {
                        model = localLastWeight;
                    }
                }
                return model;
            }
            catch (Exception e)
            {
                LogNHelper.Exception(e);
            }

            return null;
        }
        /// <summary>
        /// 获取本地称重数据
        /// </summary>
        /// <returns></returns>
        public List<WeightGridDto> GetWeightGridList(string batchId)
        {
            //if (string.IsNullOrEmpty(batchId))
            //{
            //    return new List<WeightGridDto>();
            //}
            //var nowTime = DateTime.Now;
            using (var sql = SqliteDbContext.GetInstance())
            {
                return sql.Queryable<WeightGridDto>().Where(s=>s.BatchId==batchId).OrderBy(s=>s.SerialNum,OrderByType.Desc).ToList();
            }
        }
        /// <summary>
        /// 撤销最新一条未提交的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DelLocalWeightById(string id)
        {
            try
            {
                using (var sql = SqliteDbContext.GetInstance())
                {
                   sql.Deleteable<WeightGridDto>().Where(s => s.Id==id).ExecuteCommand();
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
        /// 去头标签读写
        /// </summary>
        /// <param name="hook"></param>
        public void InsertHook(string hook)
        {
            var model = new HeadHooks();
            model.HookNumber = hook;
            model.ReadTime=DateTime.Now;
            using (var sql = SqliteDbContext.GetInstance())
            {
                sql.Insertable(model).ExecuteCommand();
            }
        }

        /// <summary>
        /// 获取固定的称重勾标
        /// </summary>
        /// <param name="num"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public List<string> GetWeightHooks(int num,DateTime time)
        {
            var hooks=new List<string>();
            var stime = new DateTime(time.Year, time.Month, time.Day);
            using (var sql = SqliteDbContext.GetInstance())
            {
                hooks= sql.Queryable<WeightHooks>().Where(s=>s.ReadTime>stime).OrderBy(s=>s.ReadTime).Select(s=>s.HookNumber).Take(num).ToList();
            }

            if (hooks.Any())
            {
                if (hooks.Count < num)
                {
                    int diffCount = num - hooks.Count;
                    for (int i = 0; i < diffCount; i++)
                    {
                        var tempTime = time.AddSeconds(i);
                        hooks.Add(tempTime.ToString("yyMMddHHmmssfff"));
                    }
                }

            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    var tempTime = time.AddSeconds(i);
                    hooks.Add(tempTime.ToString("yyMMddHHmmssfff"));
                }
            }

            return hooks;
        }
    }
}
