using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VsLogistics.UIComponent;

namespace Barcocde
{
    public partial class TimKiem : Form
    {
       
        private Stopwatch stopwatch = new Stopwatch();
        //DBHangHoaEntitiesLK db = new DBHangHoaEntitiesLK();
        DBHangHoaEntitiesNH db = new DBHangHoaEntitiesNH(ConnectionTools.BuildConnection());
        //DBHangHoaEntitiesLK db = new DBHangHoaEntitiesLK(ConnectionTools.BuildConnectionOffline(@".\SQLEXPRESS", "DBHangHoa", "sa", "longkoy3459"));

        DBHangHoaEntitiesNH context = new DBHangHoaEntitiesNH(ConnectionTools.BuildConnection());
        public TimKiem()
        {
            InitializeComponent();
            
        }
        //public void CheckMaHangHoa()
        //{
        //    string _productCode = txtMaTK.Text;

        //    string theDate1 = dt1.Value.ToShortDateString();
        //    DateTime date1 = Convert.ToDateTime(theDate1);
        //    string theDate2 = dt2.Value.ToShortDateString();
        //    DateTime date2 = Convert.ToDateTime(theDate2);
        //    int ngaydt1 = date1.Day;
        //    int thangdt1 = date1.Month;
        //    int namdt1 = date1.Year;
        //    int ngaydt2 = date2.Day;
        //    int thangdt2 = date2.Month;
        //    int namdt2 = date2.Year;

        //    if (dt1 == dt2)
        //    {
        //        var data = (from e in context.HangHoas
        //                    join t in context.DuyetHangHoas on e.HangHoaID equals t.IDHangHoa
        //                    join u in context.Users on t.IDUser equals u.ID

        //                    where (e.MaHH == _productCode && Convert.ToDateTime(t.NgayKiemKe).Day == ngaydt1 && (int)Convert.ToDateTime(t.NgayKiemKe).Month == thangdt1 && Convert.ToDateTime(t.NgayKiemKe).Year == namdt1)

        //                    select new
        //                    {

        //                        //IDHangHoa = e.HangHoaID,
        //                        MaHH = e.MaHH,
        //                        TenHH = e.TenHH,
        //                        NgayKiemKe = t.NgayKiemKe,
        //                        KhuVuc = t.TenKeHang,
        //                        NVKiemKe = u.Username,
        //                        STT = t.STT,

        //                    }).ToList();
        //        gctk.DataSource = data;
        //    }
        //    else
        //    {
        //        if (namdt1 == namdt2)
        //        {
        //            if (thangdt1 == thangdt2)
        //            {
        //                if (ngaydt1 < ngaydt2)
        //                {
        //                    var data = (from e in db.HangHoas
        //                                join t in context.DuyetHangHoas on e.HangHoaID equals t.IDHangHoa
        //                                join u in context.Users on t.IDUser equals u.ID
        //                                where (e.MaHH == _productCode && Convert.ToDateTime(t.NgayKiemKe).Day >= ngaydt1 && (int)Convert.ToDateTime(t.NgayKiemKe).Month == thangdt1 && Convert.ToDateTime(t.NgayKiemKe).Year == namdt1 && Convert.ToDateTime(t.NgayKiemKe).Day <= ngaydt2)

        //                                select new
        //                                {
        //                                    MaHH = e.MaHH,
        //                                    TenHH = e.TenHH,
        //                                    NgayKiemKe = t.NgayKiemKe,
        //                                    KhuVuc = t.TenKeHang,
        //                                    NVKiemKe = u.Username,
        //                                    STT = t.STT,

        //                                }).ToList();
        //                    gctk.DataSource = data;
        //                }
        //                else if (ngaydt1 > ngaydt2)
        //                {
        //                    MessageBox.Show("Thời gian không hợp lệ ");
        //                }
        //            }
        //            else if (thangdt1 < thangdt2)
        //            {
        //                var data = (from e in db.HangHoas
        //                            join t in context.DuyetHangHoas on e.HangHoaID equals t.IDHangHoa
        //                            join u in context.Users on t.IDUser equals u.ID
        //                            where (e.MaHH == _productCode && Convert.ToDateTime(t.NgayKiemKe).Day >= ngaydt1 && (int)Convert.ToDateTime(t.NgayKiemKe).Month >= thangdt1 && (int)Convert.ToDateTime(t.NgayKiemKe).Month <= thangdt2 && Convert.ToDateTime(t.NgayKiemKe).Year == namdt1 && Convert.ToDateTime(t.NgayKiemKe).Day <= ngaydt2)

        //                            select new
        //                            {

        //                                MaHH = e.MaHH,
        //                                TenHH = e.TenHH,
        //                                NgayKiemKe = t.NgayKiemKe,
        //                                KhuVuc = t.TenKeHang,
        //                                NVKiemKe = u.Username,
        //                                STT = t.STT,

        //                            }).ToList();
        //                gctk.DataSource = data;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Thời gian không hợp lệ ");
        //            }
        //        }
        //        else if (namdt1 < namdt2)
        //        {
        //            var data = (from e in db.HangHoas
        //                        join t in context.DuyetHangHoas on e.HangHoaID equals t.IDHangHoa
        //                        join u in context.Users on t.IDUser equals u.ID
        //                        where (e.MaHH == _productCode && Convert.ToDateTime(t.NgayKiemKe).Day >= ngaydt1 && (int)Convert.ToDateTime(t.NgayKiemKe).Month >= thangdt1 && (int)Convert.ToDateTime(t.NgayKiemKe).Month <= thangdt2 && Convert.ToDateTime(t.NgayKiemKe).Year >= namdt1 && Convert.ToDateTime(t.NgayKiemKe).Year <= namdt2 && Convert.ToDateTime(t.NgayKiemKe).Day <= ngaydt2)

        //                        select new
        //                        {

        //                            MaHH = e.MaHH,
        //                            TenHH = e.TenHH,
        //                            NgayKiemKe = t.NgayKiemKe,
        //                            KhuVuc = t.TenKeHang,
        //                            NVKiemKe = u.Username,
        //                            STT = t.STT,

        //                        }).ToList();
        //            gctk.DataSource = data;
        //        }
        //        else if (namdt1 > namdt2)
        //        {
        //            MessageBox.Show("Thời gian không hợp lệ ");
        //        }
        //    }


        //}

        private void btnXem_Click(object sender, EventArgs e)
        {
            string _productCode = txtMaTK.Text;

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
            if (lkKho.Text == "")
            {      
            if (namdt1 == namdt2 && thangdt1 == thangdt2 && ngaydt1 == ngaydt2)
            {
                var data = (from t in context.DuyetHangHoas
                            join u in context.Users on t.IDUser equals u.ID
                            where (t.NgayKiemKe.Day == ngaydt1 && t.NgayKiemKe.Month == thangdt1 && t.NgayKiemKe.Year == namdt1 && t.MaHH == _productCode)
                            select new
                            {

                                //IDHangHoa = e.HangHoaID,
                                MaHH = t.MaHH,
                                TenHH = t.TenHH,
                                //NgayKiemKe = t.NgayKiemKe,
                                KhuVuc = t.TenKeHang,
                                NVKiemKe = u.Username,
                                STT = t.STT,

                            }).ToList();
                gctk.DataSource = data;
            }
            else
            {
                if (namdt1 == namdt2)
                {
                    if (thangdt1 == thangdt2)
                    {
                        if (ngaydt1 < ngaydt2)
                        {
                            var data = (from t in context.DuyetHangHoas
                                        join u in context.Users on t.IDUser equals u.ID
                                        where (t.NgayKiemKe.Day >= ngaydt1 && t.NgayKiemKe.Day <= ngaydt2 && t.NgayKiemKe.Month == thangdt1 && t.NgayKiemKe.Year == namdt1 && t.MaHH == _productCode)

                                        select new
                                        {
                                            MaHH = t.MaHH,
                                            TenHH = t.TenHH,
                                            // NgayKiemKe = t.NgayKiemKe,
                                            KhuVuc = t.TenKeHang,
                                            NVKiemKe = u.Username,
                                            STT = t.STT,

                                        }).ToList();
                            gctk.DataSource = data;
                        }
                        else if (ngaydt1 > ngaydt2)
                        {
                            MessageBox.Show("Thời gian không hợp lệ ");
                        }
                    }
                    else if (thangdt1 < thangdt2)
                    {
                        var data = (from t in context.DuyetHangHoas
                                    join u in context.Users on t.IDUser equals u.ID
                                    where (t.NgayKiemKe.Day == ngaydt1 && t.NgayKiemKe.Day <= ngaydt2 && t.NgayKiemKe.Month >= thangdt1 && t.NgayKiemKe.Month <= thangdt2 && t.NgayKiemKe.Year == namdt1 && t.MaHH == _productCode)

                                    select new
                                    {

                                        MaHH = t.MaHH,
                                        TenHH = t.TenHH,
                                        NgayKiemKe = t.NgayKiemKe,
                                        KhuVuc = t.TenKeHang,
                                        NVKiemKe = u.Username,
                                        STT = t.STT,

                                    }).ToList();
                        gctk.DataSource = data;
                    }
                    else
                    {
                        MessageBox.Show("Thời gian không hợp lệ ");
                    }
                }
                else if (namdt1 < namdt2)
                {
                    var data = (from t in context.DuyetHangHoas
                                join u in context.Users on t.IDUser equals u.ID
                                where (t.NgayKiemKe.Day == ngaydt1 && t.NgayKiemKe.Day <= ngaydt2 && t.NgayKiemKe.Month >= thangdt1 && t.NgayKiemKe.Month <= thangdt2 && t.NgayKiemKe.Year >= namdt1 && t.NgayKiemKe.Year <= namdt2 && t.MaHH == _productCode)

                                select new
                                {

                                    MaHH = t.MaHH,
                                    TenHH = t.TenHH,
                                    NgayKiemKe = t.NgayKiemKe,
                                    KhuVuc = t.TenKeHang,
                                    NVKiemKe = u.Username,
                                    STT = t.STT,

                                }).ToList();
                    gctk.DataSource = data;
                }
                else if (namdt1 > namdt2)
                {
                    MessageBox.Show("Thời gian không hợp lệ ");
                }
            }
        }
            // lkKho != null
            else
            {
                string IDStore = (string)(lkKho as LookUpEdit).EditValue;
                if (namdt1 == namdt2 && thangdt1 == thangdt2 && ngaydt1 == ngaydt2)
                {
                    var data = (from t in context.DuyetHangHoas
                                join u in context.Users on t.IDUser equals u.ID
                                where (t.IDKho == IDStore && t.NgayKiemKe.Day == ngaydt1 && t.NgayKiemKe.Month == thangdt1 && t.NgayKiemKe.Year == namdt1 && t.MaHH == _productCode)
                                //&& Convert.ToDateTime(t.NgayKiemKe).Day == ngaydt1 && (int)Convert.ToDateTime(t.NgayKiemKe).Month == thangdt1 && Convert.ToDateTime(t.NgayKiemKe).Year == namdt1
                                select new
                                {

                                    //IDHangHoa = e.HangHoaID,
                                    MaHH = t.MaHH,
                                    TenHH = t.TenHH,
                                    //NgayKiemKe = t.NgayKiemKe,
                                    KhuVuc = t.TenKeHang,
                                    NVKiemKe = u.Username,
                                    STT = t.STT,

                                }).ToList();
                    gctk.DataSource = data;
                }
                else
                {
                    if (namdt1 == namdt2)
                    {
                        if (thangdt1 == thangdt2)
                        {
                            if (ngaydt1 < ngaydt2)
                            {
                                var data = (from t in context.DuyetHangHoas
                                            join u in context.Users on t.IDUser equals u.ID
                                            where (t.IDKho == IDStore && t.NgayKiemKe.Day >= ngaydt1 && t.NgayKiemKe.Day <= ngaydt2 && t.NgayKiemKe.Month == thangdt1 && t.NgayKiemKe.Year == namdt1 && t.MaHH == _productCode)

                                            select new
                                            {
                                                MaHH = t.MaHH,
                                                TenHH = t.TenHH,
                                                // NgayKiemKe = t.NgayKiemKe,
                                                KhuVuc = t.TenKeHang,
                                                NVKiemKe = u.Username,
                                                STT = t.STT,

                                            }).ToList();
                                gctk.DataSource = data;
                            }
                            else if (ngaydt1 > ngaydt2)
                            {
                                MessageBox.Show("Thời gian không hợp lệ ");
                            }
                        }
                        else if (thangdt1 < thangdt2)
                        {
                            var data = (from t in context.DuyetHangHoas
                                        join u in context.Users on t.IDUser equals u.ID
                                        where (t.IDKho == IDStore && t.NgayKiemKe.Day == ngaydt1 && t.NgayKiemKe.Day <= ngaydt2 && t.NgayKiemKe.Month >= thangdt1 && t.NgayKiemKe.Month <= thangdt2 && t.NgayKiemKe.Year == namdt1 && t.MaHH == _productCode)

                                        select new
                                        {

                                            MaHH = t.MaHH,
                                            TenHH = t.TenHH,
                                            NgayKiemKe = t.NgayKiemKe,
                                            KhuVuc = t.TenKeHang,
                                            NVKiemKe = u.Username,
                                            STT = t.STT,

                                        }).ToList();
                            gctk.DataSource = data;
                        }
                        else
                        {
                            MessageBox.Show("Thời gian không hợp lệ ");
                        }
                    }
                    else if (namdt1 < namdt2)
                    {
                        var data = (from t in context.DuyetHangHoas
                                    join u in context.Users on t.IDUser equals u.ID
                                    where (t.IDKho == IDStore &&t.NgayKiemKe.Day == ngaydt1 && t.NgayKiemKe.Day <= ngaydt2 && t.NgayKiemKe.Month >= thangdt1 && t.NgayKiemKe.Month <= thangdt2 && t.NgayKiemKe.Year >= namdt1 && t.NgayKiemKe.Year <= namdt2 && t.MaHH == _productCode)

                                    select new
                                    {

                                        MaHH = t.MaHH,
                                        TenHH = t.TenHH,
                                        NgayKiemKe = t.NgayKiemKe,
                                        KhuVuc = t.TenKeHang,
                                        NVKiemKe = u.Username,
                                        STT = t.STT,

                                    }).ToList();
                        gctk.DataSource = data;
                    }
                    else if (namdt1 > namdt2)
                    {
                        MessageBox.Show("Thời gian không hợp lệ ");
                    }
                }
            }

        }
        private void loadLK()
        {
            try
            {
                var data = (from t in db.Khoes

                            select new
                            {

                                IDKho = t.MaKho,
                                TenKho = t.TenKho
                            }).ToList();


                if (data == null)

                    MessageBox.Show("Error");

                else
                {
                    lkKho.Properties.DataSource = data;
                }
            }
            catch { MessageBox.Show("Lỗi hệ thống  !"); }

        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            loadLK();
            
        }
    }

}
    

