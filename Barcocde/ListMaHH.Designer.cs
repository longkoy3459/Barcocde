namespace Barcocde
{
    partial class ListMaHH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMaHH));
            this.bdListMaHH = new System.Windows.Forms.BindingSource(this.components);
            this.gcDSHangHoa = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaGoiNho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdListMaHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDSHangHoa
            // 
            this.gcDSHangHoa.DataSource = this.bdListMaHH;
            this.gcDSHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDSHangHoa.Location = new System.Drawing.Point(0, 0);
            this.gcDSHangHoa.MainView = this.gridView2;
            this.gcDSHangHoa.Name = "gcDSHangHoa";
            this.gcDSHangHoa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gcDSHangHoa.Size = new System.Drawing.Size(800, 377);
            this.gcDSHangHoa.TabIndex = 3;
            this.gcDSHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproductName,
            this.colproductCode,
            this.colMaGoiNho});
            this.gridView2.GridControl = this.gcDSHangHoa;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colproductName
            // 
            this.colproductName.Caption = "Tên Hàng Hóa";
            this.colproductName.FieldName = "ProductName";
            this.colproductName.Name = "colproductName";
            this.colproductName.Visible = true;
            this.colproductName.VisibleIndex = 1;
            this.colproductName.Width = 165;
            // 
            // colproductCode
            // 
            this.colproductCode.Caption = "Mã Hàng Hóa";
            this.colproductCode.FieldName = "ProductCode";
            this.colproductCode.Name = "colproductCode";
            this.colproductCode.Visible = true;
            this.colproductCode.VisibleIndex = 0;
            this.colproductCode.Width = 216;
            // 
            // colMaGoiNho
            // 
            this.colMaGoiNho.Caption = "Mã Gợi Nhớ";
            this.colMaGoiNho.FieldName = "MaGoiNho";
            this.colMaGoiNho.Name = "colMaGoiNho";
            this.colMaGoiNho.Visible = true;
            this.colMaGoiNho.VisibleIndex = 2;
            this.colMaGoiNho.Width = 285;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(342, 398);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(90, 40);
            this.btnChon.TabIndex = 4;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(190, 406);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 25);
            this.txtSoLuong.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số Lượng:";
            // 
            // ListMaHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.gcDSHangHoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListMaHH";
            this.Text = "Tìm Kiếm Hàng Hóa";
            this.Load += new System.EventHandler(this.ListMaHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdListMaHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bdListMaHH;
        private DevExpress.XtraGrid.GridControl gcDSHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colproductName;
        private DevExpress.XtraGrid.Columns.GridColumn colproductCode;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGoiNho;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
    }
}