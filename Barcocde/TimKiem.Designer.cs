namespace Barcocde
{
    partial class TimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiem));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.lkKho = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gctk = new DevExpress.XtraGrid.GridControl();
            this.gvTK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNVKiemKe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtMaTK);
            this.groupControl1.Controls.Add(this.btnXem);
            this.groupControl1.Controls.Add(this.dt2);
            this.groupControl1.Controls.Add(this.dt1);
            this.groupControl1.Controls.Add(this.lkKho);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 117);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(478, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mã Kho:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(478, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mã Hàng :";
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(542, 70);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(246, 21);
            this.txtMaTK.TabIndex = 2;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(301, 73);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dt2
            // 
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2.Location = new System.Drawing.Point(155, 71);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(123, 21);
            this.dt2.TabIndex = 0;
            // 
            // dt1
            // 
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1.Location = new System.Drawing.Point(10, 71);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(116, 21);
            this.dt1.TabIndex = 0;
            // 
            // lkKho
            // 
            this.lkKho.Location = new System.Drawing.Point(542, 33);
            this.lkKho.Name = "lkKho";
            this.lkKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKho.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên Kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDKho", "ID Kho")});
            this.lkKho.Properties.DisplayMember = "TenKho";
            this.lkKho.Properties.NullText = "";
            this.lkKho.Properties.PopupSizeable = false;
            this.lkKho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkKho.Properties.ValueMember = "IDKho";
            this.lkKho.Size = new System.Drawing.Size(246, 20);
            this.lkKho.TabIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gctk);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 117);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(800, 333);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh Sách";
            // 
            // gctk
            // 
            this.gctk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctk.Location = new System.Drawing.Point(2, 20);
            this.gctk.MainView = this.gvTK;
            this.gctk.Name = "gctk";
            this.gctk.Size = new System.Drawing.Size(796, 311);
            this.gctk.TabIndex = 0;
            this.gctk.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTK});
            // 
            // gvTK
            // 
            this.gvTK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHH,
            this.TenHH,
            this.colKhuVuc,
            this.colNVKiemKe,
            this.colSTT});
            this.gvTK.GridControl = this.gctk;
            this.gvTK.Name = "gvTK";
            this.gvTK.OptionsView.ShowGroupPanel = false;
            // 
            // colMaHH
            // 
            this.colMaHH.Caption = "Mã Hàng Hóa";
            this.colMaHH.FieldName = "MaHH";
            this.colMaHH.Name = "colMaHH";
            this.colMaHH.Visible = true;
            this.colMaHH.VisibleIndex = 0;
            // 
            // TenHH
            // 
            this.TenHH.Caption = "Tên Hàng Hóa";
            this.TenHH.FieldName = "TenHH";
            this.TenHH.Name = "TenHH";
            this.TenHH.Visible = true;
            this.TenHH.VisibleIndex = 1;
            // 
            // colKhuVuc
            // 
            this.colKhuVuc.Caption = "Khu Vực";
            this.colKhuVuc.FieldName = "KhuVuc";
            this.colKhuVuc.Name = "colKhuVuc";
            this.colKhuVuc.Visible = true;
            this.colKhuVuc.VisibleIndex = 2;
            // 
            // colNVKiemKe
            // 
            this.colNVKiemKe.Caption = "Nhân Viên Kiểm Kê";
            this.colNVKiemKe.FieldName = "NVKiemKe";
            this.colNVKiemKe.Name = "colNVKiemKe";
            this.colNVKiemKe.Visible = true;
            this.colNVKiemKe.VisibleIndex = 3;
            // 
            // colSTT
            // 
            this.colSTT.Caption = "Số Thứ Tự";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 4;
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiem";
            this.Text = "Tìm Kiếm Hàng Hóa";
            this.Load += new System.EventHandler(this.TimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtMaTK;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.DateTimePicker dt1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gctk;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn TenHH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHH;
        private DevExpress.XtraGrid.Columns.GridColumn colKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colNVKiemKe;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lkKho;
    }
}