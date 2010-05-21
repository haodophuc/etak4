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
        private DBConnection dbConnection;

        public LoginForm()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void btnLogin_Click(object sender, EventArgs e)
        {            
            SqlConnection connection = new SqlConnection("server=" + txtServerName.Text +
                               ";database=" + txtDBName.Text +
                               ";uid=" + txtUserName.Text +
                               ";pwd=" + txtPassword.Text);
            dbConnection = new DBConnection(connection);

            if (dbConnection.connect())
            {
                ServiceOrderForm serviceOrderForm = new ServiceOrderForm(this, dbConnection);
                serviceOrderForm.Show();                
                this.Hide();
            }
            else
                MessageBox.Show(dbConnection.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dbConnection != null)
            {
                //MessageBox.Show("Disconnected from database");
                dbConnection.disconnect();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
        #endregion
    }
}