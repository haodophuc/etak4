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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions1 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl_Year = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit_Year = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl_ViewMode = new DevExpress.XtraEditors.GroupControl();
            this.radioBtn_ChartMode = new DevExpress.XtraEditors.CheckEdit();
            this.radioBtn_TableMode = new DevExpress.XtraEditors.CheckEdit();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_preview = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl_ViewMode = new DevExpress.XtraEditors.PanelControl();
            this.gridControl_ViewMode = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chartControl_ViewMode = new DevExpress.XtraCharts.ChartControl();
            this.qLKSDataSetDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKSDataSet_DoanhThu = new QLKS.DataSets.QLKSDataSet_DoanhThu();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_Year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ViewMode)).BeginInit();
            this.groupControl_ViewMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioBtn_ChartMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioBtn_TableMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_ViewMode)).BeginInit();
            this.panelControl_ViewMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ViewMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl_ViewMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSetDoanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet_DoanhThu)).BeginInit();
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
            this.groupControl1.Size = new System.Drawing.Size(311, 84);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chọn năm để xem doanh thu theo năm";
            // 
            // labelControl_Year
            // 
            this.labelControl_Year.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_Year.Appearance.Options.UseFont = true;
            this.labelControl_Year.Location = new System.Drawing.Point(74, 41);
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
            this.spinEdit_Year.Location = new System.Drawing.Point(119, 36);
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
            this.groupControl_ViewMode.Location = new System.Drawing.Point(12, 103);
            this.groupControl_ViewMode.Name = "groupControl_ViewMode";
            this.groupControl_ViewMode.Size = new System.Drawing.Size(311, 86);
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
            this.btn_Print.Location = new System.Drawing.Point(206, 224);
            this.btn_Print.LookAndFeel.SkinName = "Money Twins";
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(60, 23);
            this.btn_Print.TabIndex = 13;
            this.btn_Print.Text = "Báo Cáo";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.Appearance.Options.UseFont = true;
            this.btn_preview.Location = new System.Drawing.Point(79, 224);
            this.btn_preview.LookAndFeel.SkinName = "Money Twins";
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(60, 23);
            this.btn_preview.TabIndex = 12;
            this.btn_preview.Text = "Xem";
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // panelControl_ViewMode
            // 
            this.panelControl_ViewMode.Controls.Add(this.gridControl_ViewMode);
            this.panelControl_ViewMode.Controls.Add(this.chartControl_ViewMode);
            this.panelControl_ViewMode.Location = new System.Drawing.Point(329, 13);
            this.panelControl_ViewMode.Name = "panelControl_ViewMode";
            this.panelControl_ViewMode.Size = new System.Drawing.Size(653, 323);
            this.panelControl_ViewMode.TabIndex = 14;
            // 
            // gridControl_ViewMode
            // 
            this.gridControl_ViewMode.Location = new System.Drawing.Point(82, 81);
            this.gridControl_ViewMode.MainView = this.gridView1;
            this.gridControl_ViewMode.Name = "gridControl_ViewMode";
            this.gridControl_ViewMode.Size = new System.Drawing.Size(400, 200);
            this.gridControl_ViewMode.TabIndex = 1;
            this.gridControl_ViewMode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl_ViewMode;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tháng";
            this.gridColumn1.FieldName = "THANG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Doanh Thu";
            this.gridColumn2.FieldName = "TONG_SO_TIEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // chartControl_ViewMode
            // 
            this.chartControl_ViewMode.AppearanceName = "Gray";
            this.chartControl_ViewMode.DataSource = this.qLKSDataSetDoanhThuBindingSource;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl_ViewMode.Diagram = xyDiagram1;
            this.chartControl_ViewMode.Location = new System.Drawing.Point(-18, 64);
            this.chartControl_ViewMode.Name = "chartControl_ViewMode";
            this.chartControl_ViewMode.PaletteBaseColorNumber = 5;
            this.chartControl_ViewMode.PaletteName = "Nature Colors";
            series1.ArgumentDataMember = "SP_DOANH_THU.THANG";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            pointSeriesLabel1.LineVisible = true;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Tháng";
            pointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Currency;
            series1.PointOptions = pointOptions1;
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series1.ValueDataMembersSerializable = "SP_DOANH_THU.TONG_SO_TIEN";
            series1.View = lineSeriesView1;
            pointSeriesLabel2.LineVisible = true;
            pointSeriesLabel2.Visible = false;
            series2.Label = pointSeriesLabel2;
            series2.Name = "Series 2";
            series2.View = lineSeriesView2;
            series2.Visible = false;
            this.chartControl_ViewMode.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            pointSeriesLabel3.LineVisible = true;
            this.chartControl_ViewMode.SeriesTemplate.Label = pointSeriesLabel3;
            this.chartControl_ViewMode.SeriesTemplate.View = lineSeriesView3;
            this.chartControl_ViewMode.Size = new System.Drawing.Size(643, 318);
            this.chartControl_ViewMode.TabIndex = 0;
            // 
            // qLKSDataSetDoanhThuBindingSource
            // 
            this.qLKSDataSetDoanhThuBindingSource.DataSource = this.qLKSDataSet_DoanhThu;
            this.qLKSDataSetDoanhThuBindingSource.Position = 0;
            // 
            // qLKSDataSet_DoanhThu
            // 
            this.qLKSDataSet_DoanhThu.DataSetName = "QLKSDataSet_DoanhThu";
            this.qLKSDataSet_DoanhThu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportDoanhThu_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl_ViewMode);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.groupControl_ViewMode);
            this.Controls.Add(this.groupControl1);
            this.Name = "ReportDoanhThu_UI";
            this.Size = new System.Drawing.Size(985, 360);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_Year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ViewMode)).EndInit();
            this.groupControl_ViewMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioBtn_ChartMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioBtn_TableMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_ViewMode)).EndInit();
            this.panelControl_ViewMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ViewMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl_ViewMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSetDoanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet_DoanhThu)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl_ViewMode;
        private DevExpress.XtraCharts.ChartControl chartControl_ViewMode;
        private System.Windows.Forms.BindingSource qLKSDataSetDoanhThuBindingSource;
        private QLKS.DataSets.QLKSDataSet_DoanhThu qLKSDataSet_DoanhThu;
        private DevExpress.XtraGrid.GridControl gridControl_ViewMode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}
