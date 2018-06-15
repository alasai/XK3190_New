namespace YIEternalMIS.Base
{
    partial class YIEAccontForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YIEAccontForm));
            this.xtabAccont = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtabAccont)).BeginInit();
            this.xtabAccont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtabAccont
            // 
            this.xtabAccont.Location = new System.Drawing.Point(0, 0);
            this.xtabAccont.Name = "xtabAccont";
            this.xtabAccont.SelectedTabPage = this.xtraTabPage1;
            this.xtabAccont.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtabAccont.Size = new System.Drawing.Size(163, 134);
            this.xtabAccont.TabIndex = 0;
            this.xtabAccont.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtabAccont.Visible = false;
            this.xtabAccont.CloseButtonClick += new System.EventHandler(this.xtabAccont_CloseButtonClick);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(157, 128);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(844, 475);
            this.pictureEdit1.TabIndex = 1;
            // 
            // YIEAccontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(844, 475);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.xtabAccont);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "YIEAccontForm";
            ((System.ComponentModel.ISupportInitialize)(this.xtabAccont)).EndInit();
            this.xtabAccont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        public DevExpress.XtraTab.XtraTabControl xtabAccont;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
