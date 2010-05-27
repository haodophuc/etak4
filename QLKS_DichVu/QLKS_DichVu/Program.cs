using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLKS_DichVu.UI;

namespace QLKS_DichVu
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
            Application.Run(new LoginForm());
        }

        public static DBConnection DBConnection
        {
            get { return dbConnection; }
            set { dbConnection = value; }
        }//end attribute ConnectionString
        private static DBConnection dbConnection;
    }
}