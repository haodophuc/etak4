namespace QLKS.UIControl
{
    partial class UIGeneralInfo
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
            this.panelInfo = new QLKS.Controls.StyledPanel();
            this.panelCenter = new QLKS.Controls.StyledPanel();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.groupDate = new DevExpress.XtraEditors.GroupControl();
            this.labelNumOfDays = new DevExpress.XtraEditors.LabelControl();
            this.textBoxNumOfDays = new DevExpress.XtraEditors.SpinEdit();
            this.labelCheckInDay = new DevExpress.XtraEditors.LabelControl();
            this.dateCheckIn = new DevExpress.XtraEditors.DateEdit();
            this.dateCheckOut = new DevExpress.XtraEditors.DateEdit();
            this.labelCheckoutDay = new DevExpress.XtraEditors.LabelControl();
            this.groupCustomerInfo = new DevExpress.XtraEditors.GroupControl();
            this.labelNumOfCustomers = new DevExpress.XtraEditors.LabelControl();
            this.groupGroupInfo = new DevExpress.XtraEditors.GroupControl();
            this.labelCompanyPhoneText = new DevExpress.XtraEditors.LabelControl();
            this.labelCompanyAddressText = new DevExpress.XtraEditors.LabelControl();
            this.labelCompanyNameText = new DevExpress.XtraEditors.LabelControl();
            this.labelCompanyPhone = new DevExpress.XtraEditors.LabelControl();
            this.labelCompanyAddress = new DevExpress.XtraEditors.LabelControl();
            this.labelCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.labelDepositText = new DevExpress.XtraEditors.LabelControl();
            this.labelBookedDayText = new DevExpress.XtraEditors.LabelControl();
            this.labelDeposit = new DevExpress.XtraEditors.LabelControl();
            this.labelBookedDay = new DevExpress.XtraEditors.LabelControl();
            this.labelGroupIDText = new DevExpress.XtraEditors.LabelControl();
            this.labelGroupID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelInfo)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCenter)).BeginInit();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDate)).BeginInit();
            this.groupDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumOfDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckIn.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckOut.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCustomerInfo)).BeginInit();
            this.groupCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGroupInfo)).BeginInit();
            this.groupGroupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelInfo.Controls.Add(this.panelCenter);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.LookAndFeel.SkinName = "Blue";
            this.panelInfo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(723, 564);
            this.panelInfo.TabIndex = 1;
            // 
            // panelCenter
            // 
            this.panelCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelCenter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelCenter.Controls.Add(this.labelTitle);
            this.panelCenter.Controls.Add(this.groupDate);
            this.panelCenter.Controls.Add(this.groupCustomerInfo);
            this.panelCenter.Controls.Add(this.groupGroupInfo);
            this.panelCenter.Location = new System.Drawing.Point(3, 3);
            this.panelCenter.LookAndFeel.SkinName = "Blue";
            this.panelCenter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(716, 558);
            this.panelCenter.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTitle.Appearance.Options.UseFont = true;
            this.labelTitle.Appearance.Options.UseForeColor = true;
            this.labelTitle.Location = new System.Drawing.Point(258, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(203, 32);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "ĐĂNG KÝ PHÒNG";
            // 
            // groupDate
            // 
            this.groupDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupDate.Controls.Add(this.labelNumOfDays);
            this.groupDate.Controls.Add(this.textBoxNumOfDays);
            this.groupDate.Controls.Add(this.labelCheckInDay);
            this.groupDate.Controls.Add(this.dateCheckIn);
            this.groupDate.Controls.Add(this.dateCheckOut);
            this.groupDate.Controls.Add(this.labelCheckoutDay);
            this.groupDate.Location = new System.Drawing.Point(81, 393);
            this.groupDate.Name = "groupDate";
            this.groupDate.Size = new System.Drawing.Size(560, 131);
            this.groupDate.TabIndex = 11;
            this.groupDate.Text = "Thời Gian Đăng Ký";
            // 
            // labelNumOfDays
            // 
            this.labelNumOfDays.Location = new System.Drawing.Point(42, 70);
            this.labelNumOfDays.Name = "labelNumOfDays";
            this.labelNumOfDays.Size = new System.Drawing.Size(40, 13);
            this.labelNumOfDays.TabIndex = 6;
            this.labelNumOfDays.Text = "Số Ngày";
            // 
            // textBoxNumOfDays
            // 
            this.textBoxNumOfDays.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBoxNumOfDays.Location = new System.Drawing.Point(156, 67);
            this.textBoxNumOfDays.Name = "textBoxNumOfDays";
            this.textBoxNumOfDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.textBoxNumOfDays.Size = new System.Drawing.Size(349, 20);
            this.textBoxNumOfDays.TabIndex = 5;
            // 
            // labelCheckInDay
            // 
            this.labelCheckInDay.Location = new System.Drawing.Point(42, 43);
            this.labelCheckInDay.Name = "labelCheckInDay";
            this.labelCheckInDay.Size = new System.Drawing.Size(48, 13);
            this.labelCheckInDay.TabIndex = 3;
            this.labelCheckInDay.Text = "Ngày Đến";
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.EditValue = null;
            this.dateCheckIn.Location = new System.Drawing.Point(156, 40);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCheckIn.Properties.LookAndFeel.SkinName = "Blue";
            this.dateCheckIn.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateCheckIn.Size = new System.Drawing.Size(349, 20);
            this.dateCheckIn.TabIndex = 0;
            // 
            // dateCheckOut
            // 
            this.dateCheckOut.EditValue = null;
            this.dateCheckOut.Location = new System.Drawing.Point(156, 93);
            this.dateCheckOut.Name = "dateCheckOut";
            this.dateCheckOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCheckOut.Properties.LookAndFeel.SkinName = "Blue";
            this.dateCheckOut.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateCheckOut.Size = new System.Drawing.Size(349, 20);
            this.dateCheckOut.TabIndex = 2;
            // 
            // labelCheckoutDay
            // 
            this.labelCheckoutDay.Location = new System.Drawing.Point(42, 96);
            this.labelCheckoutDay.Name = "labelCheckoutDay";
            this.labelCheckoutDay.Size = new System.Drawing.Size(38, 13);
            this.labelCheckoutDay.TabIndex = 4;
            this.labelCheckoutDay.Text = "Ngày Đi";
            // 
            // groupCustomerInfo
            // 
            this.groupCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupCustomerInfo.Controls.Add(this.labelNumOfCustomers);
            this.groupCustomerInfo.Location = new System.Drawing.Point(81, 242);
            this.groupCustomerInfo.Name = "groupCustomerInfo";
            this.groupCustomerInfo.Size = new System.Drawing.Size(560, 145);
            this.groupCustomerInfo.TabIndex = 10;
            this.groupCustomerInfo.Text = "Thông Tin Khách Hàng";
            // 
            // labelNumOfCustomers
            // 
            this.labelNumOfCustomers.Location = new System.Drawing.Point(42, 35);
            this.labelNumOfCustomers.Name = "labelNumOfCustomers";
            this.labelNumOfCustomers.Size = new System.Drawing.Size(141, 13);
            this.labelNumOfCustomers.TabIndex = 0;
            this.labelNumOfCustomers.Text = "Tổng cộng có {0} khách hàng";
            // 
            // groupGroupInfo
            // 
            this.groupGroupInfo.Controls.Add(this.labelCompanyPhoneText);
            this.groupGroupInfo.Controls.Add(this.labelCompanyAddressText);
            this.groupGroupInfo.Controls.Add(this.labelCompanyNameText);
            this.groupGroupInfo.Controls.Add(this.labelCompanyPhone);
            this.groupGroupInfo.Controls.Add(this.labelCompanyAddress);
            this.groupGroupInfo.Controls.Add(this.labelCompanyName);
            this.groupGroupInfo.Controls.Add(this.labelDepositText);
            this.groupGroupInfo.Controls.Add(this.labelBookedDayText);
            this.groupGroupInfo.Controls.Add(this.labelDeposit);
            this.groupGroupInfo.Controls.Add(this.labelBookedDay);
            this.groupGroupInfo.Controls.Add(this.labelGroupIDText);
            this.groupGroupInfo.Controls.Add(this.labelGroupID);
            this.groupGroupInfo.Location = new System.Drawing.Point(81, 51);
            this.groupGroupInfo.Name = "groupGroupInfo";
            this.groupGroupInfo.Size = new System.Drawing.Size(560, 185);
            this.groupGroupInfo.TabIndex = 9;
            this.groupGroupInfo.Text = "Thông Tin Đoàn Khách";
            // 
            // labelCompanyPhoneText
            // 
            this.labelCompanyPhoneText.Location = new System.Drawing.Point(148, 153);
            this.labelCompanyPhoneText.Name = "labelCompanyPhoneText";
            this.labelCompanyPhoneText.Size = new System.Drawing.Size(90, 13);
            this.labelCompanyPhoneText.TabIndex = 19;
            this.labelCompanyPhoneText.Text = "Không có thông tin";
            // 
            // labelCompanyAddressText
            // 
            this.labelCompanyAddressText.Location = new System.Drawing.Point(148, 133);
            this.labelCompanyAddressText.Name = "labelCompanyAddressText";
            this.labelCompanyAddressText.Size = new System.Drawing.Size(90, 13);
            this.labelCompanyAddressText.TabIndex = 18;
            this.labelCompanyAddressText.Text = "Không có thông tin";
            // 
            // labelCompanyNameText
            // 
            this.labelCompanyNameText.Location = new System.Drawing.Point(148, 114);
            this.labelCompanyNameText.Name = "labelCompanyNameText";
            this.labelCompanyNameText.Size = new System.Drawing.Size(90, 13);
            this.labelCompanyNameText.TabIndex = 17;
            this.labelCompanyNameText.Text = "Không có thông tin";
            // 
            // labelCompanyPhone
            // 
            this.labelCompanyPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCompanyPhone.Appearance.Options.UseFont = true;
            this.labelCompanyPhone.Location = new System.Drawing.Point(41, 153);
            this.labelCompanyPhone.Name = "labelCompanyPhone";
            this.labelCompanyPhone.Size = new System.Drawing.Size(60, 13);
            this.labelCompanyPhone.TabIndex = 16;
            this.labelCompanyPhone.Text = "Điện Thoại";
            // 
            // labelCompanyAddress
            // 
            this.labelCompanyAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCompanyAddress.Appearance.Options.UseFont = true;
            this.labelCompanyAddress.Location = new System.Drawing.Point(41, 134);
            this.labelCompanyAddress.Name = "labelCompanyAddress";
            this.labelCompanyAddress.Size = new System.Drawing.Size(39, 13);
            this.labelCompanyAddress.TabIndex = 15;
            this.labelCompanyAddress.Text = "Địa Chỉ";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCompanyName.Appearance.Options.UseFont = true;
            this.labelCompanyName.Location = new System.Drawing.Point(41, 114);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(69, 13);
            this.labelCompanyName.TabIndex = 14;
            this.labelCompanyName.Text = "Tên Công Ty";
            // 
            // labelDepositText
            // 
            this.labelDepositText.Location = new System.Drawing.Point(148, 75);
            this.labelDepositText.Name = "labelDepositText";
            this.labelDepositText.Size = new System.Drawing.Size(90, 13);
            this.labelDepositText.TabIndex = 13;
            this.labelDepositText.Text = "Không có thông tin";
            // 
            // labelBookedDayText
            // 
            this.labelBookedDayText.Location = new System.Drawing.Point(148, 56);
            this.labelBookedDayText.Name = "labelBookedDayText";
            this.labelBookedDayText.Size = new System.Drawing.Size(90, 13);
            this.labelBookedDayText.TabIndex = 12;
            this.labelBookedDayText.Text = "Không có thông tin";
            // 
            // labelDeposit
            // 
            this.labelDeposit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelDeposit.Appearance.Options.UseFont = true;
            this.labelDeposit.Location = new System.Drawing.Point(42, 75);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(47, 13);
            this.labelDeposit.TabIndex = 11;
            this.labelDeposit.Text = "Tiền Cọc";
            // 
            // labelBookedDay
            // 
            this.labelBookedDay.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelBookedDay.Appearance.Options.UseFont = true;
            this.labelBookedDay.Location = new System.Drawing.Point(42, 56);
            this.labelBookedDay.Name = "labelBookedDay";
            this.labelBookedDay.Size = new System.Drawing.Size(57, 13);
            this.labelBookedDay.TabIndex = 10;
            this.labelBookedDay.Text = "Ngày Đến ";
            // 
            // labelGroupIDText
            // 
            this.labelGroupIDText.Location = new System.Drawing.Point(148, 36);
            this.labelGroupIDText.Name = "labelGroupIDText";
            this.labelGroupIDText.Size = new System.Drawing.Size(90, 13);
            this.labelGroupIDText.TabIndex = 9;
            this.labelGroupIDText.Text = "Không có thông tin";
            // 
            // labelGroupID
            // 
            this.labelGroupID.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelGroupID.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelGroupID.Appearance.Options.UseFont = true;
            this.labelGroupID.Appearance.Options.UseForeColor = true;
            this.labelGroupID.Location = new System.Drawing.Point(42, 36);
            this.labelGroupID.LookAndFeel.SkinName = "Lilian";
            this.labelGroupID.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelGroupID.Name = "labelGroupID";
            this.labelGroupID.Size = new System.Drawing.Size(87, 13);
            this.labelGroupID.TabIndex = 8;
            this.labelGroupID.Text = "Mã Đoàn Khách";
            // 
            // UIGeneralInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelInfo);
            this.Name = "UIGeneralInfo";
            this.Size = new System.Drawing.Size(723, 564);
            ((System.ComponentModel.ISupportInitialize)(this.panelInfo)).EndInit();
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCenter)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDate)).EndInit();
            this.groupDate.ResumeLayout(false);
            this.groupDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumOfDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckIn.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckOut.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCustomerInfo)).EndInit();
            this.groupCustomerInfo.ResumeLayout(false);
            this.groupCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGroupInfo)).EndInit();
            this.groupGroupInfo.ResumeLayout(false);
            this.groupGroupInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QLKS.Controls.StyledPanel panelInfo;
        private QLKS.Controls.StyledPanel panelCenter;
        private DevExpress.XtraEditors.LabelControl labelTitle;
        private DevExpress.XtraEditors.GroupControl groupDate;
        private DevExpress.XtraEditors.LabelControl labelNumOfDays;
        private DevExpress.XtraEditors.SpinEdit textBoxNumOfDays;
        private DevExpress.XtraEditors.LabelControl labelCheckInDay;
        private DevExpress.XtraEditors.DateEdit dateCheckIn;
        private DevExpress.XtraEditors.DateEdit dateCheckOut;
        private DevExpress.XtraEditors.LabelControl labelCheckoutDay;
        private DevExpress.XtraEditors.GroupControl groupCustomerInfo;
        private DevExpress.XtraEditors.GroupControl groupGroupInfo;
        private DevExpress.XtraEditors.LabelControl labelCompanyPhoneText;
        private DevExpress.XtraEditors.LabelControl labelCompanyAddressText;
        private DevExpress.XtraEditors.LabelControl labelCompanyNameText;
        private DevExpress.XtraEditors.LabelControl labelCompanyPhone;
        private DevExpress.XtraEditors.LabelControl labelCompanyAddress;
        private DevExpress.XtraEditors.LabelControl labelCompanyName;
        private DevExpress.XtraEditors.LabelControl labelDepositText;
        private DevExpress.XtraEditors.LabelControl labelBookedDayText;
        private DevExpress.XtraEditors.LabelControl labelDeposit;
        private DevExpress.XtraEditors.LabelControl labelBookedDay;
        private DevExpress.XtraEditors.LabelControl labelGroupIDText;
        private DevExpress.XtraEditors.LabelControl labelGroupID;
        private DevExpress.XtraEditors.LabelControl labelNumOfCustomers;
    }
}
