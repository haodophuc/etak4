namespace QLKS.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.loginLogoutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerGroupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveCustomerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bookRoomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentRoomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.transactMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCompanyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomerGroupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.userMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tellerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuThuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginLogoutMenu,
            this.updateMenu,
            this.receiveCustomerMenu,
            this.transactMenu,
            this.serviceMenu,
            this.searchMenu,
            this.statisticMenu,
            this.userManagementMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(731, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // loginLogoutMenu
            // 
            this.loginLogoutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginMenuItem,
            this.logoutMenuItem});
            this.loginLogoutMenu.Name = "loginLogoutMenu";
            this.loginLogoutMenu.Size = new System.Drawing.Size(69, 20);
            this.loginLogoutMenu.Text = "Vào ra =))";
            // 
            // loginMenuItem
            // 
            this.loginMenuItem.Name = "loginMenuItem";
            this.loginMenuItem.Size = new System.Drawing.Size(138, 22);
            this.loginMenuItem.Text = "Đăng nhập";
            this.loginMenuItem.Click += new System.EventHandler(this.loginMenuItem_Click);
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(138, 22);
            this.logoutMenuItem.Text = "Đăng xuất";
            this.logoutMenuItem.Click += new System.EventHandler(this.logoutMenuItem_Click);
            // 
            // updateMenu
            // 
            this.updateMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerMenuItem,
            this.customerGroupMenuItem,
            this.serviceMenuItem,
            this.roomMenuItem,
            this.phiếuThuêPhòngToolStripMenuItem});
            this.updateMenu.Name = "updateMenu";
            this.updateMenu.Size = new System.Drawing.Size(63, 20);
            this.updateMenu.Text = "Cập nhật";
            // 
            // customerMenuItem
            // 
            this.customerMenuItem.Name = "customerMenuItem";
            this.customerMenuItem.Size = new System.Drawing.Size(171, 22);
            this.customerMenuItem.Text = "Khách hàng";
            this.customerMenuItem.Click += new System.EventHandler(this.customerMenuItem_Click);
            // 
            // customerGroupMenuItem
            // 
            this.customerGroupMenuItem.Name = "customerGroupMenuItem";
            this.customerGroupMenuItem.Size = new System.Drawing.Size(171, 22);
            this.customerGroupMenuItem.Text = "Đoàn khách";
            this.customerGroupMenuItem.Click += new System.EventHandler(this.customerGroupMenuItem_Click);
            // 
            // serviceMenuItem
            // 
            this.serviceMenuItem.Name = "serviceMenuItem";
            this.serviceMenuItem.Size = new System.Drawing.Size(171, 22);
            this.serviceMenuItem.Text = "Dịch vụ";
            this.serviceMenuItem.Click += new System.EventHandler(this.serviceMenuItem_Click);
            // 
            // roomMenuItem
            // 
            this.roomMenuItem.Name = "roomMenuItem";
            this.roomMenuItem.Size = new System.Drawing.Size(171, 22);
            this.roomMenuItem.Text = "Phòng";
            this.roomMenuItem.Click += new System.EventHandler(this.roomMenuItem_Click);
            // 
            // receiveCustomerMenu
            // 
            this.receiveCustomerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookRoomMenuItem,
            this.rentRoomMenuItem});
            this.receiveCustomerMenu.Name = "receiveCustomerMenu";
            this.receiveCustomerMenu.Size = new System.Drawing.Size(97, 20);
            this.receiveCustomerMenu.Text = "Tiếp nhận khách";
            // 
            // bookRoomMenuItem
            // 
            this.bookRoomMenuItem.Name = "bookRoomMenuItem";
            this.bookRoomMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bookRoomMenuItem.Text = "Đặt phòng";
            this.bookRoomMenuItem.Click += new System.EventHandler(this.bookRoomMenuItem_Click);
            // 
            // rentRoomMenuItem
            // 
            this.rentRoomMenuItem.Name = "rentRoomMenuItem";
            this.rentRoomMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rentRoomMenuItem.Text = "Thuê phòng";
            this.rentRoomMenuItem.Click += new System.EventHandler(this.rentRoomMenuItem_Click);
            // 
            // transactMenu
            // 
            this.transactMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactMenuItem});
            this.transactMenu.Name = "transactMenu";
            this.transactMenu.Size = new System.Drawing.Size(62, 20);
            this.transactMenu.Text = "Giao dịch";
            // 
            // transactMenuItem
            // 
            this.transactMenuItem.Name = "transactMenuItem";
            this.transactMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transactMenuItem.Text = "Thanh toán";
            this.transactMenuItem.Click += new System.EventHandler(this.transactMenuItem_Click);
            // 
            // serviceMenu
            // 
            this.serviceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceOrderMenuItem});
            this.serviceMenu.Name = "serviceMenu";
            this.serviceMenu.Size = new System.Drawing.Size(54, 20);
            this.serviceMenu.Text = "Dịch vụ";
            // 
            // serviceOrderMenuItem
            // 
            this.serviceOrderMenuItem.Name = "serviceOrderMenuItem";
            this.serviceOrderMenuItem.Size = new System.Drawing.Size(162, 22);
            this.serviceOrderMenuItem.Text = "Đăng ký dịch vụ";
            this.serviceOrderMenuItem.Click += new System.EventHandler(this.serviceOrderMenuItem_Click);
            // 
            // searchMenu
            // 
            this.searchMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchCustomerMenuItem,
            this.searchCompanyMenuItem,
            this.searchCustomerGroupMenuItem});
            this.searchMenu.Name = "searchMenu";
            this.searchMenu.Size = new System.Drawing.Size(56, 20);
            this.searchMenu.Text = "Tra cứu";
            // 
            // searchCustomerMenuItem
            // 
            this.searchCustomerMenuItem.Name = "searchCustomerMenuItem";
            this.searchCustomerMenuItem.Size = new System.Drawing.Size(142, 22);
            this.searchCustomerMenuItem.Text = "Khách hàng";
            this.searchCustomerMenuItem.Click += new System.EventHandler(this.searchCustomerMenuItem_Click_1);
            // 
            // searchCompanyMenuItem
            // 
            this.searchCompanyMenuItem.Name = "searchCompanyMenuItem";
            this.searchCompanyMenuItem.Size = new System.Drawing.Size(142, 22);
            this.searchCompanyMenuItem.Text = "Công ty";
            this.searchCompanyMenuItem.Click += new System.EventHandler(this.searchCompanyMenuItem_Click);
            // 
            // searchCustomerGroupMenuItem
            // 
            this.searchCustomerGroupMenuItem.Name = "searchCustomerGroupMenuItem";
            this.searchCustomerGroupMenuItem.Size = new System.Drawing.Size(142, 22);
            this.searchCustomerGroupMenuItem.Text = "Đoàn khách";
            this.searchCustomerGroupMenuItem.Click += new System.EventHandler(this.searchCustomerGroupMenuItem_Click);
            // 
            // statisticMenu
            // 
            this.statisticMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatisticCustomerMenuItem});
            this.statisticMenu.Name = "statisticMenu";
            this.statisticMenu.Size = new System.Drawing.Size(63, 20);
            this.statisticMenu.Text = "Thống kê";
            // 
            // StatisticCustomerMenuItem
            // 
            this.StatisticCustomerMenuItem.Name = "StatisticCustomerMenuItem";
            this.StatisticCustomerMenuItem.Size = new System.Drawing.Size(158, 22);
            this.StatisticCustomerMenuItem.Text = "Số lượng khách";
            this.StatisticCustomerMenuItem.Click += new System.EventHandler(this.StatisticCustomerMenuItem_Click);
            // 
            // userManagementMenu
            // 
            this.userManagementMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMenuItem,
            this.adminMenuItem,
            this.tellerMenuItem,
            this.roleMenuItem});
            this.userManagementMenu.Name = "userManagementMenu";
            this.userManagementMenu.Size = new System.Drawing.Size(103, 20);
            this.userManagementMenu.Text = "Quản lý tài khoản";
            // 
            // userMenuItem
            // 
            this.userMenuItem.Name = "userMenuItem";
            this.userMenuItem.Size = new System.Drawing.Size(175, 22);
            this.userMenuItem.Text = "Admin và thu ngân";
            this.userMenuItem.Click += new System.EventHandler(this.userMenuItem_Click);
            // 
            // adminMenuItem
            // 
            this.adminMenuItem.Name = "adminMenuItem";
            this.adminMenuItem.Size = new System.Drawing.Size(175, 22);
            this.adminMenuItem.Text = "Admin";
            // 
            // tellerMenuItem
            // 
            this.tellerMenuItem.Name = "tellerMenuItem";
            this.tellerMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tellerMenuItem.Text = "Thu ngân";
            // 
            // roleMenuItem
            // 
            this.roleMenuItem.Name = "roleMenuItem";
            this.roleMenuItem.Size = new System.Drawing.Size(175, 22);
            this.roleMenuItem.Text = "Quyền hạn";
            // 
            // phiếuThuêPhòngToolStripMenuItem
            // 
            this.phiếuThuêPhòngToolStripMenuItem.Name = "phiếuThuêPhòngToolStripMenuItem";
            this.phiếuThuêPhòngToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.phiếuThuêPhòngToolStripMenuItem.Text = "Phiếu Thuê Phòng";
            this.phiếuThuêPhòngToolStripMenuItem.Click += new System.EventHandler(this.phiếuThuêPhòngToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(731, 444);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem loginLogoutMenu;
        private System.Windows.Forms.ToolStripMenuItem loginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiveCustomerMenu;
        private System.Windows.Forms.ToolStripMenuItem bookRoomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentRoomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenu;
        private System.Windows.Forms.ToolStripMenuItem customerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerGroupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceMenu;
        private System.Windows.Forms.ToolStripMenuItem serviceOrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementMenu;
        private System.Windows.Forms.ToolStripMenuItem roleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tellerMenuItem;
        public System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem searchMenu;
        private System.Windows.Forms.ToolStripMenuItem searchCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCompanyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCustomerGroupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticMenu;
        private System.Windows.Forms.ToolStripMenuItem StatisticCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactMenu;
        private System.Windows.Forms.ToolStripMenuItem transactMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuThuêPhòngToolStripMenuItem;


    }
}