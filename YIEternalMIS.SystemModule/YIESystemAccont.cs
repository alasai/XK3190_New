using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YIEternalMIS.SystemModule
{
    public partial class YIESystemAccont : YIEternalMIS.Base.AccontBase
    {
        public YIESystemAccont()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            Common.Msg.ShowInformation("图片按钮");
        }
    }
}
