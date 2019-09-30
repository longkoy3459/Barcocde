namespace Barcocde
{
    partial class BaoCao
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions7 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCao));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions8 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcDSHangHoa = new DevExpress.XtraGrid.GridControl();
            this.gvDSHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_sua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bindingSourcelk = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcelk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcDSHangHoa);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 83);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1000, 362);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Danh Sách Kiểm Kê";
            // 
            // gcDSHangHoa
            // 
            this.gcDSHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSHangHoa.Location = new System.Drawing.Point(2, 20);
            this.gcDSHangHoa.MainView = this.gvDSHangHoa;
            this.gcDSHangHoa.Name = "gcDSHangHoa";
            this.gcDSHangHoa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.btn_sua});
            this.gcDSHangHoa.Size = new System.Drawing.Size(996, 340);
            this.gcDSHangHoa.TabIndex = 8;
            this.gcDSHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSHangHoa});
            // 
            // gvDSHangHoa
            // 
            this.gvDSHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenUser,
            this.colTenKho,
            this.colTenKhuVuc,
            this.colNgayTao,
            this.colSoLuong,
            this.colDaDay});
            this.gvDSHangHoa.GridControl = this.gcDSHangHoa;
            this.gvDSHangHoa.Name = "gvDSHangHoa";
            this.gvDSHangHoa.OptionsBehavior.Editable = false;
            this.gvDSHangHoa.OptionsBehavior.ReadOnly = true;
            this.gvDSHangHoa.OptionsView.ColumnAutoWidth = false;
            this.gvDSHangHoa.OptionsView.ShowAutoFilterRow = true;
            this.gvDSHangHoa.OptionsView.ShowGroupPanel = false;
            // 
            // colTenUser
            // 
            this.colTenUser.Caption = "Tên User";
            this.colTenUser.FieldName = "tenuser";
            this.colTenUser.Name = "colTenUser";
            this.colTenUser.Visible = true;
            this.colTenUser.VisibleIndex = 0;
            // 
            // colTenKho
            // 
            this.colTenKho.Caption = "Tên Kho";
            this.colTenKho.FieldName = "tenkho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.Visible = true;
            this.colTenKho.VisibleIndex = 1;
            this.colTenKho.Width = 122;
            // 
            // colTenKhuVuc
            // 
            this.colTenKhuVuc.Caption = "Tên Khu Vực";
            this.colTenKhuVuc.FieldName = "tenkv";
            this.colTenKhuVuc.Name = "colTenKhuVuc";
            this.colTenKhuVuc.Visible = true;
            this.colTenKhuVuc.VisibleIndex = 2;
            this.colTenKhuVuc.Width = 151;
            // 
            // colNgayTao
            // 
            this.colNgayTao.Caption = "Ngày Tạo";
            this.colNgayTao.DisplayFormat.FormatString = "dd-MM-yyyy hh:mm";
            this.colNgayTao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayTao.FieldName = "ngaytao";
            this.colNgayTao.Name = "colNgayTao";
            this.colNgayTao.Visible = true;
            this.colNgayTao.VisibleIndex = 3;
            this.colNgayTao.Width = 256;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Tổng Số Lượng";
            this.colSoLuong.FieldName = "soluong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            this.colSoLuong.Width = 235;
            // 
            // colDaDay
            // 
            this.colDaDay.Caption = "Trạng Thái  Đẩy";
            this.colDaDay.FieldName = "DaDay";
            this.colDaDay.Name = "colDaDay";
            this.colDaDay.Visible = true;
            this.colDaDay.VisibleIndex = 5;
            this.colDaDay.Width = 134;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions7.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions7.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions7, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btn_sua
            // 
            this.btn_sua.AutoHeight = false;
            editorButtonImageOptions8.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions8.Image")));
            this.btn_sua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions8, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_sua.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_sua_ButtonClick);
            // 
            // bindingSourcelk
            // 
            this.bindingSourcelk.DataSource = typeof(Barcocde.BaoCaoKiemKe);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnAll);
            this.groupControl2.Controls.Add(this.btnLoad);
            this.groupControl2.Controls.Add(this.btnHienThi);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.dt2);
            this.groupControl2.Controls.Add(this.btnXem);
            this.groupControl2.Controls.Add(this.dt1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1000, 83);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Thông Tin";
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(913, 45);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 29);
            this.btnAll.TabIndex = 12;
            this.btnAll.Text = "Xem Tất Cả";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click_1);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(407, 45);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 29);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Xem Mới";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(502, 46);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 29);
            this.btnHienThi.TabIndex = 10;
            this.btnHienThi.Text = "Hiển Thị ";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(129, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Đến";
            // 
            // dt2
            // 
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2.Location = new System.Drawing.Point(165, 52);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(123, 21);
            this.dt2.TabIndex = 8;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(311, 44);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 29);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem Ngày";
            this.btnXem.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dt1
            // 
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1.Location = new System.Drawing.Point(5, 52);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(118, 21);
            this.dt1.TabIndex = 3;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 445);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaoCao";
            this.Text = "Báo Cáo Kiểm Kê";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcelk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcDSHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSHangHoa;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.BindingSource bindingSourcelk;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraGrid.Columns.GridColumn colTenUser;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTao;
        private System.Windows.Forms.DateTimePicker dt2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_sua;
        private System.Windows.Forms.Button btnHienThi;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnAll;
        private DevExpress.XtraGrid.Columns.GridColumn colDaDay;
    }
}