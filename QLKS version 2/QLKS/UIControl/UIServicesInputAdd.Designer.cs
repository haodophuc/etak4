namespace QLKS.UIControl
{
    partial class UIServicesInputAdd
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
            this.groupControlAddService = new DevExpress.XtraEditors.GroupControl();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new DevExpress.XtraEditors.TextEdit();
            this.labelServicePrice = new DevExpress.XtraEditors.LabelControl();
            this.labelServiceName = new DevExpress.XtraEditors.LabelControl();
            this.textBoxPrice = new QLKS.UIControl.NumberTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddService)).BeginInit();
            this.groupControlAddService.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlAddService
            // 
            this.groupControlAddService.AppearanceCaption.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupControlAddService.AppearanceCaption.Options.UseForeColor = true;
            this.groupControlAddService.Controls.Add(this.buttonReset);
            this.groupControlAddService.Controls.Add(this.buttonAdd);
            this.groupControlAddService.Controls.Add(this.textBoxPrice);
            this.groupControlAddService.Controls.Add(this.textBoxName);
            this.groupControlAddService.Controls.Add(this.labelServicePrice);
            this.groupControlAddService.Controls.Add(this.labelServiceName);
            this.groupControlAddService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlAddService.Location = new System.Drawing.Point(0, 0);
            this.groupControlAddService.LookAndFeel.SkinName = "Money Twins";
            this.groupControlAddService.LookAndFeel.UseDefaultLookAndFeel = true;
            this.groupControlAddService.Name = "groupControlAddService";
            this.groupControlAddService.Size = new System.Drawing.Size(580, 170);
            this.groupControlAddService.TabIndex = 0;
            this.groupControlAddService.Text = "Thêm mới một dịch vụ";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(267, 130);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 25);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Hủy";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(181, 122);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 40);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(181, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelServicePrice
            // 
            this.labelServicePrice.AutoSize = true;
            this.labelServicePrice.Location = new System.Drawing.Point(57, 61);
            this.labelServicePrice.Name = "labelServicePrice";
            this.labelServicePrice.Size = new System.Drawing.Size(46, 13);
            this.labelServicePrice.TabIndex = 1;
            this.labelServicePrice.Text = "Đơn Giá";
            // 
            // labelServiceName
            // 
            this.labelServiceName.Location = new System.Drawing.Point(57, 33);
            this.labelServiceName.Name = "labelServiceName";
            this.labelServiceName.Size = new System.Drawing.Size(67, 13);
            this.labelServiceName.TabIndex = 0;
            this.labelServiceName.Text = "Tên Dịch Vụ";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(181, 61);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ShortcutsEnabled = false;
            this.textBoxPrice.Size = new System.Drawing.Size(250, 20);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // UIServicesInputAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupControlAddService);
            this.Name = "UIServicesInputAdd";
            this.Size = new System.Drawing.Size(580, 170);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddService)).EndInit();
            this.groupControlAddService.ResumeLayout(false);
            this.groupControlAddService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlAddService;
        private DevExpress.XtraEditors.LabelControl labelServicePrice;
        private DevExpress.XtraEditors.LabelControl labelServiceName;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAdd;
        private QLKS.UIControl.NumberTextBox textBoxPrice;
        private DevExpress.XtraEditors.TextEdit textBoxName;

    }
}
