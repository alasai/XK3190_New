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
using YIEternalMIS.Common;

namespace WeightManage.Module.Views.Price
{
    public partial class PriceEditForm : XtraForm
    {
        public PriceEditForm()
        {
            InitializeComponent();
        }


        private PriceAppService _priceApp=new PriceAppService();
        private AnimalTypes _animalModel=new AnimalTypes();
        public PriceEditForm(AnimalTypes dto)
        {
            InitializeComponent();
            _animalModel = dto;
        }
        private void PriceEditForm_Load(object sender, EventArgs e)
        {
            if (_animalModel.animalTypeId > 0)
            {
                txtName.Text = _animalModel.animalTypeName;
                txtNo.Text = _animalModel.traceCode;
                txtPrice.Value = _animalModel.price;
            }
        }

        
        public static bool ShowForm(AnimalTypes dto)
        {
            
            PriceEditForm form = new PriceEditForm(dto);
            DialogResult result = form.ShowDialog();
            bool ret = (result == DialogResult.OK);
            return ret;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var price = txtPrice.Value;
            var code = txtNo.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                Msg.Warning("货物名称不能为空");
                return;
            }
            if (price==0)
            {
                Msg.Warning("货物价格必须大于0");
                return;
            }
            if (string.IsNullOrEmpty(code))
            {
                code = "01";
            }

            _animalModel.animalTypeName = name;
            _animalModel.price = price;
            _animalModel.traceCode = code;
            var ret = _priceApp.SavePrice(_animalModel);
            if (ret)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Msg.Warning("保存失败");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
