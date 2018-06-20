namespace WeightManage.Module.Views.FactoryInfo
{
    partial class HookWeightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HookWeightForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtNumber = new System.Windows.Forms.NumericUpDown();
            this.txtMao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnBack);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.txtNumber);
            this.panelControl1.Controls.Add(this.txtMao);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(461, 263);
            this.panelControl1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(244, 180);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 30);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "返回";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(84, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 30);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(130, 112);
            this.txtNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(120, 22);
            this.txtNumber.TabIndex = 17;
            this.txtNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMao
            // 
            this.txtMao.Location = new System.Drawing.Point(130, 53);
            this.txtMao.Name = "txtMao";
            this.txtMao.Size = new System.Drawing.Size(118, 20);
            this.txtMao.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 114);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "过磅数量";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(52, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "毛重";
            // 
            // HookWeightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 263);
            this.Controls.Add(this.panelControl1);
            this.Name = "HookWeightForm";
            this.Text = "毛重设置";
            this.Load += new System.EventHandler(this.HookWeightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMao;
        private System.Windows.Forms.NumericUpDown txtNumber;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}