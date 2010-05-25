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

        private DBConnection dbConnection;

        public Form_Connect()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection = new DBConnection();
                dbConnection.Connection.ConnectionString = @"Data Source=" + txtServerName.Text +
                              ";Initial Catalog=" + txtDBName.Text +
                              ";User ID=" + txtUserName.Text +
                              ";Password=" + txtPassword.Text;
                dbConnection.Connect();
                dbConnection.Disconnect();
                Form_Main frmMain = new Form_Main(dbConnection);
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