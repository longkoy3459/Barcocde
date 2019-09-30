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

namespace Barcocde
{
    public partial class DataOff : Form
    {
        public DataOff()
        {
            InitializeComponent();
        }
        public string NameData()
        {
            StreamReader SR = new StreamReader(Application.StartupPath + "\\DataName.txt");
            string[] result = SR.ReadToEnd().Trim().Split('\n');
            // result[0] = fileVao;

            SR.Close();
            return result[0];
        }
        public string DataTenDatabases()
        {
            StreamReader SR = new StreamReader(Application.StartupPath + "\\DataTenDatabases.txt");
            string[] result = SR.ReadToEnd().Trim().Split('\n');
            // result[0] = fileVao;

            SR.Close();
            return result[0];
        }
        public string LoginData()
        {
            StreamReader SR = new StreamReader(Application.StartupPath + "\\DataLogin.txt");
            string[] result = SR.ReadToEnd().Trim().Split('\n');
            // result[0] = fileVao;

            SR.Close();
            return result[0];
        }
        public string PasswordData()
        {
            StreamReader SR = new StreamReader(Application.StartupPath + "\\DataPassword.txt");
            string[] result = SR.ReadToEnd().Trim().Split('\n');
            // result[0] = fileVao;

            SR.Close();
            return result[0];
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            string text = File.ReadAllText(Application.StartupPath + "\\DataName.txt");
            text = text.Replace(NameData(), txtName.Text); // thay đổi gtri cũ = mới(text)
            File.WriteAllText(Application.StartupPath + "\\DataName.txt", text);

            string text1 = File.ReadAllText(Application.StartupPath + "\\DataTenDatabases.txt");
            text1 = text1.Replace(DataTenDatabases(), txtTenDatabases.Text); // thay đổi gtri cũ = mới(text)
            File.WriteAllText(Application.StartupPath + "\\DataTenDatabases.txt", text1);

            string text2 = File.ReadAllText(Application.StartupPath + "\\DataLogin.txt");
            text2 = text2.Replace(LoginData(), txtLogin.Text); // thay đổi gtri cũ = mới(text)
            File.WriteAllText(Application.StartupPath + "\\DataLogin.txt", text2);

            string text3 = File.ReadAllText(Application.StartupPath + "\\DataPassword.txt");
            text3 = text3.Replace(PasswordData(), txtPassword.Text); // thay đổi gtri cũ = mới(text)
            File.WriteAllText(Application.StartupPath + "\\DataPassword.txt", text3);

           


        }
    }
}
