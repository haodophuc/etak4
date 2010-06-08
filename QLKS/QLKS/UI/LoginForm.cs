using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLKS.Properties;

namespace QLKS.UI
{
    public partial class LoginForm : Form
    {
        private MainForm mainForm;
        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        #region Event Handlers
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Program.DBConnection = new DBConnection(Settings.Default.ConnectionString);
                //if (Program.DBConnection.Connection.State == ConnectionState.Open)
                //    Program.DBConnection.Connection.Close();

                if (!Program.DBConnection.databaseContainsUser(usernameTextBox.Text, passwordTextBox.Text))
                    throw new Exception("Invalid username or password");
                
                // check privileges here
                if (Program.DBConnection.userHasRole("Teller", usernameTextBox.Text))
                {
                    mainForm.enableTellerMenuItems();
                }

                if (Program.DBConnection.userHasRole("Application Administrator", usernameTextBox.Text))
                {
                    mainForm.enableAllMenuItems();
                }

                mainForm.Text = Resources.ApplicationName + " - Username: " + usernameTextBox.Text;
                this.Hide();

            }// end try
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error Encountered", MessageBoxButtons.OK);
            }// end catch;
            finally
            {
                // do nothing
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterToParent();
            usernameTextBox.Focus();
        }
        #endregion

        #region Helpers
        private bool doesThisUserExist(String userName, String password)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@USERNAME", userName);
            parameters[1] = new SqlParameter("@PASSWORD", password);
            bool yesOrNo = (bool)Program.DBConnection.ExecuteScalar("SELECT dbo.FN_DOES_THIS_EMPLOYEE_EXIST(@USERNAME, @PASSWORD)", parameters);
            return yesOrNo;
        }
        #endregion


    }
}