namespace QLKS.UIControl
{
    partial class ReportDoanhThu_UI
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
            this.labelControl_Year = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit_Year = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl_ViewMode = new DevExpress.XtraEditors.GroupControl();
            this.radioBtn_ChartMode = new DevExpress.XtraEditors.CheckEdit();
            this.radioBtn_TableMode = new DevExpress.XtraEditors.CheckEdit();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_preview = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_Year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ViewMode)).BeginInit();
            this.groupControl_ViewMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioBtn_ChartMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioBtn_TableMode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.labelControl_Year);
            this.groupControl1.Controls.Add(this.spinEdit_Year);
            this.groupControl1.Location = new System.Drawing.Point(12, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(311, 83);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chọn năm để xem doanh thu theo năm";
            // 
            // labelControl_Year
            // 
            this.labelControl_Year.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_Year.Appearance.Options.UseFont = true;
            this.labelControl_Year.Location = new System.Drawing.Point(82, 43);
            this.labelControl_Year.LookAndFeel.SkinName = "Money Twins";
            this.labelControl_Year.Name = "labelControl_Year";
            this.labelControl_Year.Size = new System.Drawing.Size(26, 16);
            this.labelControl_Year.TabIndex = 27;
            this.labelControl_Year.Text = "Năm";
            // 
            // spinEdit_Year
            // 
            this.spinEdit_Year.EditValue = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.spinEdit_Year.Location = new System.Drawing.Point(127, 38);
            this.spinEdit_Year.Name = "spinEdit_Year";
            this.spinEdit_Year.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit_Year.Properties.Appearance.Options.UseFont = true;
            this.spinEdit_Year.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit_Year.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit_Year.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit_Year.Properties.IsFloatValue = false;
            this.spinEdit_Year.Properties.LookAndFeel.SkinName = "Money Twins";
            this.spinEdit_Year.Properties.Mask.EditMask = "d";
            this.spinEdit_Year.Properties.MaxValue = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.spinEdit_Year.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit_Year.Size = new System.Drawing.Size(100, 22);
            this.spinEdit_Year.TabIndex = 26;
            // 
            // groupControl_ViewMode
            // 
            this.groupControl_ViewMode.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_ViewMode.AppearanceCaption.Options.UseFont = true;
            this.groupControl_ViewMode.Controls.Add(this.radioBtn_ChartMode);
            this.groupControl_ViewMode.Controls.Add(this.radioBtn_TableMode);
            this.groupControl_ViewMode.Location = new System.Drawing.Point(12, 102);
            this.groupControl_ViewMode.Name = "groupControl_ViewMode";
            this.groupControl_ViewMode.Size = new System.Drawing.Size(311, 77);
            this.groupControl_ViewMode.TabIndex = 11;
            this.groupControl_ViewMode.Text = "Chọn chế độ để xem hay in";
            // 
            // radioBtn_ChartMode
            // 
            this.radioBtn_ChartMode.Location = new System.Drawing.Point(183, 39);
            this.radioBtn_ChartMode.Name = "radioBtn_ChartMode";
            this.radioBtn_ChartMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioBtn_ChartMode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_ChartMode.Properties.Appearance.Options.UseBackColor = true;
            this.radioBtn_ChartMode.Properties.Appearance.Options.UseFont = true;
            this.radioBtn_ChartMode.Properties.Caption = "Dạng biểu đồ";
            this.radioBtn_ChartMode.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.radioBtn_ChartMode.Properties.RadioGroupIndex = 1;
            this.radioBtn_ChartMode.Size = new System.Drawing.Size(102, 21);
            this.radioBtn_ChartMode.TabIndex = 27;
            this.radioBtn_ChartMode.TabStop = false;
            // 
            // radioBtn_TableMode
            // 
            this.radioBtn_TableMode.EditValue = true;
            this.radioBtn_TableMode.Location = new System.Drawing.Point(25, 39);
            this.radioBtn_TableMode.Name = "radioBtn_TableMode";
            this.radioBtn_TableMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioBtn_TableMode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_TableMode.Properties.Appearance.Options.UseBackColor = true;
            this.radioBtn_TableMode.Properties.Appearance.Options.UseFont = true;
            this.radioBtn_TableMode.Properties.Caption = "Dạng bảng";
            this.radioBtn_TableMode.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.radioBtn_TableMode.Properties.RadioGroupIndex = 1;
            this.radioBtn_TableMode.Size = new System.Drawing.Size(102, 21);
            this.radioBtn_TableMode.TabIndex = 26;
            // 
            // btn_Print
            // 
            this.btn_Print.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Appearance.Options.UseFont = true;
            this.btn_Print.Location = new System.Drawing.Point(187, 203);
            this.btn_Print.LookAndFeel.SkinName = "Money Twins";
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(60, 23);
            this.btn_Print.TabIndex = 13;
            this.btn_Print.Text = "Báo Cáo";
            // 
            // btn_preview
            // 
            this.btn_preview.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.Appearance.Options.UseFont = true;
            this.btn_preview.Location = new System.Drawing.Point(60, 203);
            this.btn_preview.LookAndFeel.SkinName = "Money Twins";
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(60, 23);
            this.btn_preview.TabIndex = 12;
            this.btn_preview.Text = "Xem";
            // 
            // ReportDoanhThu_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.groupControl_ViewMode);
            this.Controls.Add(this.groupControl1);
            this.Name = "ReportDoanhThu_UI";
            this.Size = new System.Drawing.Size(353, 252);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_Year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ViewMode)).EndInit();
            this.groupControl_ViewMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioBtn_ChartMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioBtn_TableMode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl_Year;
        private DevExpress.XtraEditors.SpinEdit spinEdit_Year;
        private DevExpress.XtraEditors.GroupControl groupControl_ViewMode;
        private DevExpress.XtraEditors.CheckEdit radioBtn_ChartMode;
        private DevExpress.XtraEditors.CheckEdit radioBtn_TableMode;
        private DevExpress.XtraEditors.SimpleButton btn_Print;
        private DevExpress.XtraEditors.SimpleButton btn_preview;
    }
}
