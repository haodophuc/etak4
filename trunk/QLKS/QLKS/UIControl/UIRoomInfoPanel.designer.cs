namespace QLKS.UIControl
{
    partial class UIRoomInfoPanel
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
            this.panelCenter = new QLKS.Controls.StyledPanel();
            this.textBoxRoomNumber = new QLKS.Controls.StyledTextBox();
            this.buttonDel = new QLKS.Controls.StyledButton();
            this.textBoxRoomType = new QLKS.Controls.StyledLookUpEdit();
            this.buttonAdd = new QLKS.Controls.StyledButton();
            this.textBoxBeds = new QLKS.Controls.StyledTextBox();
            this.labelQuatity = new System.Windows.Forms.Label();
            this.textBoxPrice = new QLKS.Controls.StyledTextBox();
            this.textBoxQuantity = new QLKS.Controls.StyledTextBox();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelBeds = new System.Windows.Forms.Label();
            this.buttonPick = new QLKS.Controls.StyledButton();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEditor)).BeginInit();
            this.panelEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCenter)).BeginInit();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRoomNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRoomType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBeds.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQuantity.Properties)).BeginInit();
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
            this.groupControl.Text = "Thông Tin Đăng Ký Phòng";
            // 
            // panelView
            // 
            this.panelView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(2, 238);
            this.panelView.LookAndFeel.SkinName = "Blue";
            this.panelView.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(726, 260);
            this.panelView.TabIndex = 1;
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
            this.panelEditor.Size = new System.Drawing.Size(726, 216);
            this.panelEditor.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCenter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelCenter.Controls.Add(this.textBoxRoomNumber);
            this.panelCenter.Controls.Add(this.buttonDel);
            this.panelCenter.Controls.Add(this.textBoxRoomType);
            this.panelCenter.Controls.Add(this.buttonAdd);
            this.panelCenter.Controls.Add(this.textBoxBeds);
            this.panelCenter.Controls.Add(this.labelQuatity);
            this.panelCenter.Controls.Add(this.textBoxPrice);
            this.panelCenter.Controls.Add(this.textBoxQuantity);
            this.panelCenter.Controls.Add(this.labelRoomType);
            this.panelCenter.Controls.Add(this.labelRoomNumber);
            this.panelCenter.Controls.Add(this.labelBeds);
            this.panelCenter.Controls.Add(this.buttonPick);
            this.panelCenter.Controls.Add(this.labelPrice);
            this.panelCenter.Location = new System.Drawing.Point(3, 3);
            this.panelCenter.LookAndFeel.SkinName = "Blue";
            this.panelCenter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(720, 210);
            this.panelCenter.TabIndex = 15;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(272, 45);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxRoomNumber.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxRoomNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxRoomNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxRoomNumber.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxRoomNumber.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxRoomNumber.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRoomNumber.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxRoomNumber.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxRoomNumber.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxRoomNumber.Properties.AutoHeight = false;
            this.textBoxRoomNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxRoomNumber.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxRoomNumber.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxRoomNumber.Properties.ReadOnly = true;
            this.textBoxRoomNumber.Size = new System.Drawing.Size(246, 20);
            this.textBoxRoomNumber.TabIndex = 1;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(612, 184);
            this.buttonDel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonDel.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(86, 23);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Xóa";
            // 
            // textBoxRoomType
            // 
            this.textBoxRoomType.Location = new System.Drawing.Point(272, 18);
            this.textBoxRoomType.Name = "textBoxRoomType";
            this.textBoxRoomType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textBoxRoomType.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxRoomType.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxRoomType.Properties.NullText = "Chọn Loại Phòng";
            this.textBoxRoomType.Properties.EditValueChanged += new System.EventHandler(this.textBoxRoomType_Properties_EditValueChanged);
            this.textBoxRoomType.Size = new System.Drawing.Size(246, 20);
            this.textBoxRoomType.TabIndex = 14;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(520, 184);
            this.buttonAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonAdd.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Thêm";
            // 
            // textBoxBeds
            // 
            this.textBoxBeds.Location = new System.Drawing.Point(272, 72);
            this.textBoxBeds.Name = "textBoxBeds";
            this.textBoxBeds.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxBeds.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxBeds.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxBeds.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxBeds.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxBeds.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxBeds.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxBeds.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxBeds.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxBeds.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxBeds.Properties.AutoHeight = false;
            this.textBoxBeds.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxBeds.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxBeds.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxBeds.Properties.ReadOnly = true;
            this.textBoxBeds.Size = new System.Drawing.Size(246, 20);
            this.textBoxBeds.TabIndex = 2;
            // 
            // labelQuatity
            // 
            this.labelQuatity.AutoSize = true;
            this.labelQuatity.Location = new System.Drawing.Point(149, 128);
            this.labelQuatity.Name = "labelQuatity";
            this.labelQuatity.Size = new System.Drawing.Size(107, 13);
            this.labelQuatity.TabIndex = 13;
            this.labelQuatity.Text = "Số Lượng Phòng Đặt";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(272, 99);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPrice.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxPrice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxPrice.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxPrice.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxPrice.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxPrice.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPrice.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxPrice.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxPrice.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxPrice.Properties.AutoHeight = false;
            this.textBoxPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxPrice.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxPrice.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxPrice.Properties.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(246, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(272, 125);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxQuantity.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxQuantity.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxQuantity.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxQuantity.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxQuantity.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxQuantity.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.textBoxQuantity.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxQuantity.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxQuantity.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxQuantity.Properties.AutoHeight = false;
            this.textBoxQuantity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxQuantity.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxQuantity.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxQuantity.Size = new System.Drawing.Size(246, 20);
            this.textBoxQuantity.TabIndex = 12;
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Location = new System.Drawing.Point(149, 21);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(61, 13);
            this.labelRoomType.TabIndex = 4;
            this.labelRoomType.Text = "Loại Phòng";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Location = new System.Drawing.Point(149, 48);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(54, 13);
            this.labelRoomNumber.TabIndex = 5;
            this.labelRoomNumber.Text = "Số Phòng";
            // 
            // labelBeds
            // 
            this.labelBeds.AutoSize = true;
            this.labelBeds.Location = new System.Drawing.Point(149, 75);
            this.labelBeds.Name = "labelBeds";
            this.labelBeds.Size = new System.Drawing.Size(57, 13);
            this.labelBeds.TabIndex = 6;
            this.labelBeds.Text = "Số Giường";
            // 
            // buttonPick
            // 
            this.buttonPick.Location = new System.Drawing.Point(272, 151);
            this.buttonPick.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonPick.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonPick.Name = "buttonPick";
            this.buttonPick.Size = new System.Drawing.Size(120, 40);
            this.buttonPick.TabIndex = 9;
            this.buttonPick.Text = "Chọn Phòng";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(149, 102);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(23, 13);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Giá";
            // 
            // UIRoomInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl);
            this.Name = "UIRoomInfoPanel";
            this.Size = new System.Drawing.Size(730, 500);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEditor)).EndInit();
            this.panelEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCenter)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRoomNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRoomType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBeds.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQuantity.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private Controls.StyledPanel panelEditor;
        private Controls.StyledPanel panelView;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelBeds;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelRoomType;
        private Controls.StyledTextBox textBoxPrice;
        private Controls.StyledTextBox textBoxBeds;
        private Controls.StyledTextBox textBoxRoomNumber;
        private Controls.StyledButton buttonPick;
        private Controls.StyledButton buttonDel;
        private Controls.StyledButton buttonAdd;
        private System.Windows.Forms.Label labelQuatity;
        private Controls.StyledTextBox textBoxQuantity;
        private QLKS.Controls.StyledLookUpEdit textBoxRoomType;
        private QLKS.Controls.StyledPanel panelCenter;
    }
}
