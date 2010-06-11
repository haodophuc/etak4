namespace QLKS.UIControl
{
    partial class UIGroupInfoPanel
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
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.panelCenter = new QLKS.Controls.StyledPanel();
            this.labelGroupID = new System.Windows.Forms.Label();
            this.textBoxAgentPhone = new QLKS.Controls.StyledTextBox();
            this.textBoxGroupID = new QLKS.Controls.StyledTextBox();
            this.textBoxAgent = new QLKS.Controls.StyledTextBox();
            this.buttonNewGroup = new QLKS.Controls.StyledButton();
            this.buttonLoadGroup = new QLKS.Controls.StyledButton();
            this.textBoxEmail = new QLKS.Controls.StyledTextBox();
            this.labelCheckInDay = new System.Windows.Forms.Label();
            this.labelAgentPhone = new System.Windows.Forms.Label();
            this.textBoxFax = new QLKS.Controls.StyledTextBox();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxPhone = new QLKS.Controls.StyledTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxCheckInDay = new QLKS.Controls.StyledTextBox();
            this.textBoxAddress = new QLKS.Controls.StyledTextBox();
            this.labelFax = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new QLKS.Controls.StyledTextBox();
            this.textBoxCountry = new QLKS.Controls.StyledTextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCenter)).BeginInit();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAgentPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAgent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCheckInDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCountry.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.panelCenter);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(730, 500);
            this.groupControl.TabIndex = 22;
            this.groupControl.Text = "Thông Tin Đoàn Khách";
            // 
            // panelCenter
            // 
            this.panelCenter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCenter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelCenter.Controls.Add(this.labelGroupID);
            this.panelCenter.Controls.Add(this.textBoxAgentPhone);
            this.panelCenter.Controls.Add(this.textBoxGroupID);
            this.panelCenter.Controls.Add(this.textBoxAgent);
            this.panelCenter.Controls.Add(this.buttonNewGroup);
            this.panelCenter.Controls.Add(this.buttonLoadGroup);
            this.panelCenter.Controls.Add(this.textBoxEmail);
            this.panelCenter.Controls.Add(this.labelCheckInDay);
            this.panelCenter.Controls.Add(this.labelAgentPhone);
            this.panelCenter.Controls.Add(this.textBoxFax);
            this.panelCenter.Controls.Add(this.labelAgent);
            this.panelCenter.Controls.Add(this.labelCompanyName);
            this.panelCenter.Controls.Add(this.textBoxPhone);
            this.panelCenter.Controls.Add(this.labelEmail);
            this.panelCenter.Controls.Add(this.labelCountry);
            this.panelCenter.Controls.Add(this.textBoxCheckInDay);
            this.panelCenter.Controls.Add(this.textBoxAddress);
            this.panelCenter.Controls.Add(this.labelFax);
            this.panelCenter.Controls.Add(this.labelAddress);
            this.panelCenter.Controls.Add(this.textBoxCompanyName);
            this.panelCenter.Controls.Add(this.textBoxCountry);
            this.panelCenter.Controls.Add(this.labelPhone);
            this.panelCenter.Location = new System.Drawing.Point(5, 25);
            this.panelCenter.LookAndFeel.SkinName = "Blue";
            this.panelCenter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(720, 470);
            this.panelCenter.TabIndex = 26;
            // 
            // labelGroupID
            // 
            this.labelGroupID.AutoSize = true;
            this.labelGroupID.Location = new System.Drawing.Point(92, 34);
            this.labelGroupID.Name = "labelGroupID";
            this.labelGroupID.Size = new System.Drawing.Size(85, 13);
            this.labelGroupID.TabIndex = 11;
            this.labelGroupID.Text = "Mã Đoàn Khách";
            // 
            // textBoxAgentPhone
            // 
            this.textBoxAgentPhone.Location = new System.Drawing.Point(247, 336);
            this.textBoxAgentPhone.Name = "textBoxAgentPhone";
            this.textBoxAgentPhone.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxAgentPhone.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxAgentPhone.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxAgentPhone.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxAgentPhone.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAgentPhone.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxAgentPhone.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxAgentPhone.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxAgentPhone.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxAgentPhone.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxAgentPhone.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxAgentPhone.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxAgentPhone.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAgentPhone.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxAgentPhone.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxAgentPhone.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxAgentPhone.Properties.AutoHeight = false;
            this.textBoxAgentPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxAgentPhone.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxAgentPhone.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxAgentPhone.Properties.NullText = "Chưa có thông tin.";
            this.textBoxAgentPhone.Properties.ReadOnly = true;
            this.textBoxAgentPhone.Size = new System.Drawing.Size(335, 20);
            this.textBoxAgentPhone.TabIndex = 10;
            // 
            // textBoxGroupID
            // 
            this.textBoxGroupID.Location = new System.Drawing.Point(247, 26);
            this.textBoxGroupID.Name = "textBoxGroupID";
            this.textBoxGroupID.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxGroupID.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxGroupID.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxGroupID.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxGroupID.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Gray;
            this.textBoxGroupID.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxGroupID.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxGroupID.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxGroupID.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxGroupID.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxGroupID.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxGroupID.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxGroupID.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxGroupID.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxGroupID.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxGroupID.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxGroupID.Properties.AutoHeight = false;
            this.textBoxGroupID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxGroupID.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxGroupID.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxGroupID.Properties.Mask.EditMask = "DK0000";
            this.textBoxGroupID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textBoxGroupID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textBoxGroupID.Properties.NullText = "Chưa có thông tin.";
            this.textBoxGroupID.Properties.ReadOnly = true;
            this.textBoxGroupID.Size = new System.Drawing.Size(335, 20);
            this.textBoxGroupID.TabIndex = 24;
            // 
            // textBoxAgent
            // 
            this.textBoxAgent.Location = new System.Drawing.Point(247, 310);
            this.textBoxAgent.Name = "textBoxAgent";
            this.textBoxAgent.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxAgent.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxAgent.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxAgent.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxAgent.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAgent.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxAgent.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxAgent.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxAgent.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxAgent.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxAgent.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxAgent.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxAgent.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAgent.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxAgent.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxAgent.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxAgent.Properties.AutoHeight = false;
            this.textBoxAgent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxAgent.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxAgent.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxAgent.Properties.NullText = "Chưa có thông tin.";
            this.textBoxAgent.Properties.ReadOnly = true;
            this.textBoxAgent.Size = new System.Drawing.Size(335, 20);
            this.textBoxAgent.TabIndex = 9;
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.Location = new System.Drawing.Point(373, 409);
            this.buttonNewGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonNewGroup.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(120, 40);
            this.buttonNewGroup.TabIndex = 23;
            this.buttonNewGroup.Text = "Đoàn Khách Mới";
            this.buttonNewGroup.Click += new System.EventHandler(this.buttonNewGroup_Click);
            // 
            // buttonLoadGroup
            // 
            this.buttonLoadGroup.Location = new System.Drawing.Point(247, 409);
            this.buttonLoadGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonLoadGroup.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonLoadGroup.Name = "buttonLoadGroup";
            this.buttonLoadGroup.Size = new System.Drawing.Size(120, 40);
            this.buttonLoadGroup.TabIndex = 22;
            this.buttonLoadGroup.Text = "Chọn Đoàn Khách";
            this.buttonLoadGroup.Click += new System.EventHandler(this.buttonLoadGroup_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(247, 254);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxEmail.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxEmail.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxEmail.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxEmail.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxEmail.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxEmail.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxEmail.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxEmail.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxEmail.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxEmail.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxEmail.Properties.AutoHeight = false;
            this.textBoxEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxEmail.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxEmail.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxEmail.Properties.NullText = "Chưa có thông tin.";
            this.textBoxEmail.Properties.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(335, 20);
            this.textBoxEmail.TabIndex = 8;
            // 
            // labelCheckInDay
            // 
            this.labelCheckInDay.AutoSize = true;
            this.labelCheckInDay.Location = new System.Drawing.Point(92, 55);
            this.labelCheckInDay.Name = "labelCheckInDay";
            this.labelCheckInDay.Size = new System.Drawing.Size(55, 13);
            this.labelCheckInDay.TabIndex = 13;
            this.labelCheckInDay.Text = "Ngày Đến";
            // 
            // labelAgentPhone
            // 
            this.labelAgentPhone.AutoSize = true;
            this.labelAgentPhone.Location = new System.Drawing.Point(92, 339);
            this.labelAgentPhone.Name = "labelAgentPhone";
            this.labelAgentPhone.Size = new System.Drawing.Size(75, 13);
            this.labelAgentPhone.TabIndex = 21;
            this.labelAgentPhone.Text = "Số Điện Thoại";
            // 
            // textBoxFax
            // 
            this.textBoxFax.Location = new System.Drawing.Point(247, 228);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxFax.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxFax.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxFax.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxFax.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFax.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxFax.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxFax.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxFax.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxFax.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxFax.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxFax.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxFax.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFax.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxFax.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxFax.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxFax.Properties.AutoHeight = false;
            this.textBoxFax.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxFax.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxFax.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxFax.Properties.NullText = "Chưa có thông tin.";
            this.textBoxFax.Properties.ReadOnly = true;
            this.textBoxFax.Size = new System.Drawing.Size(335, 20);
            this.textBoxFax.TabIndex = 7;
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Location = new System.Drawing.Point(92, 313);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(79, 13);
            this.labelAgent.TabIndex = 20;
            this.labelAgent.Text = "Người Đại Diện";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(92, 125);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(69, 13);
            this.labelCompanyName.TabIndex = 14;
            this.labelCompanyName.Text = "Tên Công Ty";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(247, 202);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPhone.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxPhone.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxPhone.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxPhone.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPhone.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxPhone.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxPhone.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxPhone.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxPhone.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxPhone.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxPhone.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxPhone.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPhone.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxPhone.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxPhone.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxPhone.Properties.AutoHeight = false;
            this.textBoxPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxPhone.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxPhone.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxPhone.Properties.NullText = "Chưa có thông tin.";
            this.textBoxPhone.Properties.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(335, 20);
            this.textBoxPhone.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(92, 257);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Email";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(92, 152);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(52, 13);
            this.labelCountry.TabIndex = 15;
            this.labelCountry.Text = "Quốc Gia";
            // 
            // textBoxCheckInDay
            // 
            this.textBoxCheckInDay.EditValue = "";
            this.textBoxCheckInDay.Location = new System.Drawing.Point(247, 52);
            this.textBoxCheckInDay.Name = "textBoxCheckInDay";
            this.textBoxCheckInDay.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxCheckInDay.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxCheckInDay.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxCheckInDay.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxCheckInDay.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCheckInDay.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxCheckInDay.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxCheckInDay.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxCheckInDay.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxCheckInDay.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxCheckInDay.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxCheckInDay.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxCheckInDay.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCheckInDay.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxCheckInDay.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxCheckInDay.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxCheckInDay.Properties.AutoHeight = false;
            this.textBoxCheckInDay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxCheckInDay.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxCheckInDay.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxCheckInDay.Properties.NullText = "Chưa có thông tin.";
            this.textBoxCheckInDay.Properties.ReadOnly = true;
            this.textBoxCheckInDay.Size = new System.Drawing.Size(335, 20);
            this.textBoxCheckInDay.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(247, 176);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxAddress.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxAddress.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxAddress.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxAddress.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAddress.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxAddress.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxAddress.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxAddress.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxAddress.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxAddress.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxAddress.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxAddress.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAddress.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxAddress.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxAddress.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxAddress.Properties.AutoHeight = false;
            this.textBoxAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxAddress.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxAddress.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxAddress.Properties.NullText = "Chưa có thông tin.";
            this.textBoxAddress.Properties.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(335, 20);
            this.textBoxAddress.TabIndex = 5;
            // 
            // labelFax
            // 
            this.labelFax.AutoSize = true;
            this.labelFax.Location = new System.Drawing.Point(92, 236);
            this.labelFax.Name = "labelFax";
            this.labelFax.Size = new System.Drawing.Size(24, 13);
            this.labelFax.TabIndex = 18;
            this.labelFax.Text = "Fax";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(92, 179);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(41, 13);
            this.labelAddress.TabIndex = 16;
            this.labelAddress.Text = "Địa Chỉ";
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(247, 122);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxCompanyName.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxCompanyName.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxCompanyName.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxCompanyName.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCompanyName.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxCompanyName.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxCompanyName.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxCompanyName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxCompanyName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxCompanyName.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxCompanyName.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxCompanyName.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCompanyName.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxCompanyName.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxCompanyName.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxCompanyName.Properties.AutoHeight = false;
            this.textBoxCompanyName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxCompanyName.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxCompanyName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxCompanyName.Properties.NullText = "Chưa có thông tin.";
            this.textBoxCompanyName.Properties.ReadOnly = true;
            this.textBoxCompanyName.Size = new System.Drawing.Size(335, 20);
            this.textBoxCompanyName.TabIndex = 3;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(247, 149);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxCountry.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxCountry.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxCountry.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxCountry.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCountry.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxCountry.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxCountry.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxCountry.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxCountry.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxCountry.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxCountry.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxCountry.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCountry.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxCountry.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxCountry.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxCountry.Properties.AutoHeight = false;
            this.textBoxCountry.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxCountry.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxCountry.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxCountry.Properties.NullText = "Chưa có thông tin.";
            this.textBoxCountry.Properties.ReadOnly = true;
            this.textBoxCountry.Size = new System.Drawing.Size(335, 20);
            this.textBoxCountry.TabIndex = 4;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(92, 205);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(75, 13);
            this.labelPhone.TabIndex = 17;
            this.labelPhone.Text = "Số Điện Thoại";
            // 
            // UIGroupInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl);
            this.Name = "UIGroupInfoPanel";
            this.Size = new System.Drawing.Size(730, 500);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCenter)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAgentPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAgent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCheckInDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCountry.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.StyledTextBox textBoxCheckInDay;
        private Controls.StyledTextBox textBoxCompanyName;
        private Controls.StyledTextBox textBoxCountry;
        private Controls.StyledTextBox textBoxAddress;
        private Controls.StyledTextBox textBoxPhone;
        private Controls.StyledTextBox textBoxFax;
        private Controls.StyledTextBox textBoxEmail;
        private Controls.StyledTextBox textBoxAgent;
        private Controls.StyledTextBox textBoxAgentPhone;
        private System.Windows.Forms.Label labelGroupID;
        private System.Windows.Forms.Label labelCheckInDay;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelFax;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelAgentPhone;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private Controls.StyledButton buttonNewGroup;
        private Controls.StyledButton buttonLoadGroup;
        private Controls.StyledTextBox textBoxGroupID;
        private Controls.StyledPanel panelCenter;
    }
}
