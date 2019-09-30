using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using VsLogistics.UIComponent;
using System.Diagnostics;
using System.IO;

namespace Barcocde
{
    public partial class BaoCao : DevExpress.XtraEditors.XtraForm
    {
        // DBHangHoaEntitiesLK db = new DBHangHoaEntitiesLK();
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
        //public List<clsBaoCao> list = new List<clsBaoCao>();

        public int i = 0;
        public long UserID;
        public string _IDKho;
        public string _TenUser;
        public string _TenKho;
        public List<clsDSChotLo> listChotLo = new List<clsDSChotLo>();
        
        public BaoCao()
        {
            InitializeComponent();
            loadData();
            
        
        }
        DBHangHoaEntitiesNH context = new DBHangHoaEntitiesNH(ConnectionTools.BuildConnection());
        public void loadData()
        {

            //MessageBox.Show(i.ToString());
            //admin
           
            
            if (i == 2)
            {
               
                string theDate = dt1.Value.ToShortDateString();
                DateTime date = Convert.ToDateTime(theDate);

                int ngay = date.Day;
                int thang = date.Month;
                int nam = date.Year;

                var data = (from slect in context.BaoCaoKiemKes
                            join t in context.Khoes on slect.ID_Kho equals t.MaKho
                            join k in context.Users on slect.ID_User equals k.ID
                            where (slect.NgayTao.Day == ngay && slect.NgayTao.Month == thang && slect.NgayTao.Year == nam)
                            select new
                            {
                                tenuser = k.Username,
                                tenkho = t.TenKho,
                                tenkv = slect.TenKhuVuc,
                                ngaytao = slect.NgayTao

                            }
                      ).ToList();
                gcDSHangHoa.DataSource = data;

                //}
                //catch
                //{
                //    MessageBox.Show("Lỗi Mạng");
                //}
            }

            //user
            else
            {
               
                try
                {

                    //string theDate = dt1.Value.ToShortDateString();
                    DateTime theDate = DateTime.Now;
                    DateTime date = theDate;

                    int ngay = date.Day;
                    int thang = date.Month;
                    int nam = date.Year;

                    var data = (from slect in db.BaoCaoKiemKes
                                join t in db.Khoes on slect.ID_Kho equals t.MaKho
                                join e in db.Users on slect.ID_User equals e.ID
                                where ((int)slect.NgayTao.Day == ngay && (int)slect.NgayTao.Month == thang && (int)slect.NgayTao.Year == nam && slect.ID_User == UserID && slect.TrangThaiLuu == null)
                                select new
                                {
                                    tenuser = e.Username,
                                    tenkho = t.TenKho,
                                    tenkv = slect.TenKhuVuc,
                                    ngaytao = slect.NgayTao,
                                    soluong = slect.TongSoLuong,
                                    
                                }
                         ).ToList();
                    gcDSHangHoa.DataSource = data;
                }
                catch { }
            }
           
            

        }
        // Mẫu
        //public void load ()
        //{
            
        //    int count = db.KiemKeHangHoas.Count();
        //    int index =1;
        //    //string name = "";
        //    //string name2;
        //    DateTime dt = DateTime.Now;
        //    DateTime dt2 = DateTime.Now;
        //    int ngay = 0 ;
        //    int thang = 0;
        //    int nam = 0;
        //    int gio = 0;
        //    int phut = 0;
        //    int ngay2 = 0;
        //    int thang2 = 0;
        //    int nam2 = 0;
        //    int gio2= 0;
        //    int phut2 = 0;
        //    string name = "";
        //    string name2 = "";
            
        //    foreach (var item in db.KiemKeHangHoas)
        //    {
        //        if (index < 2)
        //        {
        //            dt = Convert.ToDateTime(item.updated_at); //1
        //            name = item.TenKeHang; //1
        //            if (index ==1)
        //            {
        //                clsBaoCao bc = new clsBaoCao()
        //                {
        //                    TenKeHang = name,
        //                    ThoiGian = dt

        //                };
        //                list.Add(bc);
        //            }
                  
        //            foreach (var item2 in db.KiemKeHangHoas)
        //            {
        //                 name2 = item2.TenKeHang;
        //                dt2 = Convert.ToDateTime(item2.updated_at);
        //                if (name != name2)
        //                {
                            
        //                    clsBaoCao bc = new clsBaoCao()
        //                    {
        //                        TenKeHang = item2.TenKeHang,
        //                        ThoiGian = dt2

        //                    };
        //                    list.Add(bc);
        //                    name = name2;
        //                    dt = dt2;
        //                }
                    
        //                else
        //                {
        //                        ngay = dt.Day;
        //                        thang = dt.Month;
        //                        nam = dt.Year;
        //                        gio = dt.Hour;
        //                        phut = dt.Minute;
        //                        ngay2 = dt2.Day;
        //                        thang2 = dt2.Month;
        //                        nam2 = dt2.Year;
        //                        gio2 = dt2.Hour;
        //                        phut2 = dt2.Minute;
        //                        // lần 2
                            
        //                        //if (ngay == ngay2 && thang== thang2 && nam == nam2 && gio == gio2 && phut == phut2)
        //                        //{
        //                        //    //MessageBox.Show("lk");
                                
        //                        //}
        //                        if(ngay == ngay2 && thang == thang2 && nam == nam2 && gio == gio2 && phut == phut2)
        //                        { }
        //                        else
        //                        {
        //                            clsBaoCao bc = new clsBaoCao()
        //                            {
        //                                TenKeHang = item2.TenKeHang,
        //                                ThoiGian = dt2

        //                            };
        //                            list.Add(bc);
        //                            dt = dt2;
                                   
        //                    }
        //                }
                    
        //            }

        //        }
        //        else
        //        {
        //            // gcDSHangHoa.DataSource = list.ToList();
        //           // MessageBox.Show("vòng lặp kết thúc " + index);
        //            gcDSHangHoa.DataSource = list.ToList();

        //        }
        //        index++;
                
        //    }
        //}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string theDate1 = dt1.Value.ToShortDateString();
            DateTime date1 = Convert.ToDateTime(theDate1);
            string theDate2 = dt2.Value.ToShortDateString();
            DateTime date2 = Convert.ToDateTime(theDate2);
            int ngaydt1 = date1.Day;
            int thangdt1 = date1.Month;
            int namdt1 = date1.Year;
            int ngaydt2 = date2.Day;
            int thangdt2 = date2.Month;
            int namdt2 = date2.Year;

            // admin
            if (i == 2)
            {
               
                
                    if(namdt1 == namdt2 && thangdt1 == thangdt2 && ngaydt1 == ngaydt2)
                    {
                        string theDate = dt1.Value.ToShortDateString();
                        DateTime date = Convert.ToDateTime(theDate);

                        int ngay = date.Day;
                        int thang = date.Month;
                        int nam = date.Year;

                        var data = (from slect in context.BaoCaoKiemKes
                                    join t in context.Khoes on slect.ID_Kho equals t.MaKho
                                    join k in context.Users on slect.ID_User equals k.ID
                                    where ((int)slect.NgayTao.Day == ngay && (int)slect.NgayTao.Month == thang && (int)slect.NgayTao.Year == nam)
                                    select new
                                    {
                                        tenuser = k.Username,
                                        tenkho = t.TenKho,
                                        tenkv = slect.TenKhuVuc,
                                        ngaytao = slect.NgayTao

                                    }
                              ).ToList();
                        gcDSHangHoa.DataSource = data;
                    }
                    else if(namdt1 == namdt2)
                    {
                        if(thangdt1 == thangdt2)
                        {
                            if(ngaydt1 < ngaydt2)
                            {
                                var data = (from slect in context.BaoCaoKiemKes
                                            join t in context.Khoes on slect.ID_Kho equals t.MaKho
                                            join k in context.Users on slect.ID_User equals k.ID
                                            where ((int)slect.NgayTao.Day >= ngaydt1 && (int)slect.NgayTao.Month == thangdt1 && (int)slect.NgayTao.Year == namdt1 && (int)slect.NgayTao.Year == namdt2 && (int)slect.NgayTao.Month == thangdt2 && (int)slect.NgayTao.Day <= ngaydt2)
                                            select new
                                            {
                                                tenuser = k.Username,
                                                tenkho = t.TenKho,
                                                tenkv = slect.TenKhuVuc,
                                                ngaytao = slect.NgayTao

                                            }
                              ).ToList();
                                gcDSHangHoa.DataSource = data;
                            }
                            else
                            {
                                MessageBox.Show("Thời Gian không hợp lý !");
                            }
                        }
                        else if(thangdt1 < thangdt2)
                        {
                            var data = (from slect in context.BaoCaoKiemKes
                                        join t in context.Khoes on slect.ID_Kho equals t.MaKho
                                        join k in context.Users on slect.ID_User equals k.ID
                                        where ((int)slect.NgayTao.Day >= ngaydt1 && (int)slect.NgayTao.Month >= thangdt1 && (int)slect.NgayTao.Year == namdt1 && (int)slect.NgayTao.Year == namdt2 && (int)slect.NgayTao.Month <= thangdt2 && (int)slect.NgayTao.Day <= ngaydt2)
                                        select new
                                        {
                                            tenuser = k.Username,
                                            tenkho = t.TenKho,
                                            tenkv = slect.TenKhuVuc,
                                            ngaytao = slect.NgayTao

                                        }
                              ).ToList();
                            gcDSHangHoa.DataSource = data;

                        }
                        else
                        {
                            MessageBox.Show("Thời Gian không hợp lý !");
                        }

                    }
                    else if (namdt1 > namdt2)
                    {
                        MessageBox.Show("Thời Gian không hợp lý !");
                    }
                    else if(namdt1 < namdt2)
                    {
                        var data = (from slect in context.BaoCaoKiemKes
                                    join t in context.Khoes on slect.ID_Kho equals t.MaKho
                                    join k in context.Users on slect.ID_User equals k.ID
                                    where ((int)slect.NgayTao.Day >= ngaydt1 && (int)slect.NgayTao.Month >= thangdt1 && (int)slect.NgayTao.Year >= namdt1 && (int)slect.NgayTao.Year <= namdt2 && (int)slect.NgayTao.Month <= thangdt2 && (int)slect.NgayTao.Day <= ngaydt2)
                                    select new
                                    {
                                        tenuser = k.Username,
                                        tenkho = t.TenKho,
                                        tenkv = slect.TenKhuVuc,
                                        ngaytao = slect.NgayTao

                                    }
                              ).ToList();
                        gcDSHangHoa.DataSource = data;
                    }

                
            }

            //user
            else
            {
               
                    if(dt1 == dt2)
                    {
                        string theDate = dt1.Value.ToShortDateString();
                        DateTime date = Convert.ToDateTime(theDate);

                        int ngay = date.Day;
                        int thang = date.Month;
                        int nam = date.Year;

                    //var _SoLuong = from sl in db.KiemKeHangHoas
                    //               where ((int)sl.updated_at.Day == ngay && (int)sl.updated_at.Month == thang && (int)sl.updated_at.Year == nam && sl.ID_Users == UserID)
                    //               select sl;
                    var data = (from slect in db.BaoCaoKiemKes
                                    join t in db.Khoes on slect.ID_Kho equals t.MaKho
                                    join k in db.Users on slect.ID_User equals k.ID
                                    where ((int)slect.NgayTao.Day == ngay && (int)slect.NgayTao.Month == thang && (int)slect.NgayTao.Year == nam && slect.ID_User == UserID && slect.TrangThaiLuu ==null)
                                    select new
                                    {
                                        tenuser = k.Username,
                                        tenkho = t.TenKho,
                                        tenkv = slect.TenKhuVuc,
                                        ngaytao = slect.NgayTao,
                                        soluong = slect.TongSoLuong
                                    }
                             ).ToList();
                        gcDSHangHoa.DataSource = data;
                    }
                    if(namdt1 == namdt2)
                    {
                        if(thangdt1 == thangdt2 )
                        {
                            if(ngaydt1 < ngaydt2)
                            {
                            //var _SoLuong = from sl in db.KiemKeHangHoas
                            //               where ((int)sl.updated_at.Day >= ngaydt1 && (int)sl.updated_at.Month == thangdt1 && (int)sl.updated_at.Year == namdt1 && (int)sl.updated_at.Day <= ngaydt2 && sl.ID_Users == UserID)
                            //               select sl;
                           
                            
                           
                            
                            var data = ( from slect in db.BaoCaoKiemKes
                                            join t in db.Khoes on slect.ID_Kho equals t.MaKho
                                            join k in db.Users on slect.ID_User equals k.ID
                                            where ((int)slect.NgayTao.Day >= ngaydt1 && (int)slect.NgayTao.Month == thangdt1 && (int)slect.NgayTao.Year == namdt1 && (int)slect.NgayTao.Day <= ngaydt2 && slect.ID_User == UserID &&slect.TrangThaiLuu == null)
                                            select new
                                            {
                                                tenuser = k.Username,
                                                tenkho = t.TenKho,
                                                tenkv = slect.TenKhuVuc,
                                                ngaytao = slect.NgayTao,
                                                soluong = slect.TongSoLuong
                                            }
                            ).ToList();
                            gcDSHangHoa.DataSource = data;
                            }
                            else if( ngaydt1 > ngaydt2)
                            {
                                MessageBox.Show("Thời gian không hợp lý !");
                            }
                        }
                        else if(thangdt1 <thangdt2)
                        {
                        
                        var data = (from slect in db.BaoCaoKiemKes
                                        join t in db.Khoes on slect.ID_Kho equals t.MaKho
                                        join k in db.Users on slect.ID_User equals k.ID
                                        where ((int)slect.NgayTao.Day >= ngaydt1 && (int)slect.NgayTao.Month >= thangdt1 && (int)slect.NgayTao.Year == namdt1 && (int)slect.NgayTao.Day <= ngaydt2 && (int)slect.NgayTao.Month <= thangdt2 && slect.ID_User == UserID&&slect.TrangThaiLuu == null)
                                        select new
                                        {
                                            tenuser = k.Username,
                                            tenkho = t.TenKho,
                                            tenkv = slect.TenKhuVuc,
                                            ngaytao = slect.NgayTao,
                                            soluong = slect.TongSoLuong

                                        }
                            ).ToList();
                        gcDSHangHoa.DataSource = data;
                        }
                        else
                        {
                            MessageBox.Show("Thời gian không hợp lý !");
                        }
                    }
                    else if(namdt1 < namdt2)
                    {
                   
                    var data = (from slect in db.BaoCaoKiemKes
                                    join t in db.Khoes on slect.ID_Kho equals t.MaKho
                                    join k in db.Users on slect.ID_User equals k.ID
                                    where ((int)slect.NgayTao.Day >= ngaydt1 && (int)slect.NgayTao.Month >= thangdt1 && (int)slect.NgayTao.Year >= namdt1 && (int)slect.NgayTao.Day <= ngaydt2 && (int)slect.NgayTao.Month <= thangdt2 && (int)slect.NgayTao.Year <= namdt2 && slect.ID_User == UserID&& slect.TrangThaiLuu == null)
                                    select new
                                    {
                                        tenuser = k.Username,
                                        tenkho = t.TenKho,
                                        tenkv = slect.TenKhuVuc,
                                        ngaytao = slect.NgayTao,
                                        soluong = slect.TongSoLuong
                                    }
                           ).ToList();
                    gcDSHangHoa.DataSource = data;
                    }
                    else
                    {
                        MessageBox.Show("Thời gian không hợp lý !");
                    }
                   
               
            }
        }
        
        private void btnAll_Click(object sender, EventArgs e)
        {
            var data = from sl in db.BaoCaoKiemKes
                       join us in db.Users on sl.ID_User equals us.ID
                       join k in db.Khoes on sl.ID_Kho equals k.MaKho
                       where us.ID == UserID
                       select new
                       {
                           tenuser = sl.User,
                           tenkv = sl.TenKhuVuc,
                           tenkho = k.TenKho,
                           ngaytao = sl.NgayTao,
                           soluong = sl.TongSoLuong
                       };
                       
            bindingSourcelk.DataSource = data.ToList();
            //bindingSourcelk.DataSource = db.BaoCaoKiemKes.ToList();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            TimKiem tk = new TimKiem();
            tk.ShowDialog();
            this.Close();
        }

        //private void (object sender, /*DevExpress.XtraEditors.Controls.ButtonPressedEventArgs*/EventArgs e)
        //{
           
        //}
        private void click(object sender , EventArgs e)
        {
            string tenkehang = (string)gvDSHangHoa.GetFocusedRowCellValue(colTenKhuVuc);
            DateTime tg = Convert.ToDateTime(gvDSHangHoa.GetFocusedRowCellValue(colNgayTao));
            string _TenUser = (string)gvDSHangHoa.GetFocusedRowCellValue(colTenUser);
            string TenKho = (string)gvDSHangHoa.GetFocusedRowCellValue(colTenKho);
            listKiemke frmKK = new listKiemke();

            frmKK.TenKeHang = tenkehang;
            frmKK.ThoiGian = tg;
            frmKK.ID_User = UserID;
            frmKK.IDStore = _IDKho;
            frmKK.i = i;
            if (frmKK.ShowDialog() == DialogResult.Yes)
            {
                this.Close();
            }
            MessageBox.Show("1");
        }
        private void btn_sua_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show("1");
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string tenkehang = (string)gvDSHangHoa.GetFocusedRowCellValue(colTenKhuVuc);
            DateTime tg = Convert.ToDateTime(gvDSHangHoa.GetFocusedRowCellValue(colNgayTao));
            string _TenUser = (string)gvDSHangHoa.GetFocusedRowCellValue(colTenUser);
            string TenKho = (string)gvDSHangHoa.GetFocusedRowCellValue(colTenKho);
            listKiemke frmKK = new listKiemke();

            frmKK.TenKeHang = tenkehang;
            frmKK.ThoiGian = tg;
            frmKK.ID_User = UserID;
            frmKK.IDStore = _IDKho;
            frmKK.i = i;
            
            frmKK.ShowDialog();
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAll_Click_1(object sender, EventArgs e)
        {
            string theDate1 = dt1.Value.ToShortDateString();
            DateTime date1 = Convert.ToDateTime(theDate1);
            string theDate2 = dt2.Value.ToShortDateString();
            DateTime date2 = Convert.ToDateTime(theDate2);
            int ngaydt1 = date1.Day;
            int thangdt1 = date1.Month;
            int namdt1 = date1.Year;
            int ngaydt2 = date2.Day;
            int thangdt2 = date2.Month;
            int namdt2 = date2.Year;
            if (ngaydt1 == ngaydt2 && thangdt1==thangdt2&&namdt1==namdt2)
            {
                string theDate = dt1.Value.ToShortDateString();
                DateTime date = Convert.ToDateTime(theDate);

                int ngay = date.Day;
                int thang = date.Month;
                int nam = date.Year;

                //var _SoLuong = from sl in db.KiemKeHangHoas
                //               where ((int)sl.updated_at.Day == ngay && (int)sl.updated_at.Month == thang && (int)sl.updated_at.Year == nam && sl.ID_Users == UserID)
                //               select sl;
                var data = (from slect in db.BaoCaoKiemKes
                            join t in db.Khoes on slect.ID_Kho equals t.MaKho
                            join k in db.Users on slect.ID_User equals k.ID
                            where ((int)slect.NgayTao.Day == ngay && (int)slect.NgayTao.Month == thang && (int)slect.NgayTao.Year == nam && slect.ID_User == UserID )
                            select new
                            {
                                tenuser = k.Username,
                                tenkho = t.TenKho,
                                tenkv = slect.TenKhuVuc,
                                ngaytao = slect.NgayTao,
                                soluong = slect.TongSoLuong,
                                DaDay = slect.TrangThaiLuu
                            }
                         ).ToList();
                gcDSHangHoa.DataSource = data;
            }
            if (namdt1 == namdt2)
            {
                if (thangdt1 == thangdt2)
                {
                    if (ngaydt1 < ngaydt2)
                    {
                        //var _SoLuong = from sl in db.KiemKeHangHoas
                        //               where ((int)sl.updated_at.Day >= ngaydt1 && (int)sl.updated_at.Month == thangdt1 && (int)sl.updated_at.Year == namdt1 && (int)sl.updated_at.Day <= ngaydt2 && sl.ID_Users == UserID)
                        //               select sl;




                        var data = (from slect in db.BaoCaoKiemKes
                                    join t in db.Khoes on slect.ID_Kho equals t.MaKho
                                    join k in db.Users on slect.ID_User equals k.ID
                                    where ((int)slect.NgayTao.Day >= ngaydt1 && (int)slect.NgayTao.Month == thangdt1 && (int)slect.NgayTao.Year == namdt1 && (int)slect.NgayTao.Day <= ngaydt2 && slect.ID_User == UserID )
                                    select new
                                    {
                                        tenuser = k.Username,
                                        tenkho = t.TenKho,
                                        tenkv = slect.TenKhuVuc,
                                        ngaytao = slect.NgayTao,
                                        soluong = slect.TongSoLuong,
                                        DaDay = slect.TrangThaiLuu
                                    }
                        ).ToList();
                        gcDSHangHoa.DataSource = data;
                    }
                    else if (ngaydt1 > ngaydt2)
                    {
                        MessageBox.Show("Thời gian không hợp lý !");
                    }
                }
                else if (thangdt1 < thangdt2)
                {

                    var data = (from slect in db.BaoCaoKiemKes
                                join t in db.Khoes on slect.ID_Kho equals t.MaKho
                                join k in db.Users on slect.ID_User equals k.ID
                                where ((int)slect.NgayTao.Day >= ngaydt1 && (int)slect.NgayTao.Month >= thangdt1 && (int)slect.NgayTao.Year == namdt1 && (int)slect.NgayTao.Day <= ngaydt2 && (int)slect.NgayTao.Month <= thangdt2 && slect.ID_User == UserID )
                                select new
                                {
                                    tenuser = k.Username,
                                    tenkho = t.TenKho,
                                    tenkv = slect.TenKhuVuc,
                                    ngaytao = slect.NgayTao,
                                    soluong = slect.TongSoLuong,
                                    DaDay = slect.TrangThaiLuu

                                }
                        ).ToList();
                    gcDSHangHoa.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Thời gian không hợp lý !");
                }
            }
            else if (namdt1 < namdt2)
            {

                var data = (from slect in db.BaoCaoKiemKes
                            join t in db.Khoes on slect.ID_Kho equals t.MaKho
                            join k in db.Users on slect.ID_User equals k.ID
                            where ((int)slect.NgayTao.Day >= ngaydt1 && (int)slect.NgayTao.Month >= thangdt1 && (int)slect.NgayTao.Year >= namdt1 && (int)slect.NgayTao.Day <= ngaydt2 && (int)slect.NgayTao.Month <= thangdt2 && (int)slect.NgayTao.Year <= namdt2 && slect.ID_User == UserID )
                            select new
                            {
                                tenuser = k.Username,
                                tenkho = t.TenKho,
                                tenkv = slect.TenKhuVuc,
                                ngaytao = slect.NgayTao,
                                soluong = slect.TongSoLuong,
                                DaDay = slect.TrangThaiLuu
                            }
                       ).ToList();
                gcDSHangHoa.DataSource = data;
            }
            else
            {
                MessageBox.Show("Thời gian không hợp lý !");
            }

        
        }
    }
}