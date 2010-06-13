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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelEditor = new QLKS.Controls.StyledPanel();
            this.panelCenter = new QLKS.Controls.StyledPanel();
            this.buttonSetOwner = new QLKS.Controls.StyledButton();
            this.buttonCancel = new QLKS.Controls.StyledButton();
            this.labelPassPort = new System.Windows.Forms.Label();
            this.labelCMND = new System.Windows.Forms.Label();
            this.textBoxCountry = new QLKS.Controls.StyledLookUpEdit();
            this.buttonDel = new QLKS.Controls.StyledButton();
            this.buttonAdd = new QLKS.Controls.StyledButton();
            this.buttonNew = new QLKS.Controls.StyledButton();
            this.buttonFind = new QLKS.Controls.StyledButton();
            this.textBoxPhone = new QLKS.Controls.NumberTextBox();
            this.textBoxPassPort = new QLKS.Controls.NumberTextBox();
            this.textBoxCMND = new QLKS.Controls.NumberTextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new QLKS.Controls.TextBoxCustomer();
            this.textBoxLastName = new QLKS.Controls.StyledTextBox();
            this.textBoxFirstName = new QLKS.Controls.StyledTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelView)).BeginInit();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEditor)).BeginInit();
            this.panelEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCenter)).BeginInit();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPassPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCustomerID.Properties)).BeginInit();
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
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(730, 500);
            this.groupControl.TabIndex = 0;
            this.groupControl.Text = "Thông Tin Đăng Ký Khách Hàng";
            // 
            // panelView
            // 
            this.panelView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelView.Controls.Add(this.gridControl);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(2, 232);
            this.panelView.LookAndFeel.SkinName = "Blue";
            this.panelView.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(726, 266);
            this.panelView.TabIndex = 1;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(726, 266);
            this.gridControl.TabIndex = 0;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupPanelText = "Thông tin khách hàng thuê phòng";
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowFooter = true;
            // 
            // panelEditor
            // 
            this.panelEditor.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelEditor.Controls.Add(this.panelCenter);
            this.panelEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEditor.Location = new System.Drawing.Point(2, 22);
            this.panelEditor.LookAndFeel.SkinName = "Blue";
            this.panelEditor.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(726, 210);
            this.panelEditor.TabIndex = 2;
            // 
            // panelCenter
            // 
            this.panelCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCenter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelCenter.Controls.Add(this.buttonSetOwner);
            this.panelCenter.Controls.Add(this.buttonCancel);
            this.panelCenter.Controls.Add(this.labelPassPort);
            this.panelCenter.Controls.Add(this.labelCMND);
            this.panelCenter.Controls.Add(this.textBoxCountry);
            this.panelCenter.Controls.Add(this.buttonDel);
            this.panelCenter.Controls.Add(this.buttonAdd);
            this.panelCenter.Controls.Add(this.buttonNew);
            this.panelCenter.Controls.Add(this.buttonFind);
            this.panelCenter.Controls.Add(this.textBoxPhone);
            this.panelCenter.Controls.Add(this.textBoxPassPort);
            this.panelCenter.Controls.Add(this.textBoxCMND);
            this.panelCenter.Controls.Add(this.labelPhone);
            this.panelCenter.Controls.Add(this.labelCountry);
            this.panelCenter.Controls.Add(this.labelLastName);
            this.panelCenter.Controls.Add(this.labelFirstName);
            this.panelCenter.Controls.Add(this.labelCustomerID);
            this.panelCenter.Controls.Add(this.textBoxCustomerID);
            this.panelCenter.Controls.Add(this.textBoxLastName);
            this.panelCenter.Controls.Add(this.textBoxFirstName);
            this.panelCenter.Location = new System.Drawing.Point(3, 3);
            this.panelCenter.LookAndFeel.SkinName = "Blue";
            this.panelCenter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(720, 204);
            this.panelCenter.TabIndex = 0;
            // 
            // buttonSetOwner
            // 
            this.buttonSetOwner.Location = new System.Drawing.Point(537, 147);
            this.buttonSetOwner.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonSetOwner.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonSetOwner.Name = "buttonSetOwner";
            this.buttonSetOwner.Size = new System.Drawing.Size(178, 23);
            this.buttonSetOwner.TabIndex = 30;
            this.buttonSetOwner.Text = "Chọn Làm Người Thuê Phòng";
            this.buttonSetOwner.Click += new System.EventHandler(this.buttonSetOwner_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(369, 164);
            this.buttonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonCancel.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 23);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPassPort
            // 
            this.labelPassPort.AutoSize = true;
            this.labelPassPort.Location = new System.Drawing.Point(17, 124);
            this.labelPassPort.Name = "labelPassPort";
            this.labelPassPort.Size = new System.Drawing.Size(58, 13);
            this.labelPassPort.TabIndex = 28;
            this.labelPassPort.Text = "Hộ Chiếu *";
            // 
            // labelCMND
            // 
            this.labelCMND.AutoSize = true;
            this.labelCMND.Location = new System.Drawing.Point(17, 98);
            this.labelCMND.Name = "labelCMND";
            this.labelCMND.Size = new System.Drawing.Size(46, 13);
            this.labelCMND.TabIndex = 27;
            this.labelCMND.Text = "CMND *";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(469, 17);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textBoxCountry.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxCountry.Properties.NullText = "Chọn quốc gia";
            this.textBoxCountry.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.textBoxCountry.Size = new System.Drawing.Size(246, 20);
            this.textBoxCountry.TabIndex = 7;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(629, 176);
            this.buttonDel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonDel.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(86, 23);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "Xóa";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(537, 176);
            this.buttonAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonAdd.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(243, 147);
            this.buttonNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonNew.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(120, 40);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Khách Hàng Mới";
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(117, 147);
            this.buttonFind.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonFind.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(120, 40);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Tìm Kiếm";
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.AllowSpace = false;
            this.textBoxPhone.Length = 10;
            this.textBoxPhone.Location = new System.Drawing.Point(469, 42);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPhone.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxPhone.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxPhone.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPhone.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxPhone.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxPhone.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxPhone.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxPhone.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxPhone.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxPhone.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxPhone.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxPhone.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxPhone.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxPhone.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxPhone.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxPhone.Properties.AutoHeight = false;
            this.textBoxPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxPhone.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxPhone.Properties.Mask.EditMask = "\\d{1,10}";
            this.textBoxPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textBoxPhone.Properties.NullText = "Chưa có thông tin.";
            this.textBoxPhone.Properties.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(246, 20);
            this.textBoxPhone.TabIndex = 8;
            // 
            // textBoxPassPort
            // 
            this.textBoxPassPort.AllowSpace = false;
            this.textBoxPassPort.Length = 10;
            this.textBoxPassPort.Location = new System.Drawing.Point(117, 121);
            this.textBoxPassPort.Name = "textBoxPassPort";
            this.textBoxPassPort.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPassPort.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxPassPort.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxPassPort.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPassPort.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxPassPort.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxPassPort.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxPassPort.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxPassPort.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxPassPort.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxPassPort.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxPassPort.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassPort.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxPassPort.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxPassPort.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxPassPort.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxPassPort.Properties.AutoHeight = false;
            this.textBoxPassPort.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxPassPort.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxPassPort.Properties.Mask.EditMask = "\\d{1,10}";
            this.textBoxPassPort.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textBoxPassPort.Properties.NullText = "Chưa có thông tin.";
            this.textBoxPassPort.Properties.ReadOnly = true;
            this.textBoxPassPort.Size = new System.Drawing.Size(246, 20);
            this.textBoxPassPort.TabIndex = 6;
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.AllowSpace = false;
            this.textBoxCMND.Length = 9;
            this.textBoxCMND.Location = new System.Drawing.Point(117, 95);
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxCMND.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxCMND.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxCMND.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxCMND.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxCMND.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxCMND.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxCMND.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxCMND.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxCMND.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxCMND.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxCMND.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxCMND.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxCMND.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxCMND.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxCMND.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxCMND.Properties.AutoHeight = false;
            this.textBoxCMND.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxCMND.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxCMND.Properties.Mask.EditMask = "\\d{1,9}";
            this.textBoxCMND.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textBoxCMND.Properties.NullText = "Chưa có thông tin.";
            this.textBoxCMND.Properties.ReadOnly = true;
            this.textBoxCMND.Size = new System.Drawing.Size(246, 20);
            this.textBoxCMND.TabIndex = 5;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(382, 45);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(75, 13);
            this.labelPhone.TabIndex = 16;
            this.labelPhone.Text = "Số Điện Thoại";
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
            this.labelLastName.Size = new System.Drawing.Size(91, 13);
            this.labelLastName.TabIndex = 11;
            this.labelLastName.Text = "Họ Khách Hàng *";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(17, 72);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(96, 13);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "Tên Khách Hàng *";
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
            this.textBoxCustomerID.Enabled = false;
            this.textBoxCustomerID.Location = new System.Drawing.Point(117, 17);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxCustomerID.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxCustomerID.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxCustomerID.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxCustomerID.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxCustomerID.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxCustomerID.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxCustomerID.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxCustomerID.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxCustomerID.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxCustomerID.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxCustomerID.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxCustomerID.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxCustomerID.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxCustomerID.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxCustomerID.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxCustomerID.Properties.AutoHeight = false;
            this.textBoxCustomerID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxCustomerID.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxCustomerID.Properties.Mask.EditMask = "KH0000";
            this.textBoxCustomerID.Properties.Mask.IgnoreMaskBlank = false;
            this.textBoxCustomerID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textBoxCustomerID.Properties.Mask.SaveLiteral = false;
            this.textBoxCustomerID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textBoxCustomerID.Properties.NullText = "Mã Khách Hàng sẽ được tạo tự động.";
            this.textBoxCustomerID.Properties.ReadOnly = true;
            this.textBoxCustomerID.Size = new System.Drawing.Size(246, 20);
            this.textBoxCustomerID.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(117, 43);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxLastName.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxLastName.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxLastName.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxLastName.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxLastName.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxLastName.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxLastName.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxLastName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxLastName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxLastName.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxLastName.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxLastName.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxLastName.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxLastName.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxLastName.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxLastName.Properties.AutoHeight = false;
            this.textBoxLastName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxLastName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxLastName.Properties.NullText = "Chưa có thông tin.";
            this.textBoxLastName.Properties.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(246, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(117, 69);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxFirstName.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxFirstName.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxFirstName.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxFirstName.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxFirstName.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxFirstName.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxFirstName.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxFirstName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxFirstName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxFirstName.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxFirstName.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxFirstName.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxFirstName.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxFirstName.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxFirstName.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxFirstName.Properties.AutoHeight = false;
            this.textBoxFirstName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxFirstName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxFirstName.Properties.NullText = "Chưa có thông tin.";
            this.textBoxFirstName.Properties.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(246, 20);
            this.textBoxFirstName.TabIndex = 4;
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
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEditor)).EndInit();
            this.panelEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCenter)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPassPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFirstName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private Controls.StyledPanel panelView;
        private Controls.StyledPanel panelCenter;
        private Controls.StyledTextBox textBoxLastName;
        private Controls.StyledTextBox textBoxFirstName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelCustomerID;
        private Controls.TextBoxCustomer textBoxCustomerID;
        private Controls.NumberTextBox textBoxPhone;
        private Controls.NumberTextBox textBoxPassPort;
        private Controls.NumberTextBox textBoxCMND;
        private Controls.StyledButton buttonFind;
        private Controls.StyledButton buttonNew;
        private Controls.StyledButton buttonAdd;
        private Controls.StyledButton buttonDel;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private Controls.StyledPanel panelEditor;
        private Controls.StyledLookUpEdit textBoxCountry;
        private System.Windows.Forms.Label labelPassPort;
        private System.Windows.Forms.Label labelCMND;
        private Controls.StyledButton buttonCancel;
        private QLKS.Controls.StyledButton buttonSetOwner;
    }
}
