using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;
using System.Threading;
using YIEternalMIS.Core;
using YIEternalMIS.Common;
using YIEternalMIS.Main;


namespace YIEternalMIS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);//捕获系统所产生的异常。
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            SplashScreenManager.ShowForm(typeof(YIESplashScreen));
            YIESplashScreen.SendSplashScreenManager("读取用户配置...");
            Program.CheckInstance();  //单个实例程序运行
            SystemConfig.ReadSettings();   //读取用户配置
            //账套服务器数据连接测试
            YIESplashScreen.SendSplashScreenManager("测试数据库连接...");
            if(!BridgeDataBase.InitializeBridge())
            {
                Application.Exit();
                OpenConnTools.OpenTools();
                return;
            }

            YIESplashScreen.SendSplashScreenManager("注册控件和汉化信息...");
            //注册皮肤
            #region 注册皮肤
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle(SystemConfig.CurrentConfig.SkinName);
            #endregion

            #region 控件汉化

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-Hans");

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("zh-Hans");
            #endregion

            //YIESplashScreen.SendSplashScreenManager("检查系统更新...");
            //if(CheckVision.YIEMISVision())
            //{
            //    //执行更新方法

            //    Application.Exit();
            //}


            YIESplashScreen.SendSplashScreenManager("系统登录信息");
            //系统登录
            //if( YIESetOfBooks.Login() )
            if (LoginFrm.Login())
            {
                //检查系统时间，相差2分钟以上不允许登录
                //if (!CheckServerDate()) Application.Exit();

                Program.YIEMainForm = new YIEMain();
                //窗口初始化
                Program.YIEMainForm.InitUserInterface();
                Program.YIEMainForm.Show();
                Application.Run(Program.YIEMainForm);
            }
            else//登录失败,退出程序
                Application.Exit();

        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (SystemAuthentication.Current != null)
                SystemAuthentication.Current.Logout(); //登出
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            //Msg.ShowException(e.Exception);//处理系统异常
            DevExpress.XtraEditors.XtraMessageBox.Show(e.Exception.Message, "警告信息！", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        private static YIEMain _YIEMainForm = null;
        /// <summary>
        /// 程序主窗体
        /// </summary>
        public static YIEMain YIEMainForm { set { _YIEMainForm = value; } get { return _YIEMainForm; } }
        /// <summary>
        ///检查程序是否运行多实例
        /// </summary>
        public static void CheckInstance()
        {
            Boolean createdNew; //返回是否赋予了使用线程的互斥体初始所属权
            Mutex instance = new Mutex(true, Globals.DEF_PROGRAM_NAME, out createdNew); //同步基元变量
            if (createdNew) //首次使用互斥体
            {
                instance.ReleaseMutex();
            }
            else
            {
                if (!SystemConfig.CurrentConfig.AllowRunMultiInstance)
                {
                    Msg.Warning("已经启动了一个程序，请先退出！");
                    Application.Exit();
                    return;
                }
            }
        }


                    #region 获取系统时间
        public static bool CheckServerDate()
        {
            YIESplashScreen.SendSplashScreenManager("获取系统时间....");
            DateTime ldt_ServerDatetime;

            try
            {
                ldt_ServerDatetime = BLL.YIEDoFun.DoGetServerDateTime();
                TimeSpan ts = ldt_ServerDatetime - DateTime.Now;
                //如果客户机时间和服务器时间相差2分钟以上，不允许进入系统
                if (ts.Days > 0 || ts.Hours > 1 || ts.Minutes >= 2)
                {
                    Msg.ShowError(string.Format("当前服务器时间和本地时间相差{0}天{1}小时{2}分", ts.Days.ToString(), ts.Hours.ToString(), ts.Minutes.ToString()));
                    return false;
                }
            }

            //连接数据库失败!!
            catch (Exception e)
            {
                Msg.ShowException(e);
                return false;
            }

            return true;
        }


            #endregion

    }
}
