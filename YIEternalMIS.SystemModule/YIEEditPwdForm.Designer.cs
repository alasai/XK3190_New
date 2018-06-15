namespace YIEternalMIS.SystemModule
{
    partial class YIEEditPwdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YIEEditPwdForm));
            this.tnewt = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tnew = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.told = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tnewt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tnew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.told.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tnewt
            // 
            this.tnewt.Location = new System.Drawing.Point(145, 160);
            this.tnewt.Name = "tnewt";
            this.tnewt.Properties.PasswordChar = '*';
            this.tnewt.Size = new System.Drawing.Size(169, 20);
            this.tnewt.TabIndex = 7;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.BeforeText;
            this.groupControl1.Controls.Add(this.tnewt);
            this.groupControl1.Controls.Add(this.tnew);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.told);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(399, 277);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "修改当前登陆用户密码";
            // 
            // tnew
            // 
            this.tnew.Location = new System.Drawing.Point(145, 121);
            this.tnew.Name = "tnew";
            this.tnew.Properties.PasswordChar = '*';
            this.tnew.Size = new System.Drawing.Size(169, 20);
            this.tnew.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(81, 163);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "确认密码:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(93, 124);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "新密码:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(93, 84);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "原密码:";
            // 
            // told
            // 
            this.told.Location = new System.Drawing.Point(145, 81);
            this.told.Name = "told";
            this.told.Properties.PasswordChar = '*';
            this.told.Size = new System.Drawing.Size(169, 20);
            this.told.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(233, 213);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(86, 33);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "关闭[&X]";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(81, 213);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 33);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "确认[&O]";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // YIEEditPwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 277);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YIEEditPwdForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YIEEditPwdForm";
            ((System.ComponentModel.ISupportInitialize)(this.tnewt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tnew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.told.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit tnewt;
        private DevExpress.XtraEditors.TextEdit tnew;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit told;
    }
}