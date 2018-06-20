namespace WeightManage.Module.Views
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.txtProductNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.productId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ingredients = new DevExpress.XtraGrid.Columns.GridColumn();
            this.storageCondition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.expiration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shortName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.btnDel);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1259, 705);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(268, 93);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(83, 30);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(184, 93);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 30);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(100, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnQuery);
            this.groupControl1.Controls.Add(this.txtProductNo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtProductName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(5, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1249, 83);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "查询条件";
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.Location = new System.Drawing.Point(678, 30);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(88, 40);
            this.btnQuery.TabIndex = 15;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtProductNo
            // 
            this.txtProductNo.Location = new System.Drawing.Point(371, 40);
            this.txtProductNo.Name = "txtProductNo";
            this.txtProductNo.Size = new System.Drawing.Size(195, 20);
            this.txtProductNo.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(317, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "快捷编号";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(94, 40);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(195, 20);
            this.txtProductName.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(40, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "产品名称";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(5, 129);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gridControl1.Size = new System.Drawing.Size(1254, 512);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.check,
            this.productId,
            this.shortName1,
            this.productName,
            this.productNo,
            this.shortName,
            this.spec,
            this.comment,
            this.ingredients,
            this.storageCondition,
            this.expiration,
            this.barcode});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            // 
            // check
            // 
            this.check.Caption = "勾选";
            this.check.ColumnEdit = this.repositoryItemCheckEdit2;
            this.check.FieldName = "check";
            this.check.MaxWidth = 50;
            this.check.Name = "check";
            this.check.Visible = true;
            this.check.VisibleIndex = 0;
            this.check.Width = 50;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // productId
            // 
            this.productId.Caption = "数据id";
            this.productId.FieldName = "productId";
            this.productId.MaxWidth = 50;
            this.productId.Name = "productId";
            this.productId.Visible = true;
            this.productId.VisibleIndex = 1;
            this.productId.Width = 50;
            // 
            // productName
            // 
            this.productName.Caption = "产品名称";
            this.productName.FieldName = "productName";
            this.productName.Name = "productName";
            this.productName.Visible = true;
            this.productName.VisibleIndex = 3;
            // 
            // productNo
            // 
            this.productNo.Caption = "快捷编号";
            this.productNo.FieldName = "productNo";
            this.productNo.Name = "productNo";
            this.productNo.Visible = true;
            this.productNo.VisibleIndex = 4;
            // 
            // shortName
            // 
            this.shortName.Caption = "简称";
            this.shortName.FieldName = "shortName";
            this.shortName.Name = "shortName";
            this.shortName.Visible = true;
            this.shortName.VisibleIndex = 5;
            // 
            // spec
            // 
            this.spec.Caption = "规格";
            this.spec.FieldName = "spec";
            this.spec.Name = "spec";
            this.spec.Visible = true;
            this.spec.VisibleIndex = 6;
            // 
            // comment
            // 
            this.comment.Caption = "源自部位";
            this.comment.FieldName = "comment";
            this.comment.Name = "comment";
            this.comment.Visible = true;
            this.comment.VisibleIndex = 7;
            // 
            // ingredients
            // 
            this.ingredients.Caption = "配料";
            this.ingredients.FieldName = "ingredients";
            this.ingredients.Name = "ingredients";
            this.ingredients.Visible = true;
            this.ingredients.VisibleIndex = 8;
            // 
            // storageCondition
            // 
            this.storageCondition.Caption = "存储条件";
            this.storageCondition.FieldName = "storageCondition";
            this.storageCondition.Name = "storageCondition";
            this.storageCondition.Visible = true;
            this.storageCondition.VisibleIndex = 9;
            // 
            // expiration
            // 
            this.expiration.Caption = "保质期";
            this.expiration.FieldName = "expiration";
            this.expiration.Name = "expiration";
            this.expiration.Visible = true;
            this.expiration.VisibleIndex = 10;
            // 
            // barcode
            // 
            this.barcode.Caption = "条形码";
            this.barcode.FieldName = "barcode";
            this.barcode.Name = "barcode";
            this.barcode.Visible = true;
            this.barcode.VisibleIndex = 11;
            // 
            // shortName1
            // 
            this.shortName1.Caption = "简称";
            this.shortName1.FieldName = "shortName";
            this.shortName1.Name = "shortName1";
            this.shortName1.Visible = true;
            this.shortName1.VisibleIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(12, 93);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 30);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 705);
            this.Controls.Add(this.panelControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ProductForm";
            this.Text = "产品管理";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn productId;
        private DevExpress.XtraGrid.Columns.GridColumn productName;
        private DevExpress.XtraGrid.Columns.GridColumn productNo;
        private DevExpress.XtraGrid.Columns.GridColumn shortName;
        private DevExpress.XtraGrid.Columns.GridColumn spec;
        private DevExpress.XtraGrid.Columns.GridColumn comment;
        private DevExpress.XtraGrid.Columns.GridColumn ingredients;
        private DevExpress.XtraGrid.Columns.GridColumn storageCondition;
        private DevExpress.XtraGrid.Columns.GridColumn expiration;
        private DevExpress.XtraGrid.Columns.GridColumn barcode;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtProductNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn shortName1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}