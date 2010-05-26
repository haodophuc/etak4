using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKS_TiepNhanKhach
{
    public partial class Form_Connect : Form
    {

        public Form_Connect()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Program.dbConnection = new DBConnection();
                Program.dbConnection.Connection.ConnectionString = @"Data Source=" + txtServerName.Text +
                              ";Initial Catalog=" + txtDBName.Text +
                              ";User ID=" + txtUserName.Text +
                              ";Password=" + txtPassword.Text;
                Program.dbConnection.Connect();
                Program.dbConnection.Disconnect();
                Form_Main frmMain = new Form_Main();
                frmMain.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}