namespace QLKS_TiepNhanKhach.UI
{
    partial class UICheckIn
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
            this.groupPanel = new QLKS_TiepNhanKhach.UI.UIGroupInfoPanel();
            this.tabPageCustomer = new DevExpress.XtraTab.XtraTabPage();
            this.uiCustomerInfoPanel1 = new QLKS_TiepNhanKhach.UI.UICustomerInfoPanel();
            this.tabPageRoom = new DevExpress.XtraTab.XtraTabPage();
            this.uiRoomInfoPanelcs1 = new QLKS_TiepNhanKhach.UI.UIRoomInfoPanelcs();
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
            this.tabPageGroup.Controls.Add(this.groupPanel);
            this.tabPageGroup.Name = "tabPageGroup";
            this.tabPageGroup.Size = new System.Drawing.Size(723, 500);
            this.tabPageGroup.Text = "Đoàn Khách";
            // 
            // groupPanel
            // 
            this.groupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel.Location = new System.Drawing.Point(0, 0);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Size = new System.Drawing.Size(723, 500);
            this.groupPanel.TabIndex = 0;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.uiCustomerInfoPanel1);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Size = new System.Drawing.Size(723, 500);
            this.tabPageCustomer.Text = "Khách Hàng";
            // 
            // uiCustomerInfoPanel1
            // 
            this.uiCustomerInfoPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiCustomerInfoPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiCustomerInfoPanel1.Name = "uiCustomerInfoPanel1";
            this.uiCustomerInfoPanel1.Size = new System.Drawing.Size(723, 500);
            this.uiCustomerInfoPanel1.TabIndex = 0;
            // 
            // tabPageRoom
            // 
            this.tabPageRoom.Controls.Add(this.uiRoomInfoPanelcs1);
            this.tabPageRoom.Name = "tabPageRoom";
            this.tabPageRoom.Size = new System.Drawing.Size(723, 500);
            this.tabPageRoom.Text = "Phòng";
            // 
            // uiRoomInfoPanelcs1
            // 
            this.uiRoomInfoPanelcs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiRoomInfoPanelcs1.Location = new System.Drawing.Point(0, 0);
            this.uiRoomInfoPanelcs1.Name = "uiRoomInfoPanelcs1";
            this.uiRoomInfoPanelcs1.Size = new System.Drawing.Size(723, 500);
            this.uiRoomInfoPanelcs1.TabIndex = 0;
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
        private UIGroupInfoPanel groupPanel;
        private UICustomerInfoPanel uiCustomerInfoPanel1;
        private UIRoomInfoPanelcs uiRoomInfoPanelcs1;
    }
}
