using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using YIEternalMIS.Common;

namespace AppService.DbContext
{
public class SqliteDbContext
    {
        private SqliteDbContext()
        {

        }

        public static SqlSugarClient SugarContext = null;
        private static string ConnectionString
        {
            get
            {
                string reval = PubConstant.SqliteConnstr;
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
                    DbType = DbType.Sqlite, //必填
                    IsAutoCloseConnection = false, //默认false
                    InitKeyType = InitKeyType.Attribute
                });
            }

            return SugarContext;
        }

        public static void Dispose()
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
               LogNHelper.Exception(e);
            }
            finally
            {
                SugarContext = null;
            }

        }
    }
}
