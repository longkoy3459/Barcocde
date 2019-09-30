using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace Barcocde
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new BarcodeOff());


            //DBHangHoaEntitiesNH contextOffiline = new DBHangHoaEntitiesNH(Connectiontoo.BuiOfffile);

            //DBHangHoaEntitiesNH contextOff = new DBHangHoaEntitiesNH(Connectiontoo.BuiConn);

        }
    }
}
