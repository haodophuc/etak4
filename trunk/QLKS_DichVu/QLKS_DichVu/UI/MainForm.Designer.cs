namespace QLKS_DichVu.UI
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuSM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRunSM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSR = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRunSR = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRunLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuSM,
            this.menuSR});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(657, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuSM
            // 
            this.menuSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRunSM});
            this.menuSM.Enabled = false;
            this.menuSM.Name = "menuSM";
            this.menuSM.Size = new System.Drawing.Size(97, 20);
            this.menuSM.Text = "Quản Lý Dịch Vụ";
            // 
            // menuItemRunSM
            // 
            this.menuItemRunSM.Name = "menuItemRunSM";
            this.menuItemRunSM.Size = new System.Drawing.Size(152, 22);
            this.menuItemRunSM.Text = "Run";
            this.menuItemRunSM.Click += new System.EventHandler(this.menuItemRunSM_Click);
            // 
            // menuSR
            // 
            this.menuSR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRunSR});
            this.menuSR.Enabled = false;
            this.menuSR.Name = "menuSR";
            this.menuSR.Size = new System.Drawing.Size(178, 20);
            this.menuSR.Text = "Đăng Ký Dịch Vụ cho Khách Hàng";
            // 
            // menuItemRunSR
            // 
            this.menuItemRunSR.Name = "menuItemRunSR";
            this.menuItemRunSR.Size = new System.Drawing.Size(152, 22);
            this.menuItemRunSR.Text = "Run";
            this.menuItemRunSR.Click += new System.EventHandler(this.menuItemRunSR_Click);
            // 
            // menuLogin
            // 
            this.menuLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRunLogin});
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(44, 20);
            this.menuLogin.Text = "Login";
            // 
            // menuItemRunLogin
            // 
            this.menuItemRunLogin.Name = "menuItemRunLogin";
            this.menuItemRunLogin.Size = new System.Drawing.Size(152, 22);
            this.menuItemRunLogin.Text = "Run";
            this.menuItemRunLogin.Click += new System.EventHandler(this.menuItemRunLogin_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(657, 444);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Sạn - Module Quản Lý Dịch Vụ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemRunSM;
        private System.Windows.Forms.ToolStripMenuItem menuItemRunSR;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem menuItemRunLogin;
        public System.Windows.Forms.ToolStripMenuItem menuSM;
        public System.Windows.Forms.ToolStripMenuItem menuSR;


    }
}