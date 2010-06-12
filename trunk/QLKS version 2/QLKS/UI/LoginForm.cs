using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLKS.Properties;
using QLKS.BUS;

namespace QLKS.UI
{
    public partial class LoginForm : Form
    {
        private MainForm mainForm;
        private UserInfoBUS userInfoBUS;
        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            userInfoBUS = new UserInfoBUS();
            this.mainForm = mainForm;
        }

        #region Event Handlers
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Program.DBConnection = new DBConnection(Settings.Default.ConnectionString);

                // prevent the case ngu?i d�ng press "Login" many times => Connect many times
                // tr�nh tru?ng h?p ngu?i d�ng b?t form Login r?i c? ng?i m� nh?n Login
                if (Program.DBConnection.Connection.State == ConnectionState.Open)
                    Program.DBConnection.Connection.Close();

                // authentication
                if (!userInfoBUS.databaseContainsUser(usernameTextBox.Text, passwordTextBox.Text))
                    throw new Exception("T�n dang nh?p ho?c m?t kh?u kh�ng h?p l?");

                // check roles
                checkRoles();

                mainForm.Text = Resources.ApplicationName + " - T�n dang nh?p: " + usernameTextBox.Text;
                mainForm.setCurrentUserLogging(usernameTextBox.Text);
                this.Close();

            }// end try
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "L?i", MessageBoxButtons.OK);
            }// end catch;
            finally
            {
                // do nothing
            }
        }

        private void checkRoles()
        {
            String userName = usernameTextBox.Text;
            mainForm.disableAllMenuItems();
            mainForm.enableLoginMenuItems();
            mainForm.enableChangePasswordMenuItem();

            if (userInfoBUS.userHasRole(userName, "L? t�n"))
            {
                mainForm.enableReceptionistMenuItems();
            }

            // no "else" here because a user may have many roles
            if (userInfoBUS.userHasRole(userName, "B? ph?n d?ch v?"))
            {
                mainForm.enableServiceSupplierMenuItems();
            }

            if (userInfoBUS.userHasRole(userName, "C�n b? ph�ng k? ho?ch v� th? tru?ng"))
            {
                mainForm.enableOfficialMenuItems();
            }

            if (userInfoBUS.userHasRole(userName, "T?ng gi�m d?c"))
            {
                mainForm.enableCEOMenuItems();
            }

            if (userInfoBUS.userHasRole(userName, "Qu?n tr? ngu?i d�ng"))
            {
                mainForm.enableUserAdministratorMenuItems();
            }

            if (userInfoBUS.userHasRole(userName, "Qu?n tr? ?ng d?ng"))
            {
                mainForm.enableApplicationAdministratorMenuItems();
            }

            // ch? c?n IS_ADMIN l� true th� to�n quy?n d�ng ?ng d?ng (gi?ng super admin ?y)
            if (userInfoBUS.isAdmin(userName))
            {
                mainForm.enableAllMenuItems();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            CenterToParent();
            usernameTextBox.Focus();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
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