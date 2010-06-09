namespace QLKS.UI
{
    partial class LoginForm
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
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new DevExpress.XtraEditors.GroupControl();
            this.passwordTextBox = new DevExpress.XtraEditors.TextEdit();
            this.usernameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Appearance.Options.UseFont = true;
            this.label3.Location = new System.Drawing.Point(16, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passwordTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.usernameTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(21, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "Login";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.EditValue = "hieu";
            this.passwordTextBox.Location = new System.Drawing.Point(152, 77);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Properties.Appearance.Options.UseFont = true;
            this.passwordTextBox.Properties.Mask.EditMask = "*";
            this.passwordTextBox.Properties.MaxLength = 20;
            this.passwordTextBox.Properties.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(157, 26);
            this.passwordTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.EditValue = "hieu";
            this.usernameTextBox.Location = new System.Drawing.Point(152, 29);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Properties.Appearance.Options.UseFont = true;
            this.usernameTextBox.Properties.MaxLength = 50;
            this.usernameTextBox.Size = new System.Drawing.Size(157, 26);
            this.usernameTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Appearance.Options.UseFont = true;
            this.label4.Location = new System.Drawing.Point(16, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "User name";
            // 
            // label5
            // 
            this.label5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.label5.Appearance.Options.UseFont = true;
            this.label5.Appearance.Options.UseForeColor = true;
            this.label5.Location = new System.Drawing.Point(147, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Appearance.Options.UseFont = true;
            this.loginButton.Location = new System.Drawing.Point(173, 179);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(79, 29);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Appearance.Options.UseFont = true;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(270, 179);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(79, 29);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(371, 223);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label3;
        private  DevExpress.XtraEditors.GroupControl groupBox2;
        private DevExpress.XtraEditors.TextEdit passwordTextBox;
        private DevExpress.XtraEditors.TextEdit usernameTextBox;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraEditors.SimpleButton exitButton;
    }
}

