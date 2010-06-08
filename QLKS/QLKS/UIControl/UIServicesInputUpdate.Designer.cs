namespace QLKS.UIControl
{
    partial class UIServicesInputUpdate
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
            this.groupControlUpdateService = new DevExpress.XtraEditors.GroupControl();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.radioButtonDisable = new System.Windows.Forms.RadioButton();
            this.radioButtonEnable = new System.Windows.Forms.RadioButton();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxServicePrice = new QLKS.UIControl.NumberTextBox();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.labelServiceState = new System.Windows.Forms.Label();
            this.labelServicePrice = new System.Windows.Forms.Label();
            this.labelServiceName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUpdateService)).BeginInit();
            this.groupControlUpdateService.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlUpdateService
            // 
            this.groupControlUpdateService.AppearanceCaption.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupControlUpdateService.AppearanceCaption.Options.UseForeColor = true;
            this.groupControlUpdateService.Controls.Add(this.buttonDelete);
            this.groupControlUpdateService.Controls.Add(this.radioButtonDisable);
            this.groupControlUpdateService.Controls.Add(this.radioButtonEnable);
            this.groupControlUpdateService.Controls.Add(this.buttonReset);
            this.groupControlUpdateService.Controls.Add(this.buttonUpdate);
            this.groupControlUpdateService.Controls.Add(this.textBoxServicePrice);
            this.groupControlUpdateService.Controls.Add(this.textBoxServiceName);
            this.groupControlUpdateService.Controls.Add(this.labelServiceState);
            this.groupControlUpdateService.Controls.Add(this.labelServicePrice);
            this.groupControlUpdateService.Controls.Add(this.labelServiceName);
            this.groupControlUpdateService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlUpdateService.Location = new System.Drawing.Point(0, 0);
            this.groupControlUpdateService.LookAndFeel.SkinName = "Money Twins";
            this.groupControlUpdateService.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControlUpdateService.Name = "groupControlUpdateService";
            this.groupControlUpdateService.Size = new System.Drawing.Size(580, 170);
            this.groupControlUpdateService.TabIndex = 0;
            this.groupControlUpdateService.Text = "Cập nhật thông tin dịch vụ";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(267, 130);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 25);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Xóa Dịch Vụ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // radioButtonDisable
            // 
            this.radioButtonDisable.AutoSize = true;
            this.radioButtonDisable.Location = new System.Drawing.Point(293, 93);
            this.radioButtonDisable.Name = "radioButtonDisable";
            this.radioButtonDisable.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDisable.TabIndex = 8;
            this.radioButtonDisable.TabStop = true;
            this.radioButtonDisable.Text = "Ngừng";
            this.radioButtonDisable.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnable
            // 
            this.radioButtonEnable.AutoSize = true;
            this.radioButtonEnable.Location = new System.Drawing.Point(181, 93);
            this.radioButtonEnable.Name = "radioButtonEnable";
            this.radioButtonEnable.Size = new System.Drawing.Size(106, 17);
            this.radioButtonEnable.TabIndex = 7;
            this.radioButtonEnable.TabStop = true;
            this.radioButtonEnable.Text = "Đang Hoạt Động";
            this.radioButtonEnable.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(351, 130);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 25);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Hủy Thay Đổi";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(181, 122);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 40);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Cập Nhật";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxServicePrice
            // 
            this.textBoxServicePrice.Location = new System.Drawing.Point(181, 61);
            this.textBoxServicePrice.Name = "textBoxServicePrice";
            this.textBoxServicePrice.ShortcutsEnabled = false;
            this.textBoxServicePrice.Size = new System.Drawing.Size(250, 20);
            this.textBoxServicePrice.TabIndex = 4;
            this.textBoxServicePrice.TextChanged += new System.EventHandler(this.textBox_Changed);
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(181, 30);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceName.TabIndex = 3;
            this.textBoxServiceName.TextChanged += new System.EventHandler(this.textBox_Changed);
            // 
            // labelServiceState
            // 
            this.labelServiceState.AutoSize = true;
            this.labelServiceState.Location = new System.Drawing.Point(57, 95);
            this.labelServiceState.Name = "labelServiceState";
            this.labelServiceState.Size = new System.Drawing.Size(59, 13);
            this.labelServiceState.TabIndex = 2;
            this.labelServiceState.Text = "Hoạt Động";
            // 
            // labelServicePrice
            // 
            this.labelServicePrice.AutoSize = true;
            this.labelServicePrice.Location = new System.Drawing.Point(57, 64);
            this.labelServicePrice.Name = "labelServicePrice";
            this.labelServicePrice.Size = new System.Drawing.Size(46, 13);
            this.labelServicePrice.TabIndex = 1;
            this.labelServicePrice.Text = "Đơn Giá";
            // 
            // labelServiceName
            // 
            this.labelServiceName.AutoSize = true;
            this.labelServiceName.Location = new System.Drawing.Point(57, 33);
            this.labelServiceName.Name = "labelServiceName";
            this.labelServiceName.Size = new System.Drawing.Size(67, 13);
            this.labelServiceName.TabIndex = 0;
            this.labelServiceName.Text = "Tên Dịch Vụ";
            // 
            // UIServicesInputUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControlUpdateService);
            this.Name = "UIServicesInputUpdate";
            this.Size = new System.Drawing.Size(580, 170);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUpdateService)).EndInit();
            this.groupControlUpdateService.ResumeLayout(false);
            this.groupControlUpdateService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlUpdateService;
        private System.Windows.Forms.Label labelServicePrice;
        private System.Windows.Forms.Label labelServiceName;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.Label labelServiceState;
        //private System.Windows.Forms.TextBox textBoxServicePrice;
        private QLKS.UIControl.NumberTextBox textBoxServicePrice;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.RadioButton radioButtonDisable;
        private System.Windows.Forms.RadioButton radioButtonEnable;
        private System.Windows.Forms.Button buttonDelete;
    }
}
