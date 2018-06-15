using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YIEternalMIS.Library
{
    public partial class YIETitleButton : DevExpress.XtraEditors.XtraUserControl
    {
        public YIETitleButton()
        {
            InitializeComponent();
            Loaduser();
        }

        private void YIETitleButton_Load(object sender, EventArgs e)
        {
            simpleButton3.Visible = false;
        }

        void Loaduser()
        {
            simpleButton3.Visible = false;
        }
    }
}
