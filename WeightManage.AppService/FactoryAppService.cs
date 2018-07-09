using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppService.DbContext;
using WeightManage.Models.Db;
using YIEternalMIS.Common;

namespace WeightManage.AppService
{
    public class FactoryAppService
    {
        public Params GetFactory()
        {
            using (var sql=SugarDbContext.GetInstance())
            {
                return sql.Queryable<Params>().OrderBy(s => s.factoryId).First();
            }
        }


        public bool SaveParam(Params dto)
        {
            try
            {
                using (var sql = SugarDbContext.GetInstance())
                {
                    sql.Deleteable<Params>().ExecuteCommand();
                    sql.Insertable(dto).ExecuteCommand();
                }
                return true;
            }
            catch (Exception e)
            {
               LogNHelper.Exception(e);
            }

            return false;
        }

        public bool UpdateHookWeight(string id, decimal weights, int count)
        {
            try
            {
                decimal perWeight = decimal.Round(weights / count, 2);
                using (var sql = SugarDbContext.GetInstance())
                {
                    sql.Updateable<Params>().UpdateColumns(s=>new Params(){hookCount = count,hooksWeight = weights,hookWeight = perWeight}).Where(s=>s.factoryId==id).ExecuteCommand();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return false;
        }
    }
}
