namespace YIEternalMIS.Main
{
    partial class MainChild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainChild));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.NavMessage = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.NavSearch = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Navbusiness = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navbusiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl3);
            this.layoutControl1.Controls.Add(this.groupControl2);
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1036, 684);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImage")));
            this.groupControl3.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.BeforeText;
            this.groupControl3.Controls.Add(this.NavMessage);
            this.groupControl3.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", ((System.Drawing.Image)(resources.GetObject("groupControl3.CustomHeaderButtons"))))});
            this.groupControl3.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupControl3.Location = new System.Drawing.Point(12, 465);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(679, 207);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "公告通知";
            this.groupControl3.CustomButtonChecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControl3_CustomButtonChecked);
            // 
            // NavMessage
            // 
            this.NavMessage.ActiveGroup = null;
            this.NavMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavMessage.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem6});
            this.NavMessage.Location = new System.Drawing.Point(2, 39);
            this.NavMessage.LookAndFeel.UseDefaultLookAndFeel = false;
            this.NavMessage.Name = "NavMessage";
            this.NavMessage.OptionsNavPane.ExpandedWidth = 675;
            this.NavMessage.Size = new System.Drawing.Size(675, 166);
            this.NavMessage.StoreDefaultPaintStyleName = true;
            this.NavMessage.TabIndex = 0;
            this.NavMessage.Text = "navBarControl1";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "navBarItem6";
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem6.SmallImage")));
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.BeforeText;
            this.groupControl2.Controls.Add(this.NavSearch);
            this.groupControl2.Location = new System.Drawing.Point(695, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(329, 660);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "查询统计";
            // 
            // NavSearch
            // 
            this.NavSearch.ActiveGroup = this.navBarGroup5;
            this.NavSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavSearch.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup5});
            this.NavSearch.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem7});
            this.NavSearch.Location = new System.Drawing.Point(2, 39);
            this.NavSearch.LookAndFeel.UseWindowsXPTheme = true;
            this.NavSearch.Name = "NavSearch";
            this.NavSearch.OptionsNavPane.ExpandedWidth = 325;
            this.NavSearch.Size = new System.Drawing.Size(325, 619);
            this.NavSearch.TabIndex = 0;
            this.NavSearch.Text = "navBarControl1";
            this.NavSearch.View = new DevExpress.XtraNavBar.ViewInfo.SkinExplorerBarViewInfoRegistrator();
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "navBarGroup5";
            this.navBarGroup5.Expanded = true;
            this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7)});
            this.navBarGroup5.Name = "navBarGroup5";
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "navBarItem7";
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem7.SmallImage")));
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.BeforeText;
            this.groupControl1.Controls.Add(this.Navbusiness);
            this.groupControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", ((System.Drawing.Image)(resources.GetObject("groupControl1.CustomHeaderButtons"))))});
            this.groupControl1.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(679, 449);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "待办业务";
            this.groupControl1.CustomButtonChecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControl1_CustomButtonChecked);
            // 
            // Navbusiness
            // 
            this.Navbusiness.ActiveGroup = this.navBarGroup1;
            this.Navbusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Navbusiness.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.Navbusiness.Location = new System.Drawing.Point(2, 39);
            this.Navbusiness.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Navbusiness.Name = "Navbusiness";
            this.Navbusiness.OptionsNavPane.ExpandedWidth = 675;
            this.Navbusiness.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.Navbusiness.Size = new System.Drawing.Size(675, 408);
            this.Navbusiness.StoreDefaultPaintStyleName = true;
            this.Navbusiness.TabIndex = 0;
            this.Navbusiness.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.SmallImage")));
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1036, 684);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(683, 453);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(683, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(333, 664);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.groupControl3;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 453);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(683, 211);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(758, 146);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // MainChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1036, 684);
            this.Controls.Add(this.layoutControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MainChild";
            this.Text = "系统导航";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Navbusiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraNavBar.NavBarControl Navbusiness;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraNavBar.NavBarControl NavMessage;
        private DevExpress.XtraNavBar.NavBarControl NavSearch;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;


    }
}
