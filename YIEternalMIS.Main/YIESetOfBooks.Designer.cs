namespace YIEternalMIS.Main
{
    partial class YIESetOfBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YIESetOfBooks));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ckSaveLogin = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tUserName = new DevExpress.XtraEditors.TextEdit();
            this.tPwd = new DevExpress.XtraEditors.TextEdit();
            this.tUserID = new DevExpress.XtraEditors.TextEdit();
            this.sbtnColse = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnOK = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sbtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.ucbooks = new YIEternalMIS.Library.YIEUcSetOfBooks();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckSaveLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(632, 346);
            this.panelControl1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.BeforeText;
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.ckSaveLogin);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.tUserName);
            this.groupControl2.Controls.Add(this.tPwd);
            this.groupControl2.Controls.Add(this.tUserID);
            this.groupControl2.Controls.Add(this.sbtnColse);
            this.groupControl2.Controls.Add(this.sbtnOK);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(153, 109);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(477, 235);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "用户信息";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(96, 198);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(208, 14);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "CopyRight @2016-2017 YIEternalMIS ";
            // 
            // ckSaveLogin
            // 
            this.ckSaveLogin.Location = new System.Drawing.Point(150, 160);
            this.ckSaveLogin.Name = "ckSaveLogin";
            this.ckSaveLogin.Properties.Caption = "记住当前登录用户";
            this.ckSaveLogin.Size = new System.Drawing.Size(146, 19);
            this.ckSaveLogin.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(69, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "登录密码：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(69, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "登录用户：";
            // 
            // tUserName
            // 
            this.tUserName.Location = new System.Drawing.Point(5, 42);
            this.tUserName.Name = "tUserName";
            this.tUserName.Size = new System.Drawing.Size(11, 20);
            this.tUserName.TabIndex = 4;
            this.tUserName.Visible = false;
            // 
            // tPwd
            // 
            this.tPwd.Location = new System.Drawing.Point(150, 118);
            this.tPwd.Name = "tPwd";
            this.tPwd.Properties.PasswordChar = '*';
            this.tPwd.Size = new System.Drawing.Size(146, 20);
            this.tPwd.TabIndex = 3;
            // 
            // tUserID
            // 
            this.tUserID.Location = new System.Drawing.Point(150, 67);
            this.tUserID.Name = "tUserID";
            this.tUserID.Size = new System.Drawing.Size(146, 20);
            this.tUserID.TabIndex = 2;
            this.tUserID.EditValueChanged += new System.EventHandler(this.tUserID_EditValueChanged);
            // 
            // sbtnColse
            // 
            this.sbtnColse.Image = ((System.Drawing.Image)(resources.GetObject("sbtnColse.Image")));
            this.sbtnColse.Location = new System.Drawing.Point(348, 139);
            this.sbtnColse.Name = "sbtnColse";
            this.sbtnColse.Size = new System.Drawing.Size(101, 41);
            this.sbtnColse.TabIndex = 1;
            this.sbtnColse.Text = "退出[&Exit]";
            this.sbtnColse.Click += new System.EventHandler(this.sbtnColse_Click);
            // 
            // sbtnOK
            // 
            this.sbtnOK.Image = ((System.Drawing.Image)(resources.GetObject("sbtnOK.Image")));
            this.sbtnOK.Location = new System.Drawing.Point(348, 59);
            this.sbtnOK.Name = "sbtnOK";
            this.sbtnOK.Size = new System.Drawing.Size(101, 65);
            this.sbtnOK.TabIndex = 0;
            this.sbtnOK.Text = "登录[&Ok]";
            this.sbtnOK.Click += new System.EventHandler(this.sbtnOK_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.BeforeText;
            this.groupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupControl1.Controls.Add(this.sbtnNew);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.ucbooks);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(153, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(477, 107);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "账套信息";
            // 
            // sbtnNew
            // 
            this.sbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("sbtnNew.Image")));
            this.sbtnNew.Location = new System.Drawing.Point(368, 57);
            this.sbtnNew.Name = "sbtnNew";
            this.sbtnNew.Size = new System.Drawing.Size(93, 23);
            this.sbtnNew.TabIndex = 2;
            this.sbtnNew.Text = "新建账套";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "选择要登录的账套：";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(151, 342);
            this.pictureEdit1.TabIndex = 2;
            // 
            // ucbooks
            // 
            this.ucbooks.Location = new System.Drawing.Point(120, 59);
            this.ucbooks.Name = "ucbooks";
            this.ucbooks.Size = new System.Drawing.Size(226, 26);
            this.ucbooks.TabIndex = 0;
            // 
            // YIESetOfBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 346);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YIESetOfBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YIESetOfBooks";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckSaveLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Library.YIEUcSetOfBooks ucbooks;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtnNew;
        private DevExpress.XtraEditors.SimpleButton sbtnColse;
        private DevExpress.XtraEditors.SimpleButton sbtnOK;
        private DevExpress.XtraEditors.TextEdit tUserName;
        private DevExpress.XtraEditors.TextEdit tPwd;
        private DevExpress.XtraEditors.TextEdit tUserID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit ckSaveLogin;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}