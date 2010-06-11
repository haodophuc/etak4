using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLKS.UI;

namespace QLKS
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
            Application.Run(new UI.MainForm());
        }

        public static DBConnection DBConnection
        {
            get { return dbConnection; }
            set { dbConnection = value; }
        }//end attribute ConnectionString
        private static DBConnection dbConnection;
    }
}