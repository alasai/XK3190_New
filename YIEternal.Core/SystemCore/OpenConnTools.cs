/*************************************************************************************
    * 类 名 称：       OpenConnTools
    * 命名空间：       YIEternalMIS.Core
    * 文 件 名：       OpenConnTools
    * 创建时间：       2017/6/5 9:43:39
    * 作    者：        王宏巍
    * 说   明：        启动数据库参数配置程序
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace YIEternalMIS.Core
{
    public static class OpenConnTools
    {
        public const string _PatchTools = @"\YIEternalMIS.Tools.SqlConnector.exe";


        public static void OpenTools()
        {
            string sPathTools = Application.StartupPath + _PatchTools ;
            if (File.Exists(sPathTools))
            {
                System.Diagnostics.Process.Start( sPathTools);
            }
        }

    }
}
