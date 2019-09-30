using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System.Globalization;
using VsLogistics.UIComponent;
using System.IO;

namespace Barcocde
{
    public partial class listKiemke : DevExpress.XtraBars.Ribbon.RibbonForm
    {

         //DBHangHoaEntitiesLK db = new DBHangHoaEntitiesLK();
       // DBHangHoaEntitiesLK db = new DBHangHoaEntitiesLK(ConnectionTools.BuildConnectionOffline(@".\SQLEXPRESS", "DBHangHoa", "sa", "longkoy3459"));

        // DBHangHoaEntitiesLK db = new DBHangHoaEntitiesLK(ConnectionTools.BuildConnectionOffline());
        DBHangHoaEntitiesNH context = new DBHangHoaEntitiesNH(ConnectionTools.BuildConnection());
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
        public List<clsKiemKeHangHoa> list = new List<clsKiemKeHangHoa>();
      
        public string TenKeHang { get; set; }
        public string temp = "";
        public DateTime ThoiGian { get; set; }
        public int i=0;
        public int Sl = 0;
        public long ID_User =0;
        //public long _TongSl = 0;
        public string IDStore = "";
        //public string TenKV;
        public List<clsDuyetHangHoa> listKK = new List<clsDuyetHangHoa>();
        public listKiemke()
        {
            InitializeComponent();
            gvListKiemke.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Delete)
                {
                    
                    delete_click(sender, e);
                    
                }
            };
        }
        private void delete_click(object sender, EventArgs e)
        {


            var entity = gvListKiemke.GetFocusedRow() as clsDuyetHangHoa;


            foreach (var cnt in listKK)
            {

                if (cnt.STT > entity.STT)
                {
                    cnt.STT = cnt.STT - 1;
                    
                }
            }

            //xóa DB
            //string _IDHangHoa = (string)gvListKiemke.GetFocusedRowCellValue();
            string tenkehang = (string)gvListKiemke.GetFocusedRowCellValue(colTenKeHang);
            DateTime _NgayKiemKe = Convert.ToDateTime(gvListKiemke.GetFocusedRowCellValue(colNgayKiemKe1));
            var del = (from data in db.KiemKeHangHoas
                       where (data.ID_Users == ID_User && data.TenKeHang == tenkehang && data.NgayKiemKe.Day == _NgayKiemKe.Day && data.NgayKiemKe.Month == _NgayKiemKe.Month && data.NgayKiemKe.Year == _NgayKiemKe.Year && data.NgayKiemKe.Hour == _NgayKiemKe.Hour && data.NgayKiemKe.Minute == _NgayKiemKe.Minute && data.NgayKiemKe.Second == _NgayKiemKe.Second && data.NgayKiemKe.Millisecond == _NgayKiemKe.Millisecond)
                       select data).FirstOrDefault();

           
            db.KiemKeHangHoas.Remove(del);
           
            db.SaveChanges();
            //bdListKiemKe.Remove(del);
            gvListKiemke.DeleteRow(gvListKiemke.FocusedRowHandle);

           
            foreach (var bc in db.BaoCaoKiemKes)
            {
                if (bc.NgayTao == ThoiGian)
                {
                    //bc.NgayTao = DateTime.Now;
                    bc.TongSoLuong = gvListKiemke.RowCount;
                }
            }
            db.SaveChanges();
            listKK.Remove(entity);
            bdListKiemKe.ResetBindings(true);
            gcListKiemke.RefreshDataSource();
            // loadData();


        }
        public void loadData()
        {
            int Gio = ThoiGian.Hour;
            int Phut = ThoiGian.Minute;
            int ngay = ThoiGian.Day;
            int thang = ThoiGian.Month;
            int nam = ThoiGian.Year;
            if(i==2)
            {                
                var data = (from slect in context.DuyetHangHoas
                            join t in context.HangHoas on slect.IDHangHoa equals t.HangHoaID
                            where (slect.TenKeHang == TenKeHang && (int)slect.NgayCapNhat.Value.Day == ngay && (int)slect.NgayCapNhat.Value.Month == thang && (int)slect.NgayCapNhat.Value.Year == nam && (int)slect.NgayCapNhat.Value.Hour == Gio && (int)slect.NgayCapNhat.Value.Minute == Phut)
                            select new
                            {
                                ID = slect.ID ,
                                stt = slect.STT,
                                tenke = TenKeHang,
                                idhang = slect.IDHangHoa,
                                mahh = t.MaHH,
                                tenhang = t.TenHH,
                                soluong = 1,
                                ngaykiemke = slect.NgayKiemKe,
                                //ngaycapnhat= slect.updated_at,
                                loaikiemke = slect.LoaiKiemKe
                            }
                            ).ToList();
               // int _STT = data.Count();
                foreach (var c in data)
                {

                    clsDuyetHangHoa entity = new clsDuyetHangHoa()
                    {
                       /// ID = c.ID ,
                        STT = (int)c.stt,
                       // IDHangHoa = c.idhang,
                       // MaHH = c.mahh,
                        TenHH = c.tenhang,
                        TenKeHang = c.tenke,
                        SoLuong = 1,
                        NgayKiemKe =Convert.ToDateTime( c.ngaykiemke),
                        LoaiKiemKe =(int)c.loaikiemke
                    };

                    listKK.Add(entity);

                    //bdListKiemKe.ResetBindings(true);
                    //gcListKiemke.RefreshDataSource();
                    //_STT--;
                }
                bdListKiemKe.DataSource = listKK ;
                   // gcListKiemke.DataSource = data;
            }
           else
            {
                //btnSua.Enabled = false;
                //btnXoa.Enabled = false;
                //btnThem.Enabled = false;
                

               

                var data = (from slect in db.KiemKeHangHoas
                            join t in db.HangHoas on slect.ID_HangHoa equals t.HangHoaID
                            where (slect.TenKeHang == TenKeHang && (int)slect.updated_at.Day == ngay && (int)slect.updated_at.Month == thang && (int)slect.updated_at.Year == nam && (int)slect.updated_at.Hour == Gio && (int)slect.updated_at.Minute == Phut)
                           // where (slect.TenKeHang == TenKeHang && (int)slect.updated_at.Value.Day == ngay && (int)slect.updated_at.Value.Month == thang && (int)slect.updated_at.Value.Year == nam && (int)slect.updated_at.Value.Hour == Gio && (int)slect.updated_at.Value.Minute == Phut)

                            select new
                            {
                                stt = slect.STT,
                                tenke = TenKeHang,
                                idhang = slect.ID_HangHoa,
                                mahh = t.MaHH,
                                tenhang = t.TenHH,
                                TenGoiNho = t.MaGoiNho,
                                soluong = 1,
                                ngaykiemke = slect.NgayKiemKe,
                                //ngaycapnhat= slect.updated_at,
                                loaikiemke = slect.LoaiKiemKe
                            }
                            ).ToList();
                int _STT = data.Count();
                foreach (var c in data)
                {

                    clsDuyetHangHoa entity = new clsDuyetHangHoa()
                    {

                        STT = (int)c.stt,
                      //  IDHangHoa = c.idhang,
                       MaHH = c.mahh,
                        TenHH = c.tenhang,
                        MaGoiNho = c.TenGoiNho,
                        TenKeHang = c.tenke,
                        SoLuong = 1,
                        NgayKiemKe = Convert.ToDateTime(c.ngaykiemke),
                        LoaiKiemKe = (int)c.loaikiemke
                    };

                    listKK.Add(entity);

                    //bdListKiemKe.ResetBindings(true);
                    //gcListKiemke.RefreshDataSource();
                    _STT--;
                }

                bdListKiemKe.DataSource = listKK.ToList();

            }
        }
        
        private void listKiemke_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (i == 2)
            {
                int Gio = ThoiGian.Hour;
                int Phut = ThoiGian.Minute;
                int ngay = ThoiGian.Day;
                int thang = ThoiGian.Month;
                int nam = ThoiGian.Year;
                var data = (from slect in context.DuyetHangHoas

                            where (slect.TenKeHang == TenKeHang && (int)slect.NgayCapNhat.Value.Day == ngay && (int)slect.NgayCapNhat.Value.Month == thang && (int)slect.NgayCapNhat.Value.Year == nam && (int)slect.NgayCapNhat.Value.Hour == Gio && (int)slect.NgayCapNhat.Value.Minute == Phut)
                            select new
                            {
                                iduser = slect.IDUser,
                                idkho = slect.IDKho,
                                tenke = slect.TenKeHang,
                                idhang = slect.IDHangHoa,
                                mahh = slect.MaHH,
                                tenhang = slect.TenHH,
                                soluong = 1,
                                ngaykiemke = slect.NgayKiemKe,
                                ngaycapnhat = slect.NgayCapNhat,
                                loaikiemke = slect.LoaiKiemKe,
                                check = slect.Luu
                            }
                           ).ToList();
                List<KiemKeHangHoa> listKKHH = new List<KiemKeHangHoa>();

                int count = data.Count();
                foreach (var lk in data)
                {
                    KiemKeHangHoa kiemke = new KiemKeHangHoa();
                    {
                        //kiemke.HangHoa = new HangHoa();

                        kiemke.ID_Users = lk.iduser;
                        kiemke.ID_Kho = lk.idkho;
                        kiemke.ID_HangHoa = lk.idhang;
                        kiemke.LoaiKiemKe = lk.loaikiemke;
                        kiemke.TenKeHang = lk.tenke;
                        kiemke.SoLuong = 1;
                        //kiemke.NgayKiemKe = lk.ngaykiemke;
                        kiemke.updated_at = DateTime.Now;

                    }

                    context.KiemKeHangHoas.Add(kiemke);

                }
                //context.SaveChangesAsync();
                context.SaveChanges();
                //foreach(var d in data)
                //{
                //    var duyet = new DuyetHangHoa
                //    {

                //        LuuServer = true
                //    };

                //    context.DuyetHangHoas.Add(duyet);
                //}

                //context.SaveChanges();

                //context.SaveChanges();

                MessageBox.Show("Finish", "Thông báo");
                //foreach (var entity in listKKHH)
                //{
                //    entity.HangHoa = null;
                //}

                //string sJson = JsonConvert.SerializeObject(listKKHH);

                //var save = Barcocde.ReadAPI.SaveTo(ID_User.ToString(), sJson);

                //if (save.status == 1)
                //{

                //    MessageBox.Show("Finish", "Thông báo");
                //    this.DialogResult = DialogResult.OK;

                //    this.Close();
                //}
                //else
                //{

                //    MessageBox.Show(save.message);
                //    this.DialogResult = DialogResult.Abort;
                //}
                //}
                //}
                ////try
                ////{
                //    bdListKiemKe.EndEdit();
                //    gvListKiemke.CloseEditor();

                //    if(i==2)
                //    {
                //        List<KiemKeHangHoa> listKKHH = new List<KiemKeHangHoa>();

                //        for (int k = 0; k < gvListKiemke.RowCount; k++)
                //        {
                //            string ID_HangHoa = (string)gvListKiemke.GetRowCellValue(k, colIDHangHoa);

                //            


            }
            else
            {
                if (gvListKiemke.RowCount > 0)
                {
                    List<KiemKeHangHoa> listKKHH = new List<KiemKeHangHoa>();

                    for (int k = 0; k < gvListKiemke.RowCount; k++)
                    {
                        //string ID_HangHoa = (string)gvListKiemke.GetRowCellValue(k, colIDHangHoa);

                        var kiemke = new DuyetHangHoa();
                        {

                            kiemke.STT = (int)gvListKiemke.GetRowCellValue(k, colSTT);
                            // kiemke.STT = k;
                            kiemke.IDUser = ID_User;

                            foreach (var c in db.HangHoas)
                            {
                                if (c.TenHH == (string)gvListKiemke.GetRowCellValue(k, colTenHH))
                                {
                                    kiemke.IDHangHoa = c.HangHoaID;
                                    kiemke.MaHH = c.MaHH;
                                }

                            }
                            kiemke.TenHH = (string)gvListKiemke.GetRowCellValue(k, colTenHH);
                            //kiemke.MaHH = (string)gvListKiemke.GetRowCellValue(k, colMaHH);
                            kiemke.IDKho = IDStore;
                            kiemke.TenKeHang = TenKeHang;
                            kiemke.SoLuong = 1;
                            kiemke.NgayKiemKe = Convert.ToDateTime(gvListKiemke.GetRowCellValue(k, colNgayKiemKe1));
                            kiemke.NgayCapNhat = DateTime.Now;
                            kiemke.LoaiKiemKe = (int)gvListKiemke.GetRowCellValue(k, colLoaiKiemKe);
                        };
                        context.DuyetHangHoas.Add(kiemke);
                        context.SaveChanges();


                        // listKKHH.Add(kiemke);
                    }

                    foreach (var xch in db.BaoCaoKiemKes) // update
                    {
                        if (xch.NgayTao == ThoiGian)
                        {
                            xch.TrangThaiLuu = 1;
                        }

                    }
                    db.SaveChanges();
                    var baocao = new BaoCaoKiemKe
                    {
                        ID_User = ID_User,
                        TenKhuVuc = TenKeHang,
                        ID_Kho = IDStore,
                        NgayTao = DateTime.Now
                    };

                    context.BaoCaoKiemKes.Add(baocao);
                    context.SaveChanges();

                    MessageBox.Show("Finish", "Thông báo");
                }


                else
                    MessageBox.Show("Chưa có dữ liệu ");
                ////}
                ////catch
                ////{
                ////    MessageBox.Show("Lỗi Mạng");
                ////}
                this.Close();
            }

    }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int rows = gvListKiemke.FocusedRowHandle;
            ////string TenCot = "ID";
            //object gtri = gvListKiemke.GetRowCellValue(rows, "ID");
            //AddHangHoa add = new AddHangHoa();
            //add._ID = (long)gtri;
            //add.ShowDialog();

        }

        private void gcListKiemke_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //string TenKho = gvListKiemke.GetFocusedRowCellValue(colTenKeHang)
            var data = (from slect in db.KiemKeHangHoas
                        
                        where (slect.TenKeHang == TenKeHang && (int)slect.updated_at.Day == ThoiGian.Day && (int)slect.updated_at.Month == ThoiGian.Month && (int)slect.updated_at.Year == ThoiGian.Year && (int)slect.updated_at.Hour == ThoiGian.Hour && (int)slect.updated_at.Minute == ThoiGian.Minute)
                        // where (slect.TenKeHang == TenKeHang && (int)slect.updated_at.Value.Day == ngay && (int)slect.updated_at.Value.Month == thang && (int)slect.updated_at.Value.Year == nam && (int)slect.updated_at.Value.Hour == Gio && (int)slect.updated_at.Value.Minute == Phut)

                        select new
                        {
                            IDkho = slect.ID_Kho
                        }
                           ).ToList();
            foreach(var lk in data)
            {
                IDStore = lk.IDkho;
            }
            AddHangHoa frm = new AddHangHoa();
            frm.TenKeHang = TenKeHang;
            frm.ThoiGian = ThoiGian;
            frm.ID_User = ID_User;
            frm.IDStore = IDStore;
            frm.TongSL = gvListKiemke.RowCount;
            frm._STT = gvListKiemke.RowCount;
            frm.ShowDialog();
            this.Close();
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            int _STT = 1;
            
            for (int j=0;j<gvListKiemke.RowCount; j++)
            {

                DateTime _NgayKiemKe = Convert.ToDateTime(gvListKiemke.GetRowCellValue(j, colNgayKiemKe1));
                string tenkehang = Convert.ToString(gvListKiemke.GetRowCellValue(j, colTenKeHang));
                
               
                foreach (var data in db.KiemKeHangHoas)
                {
                    if(data.TenKeHang == tenkehang && data.NgayKiemKe == _NgayKiemKe)
                    {
                        data.STT = _STT;
                        _STT = _STT + 1;
                    }

                   
                }
                db.SaveChanges();
               

            }
            foreach (var bc in db.BaoCaoKiemKes)
            {
                if (bc.NgayTao == ThoiGian)
                {
                    
                    bc.TongSoLuong = gvListKiemke.RowCount;
                }
            }
            db.SaveChanges();







            //var items = (from r in results
            //             select r)
            //.ToList()
            //.OrderBy(q => Int32.Parse(q.Version));

        }
    }
}