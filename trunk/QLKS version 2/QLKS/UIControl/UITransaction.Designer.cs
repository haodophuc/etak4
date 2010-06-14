namespace QLKS.UIControl
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
            this.panelAction = new QLKS.Controls.StyledPanel();
            this.buttonCancel = new QLKS.Controls.StyledButton();
            this.buttonCheckIn = new QLKS.Controls.StyledButton();
            this.buttonBooking = new QLKS.Controls.StyledButton();
            this.tabPageGroup = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageCustomer = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageRoom = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabContainer)).BeginInit();
            this.tabContainer.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAction)).BeginInit();
            this.panelAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.AppearancePage.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabContainer.AppearancePage.Header.Options.UseFont = true;
            this.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContainer.Location = new System.Drawing.Point(0, 0);
            this.tabContainer.LookAndFeel.SkinName = "Blue";
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedTabPage = this.tabPageGeneral;
            this.tabContainer.Size = new System.Drawing.Size(730, 584);
            this.tabContainer.TabIndex = 0;
            this.tabContainer.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageGeneral,
            this.tabPageGroup,
            this.tabPageCustomer,
            this.tabPageRoom});
            this.tabContainer.TabPageWidth = 150;
            this.tabContainer.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tabContainer_SelectedPageChanged);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.panelAction);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Size = new System.Drawing.Size(722, 553);
            this.tabPageGeneral.Text = "Thông Tin Chung";
            // 
            // panelAction
            // 
            this.panelAction.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelAction.Controls.Add(this.buttonCancel);
            this.panelAction.Controls.Add(this.buttonCheckIn);
            this.panelAction.Controls.Add(this.buttonBooking);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAction.Location = new System.Drawing.Point(0, 480);
            this.panelAction.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(722, 73);
            this.panelAction.TabIndex = 11;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancel.Location = new System.Drawing.Point(424, 17);
            this.buttonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonCancel.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 40);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCheckIn.Location = new System.Drawing.Point(205, 17);
            this.buttonCheckIn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonCheckIn.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(88, 40);
            this.buttonCheckIn.TabIndex = 8;
            this.buttonCheckIn.Text = "Đăng Ký Phòng";
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonBooking
            // 
            this.buttonBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBooking.Location = new System.Drawing.Point(314, 17);
            this.buttonBooking.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonBooking.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Size = new System.Drawing.Size(88, 40);
            this.buttonBooking.TabIndex = 9;
            this.buttonBooking.Text = "Đặt Phòng";
            this.buttonBooking.Click += new System.EventHandler(this.buttonBooking_Click);
            // 
            // tabPageGroup
            // 
            this.tabPageGroup.Name = "tabPageGroup";
            this.tabPageGroup.Size = new System.Drawing.Size(722, 553);
            this.tabPageGroup.Text = "Đoàn Khách";
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Size = new System.Drawing.Size(722, 553);
            this.tabPageCustomer.Text = "Khách Hàng";
            // 
            // tabPageRoom
            // 
            this.tabPageRoom.Name = "tabPageRoom";
            this.tabPageRoom.Size = new System.Drawing.Size(722, 553);
            this.tabPageRoom.Text = "Phòng";
            // 
            // UITransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabContainer);
            this.Name = "UITransaction";
            this.Size = new System.Drawing.Size(730, 584);
            ((System.ComponentModel.ISupportInitialize)(this.tabContainer)).EndInit();
            this.tabContainer.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAction)).EndInit();
            this.panelAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabContainer;
        private DevExpress.XtraTab.XtraTabPage tabPageGeneral;
        private DevExpress.XtraTab.XtraTabPage tabPageGroup;
        private DevExpress.XtraTab.XtraTabPage tabPageCustomer;
        private DevExpress.XtraTab.XtraTabPage tabPageRoom;
        private QLKS.Controls.StyledPanel panelAction;
        private QLKS.Controls.StyledButton buttonCancel;
        private QLKS.Controls.StyledButton buttonCheckIn;
        private QLKS.Controls.StyledButton buttonBooking;
    }
}
