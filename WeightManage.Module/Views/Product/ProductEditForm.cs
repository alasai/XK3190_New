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
using Nelibur.ObjectMapper;
using ReactiveUI;
using Utils;
using WeightManage.AppService;
using WeightManage.Models.Db;
using WeightManage.Module.ViewModel;
using YIEternalMIS.Base;
using YIEternalMIS.Common;

namespace WeightManage.Module.Views.Product
{
    public partial class ProductEditForm : XtraForm, IViewFor<ProductsVm>
    {
        public ProductEditForm()
        {
            InitializeComponent();
        }

        public ProductEditForm(Products dto)
        {
            InitializeComponent();
            InitMvvm();
            if (dto.productId > 0)
            {
                ViewModel = TinyMapper.Map<ProductsVm>(dto);
            }


        }

        private ProductAppService _productApp=new ProductAppService();
        private void ProductEditForm_Load(object sender, EventArgs e)
        {

        }

        #region  Mvvm绑定
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ProductsVm)value;
        }
        public ProductsVm ViewModel { get; set; }
        private void InitMvvm()
        {
            this.WhenActivated(a =>
            {
                a(this.Bind(ViewModel, vm => vm.productName, v => v.pName.Text));
                a(this.Bind(ViewModel, vm => vm.shortName, v => v.shortName.Text));
                a(this.Bind(ViewModel, vm => vm.spec, v => v.spec.Text));
                a(this.Bind(ViewModel, vm => vm.comment, v => v.sourcePart.Text));
                a(this.Bind(ViewModel, vm => vm.ingredients, v => v.peiliao.Text));
                a(this.Bind(ViewModel, vm => vm.storageCondition, v => v.cunchu.Text));
                a(this.Bind(ViewModel, vm => vm.expiration, v => v.baozhiqi.Text));
                //a(this.Bind(ViewModel, vm => vm.MaoWeight, v => v.weightLabel.Text));
                //a(this.Bind(ViewModel, vm => vm.LblName, v => v.lblName.Text));
                //a(this.OneWayBind(ViewModel, vm => vm.HookNum, v => v.txtNumber.Text));
                //a(this.OneWayBind(PersonViewModel, vm => vm.Age, v => v.label3.Text));
            });
            ViewModel = new ProductsVm();
        }
        #endregion
        public static bool ShowForm(Products dto)
        {
           
            ProductEditForm form = new ProductEditForm(dto);
            DialogResult result = form.ShowDialog();
            bool ret = (result == DialogResult.OK);
            return ret;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            ViewModel.barcode = string.Empty;
            if (string.IsNullOrEmpty(ViewModel.productName))
            {
                Msg.ShowError("产品名称不能为空");
                return;
            }
            if (string.IsNullOrEmpty(ViewModel.spec))
            {
                ViewModel.spec = "称重";
                ViewModel.nominalWeight = 0;
            }
            else
            {
                if (!ViewModel.spec.Contains("*"))
                {
                    Msg.ShowError("产品规格错误");
                    return;
                }

                ViewModel.isFixedWeight = true;
                ViewModel.nominalWeight = ViewModel.spec.Split('*')[1].ToDecimal(2);
            }

            ViewModel.shortName = ViewModel.shortName ?? ViewModel.productName;

            var model = TinyMapper.Map<Products>(ViewModel);
            var ret=_productApp.SaveData(model);
            if (ret)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                //this.Hide();
                this.Close();
            }
            else
            {
                Msg.ShowError("保存失败，请检测产品信息是否有误");
            }
           
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
           // this.Hide();
            this.Close();
        }
    }
}
