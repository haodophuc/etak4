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
            this.mnuDemo = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_CapNhatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_DatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtĐoànKháchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDemo,
            this.traCứuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // mnuDemo
            // 
            this.mnuDemo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_CapNhatPhong,
            this.StripMenu_DatPhong,
            this.cậpNhậtKháchHàngToolStripMenuItem,
            this.cậpNhậtĐoànKháchToolStripMenuItem});
            this.mnuDemo.Name = "mnuDemo";
            this.mnuDemo.Size = new System.Drawing.Size(46, 20);
            this.mnuDemo.Text = "Demo";
            // 
            // StripMenu_CapNhatPhong
            // 
            this.StripMenu_CapNhatPhong.Name = "StripMenu_CapNhatPhong";
            this.StripMenu_CapNhatPhong.Size = new System.Drawing.Size(191, 22);
            this.StripMenu_CapNhatPhong.Text = "Cập Nhật Phòng";
            this.StripMenu_CapNhatPhong.Click += new System.EventHandler(this.StripMenu_CapNhatPhong_Click);
            // 
            // StripMenu_DatPhong
            // 
            this.StripMenu_DatPhong.Name = "StripMenu_DatPhong";
            this.StripMenu_DatPhong.Size = new System.Drawing.Size(191, 22);
            this.StripMenu_DatPhong.Text = "Đặt Phòng";
            this.StripMenu_DatPhong.Click += new System.EventHandler(this.StripMenu_DatPhong_Click);
            // 
            // cậpNhậtKháchHàngToolStripMenuItem
            // 
            this.cậpNhậtKháchHàngToolStripMenuItem.Name = "cậpNhậtKháchHàngToolStripMenuItem";
            this.cậpNhậtKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cậpNhậtKháchHàngToolStripMenuItem.Text = "Cập Nhật Khách Hàng";
            this.cậpNhậtKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtKháchHàngToolStripMenuItem_Click);
            // 
            // cậpNhậtĐoànKháchToolStripMenuItem
            // 
            this.cậpNhậtĐoànKháchToolStripMenuItem.Name = "cậpNhậtĐoànKháchToolStripMenuItem";
            this.cậpNhậtĐoànKháchToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cậpNhậtĐoànKháchToolStripMenuItem.Text = "Cập Nhật Đoàn Khách";
            this.cậpNhậtĐoànKháchToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtĐoànKháchToolStripMenuItem_Click);
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem});
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.traCứuToolStripMenuItem.Text = "Tra Cứu";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
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
    }
}