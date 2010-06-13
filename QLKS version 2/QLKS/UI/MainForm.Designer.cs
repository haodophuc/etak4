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
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.loginLogoutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bookRoomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCompanyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomerGroupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerGroupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentRoomBillMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhiếuThuDoanKhachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuThuKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticRoomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.caramelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyTwinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lilianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theAsphaltWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMaginaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.MenuItem_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = null;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(708, 51);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 426);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(708, 23);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginLogoutMenu,
            this.transactMenu,
            this.serviceMenu,
            this.searchMenu,
            this.updateMenu,
            this.statisticMenu,
            this.userManagementMenu,
            this.SkinMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 51);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(708, 24);
            this.mainMenu.TabIndex = 5;
            this.mainMenu.Text = "menuStrip1";
            // 
            // loginLogoutMenu
            // 
            this.loginLogoutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginMenuItem,
            this.logoutMenuItem,
            this.changePasswordMenuItem});
            this.loginLogoutMenu.Name = "loginLogoutMenu";
            this.loginLogoutMenu.Size = new System.Drawing.Size(83, 20);
            this.loginLogoutMenu.Text = "Người dùng";
            // 
            // loginMenuItem
            // 
            this.loginMenuItem.Name = "loginMenuItem";
            this.loginMenuItem.Size = new System.Drawing.Size(145, 22);
            this.loginMenuItem.Text = "Đăng nhập";
            this.loginMenuItem.Click += new System.EventHandler(this.loginMenuItem_Click);
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(145, 22);
            this.logoutMenuItem.Text = "Đăng xuất";
            this.logoutMenuItem.Click += new System.EventHandler(this.logoutMenuItem_Click);
            // 
            // changePasswordMenuItem
            // 
            this.changePasswordMenuItem.Name = "changePasswordMenuItem";
            this.changePasswordMenuItem.Size = new System.Drawing.Size(145, 22);
            this.changePasswordMenuItem.Text = "Đổi mật khẩu";
            this.changePasswordMenuItem.Click += new System.EventHandler(this.changePasswordMenuItem_Click);
            // 
            // transactMenu
            // 
            this.transactMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookRoomMenuItem,
            this.checkInMenuItem,
            this.checkOutMenuItem});
            this.transactMenu.Name = "transactMenu";
            this.transactMenu.Size = new System.Drawing.Size(69, 20);
            this.transactMenu.Text = "Giao dịch";
            // 
            // bookRoomMenuItem
            // 
            this.bookRoomMenuItem.Name = "bookRoomMenuItem";
            this.bookRoomMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bookRoomMenuItem.Text = "Đặt phòng";
            this.bookRoomMenuItem.Click += new System.EventHandler(this.bookRoomMenuItem_Click);
            // 
            // checkInMenuItem
            // 
            this.checkInMenuItem.Name = "checkInMenuItem";
            this.checkInMenuItem.Size = new System.Drawing.Size(155, 22);
            this.checkInMenuItem.Text = "Đăng ký phòng";
            this.checkInMenuItem.Click += new System.EventHandler(this.checkInMenuItem_Click);
            // 
            // checkOutMenuItem
            // 
            this.checkOutMenuItem.Name = "checkOutMenuItem";
            this.checkOutMenuItem.Size = new System.Drawing.Size(155, 22);
            this.checkOutMenuItem.Text = "Trả phòng";
            this.checkOutMenuItem.Click += new System.EventHandler(this.checkOutMenuItem_Click);
            // 
            // serviceMenu
            // 
            this.serviceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceMenuItem,
            this.serviceOrderMenuItem});
            this.serviceMenu.Name = "serviceMenu";
            this.serviceMenu.Size = new System.Drawing.Size(59, 20);
            this.serviceMenu.Text = "Dịch vụ";
            // 
            // serviceMenuItem
            // 
            this.serviceMenuItem.Name = "serviceMenuItem";
            this.serviceMenuItem.Size = new System.Drawing.Size(159, 22);
            this.serviceMenuItem.Text = "Quản lý dịch vụ";
            this.serviceMenuItem.Click += new System.EventHandler(this.serviceMenuItem_Click);
            // 
            // serviceOrderMenuItem
            // 
            this.serviceOrderMenuItem.Name = "serviceOrderMenuItem";
            this.serviceOrderMenuItem.Size = new System.Drawing.Size(159, 22);
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
            this.searchMenu.Size = new System.Drawing.Size(59, 20);
            this.searchMenu.Text = "Tra cứu";
            // 
            // searchCustomerMenuItem
            // 
            this.searchCustomerMenuItem.Name = "searchCustomerMenuItem";
            this.searchCustomerMenuItem.Size = new System.Drawing.Size(137, 22);
            this.searchCustomerMenuItem.Text = "Khách hàng";
            this.searchCustomerMenuItem.Click += new System.EventHandler(this.searchCustomerMenuItem_Click);
            // 
            // searchCompanyMenuItem
            // 
            this.searchCompanyMenuItem.Name = "searchCompanyMenuItem";
            this.searchCompanyMenuItem.Size = new System.Drawing.Size(137, 22);
            this.searchCompanyMenuItem.Text = "Công ty";
            this.searchCompanyMenuItem.Click += new System.EventHandler(this.searchCompanyMenuItem_Click);
            // 
            // searchCustomerGroupMenuItem
            // 
            this.searchCustomerGroupMenuItem.Name = "searchCustomerGroupMenuItem";
            this.searchCustomerGroupMenuItem.Size = new System.Drawing.Size(137, 22);
            this.searchCustomerGroupMenuItem.Text = "Đoàn khách";
            this.searchCustomerGroupMenuItem.Click += new System.EventHandler(this.searchCustomerGroupMenuItem_Click);
            // 
            // updateMenu
            // 
            this.updateMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerMenuItem,
            this.customerGroupMenuItem,
            this.roomMenuItem,
            this.rentRoomBillMenuItem,
            this.PhiếuThuDoanKhachToolStripMenuItem,
            this.phiếuThuKháchHàngToolStripMenuItem});
            this.updateMenu.Name = "updateMenu";
            this.updateMenu.Size = new System.Drawing.Size(67, 20);
            this.updateMenu.Text = "Cập nhật";
            // 
            // customerMenuItem
            // 
            this.customerMenuItem.Name = "customerMenuItem";
            this.customerMenuItem.Size = new System.Drawing.Size(196, 22);
            this.customerMenuItem.Text = "Khách hàng";
            this.customerMenuItem.Click += new System.EventHandler(this.customerMenuItem_Click);
            // 
            // customerGroupMenuItem
            // 
            this.customerGroupMenuItem.Name = "customerGroupMenuItem";
            this.customerGroupMenuItem.Size = new System.Drawing.Size(196, 22);
            this.customerGroupMenuItem.Text = "Đoàn khách";
            this.customerGroupMenuItem.Click += new System.EventHandler(this.customerGroupMenuItem_Click);
            // 
            // roomMenuItem
            // 
            this.roomMenuItem.Name = "roomMenuItem";
            this.roomMenuItem.Size = new System.Drawing.Size(196, 22);
            this.roomMenuItem.Text = "Phòng";
            this.roomMenuItem.Click += new System.EventHandler(this.roomMenuItem_Click);
            // 
            // rentRoomBillMenuItem
            // 
            this.rentRoomBillMenuItem.Name = "rentRoomBillMenuItem";
            this.rentRoomBillMenuItem.Size = new System.Drawing.Size(196, 22);
            this.rentRoomBillMenuItem.Text = "Phiếu Thuê Phòng";
            this.rentRoomBillMenuItem.Click += new System.EventHandler(this.rentRoomBillMenuItem_Click);
            // 
            // PhiếuThuDoanKhachToolStripMenuItem
            // 
            this.PhiếuThuDoanKhachToolStripMenuItem.Name = "PhiếuThuDoanKhachToolStripMenuItem";
            this.PhiếuThuDoanKhachToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.PhiếuThuDoanKhachToolStripMenuItem.Text = "Phiếu Thu Đoàn Khách";
            this.PhiếuThuDoanKhachToolStripMenuItem.Click += new System.EventHandler(this.PhiếuThuDoanKhachToolStripMenuItem_Click);
            // 
            // phiếuThuKháchHàngToolStripMenuItem
            // 
            this.phiếuThuKháchHàngToolStripMenuItem.Name = "phiếuThuKháchHàngToolStripMenuItem";
            this.phiếuThuKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.phiếuThuKháchHàngToolStripMenuItem.Text = "Phiếu Thu Khách Hàng";
            this.phiếuThuKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.phiếuThuKháchHàngToolStripMenuItem_Click);
            // 
            // statisticMenu
            // 
            this.statisticMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatisticCustomerMenuItem,
            this.StatisticRoomMenuItem,
            this.MenuItem_DoanhThu});
            this.statisticMenu.Name = "statisticMenu";
            this.statisticMenu.Size = new System.Drawing.Size(69, 20);
            this.statisticMenu.Text = "Thống kê";
            // 
            // StatisticCustomerMenuItem
            // 
            this.StatisticCustomerMenuItem.Name = "StatisticCustomerMenuItem";
            this.StatisticCustomerMenuItem.Size = new System.Drawing.Size(191, 22);
            this.StatisticCustomerMenuItem.Text = "Số lượng khách";
            this.StatisticCustomerMenuItem.Click += new System.EventHandler(this.StatisticCustomerMenuItem_Click);
            // 
            // StatisticRoomMenuItem
            // 
            this.StatisticRoomMenuItem.Name = "StatisticRoomMenuItem";
            this.StatisticRoomMenuItem.Size = new System.Drawing.Size(191, 22);
            this.StatisticRoomMenuItem.Text = "Hệ Số Sử Dụng Phòng";
            this.StatisticRoomMenuItem.Click += new System.EventHandler(this.StatisticRoomMenuItem_Click);
            // 
            // userManagementMenu
            // 
            this.userManagementMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagementMenuItem});
            this.userManagementMenu.Name = "userManagementMenu";
            this.userManagementMenu.Size = new System.Drawing.Size(112, 20);
            this.userManagementMenu.Text = "Quản lý tài khoản";
            // 
            // userManagementMenuItem
            // 
            this.userManagementMenuItem.Name = "userManagementMenuItem";
            this.userManagementMenuItem.Size = new System.Drawing.Size(182, 22);
            this.userManagementMenuItem.Text = "Quản trị người dùng";
            this.userManagementMenuItem.Click += new System.EventHandler(this.userManagementMenuItem_Click);
            // 
            // SkinMenu
            // 
            this.SkinMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caramelToolStripMenuItem,
            this.moneyTwinsToolStripMenuItem,
            this.lilianToolStripMenuItem,
            this.theAsphaltWorldToolStripMenuItem,
            this.iMaginaryToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.SkinMenu.Name = "SkinMenu";
            this.SkinMenu.Size = new System.Drawing.Size(41, 20);
            this.SkinMenu.Text = "Skin";
            // 
            // caramelToolStripMenuItem
            // 
            this.caramelToolStripMenuItem.Name = "caramelToolStripMenuItem";
            this.caramelToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.caramelToolStripMenuItem.Text = "Caramel";
            this.caramelToolStripMenuItem.Click += new System.EventHandler(this.camerekToolStripMenuItem_Click);
            // 
            // moneyTwinsToolStripMenuItem
            // 
            this.moneyTwinsToolStripMenuItem.Name = "moneyTwinsToolStripMenuItem";
            this.moneyTwinsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.moneyTwinsToolStripMenuItem.Text = "Money Twins";
            this.moneyTwinsToolStripMenuItem.Click += new System.EventHandler(this.moneyTwinsToolStripMenuItem_Click);
            // 
            // lilianToolStripMenuItem
            // 
            this.lilianToolStripMenuItem.Name = "lilianToolStripMenuItem";
            this.lilianToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.lilianToolStripMenuItem.Text = "Lilian";
            this.lilianToolStripMenuItem.Click += new System.EventHandler(this.lilianToolStripMenuItem_Click);
            // 
            // theAsphaltWorldToolStripMenuItem
            // 
            this.theAsphaltWorldToolStripMenuItem.Name = "theAsphaltWorldToolStripMenuItem";
            this.theAsphaltWorldToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.theAsphaltWorldToolStripMenuItem.Text = "The Asphalt World";
            this.theAsphaltWorldToolStripMenuItem.Click += new System.EventHandler(this.theAsphaltWorldToolStripMenuItem_Click);
            // 
            // iMaginaryToolStripMenuItem
            // 
            this.iMaginaryToolStripMenuItem.Name = "iMaginaryToolStripMenuItem";
            this.iMaginaryToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.iMaginaryToolStripMenuItem.Text = "iMaginary";
            this.iMaginaryToolStripMenuItem.Click += new System.EventHandler(this.iMaginaryToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabbedMdiManager1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "iMaginary";
            // 
            // MenuItem_DoanhThu
            // 
            this.MenuItem_DoanhThu.Name = "MenuItem_DoanhThu";
            this.MenuItem_DoanhThu.Size = new System.Drawing.Size(191, 22);
            this.MenuItem_DoanhThu.Text = "Doanh Thu";
            this.MenuItem_DoanhThu.Click += new System.EventHandler(this.MenuItem_DoanhThu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 449);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        public System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem loginLogoutMenu;
        private System.Windows.Forms.ToolStripMenuItem loginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenu;
        private System.Windows.Forms.ToolStripMenuItem customerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerGroupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentRoomBillMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactMenu;
        private System.Windows.Forms.ToolStripMenuItem checkOutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceMenu;
        private System.Windows.Forms.ToolStripMenuItem serviceOrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMenu;
        private System.Windows.Forms.ToolStripMenuItem searchCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCompanyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCustomerGroupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticMenu;
        private System.Windows.Forms.ToolStripMenuItem StatisticCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatisticRoomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementMenu;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.ToolStripMenuItem SkinMenu;
        private System.Windows.Forms.ToolStripMenuItem caramelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moneyTwinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lilianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookRoomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhiếuThuDoanKhachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuThuKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theAsphaltWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMaginaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_DoanhThu;
    }
}