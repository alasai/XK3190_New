/*************************************************************************************
    * 类 名 称：       LoginUser
    * 命名空间：       YIEternalMIS.Common
    * 文 件 名：       LoginUser
    * 创建时间：       2017/6/2 16:13:44
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace YIEternalMIS.Common
{

    /// <summary>
    /// 系统支持３种登录授权策略
    /// </summary>
    public enum LoginAuthType
    {
        /// <summary>
        /// 系统内部用户授权
        /// </summary>
        LocalSystemAuth = 1,

        /// <summary>
        /// Novell网用户授权
        /// </summary>
        NovellUserAuth = 2,

        /// <summary>
        /// Windows域用户授权
        /// </summary>
        WindowsDomainAuth = 3
    }

    /// <summary>
    /// 当前登录的用户信息
    /// </summary>
    [Serializable]
    public class Loginer
    {
        private string _Account = "";
        private string _AccountName = "";
        private string _Email = "";
        private DateTime _LoginTime;
        private LoginAuthType _LoginAuthType = LoginAuthType.LocalSystemAuth;
        private string _FlagAdmin = "N";
        private string _DataSetID;
        private string _DataSetName;
        private string _DBName;

        /// <summary>
        /// 用户帐号，登录帐号
        /// </summary>
        public string Account { get { return _Account; } set { _Account = value; } }

        /// <summary>
        /// 用户名
        /// </summary>
        public string AccountName { get { return _AccountName; } set { _AccountName = value; } }

        /// <summary>
        /// 用户的邮件地址
        /// </summary>
        public string Email { get { return _Email; } set { _Email = value; } }

        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime LoginTime { get { return _LoginTime; } set { _LoginTime = value; } }

        /// <summary>
        /// 登录授权策略
        /// </summary>
        public LoginAuthType LoginAuthType
        {
            get { return _LoginAuthType; }
            set { _LoginAuthType = value; }
        }

        /// <summary>
        /// ADMIN标记
        /// </summary>
        public string FlagAdmin { get { return _FlagAdmin; } set { _FlagAdmin = value; } }

        /// <summary>
        /// 帐套编号
        /// </summary>
        public string DataSetID { get { return _DataSetID; } set { _DataSetID = value; } }

        /// <summary>
        /// 帐套名称
        /// </summary>
        public string DataSetName { get { return _DataSetName; } set { _DataSetName = value; } }

        /// <summary>
        /// 数据库名
        /// </summary>
        public string DBName { get { return _DBName; } set { _DBName = value; } }

        /// <summary>
        /// 是否ADMIN
        /// </summary>
        /// <returns></returns>
        public bool IsAdmin()
        {
            return _FlagAdmin == "Y";
        }

        private static Loginer _User = null;

        /// <summary>
        /// 当前登录的用户
        /// </summary>
        public static Loginer CurrentUser
        {
            get
            {
                if (_User == null) _User = new Loginer(); //空对象
                return _User;
            }
            set
            {
                _User = value;
            }
        }
    }

    /// <summary>
    /// 用于登录及修改密码的实体类
    /// </summary>
    [Serializable]
    public class LoginUser
    {
        private string _Account;
        private string _Password;
        private string _DataSetID;
        private string _DataSetDBName;

        public LoginUser() { }

        public LoginUser(string account, string password, string dataSetID, string dataSetDBName)
        {
            _Account = account;
            _Password = password;
            _DataSetID = dataSetID;
            _DataSetDBName = dataSetDBName;
        }

        /// <summary>
        /// 用户帐号，登录帐号
        /// </summary>
        public string Account { get { return _Account; } set { _Account = value; } }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string Password { get { return _Password; } set { _Password = value; } }

        /// <summary>
        /// 当前登录的帐套
        /// </summary>
        public string DataSetID { get { return _DataSetID; } set { _DataSetID = value; } }

        /// <summary>
        /// 帐套的数据库名
        /// </summary>
        public string DataSetDBName { get { return _DataSetDBName; } set { _DataSetDBName = value; } }
    }
}
