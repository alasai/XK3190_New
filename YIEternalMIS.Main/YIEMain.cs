using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTabbedMdi;
using System.Diagnostics;
using System.Threading;
using DevExpress.XtraNavBar;
using YIEternalMIS.Common;
using YIEternalMIS.Interfaces;
using YIEternalMIS.Business;
using YIEternalMIS.Core;
using YIEternalMIS.Base;
using DevExpress.XtraSplashScreen;
using WeightManage.Module;
using YIEternalMIS.SystemModule;



namespace YIEternalMIS.Main
{
    public partial class YIEMain : DevExpress.XtraBars.Ribbon.RibbonForm 
    {

        IOpenForm OpenForm = new YIESysOpenForm();
         YIEAccontForm AccontForm = new YIEAccontForm();
        public YIEMain()
        {
            InitializeComponent();
        }

        public void InitUserInterface()
        {
            try
            {
           
                //注册主窗口
                MainFormMDI.MainMDIForm = this;
                MainFormMDI.MainTabManager = xtab_manager;
                MainFormMDI.OldBarSubItem = barOld;
                MainFormMDI.AccontTabControl = AccontForm.xtabAccont;
                MainFormMDI.AccontForm = AccontForm;
                MainFormMDI.RegOldBar = true;
                this.SuspendLayout();
                YIESplashScreen.SendSplashScreenManager("加载用户界面...");
                SetLookAndFeel();
                //设置状态栏文本
                SetStatusText();
                YIESplashScreen.SendSplashScreenManager("下载当前登录用户权限窗口...");
                //获取用户权限
                LoadNavBar( );

                YIESplashScreen.SendSplashScreenManager("加载系统导航窗口...");
                

                
                this.ResumeLayout();
                



            }
            catch (Exception ex)
            { Msg.ShowException(ex); }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        ///// <summary>
        ///// Navbar初始化完毕后，展开的Group不触发GroupExpanded，重新遍历
        ///// </summary>
        //void InitGroupOpen()
        //{
        //    if( NavMain.Groups.Count <= 0 ) return;
        //    foreach( NavBarGroup gp in NavMain.Groups)
        //    {
        //        if (gp.Expanded) OpenForm.NavGroupExpanded( gp.Tag.ToString());
        //    }
        //}
        /// <summary>
        /// 设置皮肤样式
        /// </summary>
        void SetLookAndFeel()
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(btiSkin, true);
            if (String.IsNullOrEmpty(SystemConfig.CurrentConfig.SkinName))
            {
                defaultLookAndFeel1.LookAndFeel.SetSkinStyle("Office 2010 Blue");
            }
            else
            { defaultLookAndFeel1.LookAndFeel.SetSkinStyle(SystemConfig.CurrentConfig.SkinName); }

        }


        /// <summary>
        /// 调整状态条大小
        /// </summary>
        /// <param name="iWid"></param>
        void SetStatusWidth(int iWid)
        {
            int iWidth = iWid / 4;
            barSystem.Width = iWidth;
            barUser.Width = iWidth;
            barDataSet.Width = iWidth;

        }

        /// <summary>
        /// 设置状态栏
        /// </summary>
        public void SetStatusText()
        {
            barSystem.Caption = Common.SystemConfig.CurrentConfig.AppSystemName;
            barUser.Caption = "当前登录用户：" + Loginer.CurrentUser.AccountName;
            barDataSet.Caption = "登录账套：" + Loginer.CurrentUser.DataSetName;
            barDate.Caption = "系统日期：" + DateTime.Now.ToShortDateString();
        }
        /// <summary>
        /// 设置菜单图标
        /// </summary>
        void DoSetFormRibbonImg()
        {
            //主窗口图标全部加载窗口
        }


        /// <summary>
        /// 加载主导航栏
        /// </summary>
        /// <param name="Navcol"></param>
        void LoadNavBar( )
        {
            IFormModule mainModule = new ModuleRibbonForm();
            //加载Navbar窗口
            mainModule.MainModule(ribbon);
            //加载系统导航窗口
            //InitGroupOpen();

           // MainChild MainChild = new MainChild();
           HomeForm MainChild=new HomeForm();
            MainChild.Show();
            MainChild.MdiParent = this;
            MainChild.CloseBox = false;
            MainChild.WindowState = FormWindowState.Maximized;

        }

        /// <summary>
        /// 窗口大小改变后，重置状态栏的大小和位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YIEMain_ResizeEnd(object sender, EventArgs e)
        {
            SetStatusWidth(this.Width);
        }





        #region 合并子窗口的状态栏
        private void ribbon_UnMerge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            DevExpress.XtraBars.Ribbon.RibbonControl parentRRibbon = sender as DevExpress.XtraBars.Ribbon.RibbonControl;
            parentRRibbon.StatusBar.UnMergeStatusBar();
        }

        private void ribbon_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            DevExpress.XtraBars.Ribbon.RibbonControl parentRRibbon = sender as DevExpress.XtraBars.Ribbon.RibbonControl;
            DevExpress.XtraBars.Ribbon.RibbonControl childRibbon = e.MergedChild;

            parentRRibbon.StatusBar.MergeStatusBar(childRibbon.StatusBar);
        }

        #endregion

        #region 双击Tab标签关闭页面
        //通过双击的时间判断是否双击 双击时间为0.5秒
        private DateTime m_LastClick = System.DateTime.Now;
        private XtraMdiTabPage m_lastPage = null;
        private void xtab_manager_MouseDown(object sender, MouseEventArgs e)
        {


            XtraMdiTabPage curPage = (sender as XtraTabbedMdiManager).SelectedPage;

            //导航主界面不能关闭

            if (e.Button == MouseButtons.Left)
            {

                DateTime dt = DateTime.Now;
                TimeSpan span = dt.Subtract(m_LastClick);
                if (span.TotalMilliseconds < 500)  //如果两次点击的时间间隔小于300毫秒，则认为是双击
                {


                    if (this.MdiChildren.Length > 0)
                    {
                        if (curPage.Text == "系统导航") return;
                        // 限制只有在同一个页签上双击才能关闭.(规避两个页签切换时点太快导致意外关闭页签)
                        if (curPage.Equals(m_lastPage))
                        {
                            //if (this.ActiveMdiChild != m_MapForm)
                            //{
                            this.ActiveMdiChild.Close();
                            //}

                        }
                    }
                    m_LastClick = dt.AddMinutes(-1);
                }
                else
                {
                    m_LastClick = dt;
                    m_lastPage = curPage;
                }
            }
        }

        #endregion

        #region 退出、重启、修改密码按钮方法

        #region 注销用户重启动
        private void run(Object obj)
        {
            Process ps = new Process();
            ps.StartInfo.FileName = obj.ToString();
            ps.Start();
        }


        private void Restart()
        {
            if (MessageBox.Show("是否要注销当前用户?", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
            {
                Application.ExitThread();
                Thread thtmp = new Thread(new ParameterizedThreadStart(run));
                object appName = Application.ExecutablePath;
                Thread.Sleep(2000);
                thtmp.Start(appName);

            }
        }
        #endregion


        void EditPwd()
        {
            YIEEditPwdForm EditPwd = new YIEEditPwdForm();
            EditPwd.ShowDialog();
        }

        void LookLog()
        {
            Msg.ShowError("查看日志");
        }
        void LookHelp()
        {
            
        }

 
        void AppExit()
        {
            if (Msg.AskQuestion("确定要退出系统吗？")) this.Close();
        }

        private void btiExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            AppExit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AppExit();
        }

        private void btiRestart_ItemClick(object sender, ItemClickEventArgs e)
        {
            Restart();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }


        private void btiEditPwd_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditPwd();
        }

        private void btiLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            LookLog();
        }

        private void btiHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            LookHelp();
        }
        #endregion

        private void YIEMain_Load(object sender, EventArgs e)
        {

        }

        private void xtab_manager_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            //XtraMdiTabPage curPage = (sender as XtraTabbedMdiManager).SelectedPage;

            ////导航主界面不能关闭

            //if (this.MdiChildren.Length > 0)
            //{
            //    if (curPage.Text == "系统导航") return;
            //    // 限制只有在同一个页签上双击才能关闭.(规避两个页签切换时点太快导致意外关闭页签)
            //    //if (curPage.Equals(m_lastPage))
            //    //{
            //    //    //if (this.ActiveMdiChild != m_MapForm)
            //    //    //{
            //    //    this.ActiveMdiChild.Close();
            //    //    //}

            //    //}
            //}
        }

        private void xtab_manager_PageAdded(object sender, MdiTabPageEventArgs e)
        {
            if (e.Page.Text == "首页")
                e.Page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
        }
    }
}