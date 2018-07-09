/*************************************************************************************
    * 类 名 称：       BridgeDataBase
    * 命名空间：       YIEternalMIS.Core
    * 文 件 名：       BridgeDataBase
    * 创建时间：       2017/6/2 15:45:02
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YIEternalMIS.Interfaces;
using YIEternalMIS.Common;
using YIEternalMIS.Core.SystemCore;
using YIEternalMIS.DBUtility;

namespace YIEternalMIS.Core
{
    public class BridgeDataBase
    {

        public const string TEST_BRIDGE_FAILED = "测试桥接功能失败，无法建立与后台数据层的连接！";

        /// <summary>
        /// 初始化桥接功能
        /// </summary>
        public static bool InitializeBridge()
        {
            bool connected = false;

            try
            {

                  string iniFilePath = Application.StartupPath + SqlConfiguration.INI_CFG_PATH;
                    //生产环境连接配置
                    IWriteSQLConfigValue cfgNormal = new INIFileWriter(iniFilePath);
                      //串口设置
                     SerialPortConfig.IniFile = iniFilePath;
                    SerialPortConfig.Read();
                    //设置配置信息
                    SqlConfiguration.SetSQLConfig(cfgNormal);
                    connected = SqlConfiguration.TestConnection(true);//测试AdoDirect连接       

                DbHelperSQLite.connectionString="Data Source=" + Application.StartupPath + @"\db\HookData.db";
            }

            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }

            //测试桥接是否成功
            if (false == connected)
            {
                Msg.Warning(TEST_BRIDGE_FAILED );
            }

            return connected;
        }
    }
}
