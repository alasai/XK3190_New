using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppService;
using YIEternalMIS.Common;
using YIEternalMIS.Core;
using YIEternalMIS.Core.SystemCore;
using YIEternalMIS.Interfaces;
using YIEternalMIS.Tools.SqlConnector;

namespace YIEternalMIS.Main
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        private LoginAppService _loginApp = null;
        public LoginFrm()
        {
            InitializeComponent();
            InitialForm();
        }

        public static bool Login()
        {
            LoginFrm form = new LoginFrm();
            DialogResult result = form.ShowDialog();
            bool ret = (result == DialogResult.OK);
            return ret;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void InitialForm()
        {
            _loginApp=new LoginAppService();
            //控件初始化
            //ucbooks.InitUserControl();
            //当空间选择时触发自定义事件
            //this.ucbooks.SelectedValueChanged += new EventHandler(txtCardGrade_SelectedValueChanged);
            if (Common.SystemConfig.CurrentConfig.LoginSave)
            {
                tUserID.Text = Common.SystemConfig.CurrentConfig.LastLoginUser;
                //登录用户密码解密
                tPwd.Text = Common.CEncoder.Decode(Common.SystemConfig.CurrentConfig.LastLoginPWD);

            }
            ckSaveLogin.Checked = Common.SystemConfig.CurrentConfig.LoginSave;

        }
        private void sbtnOK_Click(object sender, EventArgs e)
        {
            string sUserID, sPwd, sBookID = "屠宰管理", sBooksName = "";
            sUserID = tUserID.Text;
            // sUserName = tUserName.Text;
            sPwd = tPwd.Text;

            if (String.IsNullOrEmpty(sUserID))
            {
                YIEternalMIS.Common.Msg.ShowInformation("请输入登录用户名!!!");
                tUserID.Focus();
            }

            if (String.IsNullOrEmpty(sPwd))
            {
                YIEternalMIS.Common.Msg.ShowInformation("请输入登录密码!!!");
                tPwd.Focus();
            }


            IWriteSQLConfigValue cfgNormal = new INIFileWriter(Application.StartupPath + SqlConfiguration.INI_CFG_PATH);

            //设置配置信息
            SqlConfiguration.SetSQLConfig(cfgNormal);
            sPwd = CEncoder.Encode(sPwd.Trim());
            var user = _loginApp.Login(sUserID.Trim(), sPwd);
            if (user == null)
            {
                Msg.ShowInformation("您输入的用户名和密码不匹配!!!");
                return;
            }
            //登录成功
            Loginer.CurrentUser = user;
            //初始化导航条
            MenuHelper.InitMenu();
            DialogResult = System.Windows.Forms.DialogResult.OK;
            //登录策略
            //Business.LoginAuthorization login = new Business.LoginAuthorization();
            //SystemAuthentication.Current = login;
            YIEternalMIS.Common.SystemConfig.CurrentConfig.LoginSave = true;
            YIEternalMIS.Common.SystemConfig.CurrentConfig.LastLoginPWD = sPwd;
            YIEternalMIS.Common.SystemConfig.CurrentConfig.LastLoginUser = sUserID;
            YIEternalMIS.Common.SystemConfig.WriteSettings(YIEternalMIS.Common.SystemConfig.CurrentConfig);
            this.Hide();
            this.Close();
        }
        private void sbtnOK_Click1(object sender, EventArgs e)
        {
            string sUserID, sPwd, sBookID="屠宰管理", sBooksName ="库存管理";
            sUserID = tUserID.Text;
           // sUserName = tUserName.Text;
            sPwd = tPwd.Text;

            if (String.IsNullOrEmpty(sUserID))
            {
                Common.Msg.ShowInformation("请输入登录用户名!!!");
                tUserID.Focus();
            }

            if (String.IsNullOrEmpty(sPwd))
            {
                Common.Msg.ShowInformation("请输入登录密码!!!");
                tPwd.Focus();
            }
       

            IWriteSQLConfigValue cfgNormal = new INIFileWriter(Application.StartupPath + SqlConfiguration.INI_CFG_PATH);

            //设置配置信息
            SqlConfiguration.SetSQLConfig(cfgNormal);
            Business.LoginAuthorization login = new Business.LoginAuthorization();

            Common.LoginUser LoginUser = new Common.LoginUser(sUserID, sPwd, sBookID, sBooksName);
            //登录成功
            if (LoginAuthor(LoginUser, login))
            {
                //初始化导航条
                MenuHelper.InitMenu();
                DialogResult = System.Windows.Forms.DialogResult.OK;
                //登录策略
                SystemAuthentication.Current = login;
                Common.SystemConfig.CurrentConfig.LoginSave = true;
                Common.SystemConfig.CurrentConfig.LastLoginPWD = Common.CEncoder.Encode(sPwd);
                Common.SystemConfig.CurrentConfig.LastLoginUser = sUserID;
                Common.SystemConfig.WriteSettings(Common.SystemConfig.CurrentConfig);
                this.Hide();
                this.Close();
            }
        }

        private void sbtnColse_Click(object sender, EventArgs e)
        {
            if (Msg.AskQuestion("确定要退出系统吗？")) Application.Exit();
        }

        bool LoginAuthor(Common.LoginUser LoginUser, ILoginAuthorization login)
        {
            return login.Login(LoginUser);
        }

        private void sbtnNew_Click(object sender, EventArgs e)
        {
            frmSQLConnector.ExecuteConnection();
        }
    }
}
