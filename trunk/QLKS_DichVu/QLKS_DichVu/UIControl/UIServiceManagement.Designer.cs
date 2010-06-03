namespace QLKS_DichVu.UIControl
{
    partial class UIServicesManagement
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
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.tabContainer = new DevExpress.XtraTab.XtraTabControl();
            this.tabAddService = new DevExpress.XtraTab.XtraTabPage();
            this.tabUpdateService = new DevExpress.XtraTab.XtraTabPage();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabContainer)).BeginInit();
            this.tabContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.tabContainer);
            this.mainContainer.Size = new System.Drawing.Size(580, 610);
            this.mainContainer.SplitterDistance = 406;
            this.mainContainer.TabIndex = 0;
            // 
            // tabContainer
            // 
            this.tabContainer.AppearancePage.Header.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tabContainer.AppearancePage.Header.Options.UseFont = true;
            this.tabContainer.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tabContainer.AppearancePage.HeaderActive.Options.UseFont = true;
            this.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContainer.Location = new System.Drawing.Point(0, 0);
            this.tabContainer.LookAndFeel.SkinName = "Blue";
            this.tabContainer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedTabPage = this.tabAddService;
            this.tabContainer.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.False;
            this.tabContainer.Size = new System.Drawing.Size(580, 200);
            this.tabContainer.TabIndex = 0;
            this.tabContainer.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabAddService,
            this.tabUpdateService});
            this.tabContainer.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tabContainer_SelectedPageChanged);
            // 
            // tabAddService
            // 
            this.tabAddService.Name = "tabAddService";
            this.tabAddService.Size = new System.Drawing.Size(573, 170);
            this.tabAddService.Text = "Thêm Dịch Vụ";
            // 
            // tabUpdateService
            // 
            this.tabUpdateService.Name = "tabUpdateService";
            this.tabUpdateService.Size = new System.Drawing.Size(573, 170);
            this.tabUpdateService.Text = "Cập Nhật Dịch Vụ";
            // 
            // UIServicesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "UIServicesManagement";
            this.Size = new System.Drawing.Size(580, 610);
            this.mainContainer.Panel2.ResumeLayout(false);
            this.mainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabContainer)).EndInit();
            this.tabContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private DevExpress.XtraTab.XtraTabControl tabContainer;
        private DevExpress.XtraTab.XtraTabPage tabAddService;
        private DevExpress.XtraTab.XtraTabPage tabUpdateService;

    }
}
