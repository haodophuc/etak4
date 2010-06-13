using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKS.Properties;
using QLKS.UI;

using DevExpress.XtraBars;

namespace QLKS.UI
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
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
            disableAllMenuItems();
            enableLoginMenuItems();
            loginForm.ShowDialog();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        #endregion

        #region User Menu
        private void loginMenuItem_Click(object sender, EventArgs e)
        {
            // show login form as modal dialog
            loginForm.ShowDialog();
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            disableAllMenuItems();
            closeAllChilren();

            // enable "Login" "Logout" and disable "Change password"
            enableLoginMenuItems();
            disableChangePasswordMenuItem();

            // reset application name
            Text = Resources.ApplicationName;
        }

        private void changePasswordMenuItem_Click(object sender, EventArgs e)
        {
            UserControlPanelForm userCPForm = new UserControlPanelForm(currentUserName);
            userCPForm.MdiParent = this;
            userCPForm.Show();
        }
        #endregion

        #region Transaction Menu
        private void bookRoomMenuItem_Click(object sender, EventArgs e)
        {
            FormBooking bookingForm = new FormBooking();
            bookingForm.MdiParent = this;
            bookingForm.Show();
        }

        private void checkInMenuItem_Click(object sender, EventArgs e)
        {
            FormCheckIn checkInForm = new FormCheckIn();
            checkInForm.MdiParent = this;
            checkInForm.Show();
        }

        private void checkOutMenuItem_Click(object sender, EventArgs e)
        {
            Form_CheckOut checkOutForm = new Form_CheckOut();
            checkOutForm.MdiParent = this;
            checkOutForm.Show();
        }
        #endregion

        #region Service Menu
        private void serviceMenuItem_Click(object sender, EventArgs e)
        {
            ServicesManagementForm serviceForm = new ServicesManagementForm();
            serviceForm.MdiParent = this;
            serviceForm.Show();
        }

        private void serviceOrderMenuItem_Click(object sender, EventArgs e)
        {
            ServicesOrderForm serviceOrderForm = new ServicesOrderForm();
            serviceOrderForm.MdiParent = this;
            serviceOrderForm.Show();
        }
        #endregion

        #region Search Menu
        private void searchCustomerMenuItem_Click(object sender, EventArgs e)
        {
            Form_TraCuuThongTinKhachHang searchCustomer = new Form_TraCuuThongTinKhachHang();
            searchCustomer.MdiParent = this;
            searchCustomer.Show();
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
        #endregion

        #region Update Menu
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

        private void roomMenuItem_Click(object sender, EventArgs e)
        {
            Form_CapNhatPhong roomForm = new Form_CapNhatPhong();
            roomForm.MdiParent = this;
            roomForm.Show();
        }

        private void rentRoomBillMenuItem_Click(object sender, EventArgs e)
        {
            Form_CapNhatPhieuThuePhong formCapNhatPTP = new Form_CapNhatPhieuThuePhong();
            formCapNhatPTP.MdiParent = this;
            formCapNhatPTP.Show();
        }

        private void PhiếuThuDoanKhachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CapNhatPhieuThuDoanKhach formCapNhatPhieuThuDoanKhach = new Form_CapNhatPhieuThuDoanKhach();
            formCapNhatPhieuThuDoanKhach.MdiParent = this;
            formCapNhatPhieuThuDoanKhach.Show();
        }

        private void phiếuThuKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CapNhatPhieuThuKhachHang formCapNhatPhieuThuKhachHang = new Form_CapNhatPhieuThuKhachHang();
            formCapNhatPhieuThuKhachHang.MdiParent = this;
            formCapNhatPhieuThuKhachHang.Show();
        }
        #endregion

        #region Statistic and Report
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

        private void MenuItem_DoanhThu_Click(object sender, EventArgs e)
        {
            Form_ReportDoanhThu reportDoanhThu = new Form_ReportDoanhThu();
            reportDoanhThu.MdiParent = this;
            reportDoanhThu.Show();
        }
        #endregion

        #region User Management
        private void userManagementMenuItem_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.MdiParent = this;
            userManagementForm.Show();
        }
        #endregion

        private void searchAndSelectCustomerMenuItem_Click(object sender, EventArgs e)
        {
            Form_TimKiemVaChonKhachHang searchAndSelectForm = new Form_TimKiemVaChonKhachHang();
            searchAndSelectForm.MdiParent = this;
            searchAndSelectForm.Show();
        }

        #region Helpers
        // public helpers, be called from outside world
        public void enableAllMenuItems()
        {
            foreach (ToolStripMenuItem item in mainMenu.Items)
                item.Enabled = true;
        }

        public void disableAllMenuItems()
        {
            foreach (ToolStripMenuItem item in mainMenu.Items)
                item.Enabled = false;
            SkinMenu.Enabled = true;

            // except Skin menu
            caramelToolStripMenuItem.Enabled = true;
            moneyTwinsToolStripMenuItem.Enabled = true;
            lilianToolStripMenuItem.Enabled = true;
        }

        public void enableApplicationAdministratorMenuItems()
        {
            enableAllMenuItems();
        }

        public void enableOfficialMenuItems()
        {
            statisticMenu.Enabled = true;
        }

        public void enableUserAdministratorMenuItems()
        {
            userManagementMenu.Enabled = true;
        }

        public void enableCEOMenuItems()
        {
            statisticMenu.Enabled = true;
        }

        public void enableReceptionistMenuItems()
        {
            transactMenu.Enabled = true;
            updateMenu.Enabled = true;
            roomMenuItem.Enabled = false;
        }

        public void enableServiceSupplierMenuItems()
        {
            serviceMenu.Enabled = true;
        }

        public void enableLoginMenuItems()
        {
            loginLogoutMenu.Enabled = true;
        }

        public void enableChangePasswordMenuItem()
        {
            changePasswordMenuItem.Enabled = true;
        }

        public void disableChangePasswordMenuItem()
        {
            changePasswordMenuItem.Enabled = false;
        }

        public void closeAllChilren()
        {
            foreach (Form form in MdiChildren)
                form.Close();            
        }

        // private helpers, function fragments, can be used in combination
        public void setCurrentUserLogging(String userName)
        {
            currentUserName = userName;
        }
        #endregion

        #region skins
        private void camerekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinController.LookAndFeel.SkinName = "Caramel";
        }

        private void moneyTwinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinController.LookAndFeel.SkinName = "Money Twins";
        }

        private void lilianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinController.LookAndFeel.SkinName = "Lilian";
        }
           

        private void theAsphaltWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinController.LookAndFeel.SkinName = "The Asphalt World";
        }

        private void iMaginaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinController.LookAndFeel.SkinName = "iMaginary";
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinController.LookAndFeel.SkinName = "Black";
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinController.LookAndFeel.SkinName = "Blue";

        }
        #endregion

       
    }
}