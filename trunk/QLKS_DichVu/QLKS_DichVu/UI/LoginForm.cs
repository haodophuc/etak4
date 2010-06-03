using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKS_DichVu.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void btnLogin_Click(object sender, EventArgs e)
        {            
            String connectionString = "server=" + txtServerName.Text +
                               ";database=" + txtDBName.Text +
                               ";uid=" + txtUserName.Text +
                               ";pwd=" + txtPassword.Text;
            
            try {
                Program.DBConnection = new DBConnection(connectionString);
                Program.DBConnection.Connect();
                Program.DBConnection.Disconnect();

                this.Close();
            }// end try
            catch( Exception exception ) {
                MessageBox.Show(exception.Message, "Error Encountered", MessageBoxButtons.OK);
            }// end catch;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
        #endregion
    }
}