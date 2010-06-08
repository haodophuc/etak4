namespace QLKS.UIControl
{
    partial class UICustomerInfoPanel
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
            this.panelView = new QLKS.Controls.StyledPanel();
            this.panelEditor = new QLKS.Controls.StyledPanel();
            this.buttonDel = new QLKS.Controls.StyledButton();
            this.buttonAdd = new QLKS.Controls.StyledButton();
            this.buttonNew = new QLKS.Controls.StyledButton();
            this.buttonFind = new QLKS.Controls.StyledButton();
            this.textBoxPhone = new QLKS.Controls.NumberTextBox();
            this.textBoxPassPort = new QLKS.Controls.NumberTextBox();
            this.textBoxCMND = new QLKS.Controls.NumberTextBox();
            this.radioBtnPassPort = new System.Windows.Forms.RadioButton();
            this.radioBtnCMND = new System.Windows.Forms.RadioButton();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new QLKS.Controls.TextBoxCustomer();
            this.textBoxGender = new QLKS.Controls.StyledComboBox();
            this.textBoxCountry = new QLKS.Controls.StyledComboBox();
            this.textBoxLastName = new QLKS.Controls.StyledTextBox();
            this.textBoxFirstName = new QLKS.Controls.StyledTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEditor)).BeginInit();
            this.panelEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPassPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFirstName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.panelView);
            this.groupControl.Controls.Add(this.panelEditor);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.LookAndFeel.SkinName = "Blue";
            this.groupControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(730, 500);
            this.groupControl.TabIndex = 0;
            this.groupControl.Text = "Thông Tin Đăng Ký Khách Hàng";
            // 
            // panelView
            // 
            this.panelView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(2, 228);
            this.panelView.LookAndFeel.SkinName = "Blue";
            this.panelView.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(726, 270);
            this.panelView.TabIndex = 1;
            // 
            // panelEditor
            // 
            this.panelEditor.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelEditor.Controls.Add(this.buttonDel);
            this.panelEditor.Controls.Add(this.buttonAdd);
            this.panelEditor.Controls.Add(this.buttonNew);
            this.panelEditor.Controls.Add(this.buttonFind);
            this.panelEditor.Controls.Add(this.textBoxPhone);
            this.panelEditor.Controls.Add(this.textBoxPassPort);
            this.panelEditor.Controls.Add(this.textBoxCMND);
            this.panelEditor.Controls.Add(this.radioBtnPassPort);
            this.panelEditor.Controls.Add(this.radioBtnCMND);
            this.panelEditor.Controls.Add(this.labelPhone);
            this.panelEditor.Controls.Add(this.labelGender);
            this.panelEditor.Controls.Add(this.labelCountry);
            this.panelEditor.Controls.Add(this.labelLastName);
            this.panelEditor.Controls.Add(this.labelFirstName);
            this.panelEditor.Controls.Add(this.labelCustomerID);
            this.panelEditor.Controls.Add(this.textBoxCustomerID);
            this.panelEditor.Controls.Add(this.textBoxGender);
            this.panelEditor.Controls.Add(this.textBoxCountry);
            this.panelEditor.Controls.Add(this.textBoxLastName);
            this.panelEditor.Controls.Add(this.textBoxFirstName);
            this.panelEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEditor.Location = new System.Drawing.Point(2, 22);
            this.panelEditor.LookAndFeel.SkinName = "Blue";
            this.panelEditor.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(726, 206);
            this.panelEditor.TabIndex = 0;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(629, 173);
            this.buttonDel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonDel.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(86, 23);
            this.buttonDel.TabIndex = 25;
            this.buttonDel.Text = "Xóa";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(530, 173);
            this.buttonAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonAdd.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 23);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Thêm";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(243, 147);
            this.buttonNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonNew.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(120, 40);
            this.buttonNew.TabIndex = 23;
            this.buttonNew.Text = "Khách Hàng Mới";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(117, 147);
            this.buttonFind.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonFind.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(120, 40);
            this.buttonFind.TabIndex = 22;
            this.buttonFind.Text = "Tìm Kiếm";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.AllowSpace = false;
            this.textBoxPhone.Length = 10;
            this.textBoxPhone.Location = new System.Drawing.Point(469, 69);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPhone.Properties.Appearance.Options.UseBorderColor = true;
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
            this.textBoxPhone.Properties.Mask.EditMask = "\\d{1,10}";
            this.textBoxPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textBoxPhone.Size = new System.Drawing.Size(246, 20);
            this.textBoxPhone.TabIndex = 21;
            // 
            // textBoxPassPort
            // 
            this.textBoxPassPort.AllowSpace = false;
            this.textBoxPassPort.Length = 10;
            this.textBoxPassPort.Location = new System.Drawing.Point(117, 121);
            this.textBoxPassPort.Name = "textBoxPassPort";
            this.textBoxPassPort.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPassPort.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxPassPort.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxPassPort.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxPassPort.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxPassPort.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassPort.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassPort.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxPassPort.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxPassPort.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxPassPort.Properties.AutoHeight = false;
            this.textBoxPassPort.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxPassPort.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxPassPort.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxPassPort.Properties.Mask.EditMask = "\\d{1,10}";
            this.textBoxPassPort.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textBoxPassPort.Size = new System.Drawing.Size(246, 20);
            this.textBoxPassPort.TabIndex = 20;
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.AllowSpace = false;
            this.textBoxCMND.Length = 9;
            this.textBoxCMND.Location = new System.Drawing.Point(117, 95);
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxCMND.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxCMND.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxCMND.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxCMND.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxCMND.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxCMND.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCMND.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxCMND.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxCMND.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxCMND.Properties.AutoHeight = false;
            this.textBoxCMND.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxCMND.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxCMND.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxCMND.Properties.Mask.EditMask = "\\d{1,9}";
            this.textBoxCMND.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textBoxCMND.Size = new System.Drawing.Size(246, 20);
            this.textBoxCMND.TabIndex = 19;
            // 
            // radioBtnPassPort
            // 
            this.radioBtnPassPort.AutoSize = true;
            this.radioBtnPassPort.Location = new System.Drawing.Point(20, 122);
            this.radioBtnPassPort.Name = "radioBtnPassPort";
            this.radioBtnPassPort.Size = new System.Drawing.Size(69, 17);
            this.radioBtnPassPort.TabIndex = 18;
            this.radioBtnPassPort.TabStop = true;
            this.radioBtnPassPort.Text = "Hộ Chiếu";
            this.radioBtnPassPort.UseVisualStyleBackColor = true;
            // 
            // radioBtnCMND
            // 
            this.radioBtnCMND.AutoSize = true;
            this.radioBtnCMND.Location = new System.Drawing.Point(20, 96);
            this.radioBtnCMND.Name = "radioBtnCMND";
            this.radioBtnCMND.Size = new System.Drawing.Size(57, 17);
            this.radioBtnCMND.TabIndex = 17;
            this.radioBtnCMND.TabStop = true;
            this.radioBtnCMND.Text = "CMND";
            this.radioBtnCMND.UseVisualStyleBackColor = true;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(382, 72);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(75, 13);
            this.labelPhone.TabIndex = 16;
            this.labelPhone.Text = "Số Điện Thoại";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(382, 46);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(51, 13);
            this.labelGender.TabIndex = 15;
            this.labelGender.Text = "Giới Tính";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(382, 20);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(52, 13);
            this.labelCountry.TabIndex = 14;
            this.labelCountry.Text = "Quốc Gia";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(17, 45);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(84, 13);
            this.labelLastName.TabIndex = 11;
            this.labelLastName.Text = "Họ Khách Hàng";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(17, 72);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(89, 13);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "Tên Khách Hàng";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(17, 20);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(85, 13);
            this.labelCustomerID.TabIndex = 9;
            this.labelCustomerID.Text = "Mã Khách Hàng";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(117, 17);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxCustomerID.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxCustomerID.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxCustomerID.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxCustomerID.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxCustomerID.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxCustomerID.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCustomerID.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxCustomerID.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxCustomerID.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxCustomerID.Properties.AutoHeight = false;
            this.textBoxCustomerID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxCustomerID.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxCustomerID.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxCustomerID.Properties.Mask.EditMask = "KH0000";
            this.textBoxCustomerID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.textBoxCustomerID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textBoxCustomerID.Size = new System.Drawing.Size(246, 20);
            this.textBoxCustomerID.TabIndex = 8;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(469, 43);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textBoxGender.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.textBoxGender.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxGender.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxGender.Size = new System.Drawing.Size(246, 20);
            this.textBoxGender.TabIndex = 7;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(469, 17);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textBoxCountry.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxCountry.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxCountry.Size = new System.Drawing.Size(246, 20);
            this.textBoxCountry.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(117, 43);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxLastName.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxLastName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxLastName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxLastName.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxLastName.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxLastName.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLastName.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxLastName.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxLastName.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxLastName.Properties.AutoHeight = false;
            this.textBoxLastName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxLastName.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxLastName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxLastName.Size = new System.Drawing.Size(246, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(117, 69);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxFirstName.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxFirstName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxFirstName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxFirstName.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxFirstName.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxFirstName.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFirstName.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxFirstName.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxFirstName.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxFirstName.Properties.AutoHeight = false;
            this.textBoxFirstName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxFirstName.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxFirstName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxFirstName.Size = new System.Drawing.Size(246, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // UICustomerInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl);
            this.Name = "UICustomerInfoPanel";
            this.Size = new System.Drawing.Size(730, 500);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEditor)).EndInit();
            this.panelEditor.ResumeLayout(false);
            this.panelEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPassPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFirstName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private Controls.StyledPanel panelView;
        private Controls.StyledPanel panelEditor;
        private Controls.StyledComboBox textBoxGender;
        private Controls.StyledComboBox textBoxCountry;
        private Controls.StyledTextBox textBoxLastName;
        private Controls.StyledTextBox textBoxFirstName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelCustomerID;
        private Controls.TextBoxCustomer textBoxCustomerID;
        private System.Windows.Forms.RadioButton radioBtnPassPort;
        private System.Windows.Forms.RadioButton radioBtnCMND;
        private Controls.NumberTextBox textBoxPhone;
        private Controls.NumberTextBox textBoxPassPort;
        private Controls.NumberTextBox textBoxCMND;
        private Controls.StyledButton buttonFind;
        private Controls.StyledButton buttonNew;
        private Controls.StyledButton buttonAdd;
        private Controls.StyledButton buttonDel;
    }
}
