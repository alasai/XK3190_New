using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using YIEternalMIS.Interfaces;
using YIEternalMIS.Core;
using YIEternalMIS.Common;

namespace YIEternalMIS.Main
{
    public partial class YIESetOfBooks : DevExpress.XtraEditors.XtraForm
    {

        /// <summary>
        /// 系统登陆
        /// </summary>
        /// <returns>true 成功!</returns>
        public static bool Login()
        {
            YIESetOfBooks form = new YIESetOfBooks();
            DialogResult result = form.ShowDialog();
            bool ret = (result == DialogResult.OK);
            return ret;
        }

        public YIESetOfBooks()
        {
            InitializeComponent();
            InitialForm();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void InitialForm()
        {
            //控件初始化
            ucbooks.InitUserControl();
            //当空间选择时触发自定义事件
            this.ucbooks.SelectedValueChanged += new EventHandler(txtCardGrade_SelectedValueChanged);
            if(Common.SystemConfig.CurrentConfig.LoginSave)
            {
                tUserID.Text = Common.SystemConfig.CurrentConfig.LastLoginUser;
                //登录用户密码解密
                tPwd.Text =Common.CEncoder.Decode( Common.SystemConfig.CurrentConfig.LastLoginPWD );
                
            }
            ckSaveLogin.Checked = Common.SystemConfig.CurrentConfig.LoginSave;

        }

        private void sbtnColse_Click(object sender, EventArgs e)
        {
            if (Msg.AskQuestion("确定要退出系统吗？")) Application.Exit();
        }

        void LoginUser()
        {
            string sUserID ,sUserName , sPwd , sBookID , sBooksName ;
            sUserID = tUserID.Text;
            sUserName = tUserName.Text;
            sPwd = tPwd.Text;

            if (String.IsNullOrEmpty(sUserID))
            {
                Common.Msg.ShowInformation("请输入登录用户名!!!");
                tUserID.Focus();
            }

            if(String.IsNullOrEmpty(sPwd))
            {
                Common.Msg.ShowInformation("请输入登录密码!!!");
                tPwd.Focus();
            }
            //获取选择的账套ID和账套名
            if(!ucbooks.GetValue( out sBookID, out sBooksName)) return;
            if (String.IsNullOrEmpty(sBookID) || String.IsNullOrEmpty(sBooksName)) return;

            if (!TestBooksConn(sBookID, true))
            {
                Common.Msg.ShowError("您选择账套服务器测试连接失败!!!");
                return;
            }
            Business.LoginAuthorization login = new Business.LoginAuthorization();

            Common.LoginUser LoginUser = new Common.LoginUser(sUserID, sPwd, sBookID, sBooksName);
            //登录成功
            if (LoginAuthor(LoginUser, login))
            {
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

        /// <summary>
        /// 测试账套服务器连接
        /// </summary>
        /// <param name="sbookID">账套服务器编号</param>
        /// <param name="bSave">是否保存配置</param>
        bool TestBooksConn( string sbookID , bool bSave  )
        {

            Common.YIEBookConfig BookCfg = new Common.YIEBookConfig();
            DataTable ldt = new BLL.tb_DataSet().GetList("DataSetID='" + sbookID + "'" ).Tables[0];
            BookCfg.Server = ldt.Rows[0]["ServerIP"].ToString();
            BookCfg.DBName = ldt.Rows[0]["DBName"].ToString();
            BookCfg.UserID =Common.CEncoder.Decode( ldt.Rows[0]["DBUserName"].ToString());
            BookCfg.PWD = Common.CEncoder.Decode( ldt.Rows[0]["DBUserPassword"].ToString());
            return Core.SqlConfiguration.TestConnection(BookCfg, bSave);
        }

        bool LoginAuthor( Common.LoginUser LoginUser , ILoginAuthorization login )
        {
            return login.Login(LoginUser);
        }
        /// <summary>
        /// 触发自定义对象的选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtCardGrade_SelectedValueChanged(object sender, EventArgs e)
        {
            string ZTSelectID = ucbooks.Text;
            if (!TestBooksConn(ZTSelectID, false)) Common.Msg.ShowError("您选择账套服务器测试连接失败!!!");
        }

        private void sbtnOK_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void tUserID_EditValueChanged(object sender, EventArgs e)
        {

        }

        void LoadUserName( string sUserid)
        {
            //string s;
            //s = new BLL.YIEMYUser
        }

        
    }
}