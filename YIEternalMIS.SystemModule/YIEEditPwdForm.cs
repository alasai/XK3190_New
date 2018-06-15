using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using YIEternalMIS.Common;



namespace YIEternalMIS.SystemModule
{
    public partial class YIEEditPwdForm : DevExpress.XtraEditors.XtraForm
    {
        //数据验证控件
        ValiCustomValidation myvalidation = new ValiCustomValidation();
        List<ValiControlRule> Rulelist = new List<ValiControlRule>();


        public YIEEditPwdForm()
        {
            InitializeComponent();
            //InitValidationRules();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            editpwd();
        }

        void editpwd()
        {
            if (!InitValidationRules()) return;
            YIEternalMIS.Interfaces.ILoginAuthorization login = new Business.LoginAuthorization();
            login.EditPwd(new LoginUser(Loginer.CurrentUser.Account, told.Text, Loginer.CurrentUser.DataSetID, Loginer.CurrentUser.DataSetName), tnew.Text);

            
        }


        /// <summary>
        /// 窗口数据监测
        /// </summary>
        /// <returns></returns>
        private bool InitValidationRules()
        {
            //添加验证条件
            Rulelist.Add(new ValiControlRule(told, ValiControlRule.NotEmpty()));
            Rulelist.Add(new ValiControlRule(tnew, ValiControlRule.NotEmpty()));
            Rulelist.Add(new ValiControlRule(tnewt, ValiControlRule.NotEmpty()));
            Rulelist.Add(new ValiControlRule(tnewt,ValiControlRule.IsUniformity(tnew.Text,false)));
            //
            //数据验证
            myvalidation.RuleList = Rulelist;

            return myvalidation.Validate();
            
        }

    }
}