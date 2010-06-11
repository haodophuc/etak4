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
            this.radioButtonDisable = new DevExpress.XtraEditors.CheckEdit();
            this.radioButtonEnable = new DevExpress.XtraEditors.CheckEdit();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxServiceName = new DevExpress.XtraEditors.TextEdit();
            this.labelServiceState = new DevExpress.XtraEditors.LabelControl();
            this.labelServicePrice = new DevExpress.XtraEditors.LabelControl();
            this.labelServiceName = new DevExpress.XtraEditors.LabelControl();
            this.textBoxServicePrice = new QLKS.Controls.NumberTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUpdateService)).BeginInit();
            this.groupControlUpdateService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonDisable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxServiceName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxServicePrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlUpdateService
            // 
            this.groupControlUpdateService.AppearanceCaption.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupControlUpdateService.AppearanceCaption.Options.UseForeColor = true;
            this.groupControlUpdateService.Controls.Add(this.textBoxServicePrice);
            this.groupControlUpdateService.Controls.Add(this.buttonDelete);
            this.groupControlUpdateService.Controls.Add(this.radioButtonDisable);
            this.groupControlUpdateService.Controls.Add(this.radioButtonEnable);
            this.groupControlUpdateService.Controls.Add(this.buttonReset);
            this.groupControlUpdateService.Controls.Add(this.buttonUpdate);
            this.groupControlUpdateService.Controls.Add(this.textBoxServiceName);
            this.groupControlUpdateService.Controls.Add(this.labelServiceState);
            this.groupControlUpdateService.Controls.Add(this.labelServicePrice);
            this.groupControlUpdateService.Controls.Add(this.labelServiceName);
            this.groupControlUpdateService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlUpdateService.Location = new System.Drawing.Point(0, 0);
            this.groupControlUpdateService.LookAndFeel.SkinName = "Money Twins";
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
            this.radioButtonDisable.Location = new System.Drawing.Point(293, 93);
            this.radioButtonDisable.Name = "radioButtonDisable";
            this.radioButtonDisable.Properties.Caption = "Ngừng";
            this.radioButtonDisable.Size = new System.Drawing.Size(57, 19);
            this.radioButtonDisable.TabIndex = 8;
            // 
            // radioButtonEnable
            // 
            this.radioButtonEnable.Location = new System.Drawing.Point(181, 93);
            this.radioButtonEnable.Name = "radioButtonEnable";
            this.radioButtonEnable.Properties.Caption = "Đang Hoạt Động";
            this.radioButtonEnable.Size = new System.Drawing.Size(106, 19);
            this.radioButtonEnable.TabIndex = 7;
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
            this.labelServiceState.Location = new System.Drawing.Point(57, 95);
            this.labelServiceState.Name = "labelServiceState";
            this.labelServiceState.Size = new System.Drawing.Size(52, 13);
            this.labelServiceState.TabIndex = 2;
            this.labelServiceState.Text = "Hoạt Động";
            // 
            // labelServicePrice
            // 
            this.labelServicePrice.Location = new System.Drawing.Point(57, 64);
            this.labelServicePrice.Name = "labelServicePrice";
            this.labelServicePrice.Size = new System.Drawing.Size(38, 13);
            this.labelServicePrice.TabIndex = 1;
            this.labelServicePrice.Text = "Đơn Giá";
            // 
            // labelServiceName
            // 
            this.labelServiceName.Location = new System.Drawing.Point(57, 33);
            this.labelServiceName.Name = "labelServiceName";
            this.labelServiceName.Size = new System.Drawing.Size(56, 13);
            this.labelServiceName.TabIndex = 0;
            this.labelServiceName.Text = "Tên Dịch Vụ";
            // 
            // textBoxServicePrice
            // 
            this.textBoxServicePrice.AllowSpace = false;
            this.textBoxServicePrice.Length = 1;
            this.textBoxServicePrice.Location = new System.Drawing.Point(181, 61);
            this.textBoxServicePrice.Name = "textBoxServicePrice";
            this.textBoxServicePrice.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxServicePrice.Properties.Appearance.Options.UseBorderColor = true;
            this.textBoxServicePrice.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textBoxServicePrice.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxServicePrice.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Gray;
            this.textBoxServicePrice.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textBoxServicePrice.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textBoxServicePrice.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textBoxServicePrice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxServicePrice.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textBoxServicePrice.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.textBoxServicePrice.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxServicePrice.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxServicePrice.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textBoxServicePrice.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textBoxServicePrice.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.textBoxServicePrice.Properties.AutoHeight = false;
            this.textBoxServicePrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textBoxServicePrice.Properties.Mask.EditMask = "\\d{1,1}";
            this.textBoxServicePrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textBoxServicePrice.Properties.NullText = "Chưa có thông tin.";
            this.textBoxServicePrice.Size = new System.Drawing.Size(250, 20);
            this.textBoxServicePrice.TabIndex = 11;
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
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonDisable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxServiceName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxServicePrice.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    
        private DevExpress.XtraEditors.GroupControl groupControlUpdateService;
        private DevExpress.XtraEditors.LabelControl labelServicePrice;
        private DevExpress.XtraEditors.LabelControl labelServiceName;
        private DevExpress.XtraEditors.TextEdit textBoxServiceName;
        private DevExpress.XtraEditors.LabelControl labelServiceState;
        //private DevExpress.XtraEditors.TextEdit textBoxServicePrice;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonUpdate;
        private  DevExpress.XtraEditors.CheckEdit radioButtonDisable;
        private  DevExpress.XtraEditors.CheckEdit radioButtonEnable;
        private System.Windows.Forms.Button buttonDelete;
        private QLKS.Controls.NumberTextBox textBoxServicePrice;
    }
}
