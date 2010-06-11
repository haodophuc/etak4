namespace QLKS.UI
{
    partial class UserControlPanelForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.oldPasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.oldPasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordConfirmLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.submitButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(174, 38);
            this.userNameTextBox.MaxLength = 255;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(248, 23);
            this.userNameTextBox.TabIndex = 9;
            // 
            // oldPasswordTextBox1
            // 
            this.oldPasswordTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPasswordTextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordTextBox1.Location = new System.Drawing.Point(174, 78);
            this.oldPasswordTextBox1.MaxLength = 32;
            this.oldPasswordTextBox1.Name = "oldPasswordTextBox1";
            this.oldPasswordTextBox1.PasswordChar = '@';
            this.oldPasswordTextBox1.Size = new System.Drawing.Size(248, 23);
            this.oldPasswordTextBox1.TabIndex = 0;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(74, 41);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(94, 16);
            this.userNameLabel.TabIndex = 9;
            this.userNameLabel.Text = "Tên đăng nhập";
            // 
            // oldPasswordTextBox2
            // 
            this.oldPasswordTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPasswordTextBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordTextBox2.Location = new System.Drawing.Point(174, 121);
            this.oldPasswordTextBox2.MaxLength = 32;
            this.oldPasswordTextBox2.Name = "oldPasswordTextBox2";
            this.oldPasswordTextBox2.PasswordChar = '@';
            this.oldPasswordTextBox2.Size = new System.Drawing.Size(248, 23);
            this.oldPasswordTextBox2.TabIndex = 1;
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordLabel.Location = new System.Drawing.Point(91, 81);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(77, 16);
            this.oldPasswordLabel.TabIndex = 9;
            this.oldPasswordLabel.Text = "Mật khẩu cũ";
            // 
            // oldPasswordConfirmLabel
            // 
            this.oldPasswordConfirmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPasswordConfirmLabel.AutoSize = true;
            this.oldPasswordConfirmLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordConfirmLabel.Location = new System.Drawing.Point(40, 124);
            this.oldPasswordConfirmLabel.Name = "oldPasswordConfirmLabel";
            this.oldPasswordConfirmLabel.Size = new System.Drawing.Size(128, 16);
            this.oldPasswordConfirmLabel.TabIndex = 9;
            this.oldPasswordConfirmLabel.Text = "Nhập lại mật khẩu cũ";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextBox.Location = new System.Drawing.Point(174, 163);
            this.newPasswordTextBox.MaxLength = 32;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '@';
            this.newPasswordTextBox.Size = new System.Drawing.Size(248, 23);
            this.newPasswordTextBox.TabIndex = 2;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(83, 166);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(85, 16);
            this.newPasswordLabel.TabIndex = 9;
            this.newPasswordLabel.Text = "Mật khẩu mới";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.cancelButton);
            this.groupControl1.Controls.Add(this.submitButton);
            this.groupControl1.Controls.Add(this.userNameTextBox);
            this.groupControl1.Controls.Add(this.newPasswordLabel);
            this.groupControl1.Controls.Add(this.oldPasswordTextBox1);
            this.groupControl1.Controls.Add(this.oldPasswordConfirmLabel);
            this.groupControl1.Controls.Add(this.userNameLabel);
            this.groupControl1.Controls.Add(this.newPasswordTextBox);
            this.groupControl1.Controls.Add(this.oldPasswordLabel);
            this.groupControl1.Controls.Add(this.oldPasswordTextBox2);
            this.groupControl1.Location = new System.Drawing.Point(23, 30);
            this.groupControl1.LookAndFeel.SkinName = "Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(466, 253);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Đổi mật khẩu";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(310, 204);
            this.cancelButton.LookAndFeel.SkinName = "iMaginary";
            this.cancelButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 32);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Thoát";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(174, 204);
            this.submitButton.LookAndFeel.SkinName = "iMaginary";
            this.submitButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(112, 32);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Đổi";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // UserControlPanelForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(511, 326);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Lilian";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserControlPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Control Panel";
            this.Load += new System.EventHandler(this.UserControlPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox oldPasswordTextBox1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox oldPasswordTextBox2;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.Label oldPasswordConfirmLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton submitButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
    }
}