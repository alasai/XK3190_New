/*************************************************************************************
    * 类 名 称：       SqlConfigWriter
    * 命名空间：       YIEternal.Core
    * 文 件 名：       SqlConfigWriter
    * 创建时间：       2017/6/2 14:56:48
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.IO;
using YIEternalMIS.Common;
using YIEternalMIS.Interfaces;

namespace YIEternalMIS.Core
{


    /// <summary>
    /// 写入INI配置文件
    /// </summary>
    public class INIFileWriter : IWriteSQLConfigValue
    {

        #     region IWriteConfigValue Members
        private string _iniFile;
        private string _ServerName;
        private string _Password;
        private string _UserName;
        private string _InitialCatalog;
        public string InitialCatalog { get { return _InitialCatalog; } set { _InitialCatalog = value; } }
        public string ServerName { get { return _ServerName; } set { _ServerName = value; } }
        public string UserName { get { return _UserName; } set { _UserName = value; } }
        public string Password { get { return _Password; } set { _Password = value; } }


        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="iniFile">INI文件</param>
        public INIFileWriter(string iniFile)
        {
            _iniFile = iniFile;
            if (!System.IO.File.Exists(iniFile))
                Write();

            Read();
        }


        ///// <summary>
        /// 读取配置
        /// </summary>
        public void Read()
        {
            IniFile cfg = new IniFile(_iniFile);
            if (cfg != null)
            {
                _ServerName = cfg.IniReadValue("SQL Configuration", "SqlServer");
                _InitialCatalog = cfg.IniReadValue("SQL Configuration", "database");
                _UserName = cfg.IniReadValue("SQL Configuration", "SqlUser");
                _Password = CEncoder.Decode(cfg.IniReadValue("SQL Configuration", "SqlPwd")); //解密

            }
        }

        /// <summary>
        /// 将配置写入INI文件
        /// </summary>
        public void Write()
        {
            IniFile cfg = new IniFile(_iniFile);
            if (cfg != null)
            {
                cfg.IniWriteValue("SQL Configuration", "SqlServer", _ServerName);
                cfg.IniWriteValue("SQL Configuration", "Database", _InitialCatalog);
                cfg.IniWriteValue("SQL Configuration", "SqlUser", _UserName);
                cfg.IniWriteValue("SQL Configuration", "SqlPwd", CEncoder.Encode(_Password)); //加密
            }
        }

        /// <summary>
        /// 生成连接字符串
        /// </summary>
        /// <returns></returns>
        public string BuildConnectionString()
        {
            return new SqlConfiguration().GetConnectionString(this);
        }

        /// <summary>
        /// 加载连接配置
        /// </summary>
        /// <param name="ConfigFile">配置文件</param>
        public static void LoadConfiguration(string ConfigFile)
        {
            if (System.IO.File.Exists(ConfigFile))
            {
                IWriteSQLConfigValue cfg = new INIFileWriter(ConfigFile);
                SqlConfiguration.SetSQLConfig(cfg);
            }
            else
                throw new Exception("Program cann't run without a SQL configuration.You should config the SQL connection by running LZHBaseFrame.Tools.SqlConnector.exe!");
        }

 #endregion


    }
    /// <summary>
    /// 连接参数保存在系统注册表
    /// </summary>
    public class RegisterWriter : IWriteSQLConfigValue
    {
        #region IWriteConfigValue Members

        private string _keyPath;
        private string _ServerName;
        private string _Password;
        private string _UserName;
        private string _InitialCatalog;

        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="keyPath">注册表位置</param>
        public RegisterWriter(string keyPath)
        {
            _keyPath = keyPath;
            Read();
        }

        /// <summary>
        /// 读取配置
        /// </summary>
        public void Read()
        {
            RegistryKey key = Registry.LocalMachine.CreateSubKey(_keyPath);
            if (key != null)
            {
                _ServerName = Convertto.ToString(key.GetValue("SqlServer", "."));
                _InitialCatalog = Convertto.ToString(key.GetValue("SqlDatabase", ""));
                _UserName = Convertto.ToString(key.GetValue("SqlUser", "sa"));
                _Password = Convertto.ToString(key.GetValue("SqlPwd", ""));
                if (_Password != string.Empty) _Password = CEncoder.Decode(_Password);
                key.Close();
            }
        }

        /// <summary>
        /// 写入配置
        /// </summary>
        public void Write()
        {
            RegistryKey key = Registry.LocalMachine.CreateSubKey(_keyPath);
            if (key != null)
            {
                key.SetValue("SqlServer", _ServerName);
                key.SetValue("SqlDatabase", _InitialCatalog);
                key.SetValue("SqlUser", _UserName);
                key.SetValue("SqlPwd", CEncoder.Encode(_Password));
                key.Close();
            }
        }

        /// <summary>
        /// 生成连接字符串
        /// </summary>
        /// <returns></returns>
        public string BuildConnectionString()
        {
            return new SqlConfiguration().GetConnectionString(this);
        }

        public string InitialCatalog { get { return _InitialCatalog; } set { _InitialCatalog = value; } }
        public string ServerName { get { return _ServerName; } set { _ServerName = value; } }
        public string UserName { get { return _UserName; } set { _UserName = value; } }
        public string Password { get { return _Password; } set { _Password = value; } }

        #endregion
    }
}
