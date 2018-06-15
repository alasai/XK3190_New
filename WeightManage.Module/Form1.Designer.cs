namespace WeightManage.Module {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
this.iExit = new DevExpress.XtraBars.BarButtonItem();
this.iHelp = new DevExpress.XtraBars.BarButtonItem();
this.iAbout = new DevExpress.XtraBars.BarButtonItem();
this.siStatus = new DevExpress.XtraBars.BarStaticItem();
this.siInfo = new DevExpress.XtraBars.BarStaticItem();
this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
this.ribbonPageSkins = new DevExpress.XtraBars.Ribbon.RibbonPage();
this.skinsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
this.helpRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
this.helpRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
this.someLabelControl2 = new DevExpress.XtraEditors.LabelControl();
this.someLabelControl1 = new DevExpress.XtraEditors.LabelControl();
this.popupControlContainer2 = new DevExpress.XtraBars.PopupControlContainer(this.components);
this.buttonEdit = new DevExpress.XtraEditors.ButtonEdit();
this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
this.mailGroup = new DevExpress.XtraNavBar.NavBarGroup();
this.organizerGroup = new DevExpress.XtraNavBar.NavBarGroup();
this.inboxItem = new DevExpress.XtraNavBar.NavBarItem();
this.outboxItem = new DevExpress.XtraNavBar.NavBarItem();
this.draftsItem = new DevExpress.XtraNavBar.NavBarItem();
this.trashItem = new DevExpress.XtraNavBar.NavBarItem();
this.calendarItem = new DevExpress.XtraNavBar.NavBarItem();
this.tasksItem = new DevExpress.XtraNavBar.NavBarItem();
this.navbarImageCollection = new DevExpress.Utils.ImageCollection(this.components);
this.navbarImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
this.spreadsheetFormulaBarPanel = new System.Windows.Forms.Panel();
this.spreadsheetControl = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
this.splitterControl = new DevExpress.XtraEditors.SplitterControl();
this.formulaBarNameBoxSplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
this.spreadsheetNameBoxControl = new DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl();
this.spreadsheetFormulaBarControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl();


            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.formulaBarNameBoxSplitContainerControl)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.spreadsheetNameBoxControl.Properties)).BeginInit();


            this.SuspendLayout();

            this.splitContainerControl.SuspendLayout();
this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
this.splitContainerControl.Name = "splitContainerControl";
this.splitContainerControl.Padding = new System.Windows.Forms.Padding(6);
this.splitContainerControl.Panel1.Text = "Panel1";
this.splitContainerControl.Panel2.Text = "Panel2";
this.splitContainerControl.Size = new System.Drawing.Size(553, 248);
this.splitContainerControl.SplitterPosition = 165;
this.splitContainerControl.TabIndex = 0;
this.splitContainerControl.Text = "splitContainerControl1";
this.splitContainerControl.ResumeLayout(false);
this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
this.splitContainerControl.Panel2.Controls.Add(this.spreadsheetFormulaBarPanel);
this.ribbonControl.ApplicationButtonDropDownControl = this.appMenu;
this.ribbonControl.ApplicationButtonText = null;
this.ribbonControl.ExpandCollapseItem.Id = 0;
this.ribbonControl.ExpandCollapseItem.Name = "";
this.ribbonControl.Images = this.ribbonImageCollection;
this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.ribbonControl.ExpandCollapseItem,this.iExit,this.iHelp,this.iAbout,this.siStatus,this.siInfo,this.rgbiSkins});
this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
this.ribbonControl.Location = new System.Drawing.Point(0, 0);
this.ribbonControl.MaxItemId = 62;
this.ribbonControl.Name = "ribbonControl";
this.ribbonControl.PageHeaderItemLinks.Add(this.iAbout);
this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.ribbonPageSkins,this.helpRibbonPage});
this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
this.ribbonControl.Size = new System.Drawing.Size(750, 144);
this.ribbonControl.StatusBar = this.ribbonStatusBar;
this.ribbonControl.Toolbar.ItemLinks.Add(this.iHelp);
this.iExit.Caption = "Exit";
this.iExit.Description = "Closes this program after prompting you to save unsaved data.";
this.iExit.Hint = "Closes this program after prompting you to save unsaved data";
this.iExit.Id = 20;
this.iExit.ImageIndex = 6;
this.iExit.LargeImageIndex = 6;
this.iExit.Name = "iExit";
this.iHelp.Caption = "Help";
this.iHelp.Description = "Start the program help system.";
this.iHelp.Hint = "Start the program help system";
this.iHelp.Id = 22;
this.iHelp.ImageIndex = 7;
this.iHelp.LargeImageIndex = 7;
this.iHelp.Name = "iHelp";
this.iAbout.Caption = "About";
this.iAbout.Description = "Displays general program information.";
this.iAbout.Hint = "Displays general program information";
this.iAbout.Id = 24;
this.iAbout.ImageIndex = 8;
this.iAbout.LargeImageIndex = 8;
this.iAbout.Name = "iAbout";
this.siStatus.Caption = "Some Status Info";
this.siStatus.Id = 31;
this.siStatus.Name = "siStatus";
this.siStatus.TextAlignment = System.Drawing.StringAlignment.Near;
this.siInfo.Caption = "Some Info";
this.siInfo.Id = 32;
this.siInfo.Name = "siInfo";
this.siInfo.TextAlignment = System.Drawing.StringAlignment.Near;
this.rgbiSkins.Caption = "Skins";
this.rgbiSkins.Gallery.AllowHoverImages = true;
this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
this.rgbiSkins.Gallery.ColumnCount = 4;
this.rgbiSkins.Gallery.FixedHoverImageSize = false;
this.rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
this.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
this.rgbiSkins.Gallery.RowCount = 4;
this.rgbiSkins.Id = 60;
this.rgbiSkins.Name = "rgbiSkins";
this.ribbonPageSkins.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.skinsRibbonPageGroup});
this.ribbonPageSkins.Name = "ribbonPageSkins";
this.ribbonPageSkins.Text = "Skins";
this.skinsRibbonPageGroup.ItemLinks.Add(this.rgbiSkins);
this.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup";
this.skinsRibbonPageGroup.ShowCaptionButton = false;
this.skinsRibbonPageGroup.Text = "Skins";
this.helpRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.helpRibbonPageGroup});
this.helpRibbonPage.Name = "helpRibbonPage";
this.helpRibbonPage.Text = "Help";
this.helpRibbonPageGroup.ItemLinks.Add(this.iHelp);
this.helpRibbonPageGroup.ItemLinks.Add(this.iAbout);
this.helpRibbonPageGroup.Name = "helpRibbonPageGroup";
this.helpRibbonPageGroup.Text = "Help";
this.appMenu.BottomPaneControlContainer = this.popupControlContainer2;
this.appMenu.ItemLinks.Add(this.iExit);
this.appMenu.Name = "appMenu";
this.appMenu.Ribbon = this.ribbonControl;
this.appMenu.RightPaneControlContainer = this.popupControlContainer1;
this.appMenu.ShowRightPane = true;
this.popupControlContainer1.SuspendLayout();
this.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
this.popupControlContainer1.Appearance.Options.UseBackColor = true;
this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
this.popupControlContainer1.Controls.Add(this.someLabelControl2);
this.popupControlContainer1.Controls.Add(this.someLabelControl1);
this.popupControlContainer1.Location = new System.Drawing.Point(111, 197);
this.popupControlContainer1.Name = "popupControlContainer1";
this.popupControlContainer1.Ribbon = this.ribbonControl;
this.popupControlContainer1.Size = new System.Drawing.Size(76, 70);
this.popupControlContainer1.TabIndex = 2;
this.popupControlContainer1.Visible = false;
this.popupControlContainer1.ResumeLayout(false);
this.popupControlContainer1.PerformLayout();
this.someLabelControl2.Location = new System.Drawing.Point(3, 57);
this.someLabelControl2.Name = "someLabelControl2";
this.someLabelControl2.Size = new System.Drawing.Size(49, 13);
this.someLabelControl2.TabIndex = 0;
this.someLabelControl2.Text = "Some Info";
this.someLabelControl1.Location = new System.Drawing.Point(3, 3);
this.someLabelControl1.Name = "someLabelControl1";
this.someLabelControl1.Size = new System.Drawing.Size(49, 13);
this.someLabelControl1.TabIndex = 0;
this.someLabelControl1.Text = "Some Info";
this.popupControlContainer2.SuspendLayout();
this.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent;
this.popupControlContainer2.Appearance.Options.UseBackColor = true;
this.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
this.popupControlContainer2.Controls.Add(this.buttonEdit);
this.popupControlContainer2.Location = new System.Drawing.Point(238, 289);
this.popupControlContainer2.Name = "popupControlContainer2";
this.popupControlContainer2.Ribbon = this.ribbonControl;
this.popupControlContainer2.Size = new System.Drawing.Size(118, 28);
this.popupControlContainer2.TabIndex = 3;
this.popupControlContainer2.Visible = false;
this.popupControlContainer2.ResumeLayout(false);
this.buttonEdit.EditValue = "Some Text";
this.buttonEdit.Location = new System.Drawing.Point(3, 5);
this.buttonEdit.MenuManager = this.ribbonControl;
this.buttonEdit.Name = "buttonEdit";
this.buttonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
this.buttonEdit.Size = new System.Drawing.Size(100, 20);
this.buttonEdit.TabIndex = 0;
this.ribbonStatusBar.ItemLinks.Add(this.siStatus);
this.ribbonStatusBar.ItemLinks.Add(this.siInfo);
this.ribbonStatusBar.Location = new System.Drawing.Point(0, 371);
this.ribbonStatusBar.Name = "ribbonStatusBar";
this.ribbonStatusBar.Ribbon = this.ribbonControl;
this.ribbonStatusBar.Size = new System.Drawing.Size(750, 31);
this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_Exit_16x16.png");
this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Content_16x16.png");
this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Info_16x16.png");
this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_Exit_32x32.png");
this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Content_32x32.png");
this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Info_32x32.png");
this.navBarControl.ActiveGroup = this.mailGroup;
this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {this.mailGroup,this.organizerGroup});
this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {this.inboxItem,this.outboxItem,this.draftsItem,this.trashItem,this.calendarItem,this.tasksItem});
this.navBarControl.LargeImages = this.navbarImageCollectionLarge;
this.navBarControl.Location = new System.Drawing.Point(0, 0);
this.navBarControl.Name = "navBarControl";
this.navBarControl.OptionsNavPane.ExpandedWidth = 322;
this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
this.navBarControl.Size = new System.Drawing.Size(322, 442);
this.navBarControl.SmallImages = this.navbarImageCollection;
this.navBarControl.StoreDefaultPaintStyleName = true;
this.navBarControl.TabIndex = 0;
this.navBarControl.Text = "navBarControl1";
this.mailGroup.Caption = "Mail";
this.mailGroup.Expanded = true;
this.mailGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {new DevExpress.XtraNavBar.NavBarItemLink(this.inboxItem),new DevExpress.XtraNavBar.NavBarItemLink(this.outboxItem),new DevExpress.XtraNavBar.NavBarItemLink(this.draftsItem),new DevExpress.XtraNavBar.NavBarItemLink(this.trashItem)});
this.mailGroup.LargeImageIndex = 0;
this.mailGroup.Name = "mailGroup";
this.organizerGroup.Caption = "Organizer";
this.organizerGroup.Expanded = true;
this.organizerGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {new DevExpress.XtraNavBar.NavBarItemLink(this.calendarItem),new DevExpress.XtraNavBar.NavBarItemLink(this.tasksItem)});
this.organizerGroup.LargeImageIndex = 1;
this.organizerGroup.Name = "organizerGroup";
this.inboxItem.Caption = "Inbox";
this.inboxItem.Name = "inboxItem";
this.inboxItem.SmallImageIndex = 0;
this.outboxItem.Caption = "Outbox";
this.outboxItem.Name = "outboxItem";
this.outboxItem.SmallImageIndex = 1;
this.draftsItem.Caption = "Drafts";
this.draftsItem.Name = "draftsItem";
this.draftsItem.SmallImageIndex = 2;
this.trashItem.Caption = "Trash";
this.trashItem.Name = "trashItem";
this.trashItem.SmallImageIndex = 3;
this.calendarItem.Caption = "Calendar";
this.calendarItem.Name = "calendarItem";
this.calendarItem.SmallImageIndex = 4;
this.tasksItem.Caption = "Tasks";
this.tasksItem.Name = "tasksItem";
this.tasksItem.SmallImageIndex = 5;
this.navbarImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollection.ImageStream")));
this.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent;
this.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png");
this.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png");
this.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png");
this.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png");
this.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png");
this.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png");
this.navbarImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollectionLarge.ImageStream")));
this.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent;
this.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_16x16.png");
this.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_16x16.png");
this.spreadsheetFormulaBarPanel.SuspendLayout();
this.spreadsheetFormulaBarPanel.Controls.Add(this.spreadsheetControl);
this.spreadsheetFormulaBarPanel.Controls.Add(this.splitterControl);
this.spreadsheetFormulaBarPanel.Controls.Add(this.formulaBarNameBoxSplitContainerControl);
this.spreadsheetFormulaBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
this.spreadsheetFormulaBarPanel.Location = new System.Drawing.Point(0, 0);
this.spreadsheetFormulaBarPanel.Name = "spreadsheetFormulaBarPanel";
this.spreadsheetFormulaBarPanel.Size = new System.Drawing.Size(499, 375);
this.spreadsheetFormulaBarPanel.TabIndex = 3;
this.spreadsheetFormulaBarPanel.ResumeLayout(false);
this.spreadsheetControl.Dock = System.Windows.Forms.DockStyle.Fill;
this.spreadsheetControl.Location = new System.Drawing.Point(0, 25);
this.spreadsheetControl.Name = "spreadsheetControl";
this.spreadsheetControl.Size = new System.Drawing.Size(499, 350);
this.spreadsheetControl.TabIndex = 1;
this.spreadsheetControl.Text = "spreadsheetControl1";
this.splitterControl.Dock = System.Windows.Forms.DockStyle.Top;
this.splitterControl.Location = new System.Drawing.Point(0, 20);
this.splitterControl.MinSize = 20;
this.splitterControl.Name = "splitterControl";
this.splitterControl.Size = new System.Drawing.Size(499, 5);
this.splitterControl.TabIndex = 2;
this.splitterControl.TabStop = false;
this.formulaBarNameBoxSplitContainerControl.SuspendLayout();
this.formulaBarNameBoxSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Top;
this.formulaBarNameBoxSplitContainerControl.Location = new System.Drawing.Point(0, 0);
this.formulaBarNameBoxSplitContainerControl.Name = "formulaBarNameBoxSplitContainerControl";
this.formulaBarNameBoxSplitContainerControl.Panel1.Controls.Add(this.spreadsheetNameBoxControl);
this.formulaBarNameBoxSplitContainerControl.Panel2.Controls.Add(this.spreadsheetFormulaBarControl1);
this.formulaBarNameBoxSplitContainerControl.Size = new System.Drawing.Size(499, 20);
this.formulaBarNameBoxSplitContainerControl.SplitterPosition = 145;
this.formulaBarNameBoxSplitContainerControl.TabIndex = 3;
this.formulaBarNameBoxSplitContainerControl.ResumeLayout(false);
this.spreadsheetNameBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
this.spreadsheetNameBoxControl.EditValue = "A1";
this.spreadsheetNameBoxControl.Location = new System.Drawing.Point(0, 0);
this.spreadsheetNameBoxControl.Name = "spreadsheetNameBoxControl";
this.spreadsheetNameBoxControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
this.spreadsheetNameBoxControl.Size = new System.Drawing.Size(145, 20);
this.spreadsheetNameBoxControl.SpreadsheetControl = this.spreadsheetControl;
this.spreadsheetNameBoxControl.TabIndex = 0;
this.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
this.spreadsheetFormulaBarControl1.Location = new System.Drawing.Point(0, 0);
this.spreadsheetFormulaBarControl1.MinimumSize = new System.Drawing.Size(0, 20);
this.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1";
this.spreadsheetFormulaBarControl1.Size = new System.Drawing.Size(349, 20);
this.spreadsheetFormulaBarControl1.SpreadsheetControl = this.spreadsheetControl;
this.spreadsheetFormulaBarControl1.TabIndex = 0;


            this.Name = "Form1";
            this.Text = "Form1";
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Controls.Add(this.splitContainerControl);

            this.Controls.Add(this.ribbonControl);
this.Controls.Add(this.popupControlContainer1);
this.Controls.Add(this.popupControlContainer2);
this.Controls.Add(this.ribbonStatusBar);

            
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.formulaBarNameBoxSplitContainerControl)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.spreadsheetNameBoxControl.Properties)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
private DevExpress.XtraBars.BarButtonItem iExit;
private DevExpress.XtraBars.BarButtonItem iHelp;
private DevExpress.XtraBars.BarButtonItem iAbout;
private DevExpress.XtraBars.BarStaticItem siStatus;
private DevExpress.XtraBars.BarStaticItem siInfo;
private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSkins;
private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinsRibbonPageGroup;
private DevExpress.XtraBars.Ribbon.RibbonPage helpRibbonPage;
private DevExpress.XtraBars.Ribbon.RibbonPageGroup helpRibbonPageGroup;
private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
private DevExpress.XtraEditors.LabelControl someLabelControl2;
private DevExpress.XtraEditors.LabelControl someLabelControl1;
private DevExpress.XtraBars.PopupControlContainer popupControlContainer2;
private DevExpress.XtraEditors.ButtonEdit buttonEdit;
private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
private DevExpress.Utils.ImageCollection ribbonImageCollection;
private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
private DevExpress.XtraNavBar.NavBarControl navBarControl;
private DevExpress.XtraNavBar.NavBarGroup mailGroup;
private DevExpress.XtraNavBar.NavBarGroup organizerGroup;
private DevExpress.XtraNavBar.NavBarItem inboxItem;
private DevExpress.XtraNavBar.NavBarItem outboxItem;
private DevExpress.XtraNavBar.NavBarItem draftsItem;
private DevExpress.XtraNavBar.NavBarItem trashItem;
private DevExpress.XtraNavBar.NavBarItem calendarItem;
private DevExpress.XtraNavBar.NavBarItem tasksItem;
private DevExpress.Utils.ImageCollection navbarImageCollection;
private DevExpress.Utils.ImageCollection navbarImageCollectionLarge;
private System.Windows.Forms.Panel spreadsheetFormulaBarPanel;
private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl;
private DevExpress.XtraEditors.SplitterControl splitterControl;
private DevExpress.XtraEditors.SplitContainerControl formulaBarNameBoxSplitContainerControl;
private DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl spreadsheetNameBoxControl;
private DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl spreadsheetFormulaBarControl1;
        
    }
}
