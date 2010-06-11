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
            this.panelInfo = new QLKS.Controls.StyledPanel();
            this.panelCenter = new QLKS.Controls.StyledPanel();
            this.labelGroupInfo = new DevExpress.XtraEditors.LabelControl();
            this.buttonCancel = new QLKS.Controls.StyledButton();
            this.buttonBooking = new QLKS.Controls.StyledButton();
            this.buttonCheckIn = new QLKS.Controls.StyledButton();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.labelCheckInDay = new DevExpress.XtraEditors.LabelControl();
            this.dateCheckOut = new DevExpress.XtraEditors.DateEdit();
            this.dateCheckIn = new DevExpress.XtraEditors.DateEdit();
            this.tabPageGroup = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageCustomer = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageRoom = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabContainer)).BeginInit();
            this.tabContainer.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelInfo)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCenter)).BeginInit();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckOut.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckIn.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckIn.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabContainer.AppearancePage.Header.Options.UseFont = true;
            this.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContainer.Location = new System.Drawing.Point(0, 0);
            this.tabContainer.LookAndFeel.SkinName = "Blue";
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
            this.tabContainer.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tabContainer_SelectedPageChanged);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.panelInfo);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Size = new System.Drawing.Size(723, 499);
            this.tabPageGeneral.Text = "General";
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelInfo.Controls.Add(this.panelCenter);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.LookAndFeel.SkinName = "Blue";
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(723, 499);
            this.panelInfo.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelCenter.Controls.Add(this.labelGroupInfo);
            this.panelCenter.Controls.Add(this.buttonCancel);
            this.panelCenter.Controls.Add(this.buttonBooking);
            this.panelCenter.Controls.Add(this.buttonCheckIn);
            this.panelCenter.Controls.Add(this.label2);
            this.panelCenter.Controls.Add(this.labelCheckInDay);
            this.panelCenter.Controls.Add(this.dateCheckOut);
            this.panelCenter.Controls.Add(this.dateCheckIn);
            this.panelCenter.Location = new System.Drawing.Point(3, 3);
            this.panelCenter.LookAndFeel.SkinName = "Blue";
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(716, 493);
            this.panelCenter.TabIndex = 1;
            // 
            // labelGroupInfo
            // 
            this.labelGroupInfo.Location = new System.Drawing.Point(143, 51);
            this.labelGroupInfo.LookAndFeel.SkinName = "Lilian";
            this.labelGroupInfo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelGroupInfo.Name = "labelGroupInfo";
            this.labelGroupInfo.Size = new System.Drawing.Size(103, 13);
            this.labelGroupInfo.TabIndex = 8;
            this.labelGroupInfo.Text = "Thông tin đoàn khách";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(414, 439);
            this.buttonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonCancel.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 40);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Hủy";
            // 
            // buttonBooking
            // 
            this.buttonBooking.Location = new System.Drawing.Point(304, 439);
            this.buttonBooking.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonBooking.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Size = new System.Drawing.Size(88, 40);
            this.buttonBooking.TabIndex = 6;
            this.buttonBooking.Text = "Đặt Phòng";
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Location = new System.Drawing.Point(195, 439);
            this.buttonCheckIn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonCheckIn.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(88, 40);
            this.buttonCheckIn.TabIndex = 5;
            this.buttonCheckIn.Text = "Đăng Ký Phòng";
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(143, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày Đi";
            // 
            // labelCheckInDay
            // 
            this.labelCheckInDay.Location = new System.Drawing.Point(143, 334);
            this.labelCheckInDay.Name = "labelCheckInDay";
            this.labelCheckInDay.Size = new System.Drawing.Size(48, 13);
            this.labelCheckInDay.TabIndex = 3;
            this.labelCheckInDay.Text = "Ngày Đến";
            // 
            // dateCheckOut
            // 
            this.dateCheckOut.EditValue = null;
            this.dateCheckOut.Location = new System.Drawing.Point(257, 357);
            this.dateCheckOut.Name = "dateCheckOut";
            this.dateCheckOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCheckOut.Properties.LookAndFeel.SkinName = "Blue";
            this.dateCheckOut.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateCheckOut.Size = new System.Drawing.Size(302, 20);
            this.dateCheckOut.TabIndex = 2;
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.EditValue = null;
            this.dateCheckIn.Location = new System.Drawing.Point(257, 331);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCheckIn.Properties.LookAndFeel.SkinName = "Blue";
            this.dateCheckIn.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateCheckIn.Size = new System.Drawing.Size(302, 20);
            this.dateCheckIn.TabIndex = 0;
            // 
            // tabPageGroup
            // 
            this.tabPageGroup.Name = "tabPageGroup";
            this.tabPageGroup.Size = new System.Drawing.Size(723, 499);
            this.tabPageGroup.Text = "Đoàn Khách";
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Size = new System.Drawing.Size(723, 499);
            this.tabPageCustomer.Text = "Khách Hàng";
            // 
            // tabPageRoom
            // 
            this.tabPageRoom.Name = "tabPageRoom";
            this.tabPageRoom.Size = new System.Drawing.Size(723, 499);
            this.tabPageRoom.Text = "Phòng";
            // 
            // UITransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabContainer);
            this.Name = "UITransaction";
            this.Size = new System.Drawing.Size(730, 530);
            ((System.ComponentModel.ISupportInitialize)(this.tabContainer)).EndInit();
            this.tabContainer.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelInfo)).EndInit();
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCenter)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckOut.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckIn.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckIn.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabContainer;
        private DevExpress.XtraTab.XtraTabPage tabPageGeneral;
        private DevExpress.XtraTab.XtraTabPage tabPageGroup;
        private DevExpress.XtraTab.XtraTabPage tabPageCustomer;
        private DevExpress.XtraTab.XtraTabPage tabPageRoom;
        private Controls.StyledPanel panelInfo;
        private Controls.StyledPanel panelCenter;
        private DevExpress.XtraEditors.DateEdit dateCheckIn;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl labelCheckInDay;
        private DevExpress.XtraEditors.DateEdit dateCheckOut;
        private Controls.StyledButton buttonCancel;
        private Controls.StyledButton buttonBooking;
        private Controls.StyledButton buttonCheckIn;
        private DevExpress.XtraEditors.LabelControl labelGroupInfo;
    }
}
