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

                // prevent the case người dùng press "Login" many times => Connect many times
                // tránh trường hợp người dùng bật form Login rồi cứ ngồi mà nhấn Login
                if (Program.DBConnection.Connection.State == ConnectionState.Open)
                    Program.DBConnection.Connection.Close();

                // authentication
                if (!userInfoBUS.databaseContainsUser(usernameTextBox.Text, passwordTextBox.Text))
                    throw new Exception("Tên đăng nhập hoặc mật khẩu không hợp lệ");

                // check roles
                checkRoles();

                mainForm.Text = Resources.ApplicationName + " - Tên đăng nhập: " + usernameTextBox.Text;
                mainForm.setCurrentUserLogging(usernameTextBox.Text);
                this.Hide();

            }// end try
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Lỗi", MessageBoxButtons.OK);
            }// end catch;
            finally
            {
                // do nothing
            }
        }

        private void checkRoles()
        {
            String userName = usernameTextBox.Text;
            if (userInfoBUS.userHasRole(userName, "Thu ngân"))
            {
                mainForm.enableTellerMenuItems();
            }
            // no "else" here because a user may have many roles
            if (userInfoBUS.userHasRole(userName, "Lễ tân"))
            {
                //
            }

            if (userInfoBUS.userHasRole(userName, "Lễ tân"))
            {
                //
            }

            if (userInfoBUS.userHasRole(userName, "Tổng giám đốc"))
            {
                //
            }

            if (userInfoBUS.userHasRole(userName, "Bộ phận dịch vụ"))
            {
                //
            }

            if (userInfoBUS.userHasRole(userName, "Quản trị người dùng"))
            {
                mainForm.enableUserManagementMenuItems();
            }

            if (userInfoBUS.userHasRole(userName, "Quản trị ứng dụng"))
            {
                mainForm.enableAllMenuItems();
            }

            // chỉ cần IS_ADMIN là true thì toàn quyền dùng ứng dụng
            if (userInfoBUS.isAdmin(userName))
            {
                mainForm.enableAllMenuItems();
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