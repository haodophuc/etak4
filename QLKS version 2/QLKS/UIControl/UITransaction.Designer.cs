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
            this.panelInfo = new Controls.StyledPanel();
            this.panelControl = new Controls.StyledPanel();
            this.buttonCancel = new Controls.StyledButton();
            this.buttonBooking = new Controls.StyledButton();
            this.buttonCheckIn = new Controls.StyledButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
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
            this.tabContainer.LookAndFeel.UseDefaultLookAndFeel = true;
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
            this.tabPageGeneral.Controls.Add(this.panelControl);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Size = new System.Drawing.Size(723, 500);
            this.tabPageGeneral.Text = "General";
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.LookAndFeel.SkinName = "Blue";
            this.panelInfo.LookAndFeel.UseDefaultLookAndFeel = true;
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(723, 406);
            this.panelInfo.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl.Controls.Add(this.buttonCancel);
            this.panelControl.Controls.Add(this.buttonBooking);
            this.panelControl.Controls.Add(this.buttonCheckIn);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.labelCheckInDay);
            this.panelControl.Controls.Add(this.dateCheckOut);
            this.panelControl.Controls.Add(this.dateCheckIn);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 406);
            this.panelControl.LookAndFeel.SkinName = "Blue";
            this.panelControl.LookAndFeel.UseDefaultLookAndFeel = true;
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(723, 94);
            this.panelControl.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(586, 23);
            this.buttonCancel.LookAndFeel.UseDefaultLookAndFeel = true;
            this.buttonCancel.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 40);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Hủy";
            // 
            // buttonBooking
            // 
            this.buttonBooking.Location = new System.Drawing.Point(476, 23);
            this.buttonBooking.LookAndFeel.UseDefaultLookAndFeel = true;
            this.buttonBooking.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Size = new System.Drawing.Size(88, 40);
            this.buttonBooking.TabIndex = 6;
            this.buttonBooking.Text = "Đặt Phòng";
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Location = new System.Drawing.Point(367, 23);
            this.buttonCheckIn.LookAndFeel.UseDefaultLookAndFeel = true;
            this.buttonCheckIn.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(88, 40);
            this.buttonCheckIn.TabIndex = 5;
            this.buttonCheckIn.Text = "Đăng Ký Phòng";
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày Đi";
            // 
            // labelCheckInDay
            // 
            this.labelCheckInDay.AutoSize = true;
            this.labelCheckInDay.Location = new System.Drawing.Point(35, 23);
            this.labelCheckInDay.Name = "labelCheckInDay";
            this.labelCheckInDay.Size = new System.Drawing.Size(55, 13);
            this.labelCheckInDay.TabIndex = 3;
            this.labelCheckInDay.Text = "Ngày Đến";
            // 
            // dateCheckOut
            // 
            this.dateCheckOut.EditValue = null;
            this.dateCheckOut.Location = new System.Drawing.Point(110, 46);
            this.dateCheckOut.Name = "dateCheckOut";
            this.dateCheckOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCheckOut.Properties.LookAndFeel.SkinName = "Blue";
            this.dateCheckOut.Properties.LookAndFeel.UseDefaultLookAndFeel = true;
            this.dateCheckOut.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateCheckOut.Size = new System.Drawing.Size(207, 20);
            this.dateCheckOut.TabIndex = 2;
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.EditValue = null;
            this.dateCheckIn.Location = new System.Drawing.Point(110, 20);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCheckIn.Properties.LookAndFeel.SkinName = "Blue";
            this.dateCheckIn.Properties.LookAndFeel.UseDefaultLookAndFeel = true;
            this.dateCheckIn.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateCheckIn.Size = new System.Drawing.Size(207, 20);
            this.dateCheckIn.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
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
        private Controls.StyledPanel panelControl;
        private DevExpress.XtraEditors.DateEdit dateCheckIn;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl labelCheckInDay;
        private DevExpress.XtraEditors.DateEdit dateCheckOut;
        private Controls.StyledButton buttonCancel;
        private Controls.StyledButton buttonBooking;
        private Controls.StyledButton buttonCheckIn;
    }
}
