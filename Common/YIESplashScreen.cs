using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace YIEternalMIS.Common
{
    public partial class YIESplashScreen : SplashScreen
    {
        public YIESplashScreen()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
            SplashScreenCommand command = (SplashScreenCommand)cmd;
            if (command == SplashScreenCommand.labelControl2)
            {
                labelControl2.Text = arg.ToString();
            }
        }

        #endregion

        public enum SplashScreenCommand
        {
            labelControl2,
            command2,
            command3
        }


        /// <summary>
        /// 系统启动信息控制函数
        /// </summary>
        /// <param name="as_Msg">更新启动信息</param>
        public static void SendSplashScreenManager(string as_Msg)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SendCommand(YIESplashScreen.SplashScreenCommand.labelControl2, as_Msg);
            System.Threading.Thread.Sleep(500);

        }
    }
}