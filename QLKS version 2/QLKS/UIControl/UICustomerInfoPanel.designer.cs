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
            this.textBoxCountry.Properties.NullText = "Chọn quốc gia";
            this.textBoxCountry.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.textBoxCountry.Size = new System.Drawing.Size(246, 20);
            this.textBoxCountry.TabIndex = 7;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(629, 173);
            this.buttonDel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonDel.LookAndFeel.UseWindowsXPTheme = true;
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(86, 23);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "Xóa";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(530, 173);
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
            this.textBoxCustomerID.Properties.ReadOnly = true;
            this.textBoxCustomerID.Size = new System.Drawing.Size(246, 20);
            this.textBoxCustomerID.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(117, 43);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Properties.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(246, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(117, 69);
            this.textBoxFirstName.Name = "textBoxFirstName";
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
    }
}
