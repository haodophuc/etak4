using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKS.Properties;

namespace QLKS.UI
{
    public partial class MainForm : Form
    {
        private LoginForm loginForm;
        private String currentUserName;
        public MainForm()
        {
            InitializeComponent();
            loginForm = new LoginForm(this);
 
        }

        #region Event Handlers
        private void MainForm_Load(object sender, EventArgs e)
        {
            // show login form as modal dialog            
            enableLoginMenuItems();            
            loginForm.ShowDialog(); 
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
        }

        private void customerMenuItem_Click(object sender, EventArgs e)
        {
            Form_CapNhatKhachHang customerForm = new Form_CapNhatKhachHang();
            customerForm.MdiParent = this;
            customerForm.Show();
        }

        private void customerGroupMenuItem_Click(object sender, EventArgs e)
        {
            Form_CapNhatDoanKhach customerGroupForm = new Form_CapNhatDoanKhach();
            customerGroupForm.MdiParent = this;
            customerGroupForm.Show();
        }

        private void serviceMenuItem_Click(object sender, EventArgs e)
        {
            ServicesManagementForm serviceForm = new ServicesManagementForm();
            serviceForm.MdiParent = this;
            serviceForm.Show();
        }

        private void roomMenuItem_Click(object sender, EventArgs e)
        {
            Form_CapNhatPhong roomForm = new Form_CapNhatPhong();
            roomForm.MdiParent = this;
            roomForm.Show();
        }

        private void searchAndSelectCustomerMenuItem_Click(object sender, EventArgs e)
        {
            Form_TimKiemVaChonKhachHang searchAndSelectForm = new Form_TimKiemVaChonKhachHang();
            searchAndSelectForm.MdiParent = this;
            searchAndSelectForm.Show();
        }

        private void searchCustomerMenuItem_Click(object sender, EventArgs e)
        {
            Form_TraCuuThongTinKhachHang searchCustomer = new Form_TraCuuThongTinKhachHang();
            searchCustomer.MdiParent = this;
            searchCustomer.Show();
        }

        private void bookRoomMenuItem_Click(object sender, EventArgs e)
        {
            Form_DatPhong bookRoomForm = new Form_DatPhong();
            bookRoomForm.MdiParent = this;
            bookRoomForm.Show();
        }

        private void rentRoomMenuItem_Click(object sender, EventArgs e)
        {
            FormCheckIn checkInForm = new FormCheckIn();
            checkInForm.MdiParent = this;
            checkInForm.Show();
        }

        private void serviceOrderMenuItem_Click(object sender, EventArgs e)
        {
            ServicesOrderForm serviceOrderForm = new ServicesOrderForm();
            serviceOrderForm.MdiParent = this;
            serviceOrderForm.Show();
        }

        private void userManagementMenuItem_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.MdiParent = this;
            userManagementForm.Show();
        }

        private void loginMenuItem_Click(object sender, EventArgs e)
        {
            // show login form as modal dialog
            loginForm.ShowDialog();
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            disableAllMenuItems();

            // enable "Login" "Logout"
            enableLoginMenuItems();

            Text = Resources.ApplicationName;
        }

        private void searchCustomerMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_TraCuuThongTinKhachHang searchCustomerForm = new Form_TraCuuThongTinKhachHang();
            searchCustomerForm.MdiParent = this;
            searchCustomerForm.Show();
        }

        private void searchCompanyMenuItem_Click(object sender, EventArgs e)
        {
            Form_TraCuuThongTinCongTy searchCompanyForm = new Form_TraCuuThongTinCongTy();
            searchCompanyForm.MdiParent = this;
            searchCompanyForm.Show();
        }

        private void searchCustomerGroupMenuItem_Click(object sender, EventArgs e)
        {
            Form_TraCuuThongTinDoanKhach searchCustomerGroupForm = new Form_TraCuuThongTinDoanKhach();
            searchCustomerGroupForm.MdiParent = this;
            searchCustomerGroupForm.Show();
        }

        private void StatisticCustomerMenuItem_Click(object sender, EventArgs e)
        {
            Form_ReportKhachHang reportCustomerForm = new Form_ReportKhachHang();
            reportCustomerForm.MdiParent = this;
            reportCustomerForm.Show();
        }

        private void StatisticRoomMenuItem_Click(object sender, EventArgs e)
        {
            Form_ReportHeSoPhong formReportPhong = new Form_ReportHeSoPhong();
            formReportPhong.MdiParent = this;
            formReportPhong.Show();
        }
       
        private void transactMenuItem_Click(object sender, EventArgs e)
        {
            Form_CheckOut checkOutForm = new Form_CheckOut();
            checkOutForm.MdiParent = this;
            checkOutForm.Show();
        }

        private void rentRoomBillMenuItem_Click(object sender, EventArgs e)
        {
            Form_CapNhatPhieuThuePhong formCapNhatPTP = new Form_CapNhatPhieuThuePhong();
            formCapNhatPTP.MdiParent = this;
            formCapNhatPTP.Show();
        }

        private void userCPMenuItem_Click(object sender, EventArgs e)
        {
            UserControlPanelForm userCPForm = new UserControlPanelForm(currentUserName);
            userCPForm.MdiParent = this;
            userCPForm.Show();
        }
        #endregion

        #region Helpers
        // public helpers, be called from outside world
        public void enableAllMenuItems()
        {
            foreach (ToolStripMenuItem item in mainMenu.Items)
                item.Enabled = true;
        }

        public void enableUserManagementMenuItems()
        {
            disableAllMenuItems();
            enableLoginMenuItems();
            userManagementMenu.Enabled = true;
            userManagementMenuItem.Enabled = true;
        }

        public void enableTellerMenuItems()
        {
            enableAllMenuItems();
            userManagementMenu.Enabled = false;
        }

        // private helpers, function fragments, can be used in combination
        private void disableAllMenuItems()
        {
            foreach (ToolStripMenuItem item in mainMenu.Items)
                item.Enabled = false;
        }

        private void enableLoginMenuItems()
        {
            loginLogoutMenu.Enabled = true;
            loginMenuItem.Enabled = true;
            logoutMenuItem.Enabled = true;
        }

        public void setCurrentUserLogging(String userName)
        {
            currentUserName = userName;
        }
        #endregion




    }//end class MainForm
}//end namespace