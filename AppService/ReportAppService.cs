using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppService.DbContext;
using Models;
using Models.Db;
using Models.Dto;
using SqlSugar;
using Utils;
using YIEternalMIS.Common;

namespace AppService
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
            try
            {
                var yearNum = time.ToString("yyyyMMdd").ToInt();
                using (var sql = SugarDbContext.GetInstance())
                {
                    return sql.Queryable<Batches>()
                        .Where(s => s.yearNum==yearNum && s.flag ==true)
                        .WhereIF(!string.IsNullOrEmpty(name), s => s.hostName.Contains(name))
                        .WhereIF(!string.IsNullOrEmpty(idnumber), s => s.PIN.Contains(idnumber))
                        .OrderBy(s => s.sort, OrderByType.Desc)
                        .Select(s=>new WeightBatchDto(){batchId = s.batchId,hostName = s.hostName,PIN = s.PIN,weighingBeginTime = s.weighingBeginTime}).ToList();
                }
            }
            catch (Exception e)
            {
                LogNHelper.Exception(e);
            }

            return new List<WeightBatchDto>();
        }

        /// <summary>
        /// 获取称重报表数据
        /// </summary>
        /// <param name="batchId"></param>
        /// <returns></returns>
        public List<WeightGridDto> GetWeightReport(string batchId)
        {
            try
            {

            }
            catch (Exception e)
            {
                LogNHelper.Exception(e);

            }

            return new List<WeightGridDto>();
        }
    }
}
