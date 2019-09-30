namespace Barcocde
{
    partial class AddHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHangHoa));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lkTenKhoHang = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenKhuVuc = new DevExpress.XtraEditors.TextEdit();
            this.gcDSHangHoa = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaGoiNho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGianQuet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGianCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiKiemKe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.txtMessage = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.item0 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.kh = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkTenKhoHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhuVuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnCapNhat,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(998, 143);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Caption = "Cập Nhật";
            this.btnCapNhat.Id = 1;
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCapNhat_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Hủy";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức Năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCapNhat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Cập Nhật";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Hủy";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lkTenKhoHang);
            this.layoutControl1.Controls.Add(this.txtTenKhuVuc);
            this.layoutControl1.Controls.Add(this.gcDSHangHoa);
            this.layoutControl1.Controls.Add(this.txtMa);
            this.layoutControl1.Controls.Add(this.txtMessage);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(998, 392);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lkTenKhoHang
            // 
            this.lkTenKhoHang.Location = new System.Drawing.Point(125, 55);
            this.lkTenKhoHang.Name = "lkTenKhoHang";
            this.lkTenKhoHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTenKhoHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDKho", "Mã Kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên Kho")});
            this.lkTenKhoHang.Properties.DisplayMember = "TenKho";
            this.lkTenKhoHang.Properties.NullText = "";
            this.lkTenKhoHang.Properties.PopupSizeable = false;
            this.lkTenKhoHang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkTenKhoHang.Properties.ValueMember = "IDKho";
            this.lkTenKhoHang.Size = new System.Drawing.Size(322, 20);
            this.lkTenKhoHang.StyleController = this.layoutControl1;
            this.lkTenKhoHang.TabIndex = 1;
            // 
            // txtTenKhuVuc
            // 
            this.txtTenKhuVuc.Location = new System.Drawing.Point(125, 85);
            this.txtTenKhuVuc.Name = "txtTenKhuVuc";
            this.txtTenKhuVuc.Size = new System.Drawing.Size(322, 20);
            this.txtTenKhuVuc.StyleController = this.layoutControl1;
            this.txtTenKhuVuc.TabIndex = 2;
            // 
            // gcDSHangHoa
            // 
            this.gcDSHangHoa.DataSource = this.bindingSource1;
            this.gcDSHangHoa.Location = new System.Drawing.Point(34, 156);
            this.gcDSHangHoa.MainView = this.gridView1;
            this.gcDSHangHoa.Name = "gcDSHangHoa";
            this.gcDSHangHoa.Size = new System.Drawing.Size(930, 202);
            this.gcDSHangHoa.TabIndex = 7;
            this.gcDSHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.IDHangHoa,
            this.colMaHH,
            this.colTenHH,
            this.colMaGoiNho,
            this.colThoiGianQuet,
            this.colThoiGianCapNhat,
            this.colLoaiKiemKe,
            this.colID});
            this.gridView1.GridControl = this.gcDSHangHoa;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSTT, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "SoTT";
            this.colSTT.Name = "colSTT";
            this.colSTT.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            // 
            // IDHangHoa
            // 
            this.IDHangHoa.Caption = "ID Hàng Hóa";
            this.IDHangHoa.FieldName = "IDHangHoa";
            this.IDHangHoa.Name = "IDHangHoa";
            // 
            // colMaHH
            // 
            this.colMaHH.Caption = "Mã Hàng Hóa";
            this.colMaHH.FieldName = "ProductCode";
            this.colMaHH.Name = "colMaHH";
            this.colMaHH.Visible = true;
            this.colMaHH.VisibleIndex = 1;
            this.colMaHH.Width = 158;
            // 
            // colTenHH
            // 
            this.colTenHH.Caption = "Tên Hàng Hóa";
            this.colTenHH.FieldName = "ProductName";
            this.colTenHH.Name = "colTenHH";
            this.colTenHH.Visible = true;
            this.colTenHH.VisibleIndex = 2;
            this.colTenHH.Width = 123;
            // 
            // colMaGoiNho
            // 
            this.colMaGoiNho.Caption = "Mã Gợi Nhớ";
            this.colMaGoiNho.FieldName = "MaGoiNho";
            this.colMaGoiNho.Name = "colMaGoiNho";
            this.colMaGoiNho.Visible = true;
            this.colMaGoiNho.VisibleIndex = 3;
            this.colMaGoiNho.Width = 149;
            // 
            // colThoiGianQuet
            // 
            this.colThoiGianQuet.Caption = "Thời Gian Quét";
            this.colThoiGianQuet.DisplayFormat.FormatString = "dd-MM-yyyy hh:mm:ss:ttt";
            this.colThoiGianQuet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colThoiGianQuet.FieldName = "ThoiGianQuet";
            this.colThoiGianQuet.Name = "colThoiGianQuet";
            this.colThoiGianQuet.Visible = true;
            this.colThoiGianQuet.VisibleIndex = 4;
            this.colThoiGianQuet.Width = 151;
            // 
            // colThoiGianCapNhat
            // 
            this.colThoiGianCapNhat.Caption = "Update_at";
            this.colThoiGianCapNhat.DisplayFormat.FormatString = "dd-MM-yyyy hh:mm";
            this.colThoiGianCapNhat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colThoiGianCapNhat.FieldName = "ThoiGianCapNhat";
            this.colThoiGianCapNhat.GroupFormat.FormatString = "dd-MM-yyyy hh:mm";
            this.colThoiGianCapNhat.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colThoiGianCapNhat.Name = "colThoiGianCapNhat";
            this.colThoiGianCapNhat.Visible = true;
            this.colThoiGianCapNhat.VisibleIndex = 5;
            this.colThoiGianCapNhat.Width = 131;
            // 
            // colLoaiKiemKe
            // 
            this.colLoaiKiemKe.Caption = "Loại Kiểm Kê";
            this.colLoaiKiemKe.FieldName = "LoaiKiemKe";
            this.colLoaiKiemKe.Name = "colLoaiKiemKe";
            this.colLoaiKiemKe.Visible = true;
            this.colLoaiKiemKe.VisibleIndex = 6;
            this.colLoaiKiemKe.Width = 160;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(569, 55);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.txtMa.Properties.Appearance.Options.UseFont = true;
            this.txtMa.Size = new System.Drawing.Size(357, 30);
            this.txtMa.StyleController = this.layoutControl1;
            this.txtMa.TabIndex = 0;
            this.txtMa.ToolTip = "Bấm Enter để tìm";
            this.txtMa.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // txtMessage
            // 
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(492, 92);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtMessage.Properties.Appearance.Options.UseFont = true;
            this.txtMessage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMessage.Properties.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(469, 18);
            this.txtMessage.StyleController = this.layoutControl1;
            this.txtMessage.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.item0});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(998, 392);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // item0
            // 
            this.item0.CustomizationFormText = "Root";
            this.item0.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.item0.GroupBordersVisible = false;
            this.item0.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlGroup5});
            this.item0.Location = new System.Drawing.Point(0, 0);
            this.item0.Name = "item0";
            this.item0.Size = new System.Drawing.Size(978, 372);
            this.item0.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.item0.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Thông Tin";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.kh,
            this.layoutControlItem2});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(455, 104);
            this.layoutControlGroup3.Text = "Thông Tin";
            // 
            // kh
            // 
            this.kh.Control = this.lkTenKhoHang;
            this.kh.CustomizationFormText = "Tên Kho Hàng :";
            this.kh.Location = new System.Drawing.Point(0, 0);
            this.kh.Name = "kh";
            this.kh.Padding = new DevExpress.XtraLayout.Utils.Padding(16, 16, 5, 5);
            this.kh.Size = new System.Drawing.Size(431, 30);
            this.kh.Text = "Tên Kho Hàng :";
            this.kh.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTenKhuVuc;
            this.layoutControlItem2.CustomizationFormText = "Tên Khu Vực :";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(16, 16, 5, 5);
            this.layoutControlItem2.Size = new System.Drawing.Size(431, 32);
            this.layoutControlItem2.Text = "Tên Khu Vực :";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "Danh Sách";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 104);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(958, 248);
            this.layoutControlGroup4.Text = "Danh Sách";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gcDSHangHoa;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(934, 206);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.CustomizationFormText = "Scan BarCode";
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup5.Location = new System.Drawing.Point(455, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(503, 104);
            this.layoutControlGroup5.Text = "Scan BarCode";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtMa;
            this.layoutControlItem3.CustomizationFormText = "Code";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 40, 5, 5);
            this.layoutControlItem3.Size = new System.Drawing.Size(479, 40);
            this.layoutControlItem3.Text = "Code Scan";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMessage;
            this.layoutControlItem1.CustomizationFormText = "Trạng thái";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.layoutControlItem1.Size = new System.Drawing.Size(479, 22);
            this.layoutControlItem1.Text = "Trạng thái";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // AddHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 535);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddHangHoa";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Cập Nhật Hàng Hóa";
            this.Load += new System.EventHandler(this.AddHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkTenKhoHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhuVuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit lkTenKhoHang;
        private DevExpress.XtraEditors.TextEdit txtTenKhuVuc;
        private DevExpress.XtraGrid.GridControl gcDSHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.TextEdit txtMessage;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup item0;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem kh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGoiNho;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGianQuet;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiKiemKe;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Columns.GridColumn IDHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGianCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
    }
}