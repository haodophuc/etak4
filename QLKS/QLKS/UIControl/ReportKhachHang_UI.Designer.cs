namespace QLKS.UIControl
{
    partial class ReportKhachHang_UI
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_preview = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup_ReportKH = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_ReportKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_Print);
            this.groupControl1.Controls.Add(this.btn_preview);
            this.groupControl1.Controls.Add(this.radioGroup_ReportKH);
            this.groupControl1.Location = new System.Drawing.Point(10, 10);
            this.groupControl1.LookAndFeel.SkinName = "Money Twins";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(407, 211);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Chọn một trong hai lựa chọn để xem hay in";
            // 
            // btn_Print
            // 
            this.btn_Print.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Appearance.Options.UseFont = true;
            this.btn_Print.Location = new System.Drawing.Point(218, 169);
            this.btn_Print.LookAndFeel.SkinName = "Money Twins";
            this.btn_Print.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(60, 23);
            this.btn_Print.TabIndex = 2;
            this.btn_Print.Text = "In";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.Appearance.Options.UseFont = true;
            this.btn_preview.Location = new System.Drawing.Point(117, 169);
            this.btn_preview.LookAndFeel.SkinName = "Money Twins";
            this.btn_preview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(60, 23);
            this.btn_preview.TabIndex = 1;
            this.btn_preview.Text = "Xem";
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // radioGroup_ReportKH
            // 
            this.radioGroup_ReportKH.Location = new System.Drawing.Point(18, 27);
            this.radioGroup_ReportKH.Name = "radioGroup_ReportKH";
            this.radioGroup_ReportKH.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.radioGroup_ReportKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup_ReportKH.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup_ReportKH.Properties.Appearance.Options.UseFont = true;
            this.radioGroup_ReportKH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup_ReportKH.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tổng số khách hàng dạng đơn giản"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tổng số khách hàng nhóm theo người đại diện phòng")});
            this.radioGroup_ReportKH.Properties.LookAndFeel.SkinName = "Money Twins";
            this.radioGroup_ReportKH.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.radioGroup_ReportKH.Size = new System.Drawing.Size(369, 126);
            this.radioGroup_ReportKH.TabIndex = 0;
            // 
            // ReportKhachHang_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.groupControl1);
            this.Name = "ReportKhachHang_UI";
            this.Size = new System.Drawing.Size(430, 234);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_ReportKH.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Print;
        private DevExpress.XtraEditors.SimpleButton btn_preview;
        private DevExpress.XtraEditors.RadioGroup radioGroup_ReportKH;
    }
}
