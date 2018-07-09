using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AppService.DbContext;
using WeightManage.Models.Db;
using YIEternalMIS.Common;

namespace WeightManage.AppService
{
    public class ProductAppService
    {

        public List<Products> GetProductList(int page, int psize)
        {
            var list = new List<Products>();
            try
            {
              //  var nowTime = DateTime.Now.AddDays(-1);
                using (var sql = SugarDbContext.GetInstance())
                {
                    list = sql.Queryable<Products>().OrderBy(s => s.productNo).ToList();
                }
            }
            catch (Exception ex)
            {
                LogNHelper.Exception(ex);
               
            }

            return list;
        }


        public bool SaveData(Products dto)
        {
            try
            {
                using (var sql = SugarDbContext.GetInstance())
                {
                    if (dto.productId > 0)
                    {
                        sql.Updateable(dto).ExecuteCommand();
                    }
                    else
                    {
                        sql.Insertable(dto).ExecuteCommand();
                    }
                }
                return true;
            }
            catch (Exception e)
            {
              LogNHelper.Exception(e);
            }
            return false;
        }

        public bool DelById(int id)
        {
            try
            {
                using (var sql = SugarDbContext.GetInstance())
                {
                    sql.Deleteable<Products>().Where(s => s.productId == id).ExecuteCommand();
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
