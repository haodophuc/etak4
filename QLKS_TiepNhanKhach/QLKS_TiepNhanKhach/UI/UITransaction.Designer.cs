namespace QLKS_TiepNhanKhach.UI
{
    partial class UITransaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabContainer = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageGroup = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageCustomer = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageRoom = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabContainer)).BeginInit();
            this.tabContainer.SuspendLayout();
            this.tabPageGroup.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            this.tabPageRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabContainer.AppearancePage.Header.Options.UseFont = true;
            this.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContainer.Location = new System.Drawing.Point(0, 0);
            this.tabContainer.LookAndFeel.SkinName = "Blue";
            this.tabContainer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedTabPage = this.tabPageGeneral;
            this.tabContainer.Size = new System.Drawing.Size(730, 530);
            this.tabContainer.TabIndex = 0;
            this.tabContainer.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageGeneral,
            this.tabPageGroup,
            this.tabPageCustomer,
            this.tabPageRoom});
            this.tabContainer.TabPageWidth = 150;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Size = new System.Drawing.Size(723, 500);
            this.tabPageGeneral.Text = "General";
            // 
            // tabPageGroup
            // 
            this.tabPageGroup.Name = "tabPageGroup";
            this.tabPageGroup.Size = new System.Drawing.Size(723, 500);
            this.tabPageGroup.Text = "Đoàn Khách";
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Size = new System.Drawing.Size(723, 500);
            this.tabPageCustomer.Text = "Khách Hàng";
            // 
            // tabPageRoom
            // 
            this.tabPageRoom.Name = "tabPageRoom";
            this.tabPageRoom.Size = new System.Drawing.Size(723, 500);
            this.tabPageRoom.Text = "Phòng";
            // 
            // UICheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabContainer);
            this.Name = "UICheckIn";
            this.Size = new System.Drawing.Size(730, 530);
            ((System.ComponentModel.ISupportInitialize)(this.tabContainer)).EndInit();
            this.tabContainer.ResumeLayout(false);
            this.tabPageGroup.ResumeLayout(false);
            this.tabPageCustomer.ResumeLayout(false);
            this.tabPageRoom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabContainer;
        private DevExpress.XtraTab.XtraTabPage tabPageGeneral;
        private DevExpress.XtraTab.XtraTabPage tabPageGroup;
        private DevExpress.XtraTab.XtraTabPage tabPageCustomer;
        private DevExpress.XtraTab.XtraTabPage tabPageRoom;
    }
}
