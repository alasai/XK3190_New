/*************************************************************************************
    * 类 名 称：       YIEBookConfig
    * 命名空间：       YIEternalMIS.Common
    * 文 件 名：       YIEBookConfig
    * 创建时间：       2017/6/7 13:47:29
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YIEternalMIS.Common
{
    public  class YIEBookConfig
    {
        string _Server, _DBName, _UserID, _Pwd;
        public string Server 
        {
            get { return _Server; }
            set { _Server = value; }
        }

        public string DBName 
        {
            get { return _DBName; }
            set { _DBName = value; }
        }

        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        public string PWD
        {
            get { return _Pwd; }
            set { _Pwd = value; }
        }

    }
}
