using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AppService;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using WeightManage.AppService;
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

        private LoginAppService _loginApp=new LoginAppService();
        void editpwd()
        {
            if (!InitValidationRules()) return;
      
          string msg=  _loginApp.UpdatePwd(Loginer.CurrentUser.Account.Trim(), told.Text.Trim(), tnew.Text.Trim());
            if (string.IsNullOrEmpty(msg))
            {
                if (SystemConfig.CurrentConfig.LoginSave)
                {
                    Common.SystemConfig.CurrentConfig.LastLoginPWD = CEncoder.Encode(tnew.Text.Trim());
                    Common.SystemConfig.WriteSettings(Common.SystemConfig.CurrentConfig);
                }
                Msg.ShowInformation("密码修改成功");
            }
            else
            {
               Msg.ShowError(msg);
            }
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