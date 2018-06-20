using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppService;
using Utils;
using YIEternalMIS.Common;

namespace WeightManage.Module.Views.FactoryInfo
{
    public partial class HookWeightForm : Form
    {
        public HookWeightForm()
        {
            InitializeComponent();
        }
        private FactoryAppService _factoryApp=new FactoryAppService();
        private string Id = string.Empty;

        public static int HookCount = 0;
        public static decimal HooksWeight = 0;

        private void HookWeightForm_Load(object sender, EventArgs e)
        {
            var model = _factoryApp.GetFactory();
            if (model == null)
            {
                Msg.ShowError("请先维护系统参数");
            }
            else
            {
                Id = model.factoryId;
                txtMao.Text = model.hooksWeight.ToString();
                txtNumber.Text = model.hookCount.ToString();
            }
        }

        public static bool SetHookWeight()
        {
            HookWeightForm form = new HookWeightForm();
            DialogResult result = form.ShowDialog();
            bool ret = (result == DialogResult.OK);
            return ret;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Id))
            {
                Msg.Warning("请先维护系统参数");
                return;
            }
            var weight = txtMao.Text.Trim().ToDecimal(2);
            if (weight == 0)
            {
                Msg.Warning("毛重不能为0");
                return;
            }
            var num = txtNumber.Text.ToInt();
            if (num == 0)
            {
                Msg.Warning("过磅数量不能为0");
                return;
            }
            var ret = _factoryApp.UpdateHookWeight(Id, weight, num);
            if (ret)
            {
                HookCount = num;
                HooksWeight = weight;
                DialogResult = DialogResult.OK;
                this.Hide();
                this.Close();
            }
            else
            {
                Msg.ShowError("保存失败");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
