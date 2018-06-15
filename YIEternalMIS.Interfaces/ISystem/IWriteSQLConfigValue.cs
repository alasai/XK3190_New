/*************************************************************************************
    * 类 名 称：       IWriteSQLConfigValue
    * 命名空间：       YIEternalMIS.Interfaces
    * 文 件 名：       IWriteSQLConfigValue
    * 创建时间：       2017/6/2 13:52:52
    * 作    者：         
    * 说   明：        SQL连接接口
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YIEternalMIS.Interfaces
{

    /// <summary>
    /// 存储SQL连接配置的接口
    /// </summary>
    public interface IWriteSQLConfigValue
    {
        /// <summary>
        /// 写入SQL的连接配置信息
        /// </summary>
        void Write();

        /// <summary>
        /// 读取SQL的连接配置信息
        /// </summary>
        void Read();

        /// <summary>
        /// SQL Server Name/IP
        /// </summary>
        string ServerName { get; set; }

        /// <summary>
        /// 连接的数据库
        /// </summary>
        string InitialCatalog { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// 生成连接字符串
        /// </summary>
        /// <returns></returns>
        string BuildConnectionString();
    }
}
