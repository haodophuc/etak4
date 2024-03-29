namespace QLKS_TiepNhanKhach
{
    partial class Form_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDemo = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_CapNhatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_DatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtĐoànKháchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmVàChọnKháchHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngTyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đoànKháchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SoLuongKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTransaction,
            this.mnuDemo,
            this.traCứuToolStripMenuItem,
            this.thốToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // menuTransaction
            // 
            this.menuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCheckIn,
            this.menuItemBooking});
            this.menuTransaction.Name = "menuTransaction";
            this.menuTransaction.Size = new System.Drawing.Size(63, 20);
            this.menuTransaction.Text = "Giao Dịch";
            // 
            // menuItemCheckIn
            // 
            this.menuItemCheckIn.Name = "menuItemCheckIn";
            this.menuItemCheckIn.Size = new System.Drawing.Size(159, 22);
            this.menuItemCheckIn.Text = "Đăng Ký Phòng";
            this.menuItemCheckIn.Click += new System.EventHandler(this.menuItemCheckIn_Click);
            // 
            // menuItemBooking
            // 
            this.menuItemBooking.Name = "menuItemBooking";
            this.menuItemBooking.Size = new System.Drawing.Size(159, 22);
            this.menuItemBooking.Text = "Đặt Phòng";
            // 
            // mnuDemo
            // 
            this.mnuDemo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_CapNhatPhong,
            this.StripMenu_DatPhong,
            this.cậpNhậtKháchHàngToolStripMenuItem,
            this.cậpNhậtĐoànKháchToolStripMenuItem,
            this.tìmVàChọnKháchHangToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.mnuDemo.Name = "mnuDemo";
            this.mnuDemo.Size = new System.Drawing.Size(46, 20);
            this.mnuDemo.Text = "Demo";
            // 
            // StripMenu_CapNhatPhong
            // 
            this.StripMenu_CapNhatPhong.Name = "StripMenu_CapNhatPhong";
            this.StripMenu_CapNhatPhong.Size = new System.Drawing.Size(243, 22);
            this.StripMenu_CapNhatPhong.Text = "Cập Nhật Phòng";
            this.StripMenu_CapNhatPhong.Click += new System.EventHandler(this.StripMenu_CapNhatPhong_Click);
            // 
            // StripMenu_DatPhong
            // 
            this.StripMenu_DatPhong.Name = "StripMenu_DatPhong";
            this.StripMenu_DatPhong.Size = new System.Drawing.Size(243, 22);
            this.StripMenu_DatPhong.Text = "Đặt Phòng";
            this.StripMenu_DatPhong.Click += new System.EventHandler(this.StripMenu_DatPhong_Click);
            // 
            // cậpNhậtKháchHàngToolStripMenuItem
            // 
            this.cậpNhậtKháchHàngToolStripMenuItem.Name = "cậpNhậtKháchHàngToolStripMenuItem";
            this.cậpNhậtKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.cậpNhậtKháchHàngToolStripMenuItem.Text = "Cập Nhật Khách Hàng";
            this.cậpNhậtKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtKháchHàngToolStripMenuItem_Click);
            // 
            // cậpNhậtĐoànKháchToolStripMenuItem
            // 
            this.cậpNhậtĐoànKháchToolStripMenuItem.Name = "cậpNhậtĐoànKháchToolStripMenuItem";
            this.cậpNhậtĐoànKháchToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.cậpNhậtĐoànKháchToolStripMenuItem.Text = "Cập Nhật Đoàn Khách";
            this.cậpNhậtĐoànKháchToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtĐoànKháchToolStripMenuItem_Click);
            // 
            // tìmVàChọnKháchHangToolStripMenuItem
            // 
            this.tìmVàChọnKháchHangToolStripMenuItem.Name = "tìmVàChọnKháchHangToolStripMenuItem";
            this.tìmVàChọnKháchHangToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.tìmVàChọnKháchHangToolStripMenuItem.Text = "Tìm và chọn phong trong for Hau";
            this.tìmVàChọnKháchHangToolStripMenuItem.Click += new System.EventHandler(this.tìmVàChọnKháchHangToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.côngTyToolStripMenuItem,
            this.đoànKháchToolStripMenuItem});
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.traCứuToolStripMenuItem.Text = "Tra Cứu";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // côngTyToolStripMenuItem
            // 
            this.côngTyToolStripMenuItem.Name = "côngTyToolStripMenuItem";
            this.côngTyToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.côngTyToolStripMenuItem.Text = "Công Ty";
            this.côngTyToolStripMenuItem.Click += new System.EventHandler(this.côngTyToolStripMenuItem_Click);
            // 
            // đoànKháchToolStripMenuItem
            // 
            this.đoànKháchToolStripMenuItem.Name = "đoànKháchToolStripMenuItem";
            this.đoànKháchToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.đoànKháchToolStripMenuItem.Text = "Đoàn Khách";
            this.đoànKháchToolStripMenuItem.Click += new System.EventHandler(this.đoànKháchToolStripMenuItem_Click);
            // 
            // thốToolStripMenuItem
            // 
            this.thốToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_SoLuongKhach});
            this.thốToolStripMenuItem.Name = "thốToolStripMenuItem";
            this.thốToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.thốToolStripMenuItem.Text = "Thống Kê";
            // 
            // MenuItem_SoLuongKhach
            // 
            this.MenuItem_SoLuongKhach.Name = "MenuItem_SoLuongKhach";
            this.MenuItem_SoLuongKhach.Size = new System.Drawing.Size(162, 22);
            this.MenuItem_SoLuongKhach.Text = "Số Lượng Khách";
            this.MenuItem_SoLuongKhach.Click += new System.EventHandler(this.MenuItem_SoLuongKhach_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 319);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDemo;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_CapNhatPhong;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_DatPhong;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtĐoànKháchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmVàChọnKháchHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngTyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đoànKháchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTransaction;
        private System.Windows.Forms.ToolStripMenuItem menuItemCheckIn;
        private System.Windows.Forms.ToolStripMenuItem menuItemBooking;
        private System.Windows.Forms.ToolStripMenuItem thốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SoLuongKhach;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
    }
}