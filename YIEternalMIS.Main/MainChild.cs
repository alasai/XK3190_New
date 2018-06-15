using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YIEternalMIS.Common;
using YIEternalMIS.Interfaces;
using YIEternalMIS.Business;

namespace YIEternalMIS.Main
{
    public partial class MainChild : YIEternalMIS.Base.BaseForm
    {
        public MainChild()
        {
            InitializeComponent();
            NavMessage.LookAndFeel.SetSkinStyle("Whiteprint");
            NavSearch.LookAndFeel.SetSkinStyle("Whiteprint");
            Navbusiness.LookAndFeel.SetSkinStyle("Whiteprint");
            Init();
        }

        void Init()
        {
            MsgNavInit();
            
            
        }

        void MsgNavInit()
        {
            NavMessage.Groups.Clear();
            IMainChildInit ChildInit = new MainChildInit();
            ChildInit.InitNavMessage(NavMessage);
        }
        /// <summary>
        /// 刷新待办业务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupControl1_CustomButtonChecked(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            Msg.AskQuestion("刷新待办业务");

        }


        /// <summary>
        /// 刷新通知公告
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupControl3_CustomButtonChecked(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            MsgNavInit();
        }


    }
}
