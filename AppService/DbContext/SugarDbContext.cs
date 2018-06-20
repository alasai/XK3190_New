using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using YIEternalMIS.Common;

namespace AppService.DbContext
{
     public class SugarDbContext
    {
        private SugarDbContext()
        {

        }

        private static SqlSugarClient SugarContext = null;
        private static string ConnectionString
        {
            get
            {
                string reval = YIEternalMIS.DBUtility.DbHelperSQL.connectionString;
                return reval;
            }
        }
        public static SqlSugarClient GetInstance()
        {
            if (SugarContext == null)
            {
                SugarContext = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = ConnectionString, //必填
                    DbType = DbType.SqlServer, //必填
                    IsAutoCloseConnection = false, //默认false
                    InitKeyType = InitKeyType.Attribute
                });
            }

            return SugarContext;
        }

        private static void Dispose()
        {
            try
            {
                if (SugarContext != null)
                {
                    SugarContext.Dispose();
                }

            }
            catch (Exception e)
            {
              Msg.ShowException(e,"数据库连接失败");
            }
            finally
            {
                SugarContext = null;
            }

        }
    }
}
