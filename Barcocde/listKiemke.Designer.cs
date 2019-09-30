namespace Barcocde
{
    partial class listKiemke
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listKiemke));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcListKiemke = new DevExpress.XtraGrid.GridControl();
            this.bdListKiemKe = new System.Windows.Forms.BindingSource(this.components);
            this.gvListKiemke = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKeHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenGoiNho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKiemKe1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiKiemKe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.colNgayKiemKe = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListKiemke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdListKiemKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListKiemke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcListKiemke);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(969, 286);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh Sách kiểm kê";
            // 
            // gcListKiemke
            // 
            this.gcListKiemke.DataSource = this.bdListKiemKe;
            this.gcListKiemke.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gcListKiemke.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcListKiemke.Location = new System.Drawing.Point(2, 20);
            this.gcListKiemke.MainView = this.gvListKiemke;
            this.gcListKiemke.Name = "gcListKiemke";
            this.gcListKiemke.Size = new System.Drawing.Size(965, 264);
            this.gcListKiemke.TabIndex = 8;
            this.gcListKiemke.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListKiemke});
            this.gcListKiemke.Click += new System.EventHandler(this.gcListKiemke_Click);
            // 
            // gvListKiemke
            // 
            this.gvListKiemke.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gvListKiemke.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvListKiemke.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvListKiemke.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gvListKiemke.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvListKiemke.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvListKiemke.Appearance.Row.Options.UseTextOptions = true;
            this.gvListKiemke.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvListKiemke.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvListKiemke.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colTenKeHang,
            this.colMaHH,
            this.colTenHH,
            this.colTenGoiNho,
            this.colSoLuong,
            this.colNgayKiemKe1,
            this.colLoaiKiemKe});
            this.gvListKiemke.GridControl = this.gcListKiemke;
            this.gvListKiemke.Name = "gvListKiemke";
            this.gvListKiemke.OptionsBehavior.Editable = false;
            this.gvListKiemke.OptionsBehavior.ReadOnly = true;
            this.gvListKiemke.OptionsView.ColumnAutoWidth = false;
            this.gvListKiemke.OptionsView.ShowAutoFilterRow = true;
            this.gvListKiemke.OptionsView.ShowGroupPanel = false;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 52;
            // 
            // colTenKeHang
            // 
            this.colTenKeHang.Caption = "Tên kệ Hàng";
            this.colTenKeHang.FieldName = "TenKeHang";
            this.colTenKeHang.Name = "colTenKeHang";
            this.colTenKeHang.Visible = true;
            this.colTenKeHang.VisibleIndex = 1;
            this.colTenKeHang.Width = 112;
            // 
            // colMaHH
            // 
            this.colMaHH.Caption = "Mã Hàng Hóa";
            this.colMaHH.FieldName = "MaHH";
            this.colMaHH.Name = "colMaHH";
            this.colMaHH.Visible = true;
            this.colMaHH.VisibleIndex = 2;
            this.colMaHH.Width = 147;
            // 
            // colTenHH
            // 
            this.colTenHH.Caption = "Tên Hàng Hóa";
            this.colTenHH.FieldName = "TenHH";
            this.colTenHH.Name = "colTenHH";
            this.colTenHH.Visible = true;
            this.colTenHH.VisibleIndex = 3;
            this.colTenHH.Width = 186;
            // 
            // colTenGoiNho
            // 
            this.colTenGoiNho.Caption = "Mã Gợi Nhớ";
            this.colTenGoiNho.FieldName = "MaGoiNho";
            this.colTenGoiNho.Name = "colTenGoiNho";
            this.colTenGoiNho.Visible = true;
            this.colTenGoiNho.VisibleIndex = 4;
            this.colTenGoiNho.Width = 158;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số  Lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 5;
            // 
            // colNgayKiemKe1
            // 
            this.colNgayKiemKe1.Caption = "Ngày Kiểm kê";
            this.colNgayKiemKe1.DisplayFormat.FormatString = "dd-MM-yyyy hh:mm:ss:tt";
            this.colNgayKiemKe1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayKiemKe1.FieldName = "NgayKiemKe";
            this.colNgayKiemKe1.Name = "colNgayKiemKe1";
            this.colNgayKiemKe1.Visible = true;
            this.colNgayKiemKe1.VisibleIndex = 6;
            this.colNgayKiemKe1.Width = 139;
            // 
            // colLoaiKiemKe
            // 
            this.colLoaiKiemKe.Caption = "Loại Kiểm Kê";
            this.colLoaiKiemKe.FieldName = "LoaiKiemKe";
            this.colLoaiKiemKe.Name = "colLoaiKiemKe";
            this.colLoaiKiemKe.Visible = true;
            this.colLoaiKiemKe.VisibleIndex = 7;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 143);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(973, 308);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông Tin";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(973, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đẩy";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Cập Nhật Hàng Hóa";
            this.btnThem.Id = 2;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 3;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Name = "btnSua";
            this.btnSua.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 4;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Lưu";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Kiểm kê";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Đẩy";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Cập Nhật";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Lưu Hàng Hóa";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 451);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(973, 31);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // colNgayKiemKe
            // 
            this.colNgayKiemKe.Caption = "Ngày Kiểm Kê";
            this.colNgayKiemKe.DisplayFormat.FormatString = "dd-MM-yyyy hh:mm";
            this.colNgayKiemKe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayKiemKe.FieldName = "ngaykiemke";
            this.colNgayKiemKe.Name = "colNgayKiemKe";
            this.colNgayKiemKe.Width = 256;
            // 
            // listKiemke
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 482);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "listKiemke";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Danh Sách Kiểm kê";
            this.Load += new System.EventHandler(this.listKiemke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcListKiemke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdListKiemKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListKiemke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource bdListKiemKe;
        private DevExpress.XtraGrid.GridControl gcListKiemke;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListKiemke;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKiemKe;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKeHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKiemKe1;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiKiemKe;
        private DevExpress.XtraGrid.Columns.GridColumn colTenGoiNho;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHH;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}