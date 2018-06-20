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
using DevExpress.XtraEditors;
using Models.Db;
using Nelibur.ObjectMapper;
using ReactiveUI;
using WeightManage.Module.ViewModel;
using YIEternalMIS.Common;

namespace WeightManage.Module.Views
{
    public partial class FactoryForm : XtraForm, IViewFor<FactoryVm>
    {
        public FactoryForm()
        {
            InitializeComponent();
            InitMvvm();
        }

        private FactoryAppService _factoryApp=new FactoryAppService();
        private void FactoryForm_Load(object sender, EventArgs e)
        {
            var model = _factoryApp.GetFactory();
            ViewModel = TinyMapper.Map<FactoryVm>(model);
        }

        #region  Mvvm绑定
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (FactoryVm)value;
        }
        public FactoryVm ViewModel { get; set; }
        private void InitMvvm()
        {
            this.WhenActivated(a =>
            {
                a(this.Bind(ViewModel, vm => vm.factoryId, v => v.txtFactoryNo.Text));
                a(this.Bind(ViewModel, vm => vm.factoryName, v => v.txtFactoryName.Text));
                a(this.Bind(ViewModel, vm => vm.hooksWeight, v => v.txtPi.Text));
                a(this.Bind(ViewModel, vm => vm.hookCount, v => v.txtNumber.Text));
                a(this.Bind(ViewModel, vm => vm.meatRate, v => v.txtChuRou.Text));
                a(this.Bind(ViewModel, vm => vm.bonedRate, v => v.txtHanGu.Text));
                a(this.Bind(ViewModel, vm => vm.traceURL, v => v.txtTrace.Text));
                a(this.Bind(ViewModel, vm => vm.serverUrl, v => v.txtServerUrl.Text));
                //a(this.Bind(ViewModel, vm => vm.MaoWeight, v => v.weightLabel.Text));
                //a(this.Bind(ViewModel, vm => vm.LblName, v => v.lblName.Text));
                //a(this.OneWayBind(ViewModel, vm => vm.HookNum, v => v.txtNumber.Text));
                //a(this.OneWayBind(PersonViewModel, vm => vm.Age, v => v.label3.Text));
            });
            ViewModel = new FactoryVm();
        }
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ViewModel.factoryId))
            {
                Msg.Warning("编号不能为空");
                return;
            }
            if (string.IsNullOrEmpty(ViewModel.factoryName))
            {
                Msg.Warning("名称不能为空");
                return;
            }
            if (ViewModel.hooksWeight==0)
            {
                Msg.Warning("皮重不能为0");
                return;
            }
            if (string.IsNullOrEmpty(ViewModel.traceURL))
            {
                Msg.Warning("溯源地址不能为空");
                return;
            }
            if (string.IsNullOrEmpty(ViewModel.serverUrl))
            {
                Msg.Warning("服务器地址不能为空");
                return;
            }

            ViewModel.hookWeight = decimal.Round(ViewModel.hooksWeight / ViewModel.hookCount, 2);
            var model = TinyMapper.Map<Params>(ViewModel);
            var ret = _factoryApp.SaveParam(model);
            if (ret)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                //this.Hide();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }


    }
}
