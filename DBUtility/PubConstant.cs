using System;
using System.Configuration;
using YIEternalMIS.Common;
namespace YIEternalMIS.DBUtility
{
    
    public class PubConstant
    {
        private static string _Connstr;
        private static string _connectionString;

        public static string Connstr
        {
            set { _Connstr = value; }
            get { return _Connstr; }
        }
        
        /// <summary>
        /// 获取连接字符串
        /// </summary>

        public static string ConnectionString
        {
            set { _connectionString = value; }
            get 
            {
                return _connectionString; 
            }

        }



        /// <summary>
        /// 得到web.config里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }


    }
}
