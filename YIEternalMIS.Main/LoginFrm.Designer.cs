namespace YIEternalMIS.Main
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.sbtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ckSaveLogin = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tPwd = new DevExpress.XtraEditors.TextEdit();
            this.tUserID = new DevExpress.XtraEditors.TextEdit();
            this.sbtnColse = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckSaveLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUserID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(531, 312);
            this.panelControl1.TabIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.BeforeText;
            this.groupControl2.Controls.Add(this.sbtnNew);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.ckSaveLogin);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.tPwd);
            this.groupControl2.Controls.Add(this.tUserID);
            this.groupControl2.Controls.Add(this.sbtnColse);
            this.groupControl2.Controls.Add(this.sbtnOK);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(527, 308);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "用户信息";
            // 
            // sbtnNew
            // 
            this.sbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("sbtnNew.Image")));
            this.sbtnNew.Location = new System.Drawing.Point(424, 10);
            this.sbtnNew.Name = "sbtnNew";
            this.sbtnNew.Size = new System.Drawing.Size(93, 23);
            this.sbtnNew.TabIndex = 9;
            this.sbtnNew.Text = "配置连接";
            this.sbtnNew.Click += new System.EventHandler(this.sbtnNew_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(163, 262);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(144, 14);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "江苏真源网络服务有限公司";
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
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 312);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFrm";
            this.Text = "LoginFrm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckSaveLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUserID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit ckSaveLogin;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tPwd;
        private DevExpress.XtraEditors.TextEdit tUserID;
        private DevExpress.XtraEditors.SimpleButton sbtnColse;
        private DevExpress.XtraEditors.SimpleButton sbtnOK;
        private DevExpress.XtraEditors.SimpleButton sbtnNew;
    }
}