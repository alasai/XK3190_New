namespace WeightManage.Module
{
    partial class WeightReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeightReportForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.date = new DevExpress.XtraEditors.DateEdit();
            this.txtIdNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridWeight = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SerialNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaoWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PiWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NetWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WeightTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.axGRDisplayViewer1 = new Axgregn6Lib.AxGRDisplayViewer();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGRDisplayViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.gridWeight);
            this.panelControl1.Controls.Add(this.axGRDisplayViewer1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1000, 600);
            this.panelControl1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnQuery);
            this.groupControl1.Controls.Add(this.date);
            this.groupControl1.Controls.Add(this.txtIdNumber);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(5, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(983, 115);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "查询条件";
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.Location = new System.Drawing.Point(751, 37);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(88, 40);
            this.btnQuery.TabIndex = 14;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // date
            // 
            this.date.EditValue = null;
            this.date.Location = new System.Drawing.Point(562, 47);
            this.date.Name = "date";
            this.date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Size = new System.Drawing.Size(169, 20);
            this.date.TabIndex = 13;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(290, 47);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(201, 20);
            this.txtIdNumber.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(518, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "日期";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 20);
            this.txtName.TabIndex = 10;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(870, 37);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 40);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(239, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "身份证";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "姓名";
            // 
            // gridWeight
            // 
            this.gridWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridWeight.Location = new System.Drawing.Point(10, 131);
            this.gridWeight.MainView = this.gridView1;
            this.gridWeight.Name = "gridWeight";
            this.gridWeight.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridWeight.Size = new System.Drawing.Size(978, 433);
            this.gridWeight.TabIndex = 7;
            this.gridWeight.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.check,
            this.Id,
            this.SerialNum,
            this.IdNumber,
            this.ProductName,
            this.Price,
            this.Num,
            this.MaoWeight,
            this.PiWeight,
            this.NetWeight,
            this.TotalPrice,
            this.WeightTime});
            this.gridView1.GridControl = this.gridWeight;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // check
            // 
            this.check.Caption = "操作";
            this.check.ColumnEdit = this.repositoryItemCheckEdit1;
            this.check.FieldName = "check";
            this.check.MaxWidth = 50;
            this.check.Name = "check";
            this.check.Visible = true;
            this.check.VisibleIndex = 0;
            this.check.Width = 50;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // SerialNum
            // 
            this.SerialNum.Caption = "编号";
            this.SerialNum.FieldName = "SerialNum";
            this.SerialNum.MaxWidth = 60;
            this.SerialNum.Name = "SerialNum";
            this.SerialNum.Visible = true;
            this.SerialNum.VisibleIndex = 1;
            this.SerialNum.Width = 50;
            // 
            // IdNumber
            // 
            this.IdNumber.Caption = "身份证";
            this.IdNumber.FieldName = "IdNumber";
            this.IdNumber.Name = "IdNumber";
            this.IdNumber.Visible = true;
            this.IdNumber.VisibleIndex = 2;
            this.IdNumber.Width = 114;
            // 
            // ProductName
            // 
            this.ProductName.Caption = "货物名称";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 3;
            this.ProductName.Width = 114;
            // 
            // Price
            // 
            this.Price.Caption = "单价";
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 4;
            this.Price.Width = 114;
            // 
            // Num
            // 
            this.Num.Caption = "数量";
            this.Num.FieldName = "Num";
            this.Num.Name = "Num";
            this.Num.Visible = true;
            this.Num.VisibleIndex = 5;
            this.Num.Width = 114;
            // 
            // MaoWeight
            // 
            this.MaoWeight.Caption = "毛重";
            this.MaoWeight.FieldName = "MaoWeight";
            this.MaoWeight.Name = "MaoWeight";
            this.MaoWeight.Visible = true;
            this.MaoWeight.VisibleIndex = 6;
            this.MaoWeight.Width = 114;
            // 
            // PiWeight
            // 
            this.PiWeight.Caption = "皮重";
            this.PiWeight.FieldName = "PiWeight";
            this.PiWeight.Name = "PiWeight";
            this.PiWeight.Visible = true;
            this.PiWeight.VisibleIndex = 7;
            this.PiWeight.Width = 114;
            // 
            // NetWeight
            // 
            this.NetWeight.Caption = "净重";
            this.NetWeight.FieldName = "NetWeight";
            this.NetWeight.Name = "NetWeight";
            this.NetWeight.Visible = true;
            this.NetWeight.VisibleIndex = 8;
            this.NetWeight.Width = 114;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Caption = "金额";
            this.TotalPrice.FieldName = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 9;
            this.TotalPrice.Width = 114;
            // 
            // WeightTime
            // 
            this.WeightTime.Caption = "时间";
            this.WeightTime.DisplayFormat.FormatString = "G";
            this.WeightTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.WeightTime.FieldName = "WeightTime";
            this.WeightTime.Name = "WeightTime";
            this.WeightTime.Visible = true;
            this.WeightTime.VisibleIndex = 10;
            this.WeightTime.Width = 144;
            // 
            // axGRDisplayViewer1
            // 
            this.axGRDisplayViewer1.Enabled = true;
            this.axGRDisplayViewer1.Location = new System.Drawing.Point(355, 474);
            this.axGRDisplayViewer1.Name = "axGRDisplayViewer1";
            this.axGRDisplayViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGRDisplayViewer1.OcxState")));
            this.axGRDisplayViewer1.Size = new System.Drawing.Size(192, 192);
            this.axGRDisplayViewer1.TabIndex = 0;
            // 
            // WeightReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "WeightReportForm";
            this.Text = "报表打印";
            this.Load += new System.EventHandler(this.WeightReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGRDisplayViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Axgregn6Lib.AxGRDisplayViewer axGRDisplayViewer1;
        private DevExpress.XtraGrid.GridControl gridWeight;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn SerialNum;
        private DevExpress.XtraGrid.Columns.GridColumn IdNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Num;
        private DevExpress.XtraGrid.Columns.GridColumn MaoWeight;
        private DevExpress.XtraGrid.Columns.GridColumn PiWeight;
        private DevExpress.XtraGrid.Columns.GridColumn NetWeight;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn WeightTime;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtIdNumber;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.DateEdit date;
    }
}