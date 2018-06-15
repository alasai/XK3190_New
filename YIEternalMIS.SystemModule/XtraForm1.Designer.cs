namespace YIEternalMIS.SystemModule
{
    partial class XtraForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yieOnPage1 = new YIEternalMIS.Library.YIEOnPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.yieDateSearchMenu1 = new YIEternalMIS.Library.YIEDateSearchMenu();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // yieOnPage1
            // 
            this.yieOnPage1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.yieOnPage1.Location = new System.Drawing.Point(0, 553);
            this.yieOnPage1.Name = "yieOnPage1";
            this.yieOnPage1.PageIndex = 1;
            this.yieOnPage1.PageSize = 20;
            this.yieOnPage1.RecordCount = 0;
            this.yieOnPage1.Size = new System.Drawing.Size(984, 49);
            this.yieOnPage1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 146);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(984, 407);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(800, 16);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // yieDateSearchMenu1
            // 
            this.yieDateSearchMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.yieDateSearchMenu1.Edate = new System.DateTime(((long)(0)));
            this.yieDateSearchMenu1.Location = new System.Drawing.Point(0, 0);
            this.yieDateSearchMenu1.Name = "yieDateSearchMenu1";
            this.yieDateSearchMenu1.Sdate = new System.DateTime(((long)(0)));
            this.yieDateSearchMenu1.Size = new System.Drawing.Size(984, 91);
            this.yieDateSearchMenu1.TabIndex = 1;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 602);
            this.Controls.Add(this.yieDateSearchMenu1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.yieOnPage1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Library.YIEOnPage yieOnPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Library.YIEDateSearchMenu yieDateSearchMenu1;
    }
}