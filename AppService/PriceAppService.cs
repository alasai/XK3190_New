using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppService.DbContext;
using Models.Db;
using SqlSugar;
using YIEternalMIS.Common;

namespace AppService
{
    public class PriceAppService
    {

        public List<AnimalTypes> GetPriceList()
        {
            var list=new List<AnimalTypes>();
            try
            {
                using (var sql=SugarDbContext.GetInstance())
                {
                    list = sql.Queryable<AnimalTypes>().OrderBy(s=>s.price,OrderByType.Desc).ToList();
                }
            }
            catch (Exception ex)
            {
              LogNHelper.Exception(ex);
            }

            return list;
        }


        public bool SavePrice(AnimalTypes dto)
        {
            try
            {
                using (var sql = SugarDbContext.GetInstance())
                {
                    if (dto.animalTypeId == 0)
                    {
                        sql.Insertable(dto).ExecuteCommand();
                    }
                    else
                    {
                        sql.Updateable(dto).ExecuteCommand();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                LogNHelper.Exception(ex);
            }
            return false;
        }


        public bool DelById(int id)
        {
            try
            {
                using (var sql = SugarDbContext.GetInstance())
                {
                    sql.Deleteable<AnimalTypes>().Where(s => s.animalTypeId == id).ExecuteCommand();
                }
                return true;
            }
            catch (Exception e)
            {
                LogNHelper.Exception(e);
            }
            return false;
        }
    }
}
