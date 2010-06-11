using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLKS.BUS;

namespace QLKS.UI
{
    public partial class UserControlPanelForm : DevExpress.XtraEditors.XtraForm
    {
        private String userName;
        private UserInfoBUS userInfoBUS;
        public UserControlPanelForm(String userName)
        {
            InitializeComponent();
            userInfoBUS = new UserInfoBUS();
            this.userName = userName;
        }

        private void UserControlPanelForm_Load(object sender, EventArgs e)
        {
            userNameTextBox.Text = userName;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            changePassword();
        }

        private void changePassword()
        {
            try
            {
                if (oldPasswordTextBox1.Text == "" || oldPasswordTextBox2.Text == "" || newPasswordTextBox.Text == "")
                    throw new Exception("Làm ơn nhập đầy đủ các ô");

                if (oldPasswordTextBox1.Text != oldPasswordTextBox2.Text)
                    throw new Exception("Hai mật khẩu cũ không giống nhau.");//, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!userInfoBUS.databaseContainsUser(userNameTextBox.Text, oldPasswordTextBox1.Text))
                    throw new Exception("Mật khẩu không hợp lệ.");//, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                userInfoBUS.changePassword(userNameTextBox.Text, oldPasswordTextBox1.Text, newPasswordTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            oldPasswordTextBox1.Clear();
            oldPasswordTextBox2.Clear();
            newPasswordTextBox.Clear();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}