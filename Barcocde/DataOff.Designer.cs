namespace Barcocde
{
    partial class DataOff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataOff));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbAuthe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDatabases = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAuthe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(194, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(194, 112);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(157, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(194, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(157, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(72, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Server Name:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(72, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Authentication:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(72, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Login :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(72, 149);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Password :";
            // 
            // cmbAuthe
            // 
            this.cmbAuthe.Location = new System.Drawing.Point(194, 74);
            this.cmbAuthe.Name = "cmbAuthe";
            this.cmbAuthe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAuthe.Properties.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cmbAuthe.Size = new System.Drawing.Size(157, 20);
            this.cmbAuthe.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(176, 240);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 28);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Cập Nhật";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(72, 186);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Tên Databases:";
            // 
            // txtTenDatabases
            // 
            this.txtTenDatabases.Location = new System.Drawing.Point(194, 183);
            this.txtTenDatabases.Name = "txtTenDatabases";
            this.txtTenDatabases.Size = new System.Drawing.Size(157, 20);
            this.txtTenDatabases.TabIndex = 5;
            // 
            // DataOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 280);
            this.Controls.Add(this.txtTenDatabases);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmbAuthe);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataOff";
            this.Text = "Thông Tin Server";
            ((System.ComponentModel.ISupportInitialize)(this.cmbAuthe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAuthe;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtTenDatabases;
    }
}