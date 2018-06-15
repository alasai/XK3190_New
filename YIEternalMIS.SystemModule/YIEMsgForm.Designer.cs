namespace YIEternalMIS.SystemModule
{
    partial class YIEMsgForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MsgID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MsgTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MsgUp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.MsgText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Loginid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MsgRelease = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.MsgSdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MsgExpiry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.MsgEdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.DataSearch = new YIEternalMIS.Library.YIEDateSearchMenu();
            this.OnPages = new YIEternalMIS.Library.YIEOnPage();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.DataSearch);
            this.groupControl1.Controls.Add(this.OnPages);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1101, 534);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "查询结果";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(2, 112);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemDateEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1097, 370);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MsgID,
            this.MsgTitle,
            this.MsgUp,
            this.MsgText,
            this.Loginid,
            this.LoginName,
            this.MsgRelease,
            this.MsgSdate,
            this.MsgExpiry,
            this.MsgEdate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MsgID
            // 
            this.MsgID.Caption = "编号";
            this.MsgID.FieldName = "MsgID";
            this.MsgID.Name = "MsgID";
            this.MsgID.Visible = true;
            this.MsgID.VisibleIndex = 0;
            // 
            // MsgTitle
            // 
            this.MsgTitle.AppearanceHeader.Options.UseTextOptions = true;
            this.MsgTitle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MsgTitle.Caption = "标题";
            this.MsgTitle.FieldName = "MsgTitle";
            this.MsgTitle.Name = "MsgTitle";
            this.MsgTitle.Visible = true;
            this.MsgTitle.VisibleIndex = 1;
            // 
            // MsgUp
            // 
            this.MsgUp.AppearanceHeader.Options.UseTextOptions = true;
            this.MsgUp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MsgUp.Caption = "置顶标志";
            this.MsgUp.ColumnEdit = this.repositoryItemCheckEdit1;
            this.MsgUp.FieldName = "MsgUp";
            this.MsgUp.Name = "MsgUp";
            this.MsgUp.Visible = true;
            this.MsgUp.VisibleIndex = 2;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = "1";
            this.repositoryItemCheckEdit1.ValueUnchecked = "0";
            // 
            // MsgText
            // 
            this.MsgText.AppearanceHeader.Options.UseTextOptions = true;
            this.MsgText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MsgText.Caption = "内容";
            this.MsgText.FieldName = "MsgText";
            this.MsgText.Name = "MsgText";
            this.MsgText.Visible = true;
            this.MsgText.VisibleIndex = 3;
            // 
            // Loginid
            // 
            this.Loginid.AppearanceHeader.Options.UseTextOptions = true;
            this.Loginid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Loginid.Caption = "发布人编号";
            this.Loginid.FieldName = "Loginid";
            this.Loginid.Name = "Loginid";
            this.Loginid.Visible = true;
            this.Loginid.VisibleIndex = 4;
            // 
            // LoginName
            // 
            this.LoginName.AppearanceHeader.Options.UseTextOptions = true;
            this.LoginName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LoginName.Caption = "发布人";
            this.LoginName.FieldName = "LoginName";
            this.LoginName.Name = "LoginName";
            this.LoginName.Visible = true;
            this.LoginName.VisibleIndex = 5;
            // 
            // MsgRelease
            // 
            this.MsgRelease.AppearanceHeader.Options.UseTextOptions = true;
            this.MsgRelease.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MsgRelease.Caption = "录入日期";
            this.MsgRelease.ColumnEdit = this.repositoryItemDateEdit1;
            this.MsgRelease.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.MsgRelease.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.MsgRelease.FieldName = "MsgRelease";
            this.MsgRelease.Name = "MsgRelease";
            this.MsgRelease.Visible = true;
            this.MsgRelease.VisibleIndex = 6;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // MsgSdate
            // 
            this.MsgSdate.AppearanceHeader.Options.UseTextOptions = true;
            this.MsgSdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MsgSdate.Caption = "发布日期";
            this.MsgSdate.ColumnEdit = this.repositoryItemDateEdit1;
            this.MsgSdate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.MsgSdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.MsgSdate.FieldName = "MsgSdate";
            this.MsgSdate.Name = "MsgSdate";
            this.MsgSdate.Visible = true;
            this.MsgSdate.VisibleIndex = 7;
            // 
            // MsgExpiry
            // 
            this.MsgExpiry.AppearanceHeader.Options.UseTextOptions = true;
            this.MsgExpiry.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MsgExpiry.Caption = "有效期";
            this.MsgExpiry.ColumnEdit = this.repositoryItemCalcEdit1;
            this.MsgExpiry.DisplayFormat.FormatString = "{0}天";
            this.MsgExpiry.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.MsgExpiry.FieldName = "MsgExpiry";
            this.MsgExpiry.Name = "MsgExpiry";
            this.MsgExpiry.Visible = true;
            this.MsgExpiry.VisibleIndex = 8;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // MsgEdate
            // 
            this.MsgEdate.AppearanceHeader.Options.UseTextOptions = true;
            this.MsgEdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MsgEdate.Caption = "结束日期";
            this.MsgEdate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.MsgEdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.MsgEdate.FieldName = "MsgEdate";
            this.MsgEdate.Name = "MsgEdate";
            this.MsgEdate.Visible = true;
            this.MsgEdate.VisibleIndex = 9;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // DataSearch
            // 
            this.DataSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataSearch.Edate = new System.DateTime(((long)(0)));
            this.DataSearch.Location = new System.Drawing.Point(2, 21);
            this.DataSearch.Name = "DataSearch";
            this.DataSearch.Sdate = new System.DateTime(((long)(0)));
            this.DataSearch.Size = new System.Drawing.Size(1097, 91);
            this.DataSearch.TabIndex = 0;
            this.DataSearch.Load += new System.EventHandler(this.DataSearch_Load);
            // 
            // OnPages
            // 
            this.OnPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OnPages.Location = new System.Drawing.Point(2, 482);
            this.OnPages.Name = "OnPages";
            this.OnPages.PageIndex = 1;
            this.OnPages.PageSize = 100;
            this.OnPages.RecordCount = 0;
            this.OnPages.Size = new System.Drawing.Size(1097, 50);
            this.OnPages.TabIndex = 3;
            this.OnPages.Load += new System.EventHandler(this.OnPages_Load);
            // 
            // YIEMsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1101, 534);
            this.Controls.Add(this.groupControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "YIEMsgForm";
            this.Text = "字段查询";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Library.YIEOnPage OnPages;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MsgID;
        private DevExpress.XtraGrid.Columns.GridColumn MsgTitle;
        private DevExpress.XtraGrid.Columns.GridColumn MsgUp;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn MsgText;
        private DevExpress.XtraGrid.Columns.GridColumn Loginid;
        private DevExpress.XtraGrid.Columns.GridColumn LoginName;
        private DevExpress.XtraGrid.Columns.GridColumn MsgRelease;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn MsgSdate;
        private DevExpress.XtraGrid.Columns.GridColumn MsgExpiry;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn MsgEdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private Library.YIEDateSearchMenu DataSearch;
    }
}
