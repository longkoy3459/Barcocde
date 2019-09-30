using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using VsLogistics.UIComponent;
using System.IO;

namespace Barcocde
{
    public partial class Login : Form
    {
        //public string UserLoginName { get; set; }
        //public string Password { get; set; }
        public long UserID { get; set; }
        public string UserLoginName { get; set; }
        public string Password { get; set; }
        public int i = 0;
        public string _DataSoure1 = @".\SQLEXPRESS";
        public Login()
        {
            InitializeComponent();
            
        }
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
        string ten = NameData();
        DBHangHoaEntitiesNH db = new DBHangHoaEntitiesNH(ConnectionTools.BuildConnectionOffline(@".\SQLEXPRESS", "DBHangHoa", "sa", "longkoy3459"));

        //DBHangHoaEntitiesLK db = new DBHangHoaEntitiesLK(ConnectionTools.BuildConnectionOffline());

        public static string EncodePasswordToBase64(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);

            return Convert.ToBase64String(inArray);
        }   
       
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

           // MessageBox.Show(NameData());
            string _UserName = txtTenDN.Text;
            string _password = Module.Module.CreateMd5Hash(txtMatKhau.Text);
            if (_UserName.Trim().Length == 0 || _password.Trim().Length == 0)
            {
                MessageBox.Show("Nhập tài khoản và mật khẩu !", "Thông  báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (_UserName.Trim().Length != 0 && _password.Trim().Length != 0)
            {

                //ONLINE
                if (i == 2)
                {
                    //try
                    //{


                        var obj = Barcocde.ReadAPI.Login(_UserName, _password);
                        if (obj == null)
                        {
                            MessageBox.Show("Error");
                            this.DialogResult = DialogResult.Abort;
                        }
                        else
                        {
                            if (obj.status == 1)
                            {
                            //this.UserID = obj.obj.userID;
                            //this.UserLoginName = _UserName;
                            //this.Password = obj.obj.password;

                            //this.DialogResult = DialogResult.OK;

                            
                            
                           
                              
                            //bc.UserID = UserID;

                            //this.DialogResult = DialogResult.OK;
                            //this.Close();
                            BaoCao bc = new BaoCao();

                            bc.i = i;
                            bc.ShowDialog();

                            
                        }

                            else
                            {
                                MessageBox.Show(obj.message);
                            }
                        }
                    
                    //}
                    //catch { MessageBox.Show("Lỗi mạng !"); }
                }
                
                //OFF
                else
                {
                    var user = db.Users.FirstOrDefault(x => x.Username == _UserName);


                    if (user == null)
                    {
                        MessageBox.Show("Tài Khoản Không đúng", "Thông  báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        if (user.Password == _password)
                        {
                            this.UserID = user.ID;
                            this.UserLoginName = user.Username;
                            this.Password = user.Password;

                            this.DialogResult = DialogResult.OK;

                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không đúng !", "Thông  báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                    }
                }
              
            }
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            

        }
    }
}
