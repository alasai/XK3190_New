using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YIEternalMIS
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            XtraForm1 md = new XtraForm1();
            md.MdiParent = this;
            md.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //navigationPane1.
            XtraForm1 md = new XtraForm1();
            md.MdiParent = this;
            md.Show();
        }
    }
}
