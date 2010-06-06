namespace QLKS_TiepNhanKhach.UI
{
    partial class UIRoomInfoPanelcs
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
            this.panelView = new QLKS_TiepNhanKhach.Controls.StyledPanel();
            this.panelEditor = new QLKS_TiepNhanKhach.Controls.StyledPanel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelBeds = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.textBoxPrice = new QLKS_TiepNhanKhach.Controls.StyledTextBox();
            this.textBoxBeds = new QLKS_TiepNhanKhach.Controls.StyledTextBox();
            this.textBoxRoomNumber = new QLKS_TiepNhanKhach.Controls.StyledTextBox();
            this.textBoxRoomType = new QLKS_TiepNhanKhach.Controls.StyledComboBox();
            this.buttonPick = new QLKS_TiepNhanKhach.Controls.StyledButton();
            this.buttonAdd = new QLKS_TiepNhanKhach.Controls.StyledButton();
            this.buttonDel = new QLKS_TiepNhanKhach.Controls.StyledButton();
            this.styledTextBox1 = new QLKS_TiepNhanKhach.Controls.StyledTextBox();
            this.labelQuatity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEditor)).BeginInit();
            this.panelEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBeds.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRoomNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRoomType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styledTextBox1.Properties)).BeginInit();
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
            this.panelEditor.Controls.Add(this.labelQuatity);
            this.panelEditor.Controls.Add(this.styledTextBox1);
            this.panelEditor.Controls.Add(this.buttonDel);
            this.panelEditor.Controls.Add(this.buttonAdd);
            this.panelEditor.Controls.Add(this.buttonPick);
            this.panelEditor.Controls.Add(this.textBoxRoomType);
            this.panelEditor.Controls.Add(this.labelPrice);
            this.panelEditor.Controls.Add(this.labelBeds);
            this.panelEditor.Controls.Add(this.labelRoomNumber);
            this.panelEditor.Controls.Add(this.labelRoomType);
            this.panelEditor.Controls.Add(this.textBoxPrice);
            this.panelEditor.Controls.Add(this.textBoxBeds);
            this.panelEditor.Controls.Add(this.textBoxRoomNumber);
            this.panelEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEditor.Location = new System.Drawing.Point(2, 22);
            this.panelEditor.LookAndFeel.SkinName = "Blue";
            this.panelEditor.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(726, 216);
            this.panelEditor.TabIndex = 0;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(147, 107);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(23, 13);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Giá";
            // 
            // labelBeds
            // 
            this.labelBeds.AutoSize = true;
            this.labelBeds.Location = new System.Drawing.Point(147, 80);
            this.labelBeds.Name = "labelBeds";
            this.labelBeds.Size = new System.Drawing.Size(57, 13);
            this.labelBeds.TabIndex = 6;
            this.labelBeds.Text = "Số Giường";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Location = new System.Drawing.Point(147, 53);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(54, 13);
            this.labelRoomNumber.TabIndex = 5;
            this.labelRoomNumber.Text = "Số Phòng";
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Location = new System.Drawing.Point(147, 26);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(61, 13);
            this.labelRoomType.TabIndex = 4;
            this.labelRoomType.Text = "Loại Phòng";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(270, 104);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Properties.AutoHeight = false;
            this.textBoxPrice.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxPrice.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxPrice.Size = new System.Drawing.Size(246, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // textBoxBeds
            // 
            this.textBoxBeds.Location = new System.Drawing.Point(270, 77);
            this.textBoxBeds.Name = "textBoxBeds";
            this.textBoxBeds.Properties.AutoHeight = false;
            this.textBoxBeds.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxBeds.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxBeds.Size = new System.Drawing.Size(246, 20);
            this.textBoxBeds.TabIndex = 2;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(270, 50);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Properties.AutoHeight = false;
            this.textBoxRoomNumber.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxRoomNumber.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxRoomNumber.Size = new System.Drawing.Size(246, 20);
            this.textBoxRoomNumber.TabIndex = 1;
            // 
            // textBoxRoomType
            // 
            this.textBoxRoomType.Location = new System.Drawing.Point(270, 23);
            this.textBoxRoomType.Name = "textBoxRoomType";
            this.textBoxRoomType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textBoxRoomType.Properties.LookAndFeel.SkinName = "Blue";
            this.textBoxRoomType.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textBoxRoomType.Size = new System.Drawing.Size(246, 20);
            this.textBoxRoomType.TabIndex = 8;
            // 
            // buttonPick
            // 
            this.buttonPick.Location = new System.Drawing.Point(270, 156);
            this.buttonPick.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonPick.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonPick.Name = "buttonPick";
            this.buttonPick.Size = new System.Drawing.Size(120, 40);
            this.buttonPick.TabIndex = 9;
            this.buttonPick.Text = "Chọn Phòng";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(536, 187);
            this.buttonAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonAdd.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Thêm";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(628, 187);
            this.buttonDel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonDel.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(86, 23);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Xóa";
            // 
            // styledTextBox1
            // 
            this.styledTextBox1.Location = new System.Drawing.Point(270, 130);
            this.styledTextBox1.Name = "styledTextBox1";
            this.styledTextBox1.Properties.AutoHeight = false;
            this.styledTextBox1.Properties.LookAndFeel.SkinName = "Blue";
            this.styledTextBox1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.styledTextBox1.Size = new System.Drawing.Size(246, 20);
            this.styledTextBox1.TabIndex = 12;
            // 
            // labelQuatity
            // 
            this.labelQuatity.AutoSize = true;
            this.labelQuatity.Location = new System.Drawing.Point(147, 133);
            this.labelQuatity.Name = "labelQuatity";
            this.labelQuatity.Size = new System.Drawing.Size(87, 13);
            this.labelQuatity.TabIndex = 13;
            this.labelQuatity.Text = "Số Lượng Phòng";
            // 
            // UIRoomInfoPanelcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl);
            this.Name = "UIRoomInfoPanelcs";
            this.Size = new System.Drawing.Size(730, 500);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEditor)).EndInit();
            this.panelEditor.ResumeLayout(false);
            this.panelEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBeds.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRoomNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRoomType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styledTextBox1.Properties)).EndInit();
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
        private Controls.StyledComboBox textBoxRoomType;
        private Controls.StyledButton buttonPick;
        private Controls.StyledButton buttonDel;
        private Controls.StyledButton buttonAdd;
        private System.Windows.Forms.Label labelQuatity;
        private Controls.StyledTextBox styledTextBox1;
    }
}
