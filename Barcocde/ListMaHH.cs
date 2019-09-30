using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VsLogistics.UIComponent;

namespace Barcocde
{
   
    public partial class ListMaHH : DevExpress.XtraEditors.XtraForm
    {
        public string _MaHHPartial { get; set; } //Ma sai
        public string MaHHSelect { get; set; } // Mã chọn
        public string _MaGoiNho { get; set; }
        public int _SoLuong { get; set; }
        //DBHangHoaEntitiesLK db = new DBHangHoaEntitiesLK();
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

        public ListMaHH()
        {
            InitializeComponent();
           
        }
        public void listMa(string word,List<string> wordList,double fuzzyness)  
        {

           
        }
        public bool GetListMa()
        {
            //StartsWith == bắt đầu
            //Contains == chứa đựng
            var FilteredList = (from x in db.HangHoas
                                where( x.MaHH.Contains(_MaHHPartial) || x.MaGoiNho.Contains(_MaGoiNho))
                                select new
                                {
                                    ProductCode = x.MaHH ,
                                    ProductName = x.TenHH,
                                    MaGoiNho = x.MaGoiNho
                                }

                ).ToList();
            if (FilteredList.Count == 0)
            {
                MessageBox.Show("không có dữ liệu !", "Error");

                return false;
            }
            else
            {

                    bdListMaHH.DataSource = FilteredList ;
                    return true;

            }           
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoLuong.Text == "")
                {
                    MaHHSelect = (string)gridView2.GetFocusedRowCellValue(colproductCode);
                    //_MaGoiNho = (string)gridView2.GetFocusedRowCellValue(colMaGoiNho);
                    _SoLuong = 1;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MaHHSelect = (string)gridView2.GetFocusedRowCellValue(colproductCode);
                    //_MaGoiNho = (string)gridView2.GetFocusedRowCellValue(colMaGoiNho);
                    _SoLuong = Convert.ToInt16(txtSoLuong.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("Số  lượng không hợp lệ !");
            }


        }

        private void ListMaHH_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
