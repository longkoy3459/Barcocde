using barcodeservice;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VsLogistics.UIComponent;

namespace Barcocde
{
    public partial class BarcodeOff : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _SoTT = 1;

        public List<clsHangHoa> list = new List<clsHangHoa>();

        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
        public long UserID { get; set; } = -1;

        public int bLoaiKiemKe = 0;
        //public int _SoLuong = 1;
        public int _SoLuong { get; set; }
        private bool bCtrlV = false;
        private bool First = true;
        public int o = 0;

        public string TenKeHang { get; set; }
        public DateTime ThoiGian { get; set; }
        public long ID_User { get; set; }
        public string IDStore { get; set; }

        private Stopwatch stopwatch = new Stopwatch();
        // DBHangHoaEntitiesNH db = new DBHangHoaEntitiesNH(ConnectionTools.BuildConnectionOffline());
        public static string NameData()
        {
            StreamReader SR = new StreamReader(Application.StartupPath + "\\DataName.txt");
            string[] result = SR.ReadToEnd().Trim().Split('\n');
            // result[0] = fileVao;

            SR.Close();
            return result[0];
        }
        public static string DataTenDatabases()
        {
            StreamReader SR = new StreamReader(Application.StartupPath + "\\DataTenDatabases.txt");
            string[] result = SR.ReadToEnd().Trim().Split('\n');
            // result[0] = fileVao;

            SR.Close();
            return result[0];
        }
        public static string LoginData()
        {
            StreamReader SR = new StreamReader(Application.StartupPath + "\\DataLogin.txt");
            string[] result = SR.ReadToEnd().Trim().Split('\n');
            // result[0] = fileVao;

            SR.Close();
            return result[0];
        }
        public static string PasswordData()
        {
            StreamReader SR = new StreamReader(Application.StartupPath + "\\DataPassword.txt");
            string[] result = SR.ReadToEnd().Trim().Split('\n');
            // result[0] = fileVao;

            SR.Close();
            return result[0];
        }

        //DBHangHoaEntitiesLK db = new DBHangHoaEntitiesLK(ConnectionTools.BuildConnectionOffline());
        DBHangHoaEntitiesNH db = new DBHangHoaEntitiesNH(VsLogistics.UIComponent.ConnectionTools.BuildConnectionOffline(NameData(), DataTenDatabases(), LoginData(), PasswordData()));
        //DBHangHoaEntitiesNH context = new DBHangHoaEntitiesNH(ConnectionTools.BuildConnection());
        public BarcodeOff()
        {
            InitializeComponent();
            
                First = true;
                barButtonItem3.Enabled = false;
                layoutControl1.Enabled = false;
                btnLogout.Enabled = false;
                btnSave.Enabled = false;
                this.Text = "M2 Scan Barcode ";
                // btnBaoCao.Enabled = false;
                barButtonItem1.Enabled = false;
                bindingSource1.DataSource = list;
            
           


            txtMa.KeyDown += (sender, e) =>

            {
                if (First)
                {

                    stopwatch.Start();
                    First = false;
                }

                if (e.KeyCode == Keys.V && e.Control)
                {
                    bCtrlV = true;
                }

                if (e.KeyCode == Keys.Enter)
                {

                    stopwatch.Stop();

                    if (bCtrlV)
                        bLoaiKiemKe = 1;
                    else
                        bLoaiKiemKe = (stopwatch.ElapsedMilliseconds > 2000) ? 1 : 0;

                    First = true;
                    bCtrlV = false;
                    stopwatch.Reset();

                    CheckMaHangHoa();
                }

            };

            gvDSHangHoa.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Delete)
                {
                    delete_click(sender, e);
                    _SoTT = _SoTT - 1;
                }
            };
        }
        //check hàng
        private void CheckMaHangHoa()
        {
            try
            {
                if (txtMa.Text == "")
                {
                    return;
                }
                else
                {
                    if (lkTenKhoHang.Text == "" || txtTenKhuVuc.Text == "")
                    {
                        System.Media.SystemSounds.Beep.Play();
                        MessageBox.Show("Chưa nhập tên khu vực và tên kho hàng");
                        txtMa.Text = "";
                        return;
                    }
                    else
                    {
                        string _productCode = txtMa.Text;


                        var data = (from e in db.HangHoas
                                    where (e.MaHH == _productCode || e.MaGoiNho == _productCode)
                                    select new
                                    {

                                        IDHangHoa = e.HangHoaID,
                                        MaHH = e.MaHH,
                                        TenHH = e.TenHH,
                                        MaGoiNho = e.MaGoiNho

                                    }).ToList();


                        string IDStore = (string)(lkTenKhoHang as LookUpEdit).EditValue;
                        if (data.Count != 0)
                        {

                            foreach (var c in data)
                            {

                                clsHangHoa entity = new clsHangHoa()
                                {

                                    IDHangHoa = c.IDHangHoa,
                                    SoTT = _SoTT,
                                    ProductCode = c.MaHH,
                                    ProductName = c.TenHH,
                                    MaGoiNho = c.MaGoiNho,
                                    //SoLuong = _SoLuong,
                                    ThoiGianQuet = DateTime.Now,
                                    LoaiKiemKe = bLoaiKiemKe
                                };

                                list.Add(entity);

                                bindingSource1.ResetBindings(true);
                                gcDSHangHoa.RefreshDataSource();
                                txtMessage.Text = string.Format("Tìm thấy: {0}", txtMa.Text);
                                txtMessage.ForeColor = Color.Green;

                                txtMa.Text = "";
                                bLoaiKiemKe = 0;

                                _SoTT = _SoTT + 1;
                            }


                        }
                        else if (data.Count == 0)
                        {
                            System.Media.SystemSounds.Beep.Play();

                            // MessageBox.Show("Không tìm thấy mã trong kho ! \n Xem gợi ý hàng hóa ?", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            if (MessageBox.Show("Không tìm thấy mã trong kho ! \n Xem gợi ý hàng hóa ?", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                var frmSelect = new ListMaHH();
                                frmSelect._MaHHPartial = txtMa.Text;
                                frmSelect._MaGoiNho = txtMa.Text;
                                if (frmSelect.GetListMa())
                                {
                                    if (frmSelect.ShowDialog() == DialogResult.OK)
                                    {
                                        _SoLuong = frmSelect._SoLuong;
                                        for (int i = 0; i < _SoLuong; i++)
                                        {
                                            txtMa.Text = frmSelect.MaHHSelect;
                                            bLoaiKiemKe = 1;
                                            CheckMaHangHoa();
                                        }


                                        return;
                                    }
                                }

                                txtMessage.Text = string.Format("{0}: {1}", txtMa.Text);
                                txtMessage.ForeColor = Color.Red;
                                txtMa.Text = "";
                                bLoaiKiemKe = 0;

                            }
                        }

                    }

                }
            }
            catch
            { }
        }
        private void delete_click(object sender, EventArgs e)
        {

            var entity = gvDSHangHoa.GetFocusedRow() as clsHangHoa;

            foreach (var cnt in list)
            {

                if (cnt.SoTT > entity.SoTT)
                {
                    cnt.SoTT = cnt.SoTT - 1;
                }
            }

            list.Remove(entity);
            bindingSource1.ResetBindings(true);
            gcDSHangHoa.RefreshDataSource();

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {


                DateTime NgayKiemKe = DateTime.Now;
                string IDStore = (string)(lkTenKhoHang as LookUpEdit).EditValue; // ID Kho
                string tenKV = txtTenKhuVuc.Text;
                int index = 0;
                for (int i = 0; i < gvDSHangHoa.RowCount; i++)
                {

                    var kiemke = new KiemKeHangHoa
                    {
                       STT = Convert.ToInt32(gvDSHangHoa.GetRowCellValue(i, colSoTT)),
                        ID_Users = UserID,
                        ID_HangHoa =(string) gvDSHangHoa.GetRowCellValue(i, colIDHangHoa),
                        ID_Kho = IDStore,
                        TenKeHang = tenKV,
                        SoLuong = 1,
                        NgayKiemKe = Convert.ToDateTime(gvDSHangHoa.GetRowCellValue(i, colThoiGianQuet)),
                        updated_at = DateTime.Now,
                        LoaiKiemKe = (int)gvDSHangHoa.GetRowCellValue(i, colLoaiKiemKe)

                    };

                    db.KiemKeHangHoas.Add(kiemke);
                    db.SaveChanges();
                    index = index + 1;

                }
                var baocao = new BaoCaoKiemKe
                {
                    ID_User = UserID,
                    TenKhuVuc = txtTenKhuVuc.Text,
                    ID_Kho = IDStore,
                    NgayTao = DateTime.Now,
                    TongSoLuong = index

                };

                db.BaoCaoKiemKes.Add(baocao);
                db.SaveChanges();
                MessageBox.Show("Lưu dữ liệu thành công !", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                list.Clear();
                txtTenKhuVuc.Text = "";
                txtMessage.Text = "";
                bindingSource1.ResetBindings(true);
                gcDSHangHoa.RefreshDataSource();
                _SoTT = 1;
            }
            catch
            {
                MessageBox.Show("Chưa thể lưu dữ liệu !");
            }

        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int i = 1;
            var frm = new Login();
            frm.i = i;
            var ret = frm.ShowDialog();

            if (ret == DialogResult.Abort)
            {
                MessageBox.Show("Error");
            }
            if (ret == DialogResult.OK)
            {
                UserID = frm.UserID; // lấy ID của userName vừa nhập
                UserName = frm.UserLoginName;
                Password = frm.Password;
                layoutControl1.Enabled = true;
                btnSave.Enabled = true;
                btnLogout.Enabled = true;
                //btnBaoCao.Enabled = true;
                barButtonItem1.Enabled = true;
                barButtonItem3.Enabled = true;
                this.Text = string.Format("M2 Scan Barcode - Curent login : [{0}]", frm.UserLoginName);
                _SoTT = 1;
                InitDataSource();

            }

            if (ret == DialogResult.Cancel)
            {

            }

        }
        private void InitDataSource()
        {
            try
            {
                var data = (from e in db.PhanCongKiemKes

                            join t in db.Khoes on e.ID_Kho equals t.MaKho
                            where (e.ID_Users == UserID)
                            select new
                            {

                                IDKho = t.MaKho,
                                TenKho = t.TenKho
                            }).ToList();


                if (data == null)

                    MessageBox.Show("Error");

                else
                {
                    lkTenKhoHang.Properties.DataSource = data;
                }
            }
            catch {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("Lỗi hệ thống  !");
                }

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newTotalList = list.GroupBy(x => new { x.ProductCode, x.LoaiKiemKe })
                .Select(x => new clsHangHoa
                {
                    IDHangHoa = x.Select(x1 => x1.IDHangHoa).FirstOrDefault(),
                    ProductCode = x.Key.ProductCode,
                    LoaiKiemKe = x.Key.LoaiKiemKe,

                    ProductName = x.Select(x1 => x1.ProductName).FirstOrDefault(),
                    ThoiGianQuet = DateTime.Now,
                    SoTT = x.Select(x1 => x1.SoTT).FirstOrDefault(),
                    SoLuong = x.Sum(y => y.SoLuong),

                })
                .ToList();
        }

        private void btnBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            int i = 2;
            Login fmlogin = new Login();
            fmlogin.i = i;

            fmlogin.ShowDialog();
            this.Close();

        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UserName == "" || Password == "")
            {
                MessageBox.Show("Not login");
            }

            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                // MessageBox.Show("Logout");
                UserID = -1;
                UserName = "";
                Password = "";
                layoutControl1.Enabled = false;
                btnSave.Enabled = false;
                btnLogout.Enabled = false;
                btnBaoCao.Enabled = false;

                txtTenKhuVuc.Text = "";
                lkTenKhoHang.Text = "";
                txtMessage.Text = "";
                this.Text = "M2 Scan Barcode";

                list.Clear();

                bindingSource1.ResetBindings(true);
                gcDSHangHoa.RefreshDataSource();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string IDStore = Convert.ToString((lkTenKhoHang as LookUpEdit).EditValue); // ID Kho
            int i = 3;
            BaoCao bc = new BaoCao();
            bc.i = i;
            bc.UserID = UserID;
            bc._IDKho = IDStore;
            bc.ShowDialog();


        }
        

        private void BarcodeOff_Load(object sender, EventArgs e)
        {
            //if (o == 2)
            //{
            //    layoutControl1.Enabled = true;
            //    btnSave.Enabled = true;
            //    btnLogout.Enabled = true;
            //    //btnBaoCao.Enabled = true;
            //    barButtonItem1.Enabled = true;
            //    barButtonItem3.Enabled = true;
            //    this.Text = string.Format("M2 Scan Barcode - Curent");
            //    //_SoTT = 1;
            //    InitDataSource();
            //    loadData();
            //}

            //else
            //{
            //    First = true;
            //    barButtonItem3.Enabled = false;
            //    layoutControl1.Enabled = false;
            //    btnLogout.Enabled = false;
            //    btnSave.Enabled = false;
            //    this.Text = "M2 Scan Barcode ";
            //    // btnBaoCao.Enabled = false;
            //    barButtonItem1.Enabled = false;
            //    bindingSource1.DataSource = list;
            //}
        }

        private void gcDSHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataOff frm = new DataOff();
            frm.ShowDialog();
        }
    }
}
