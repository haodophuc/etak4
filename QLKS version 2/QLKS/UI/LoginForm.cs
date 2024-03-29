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

                // prevent the case user press "Login" many times => Connect many times
                // tránh trường hợp người dùng bật form Login rồi cứ ngồi đó mà nhấn Login
                if (Program.DBConnection.Connection.State == ConnectionState.Open)
                    Program.DBConnection.Connection.Close();
                mainForm.closeAllChilren();

                // authentication
                if (!userInfoBUS.databaseContainsUser(usernameTextBox.Text, passwordTextBox.Text))
                    throw new Exception("Tên đăng nhập hoặc mật khẩu không hợp lệ");

                // check roles
                checkRoles();

                mainForm.Text = Resources.ApplicationName + " - Tên đăng nhập: " + usernameTextBox.Text;
                mainForm.setCurrentUserLogging(usernameTextBox.Text);
                this.Close();

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
            mainForm.disableAllMenuItems();
            mainForm.enableLoginMenuItems();
            mainForm.enableChangePasswordMenuItem();

            if (userInfoBUS.userHasRole(userName, "Lễ tân"))
            {
                mainForm.enableReceptionistMenuItems();
            }

            // no "else" here because a user may have many roles
            if (userInfoBUS.userHasRole(userName, "Bộ phận dịch vụ"))
            {
                mainForm.enableServiceSupplierMenuItems();
            }

            if (userInfoBUS.userHasRole(userName, "Cán bộ phòng kế hoạch và thị trường"))
            {
                mainForm.enableOfficialMenuItems();
            }

            if (userInfoBUS.userHasRole(userName, "Tổng giám đốc"))
            {
                mainForm.enableCEOMenuItems();
            }

            if (userInfoBUS.userHasRole(userName, "Quản trị người dùng"))
            {
                mainForm.enableUserAdministratorMenuItems();
            }

            if (userInfoBUS.userHasRole(userName, "Quản trị ứng dụng"))
            {
                mainForm.enableApplicationAdministratorMenuItems();
            }

            // chỉ cần IS_ADMIN là true thì toàn quyền dùng ứng dụng (giống super admin)
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