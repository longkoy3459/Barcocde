using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VsLogistics.UIComponent;

namespace Barcocde
{

    public partial class AddHangHoa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //DBHangHoaEntitiesNH context = new DBHangHoaEntitiesNH(ConnectionTools.BuildConnection());
        //DBHangHoaEntitiesLK db = new DBHangHoaEntitiesLK(ConnectionTools.BuildConnectionOffline());
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
        DBHangHoaEntitiesNH db = new DBHangHoaEntitiesNH(ConnectionTools.BuildConnectionOffline(NameData(), DataTenDatabases(), LoginData(), PasswordData()));

        public int bLoaiKiemKe = 0;
        //public int _SoLuong = 1;
        public int _SoLuong { get; set; }
        private bool bCtrlV = false;
        private bool First = true;
        public int _SoTT = 1;
        
        public string temp = "";
        public string TenKeHang { get; set; }
        public DateTime ThoiGian { get; set; }
        public long ID_User { get; set; }
        public int TongSL { get; set; }
        public int _STT { get; set; }
        public string IDStore { get; set; }

        private Stopwatch stopwatch = new Stopwatch();
        
        public List<clsHangHoa> list = new List<clsHangHoa>();
        
        public AddHangHoa()
        {
            InitializeComponent();
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

            gridView1.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Delete)
                {
                    delete_click(sender, e);
                    _SoTT = _SoTT - 1;
                }
            };
        }
        //public long _ID = 0;


        private void delete_click(object sender, EventArgs e)
        {

           
            //xóa DB
            string _IDHangHoa =(string)gridView1.GetFocusedRowCellValue(IDHangHoa);
            string tenkehang = txtTenKhuVuc.Text;
            DateTime _NgayKiemKe = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colThoiGianQuet));
            int _ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID));

            //var del = (from data in db.KiemKeHangHoas
            //           where (data.ID_HangHoa == _IDHangHoa && data.ID_Users == ID_User && data.TenKeHang == tenkehang /*&& data.NgayKiemKe.Day == _NgayKiemKe.Day && data.NgayKiemKe.Month == _NgayKiemKe.Month && data.NgayKiemKe.Year == _NgayKiemKe.Year && data.NgayKiemKe.Hour == _NgayKiemKe.Hour && data.NgayKiemKe.Minute == _NgayKiemKe.Minute && data.NgayKiemKe.Second == _NgayKiemKe.Second*/ && data.ID==_ID /*data.NgayKiemKe.Millisecond == _NgayKiemKe.Millisecond*/)
            //           select data).FirstOrDefault();
            //if (del != null)
            //{
            //    db.KiemKeHangHoas.Remove(del);
            //    db.SaveChanges();
            //    //MessageBox.Show("không xóa dữ liệu cũ !");
            //    //this.Close();
            //}
            //else
            //{
            var entity = gridView1.GetFocusedRow() as clsHangHoa;

            foreach (var cnt in list)
            {

                if (cnt.SoTT > entity.SoTT)
                {
                    cnt.SoTT = cnt.SoTT - 1;
                }
            }
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            //int SoLuong = Convert.ToInt32(gridView1.GetRowCellValue(0, colSTT));
            //    foreach (var bc in db.BaoCaoKiemKes)
            //    {
            //        if (bc.NgayTao == ThoiGian)
            //        {
            //            //bc.NgayTao = DateTime.Now;
            //            bc.TongSoLuong = SoLuong;
            //        }
            //    }
            //    db.SaveChanges();
                list.Remove(entity);
           

            bindingSource1.ResetBindings(true);
                gcDSHangHoa.RefreshDataSource();
            //}

           

        }
        private void CheckMaHangHoa()
        {

            try
            {
                // _id = Convert.ToInt64(gridView1.GetRowCellValue(0, colID));
               
                if (txtMa.Text == "")
                {
                    return;
                }
                else
                {
                    if (lkTenKhoHang.Text == "" || txtTenKhuVuc.Text == "")
                    {
                        MessageBox.Show("Chưa nhập tên khu vực và tên kho hàng");
                        txtMa.Text = "";
                        return;
                    }
                    else
                    {
                        string _productCode = txtMa.Text;
                        string IDStore = (string)(lkTenKhoHang as LookUpEdit).EditValue; // ID Kho
                        string tenKV = txtTenKhuVuc.Text;

                        var data = (from e in db.HangHoas
                                    where (e.MaHH == _productCode || e.MaGoiNho == _productCode)
                                    select new
                                    {

                                        IDHangHoa = e.HangHoaID,
                                        MaHH = e.MaHH,
                                        TenHH = e.TenHH,
                                        MaGoiNho = e.MaGoiNho


                                    }).ToList();

                        //sửa
                        //foreach(var c in data)
                        //{
                        //    var kiemke = new KiemKeHangHoa
                        //    {
                        //        STT = _SoTT,
                        //        ID_Users = ID_User,
                        //        ID_HangHoa = c.IDHangHoa,
                        //        ID_Kho = IDStore,

                        //        TenKeHang = tenKV,
                        //        SoLuong = 1,
                        //        NgayKiemKe = DateTime.Now,
                        //        updated_at = ThoiGian,
                        //        LoaiKiemKe = bLoaiKiemKe


                        //    };
                        //    db.KiemKeHangHoas.Add(kiemke);
                        //    db.SaveChanges();
                        //}
                        
                        //string IDStore = (string)(lkTenKhoHang as LookUpEdit).EditValue;
                        if (data.Count != 0)
                        {

                            foreach (var c in data)
                            {

                                clsHangHoa entity = new clsHangHoa()
                                {
                                   // ID = _id+1 ,
                                    IDHangHoa = c.IDHangHoa,
                                    SoTT = _SoTT,
                                    ProductCode = c.MaHH,
                                    ProductName = c.TenHH,
                                    MaGoiNho = c.MaGoiNho,
                                    //SoLuong = _SoLuong,
                                    ThoiGianQuet = DateTime.Now,
                                    ThoiGianCapNhat = DateTime.Now,
                                    LoaiKiemKe = bLoaiKiemKe
                                };

                                list.Add(entity);

                                bindingSource1.ResetBindings(true);
                                gcDSHangHoa.RefreshDataSource();
                                gcDSHangHoa.DataSource = list;
                                txtMessage.Text = string.Format("Tìm thấy: {0}", txtMa.Text);
                                txtMessage.ForeColor = Color.Green;

                                txtMa.Text = "";
                                bLoaiKiemKe = 0;
                               // _id = _id + 1;
                                _SoTT = _SoTT + 1;
                            }
                           


                        }
                        else if (data.Count == 0)
                        {
                            System.Media.SystemSounds.Beep.Play();
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
       
        private void AddHangHoa_Load(object sender, EventArgs e)
        {
            
            var tenkho = from j in db.Khoes
                         where (j.MaKho == IDStore)
                         select new
                         {
                             ten = j.TenKho
                         };
            foreach (var lk in tenkho)
            {
                temp = lk.ten;
            }
            lkTenKhoHang.Text = temp;
            txtTenKhuVuc.Text = TenKeHang;
            loadLK();
            //var data = (from d in db.KiemKeHangHoas

            //            join t in db.HangHoas on d.ID_HangHoa equals t.HangHoaID
            //            where (d.ID_Users == ID_User && d.TenKeHang == TenKeHang && d.updated_at.Day == ThoiGian.Day && d.updated_at.Month == ThoiGian.Month && d.updated_at.Year == ThoiGian.Year && d.updated_at.Hour == ThoiGian.Hour && d.updated_at.Minute == ThoiGian.Minute && d.ID_Kho == IDStore)
            //            select new
            //            {
            //                id = d.ID,
            //                stt = d.STT, 
            //                IDHangHoa = d.ID_HangHoa,
            //                MaHH = t.MaHH,
            //                TenHH = t.TenHH,
            //                MaGoiNho = t.MaGoiNho,
            //                LoaiKiemKe = d.LoaiKiemKe,
            //                ThoiGianQuet = d.NgayKiemKe,
            //                ThoiGianCapNhat = d.updated_at
            //            }).ToList();
            
            //foreach (var c in data)
            //{

            //    clsHangHoa entity = new clsHangHoa()
            //    {

            //        IDHangHoa = c.IDHangHoa,
            //        SoTT = (int)c.stt,
            //        ProductCode = c.MaHH,
            //        ProductName = c.TenHH,
            //        MaGoiNho = c.MaGoiNho,

            //        ThoiGianQuet = c.ThoiGianQuet,
            //        ThoiGianCapNhat = c.ThoiGianCapNhat,
            //        LoaiKiemKe = (int)c.LoaiKiemKe,
            //        ID = c.id 
            //    };

            //    list.Add(entity);
            //    bindingSource1.DataSource = list;
                
            //    _SoTT = _SoTT + 1;
            //}
        }
        // Tên Kho
        private void loadLK()
        {
            try
            {
                var data = (from e in db.PhanCongKiemKes

                            join t in db.Khoes on e.ID_Kho equals t.MaKho
                            where (e.ID_Users == ID_User)
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
            catch { MessageBox.Show("Lỗi hệ thống  !"); }

        }
        

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //DateTime NgayKiemKe = DateTime.Now;
            //string IDStore = (string)(lkTenKhoHang as LookUpEdit).EditValue; // ID Kho
            //string tenKV = txtTenKhuVuc.Text;
            //int index = 0;
            //var data = (from d in db.KiemKeHangHoas

            //            join t in db.HangHoas on d.ID_HangHoa equals t.HangHoaID
            //            where (d.ID_Users == ID_User && d.TenKeHang == TenKeHang && d.updated_at.Day == ThoiGian.Day && d.updated_at.Month == ThoiGian.Month && d.updated_at.Year == ThoiGian.Year&&d.updated_at.Hour == ThoiGian.Hour && d.updated_at.Minute == ThoiGian.Minute && d.updated_at.Second == ThoiGian.Second && d.ID_Kho == IDStore)
            //            select new
            //            {

            //                ThoiGianQuet = d.updated_at
            //            }).ToList();



            //    for (int i = 0; i < gridView1.RowCount; i++)
            //{
            //    DateTime TGQuet = Convert.ToDateTime(gridView1.GetRowCellValue(i, colThoiGianCapNhat));
            //    foreach (var c in data)
            //    {
            //        if(c.ThoiGianQuet.Day != TGQuet.Day || c.ThoiGianQuet.Month!= TGQuet.Month || c.ThoiGianQuet.Year!= TGQuet.Year || c.ThoiGianQuet.Hour != TGQuet.Hour || c.ThoiGianQuet.Minute!= TGQuet.Minute||c.ThoiGianQuet.Second !=TGQuet.Second)
            //        {
            //            var kiemke = new KiemKeHangHoa
            //            {
            //                STT = Convert.ToInt32(gridView1.GetRowCellValue(i, colSTT)),
            //                ID_Users = ID_User,
            //                ID_HangHoa = (string)gridView1.GetRowCellValue(i, IDHangHoa),
            //                ID_Kho = IDStore,

            //                TenKeHang = tenKV,
            //                SoLuong = 1,
            //                NgayKiemKe = Convert.ToDateTime(gridView1.GetRowCellValue(i, colThoiGianQuet)),
            //                updated_at =c.ThoiGianQuet,
            //                LoaiKiemKe = (int)gridView1.GetRowCellValue(i, colLoaiKiemKe)


            //            };
            //            db.KiemKeHangHoas.Add(kiemke);
            //            db.SaveChanges();
            //            TGQuet = c.ThoiGianQuet;

            //        }


            //    }

            //    index = index + 1;

            //}

            //foreach (var d in db.KiemKeHangHoas) // update
            //{
            //    if (d.ID_Users == ID_User && d.TenKeHang == TenKeHang && d.updated_at.Day == ThoiGian.Day && d.updated_at.Month == ThoiGian.Month && d.updated_at.Year == ThoiGian.Year && d.ID_Kho == IDStore)
            //    {
            //        d.updated_at = DateTime.Now;
            //    }

            //}
            //db.SaveChanges();
            //foreach (var bc in db.BaoCaoKiemKes)
            //{
            //    if(bc.NgayTao == ThoiGian)
            //    {
            //        bc.NgayTao = DateTime.Now;
            //        bc.TongSoLuong = index;
            //    }
            //}
            //db.SaveChanges();



            //MessageBox.Show("Lưu dữ liệu thành công !", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            DateTime NgayKiemKe = DateTime.Now;
            string IDStore = (string)(lkTenKhoHang as LookUpEdit).EditValue; // ID Kho
            string tenKV = txtTenKhuVuc.Text;
            int index = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {

                var kiemke = new KiemKeHangHoa
                {
                    STT = _STT +1,
                    ID_Users = ID_User,
                    ID_HangHoa = (string)gridView1.GetRowCellValue(i, IDHangHoa),
                    ID_Kho = IDStore,
                    TenKeHang = tenKV,
                    SoLuong = 1,
                    NgayKiemKe = Convert.ToDateTime(gridView1.GetRowCellValue(i, colThoiGianQuet)),
                    updated_at = ThoiGian,
                    LoaiKiemKe = (int)gridView1.GetRowCellValue(i, colLoaiKiemKe)

                };

                db.KiemKeHangHoas.Add(kiemke);
                db.SaveChanges();
                index = index + 1;
                _STT = _STT + 1;
            }
            foreach (var d in db.KiemKeHangHoas) // update
            {
                if (d.ID_Users == ID_User && d.TenKeHang == TenKeHang && d.updated_at.Day == ThoiGian.Day && d.updated_at.Month == ThoiGian.Month && d.updated_at.Year == ThoiGian.Year && d.ID_Kho == IDStore)
                {
                    d.updated_at = DateTime.Now;
                }

            }
            db.SaveChanges();

            foreach (var bc in db.BaoCaoKiemKes)
            {
                if (bc.NgayTao == ThoiGian)
                {
                    bc.NgayTao = DateTime.Now;
                    bc.TongSoLuong = TongSL + gridView1.RowCount ;
                }
            }
            db.SaveChanges();


            this.Close();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        public void loadData()
        {
           
            lkTenKhoHang.Text = temp;
            txtTenKhuVuc.Text = TenKeHang;
            loadLK();
            var data = (from d in db.KiemKeHangHoas

                        join t in db.HangHoas on d.ID_HangHoa equals t.HangHoaID
                        where (d.ID_Users == ID_User && d.TenKeHang == TenKeHang && d.updated_at.Day == ThoiGian.Day && d.updated_at.Month == ThoiGian.Month && d.updated_at.Year == ThoiGian.Year && d.updated_at.Hour == ThoiGian.Hour && d.updated_at.Minute == ThoiGian.Minute && d.ID_Kho == IDStore)
                        select new
                        {
                            stt = d.STT,
                            IDHangHoa = d.ID_HangHoa,
                            MaHH = t.MaHH,
                            TenHH = t.TenHH,
                            MaGoiNho = t.MaGoiNho,
                            LoaiKiemKe = d.LoaiKiemKe,
                            ThoiGianQuet = d.NgayKiemKe,
                            ThoiGianCapNhat = d.updated_at
                        }).ToList();

            foreach (var c in data)
            {

                clsHangHoa entity = new clsHangHoa()
                {

                    IDHangHoa = c.IDHangHoa,
                    SoTT = (int)c.stt,
                    ProductCode = c.MaHH,
                    ProductName = c.TenHH,
                    MaGoiNho = c.MaGoiNho,

                    ThoiGianQuet = c.ThoiGianQuet,
                    ThoiGianCapNhat = c.ThoiGianCapNhat,
                    LoaiKiemKe = (int)c.LoaiKiemKe
                };

                list.Add(entity);
                bindingSource1.DataSource = list;

                _SoTT = _SoTT + 1;
            }
        }
    }
}
