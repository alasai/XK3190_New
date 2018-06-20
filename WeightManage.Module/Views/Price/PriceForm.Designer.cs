namespace WeightManage.Module.Views
{
    partial class PriceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.animalTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.animalTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.traceCode = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDel);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(956, 585);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(262, 25);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(83, 30);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(178, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 30);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(94, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(5, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 30);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(5, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gridControl1.Size = new System.Drawing.Size(946, 512);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.check,
            this.animalTypeId,
            this.animalTypeName,
            this.price,
            this.traceCode});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // animalTypeId
            // 
            this.animalTypeId.Caption = "数据id";
            this.animalTypeId.FieldName = "animalTypeId";
            this.animalTypeId.MaxWidth = 50;
            this.animalTypeId.Name = "animalTypeId";
            this.animalTypeId.Visible = true;
            this.animalTypeId.VisibleIndex = 1;
            this.animalTypeId.Width = 50;
            // 
            // animalTypeName
            // 
            this.animalTypeName.Caption = "货物名称";
            this.animalTypeName.FieldName = "animalTypeName";
            this.animalTypeName.Name = "animalTypeName";
            this.animalTypeName.Visible = true;
            this.animalTypeName.VisibleIndex = 2;
            // 
            // price
            // 
            this.price.Caption = "货物单价";
            this.price.FieldName = "price";
            this.price.Name = "price";
            this.price.Visible = true;
            this.price.VisibleIndex = 3;
            // 
            // traceCode
            // 
            this.traceCode.Caption = "溯源编号";
            this.traceCode.FieldName = "traceCode";
            this.traceCode.Name = "traceCode";
            this.traceCode.Visible = true;
            this.traceCode.VisibleIndex = 4;
            // 
            // PriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 585);
            this.Controls.Add(this.panelControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PriceForm";
            this.Text = "货物价格";
            this.Load += new System.EventHandler(this.PriceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
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
        private DevExpress.XtraGrid.Columns.GridColumn animalTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn animalTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn price;
        private DevExpress.XtraGrid.Columns.GridColumn traceCode;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDel;
    }
}