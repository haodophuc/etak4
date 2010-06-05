using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLKS_DichVu.Properties;

namespace QLKS_DichVu.UI
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Program.DBConnection = new DBConnection(Settings.Default.ConnectionString);
                Program.DBConnection.Connect();
                Program.DBConnection.Disconnect();

                // Hieu's
                if (!doesThisUserExist(txtUserName.Text, txtPassword.Text))
                    throw new Exception("Invalid username or password");
                this.Hide();
                mainForm.menuSM.Enabled = true;
                mainForm.menuSR.Enabled = true;

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterToParent();
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