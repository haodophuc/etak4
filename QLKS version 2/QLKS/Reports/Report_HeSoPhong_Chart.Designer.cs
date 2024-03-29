namespace QLKS.Reports
{
    partial class Report_HeSoPhong_Chart
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram3D xyDiagram3D1 = new DevExpress.XtraCharts.XYDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Bar3DSeriesLabel bar3DSeriesLabel1 = new DevExpress.XtraCharts.Bar3DSeriesLabel();
            DevExpress.XtraCharts.SideBySideBar3DSeriesView sideBySideBar3DSeriesView1 = new DevExpress.XtraCharts.SideBySideBar3DSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Bar3DSeriesLabel bar3DSeriesLabel2 = new DevExpress.XtraCharts.Bar3DSeriesLabel();
            DevExpress.XtraCharts.SideBySideBar3DSeriesView sideBySideBar3DSeriesView2 = new DevExpress.XtraCharts.SideBySideBar3DSeriesView();
            DevExpress.XtraCharts.Bar3DSeriesLabel bar3DSeriesLabel3 = new DevExpress.XtraCharts.Bar3DSeriesLabel();
            DevExpress.XtraCharts.SideBySideBar3DSeriesView sideBySideBar3DSeriesView3 = new DevExpress.XtraCharts.SideBySideBar3DSeriesView();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.lbAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.pic_logo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lbDate = new DevExpress.XtraReports.UI.XRLabel();
            this.qlksDataSet_HeSoPhong1 = new QLKS.DataSets.QLKSDataSet_HeSoPhong();
            this.sP_HE_SO_SU_DUNG_PHONGTableAdapter = new QLKS.DataSets.QLKSDataSet_HeSoPhongTableAdapters.SP_HE_SO_SU_DUNG_PHONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bar3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bar3DSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bar3DSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlksDataSet_HeSoPhong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 52F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 26F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart1,
            this.xrPageInfo1,
            this.lbAddress,
            this.xrLine1,
            this.xrLabel4,
            this.pic_logo,
            this.lbDate});
            this.ReportHeader.HeightF = 902F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrChart1
            // 
            this.xrChart1.AppearanceName = "Light";
            this.xrChart1.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xyDiagram3D1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram3D1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" +
                "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" +
                "1";
            this.xrChart1.Diagram = xyDiagram3D1;
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 145.5F);
            this.xrChart1.Name = "xrChart1";
            this.xrChart1.PaletteBaseColorNumber = 5;
            this.xrChart1.PaletteName = "Nature Colors";
            series1.ArgumentDataMember = "SP_HE_SO_SU_DUNG_PHONG.TEN_LOAI_PHONG";
            bar3DSeriesLabel1.LineVisible = true;
            bar3DSeriesLabel1.Visible = true;
            series1.Label = bar3DSeriesLabel1;
            series1.Name = "Loại Phòng";
            series1.ValueDataMembersSerializable = "SP_HE_SO_SU_DUNG_PHONG.HE_SO_SU_DUNG";
            series1.View = sideBySideBar3DSeriesView1;
            bar3DSeriesLabel2.LineVisible = true;
            bar3DSeriesLabel2.Visible = false;
            series2.Label = bar3DSeriesLabel2;
            series2.Name = "Series 2";
            series2.View = sideBySideBar3DSeriesView2;
            series2.Visible = false;
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            bar3DSeriesLabel3.LineVisible = true;
            bar3DSeriesLabel3.Visible = true;
            this.xrChart1.SeriesTemplate.Label = bar3DSeriesLabel3;
            this.xrChart1.SeriesTemplate.View = sideBySideBar3DSeriesView3;
            this.xrChart1.SizeF = new System.Drawing.SizeF(690.9999F, 719.5F);
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.xrPageInfo1.Format = "{0:dd-MM-yyyy}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(525F, 112.5F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(87F, 20.00002F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseForeColor = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbAddress
            // 
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.Black;
            this.lbAddress.LocationFloat = new DevExpress.Utils.PointFloat(0F, 112.5F);
            this.lbAddress.Multiline = true;
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbAddress.SizeF = new System.Drawing.SizeF(258F, 33F);
            this.lbAddress.StylePriority.UseFont = false;
            this.lbAddress.Text = "116 Đinh Tiên Hoàng Q.Bình Thạnh.Tp.HCM\r\nSố Điện thoại: (+84)988.446.843";
            this.lbAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine1
            // 
            this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 100F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine1.SizeF = new System.Drawing.SizeF(690.9999F, 9F);
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(350F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(260.4167F, 39.66667F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Hệ Số Sử Dụng Phòng";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // pic_logo
            // 
            this.pic_logo.ImageUrl = "sE:\\Hieu\\Temp\\Etak_QLKS\\QLKS version 2\\QLKS\\Resources\\logo.jpg";
            this.pic_logo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.pic_logo.SizeF = new System.Drawing.SizeF(133.3333F, 96.875F);
            this.pic_logo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.lbDate.LocationFloat = new DevExpress.Utils.PointFloat(462.5F, 112.5F);
            this.lbDate.Name = "lbDate";
            this.lbDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDate.SizeF = new System.Drawing.SizeF(49F, 20F);
            this.lbDate.StylePriority.UseFont = false;
            this.lbDate.StylePriority.UseForeColor = false;
            this.lbDate.Text = "Date:";
            this.lbDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // qlksDataSet_HeSoPhong1
            // 
            this.qlksDataSet_HeSoPhong1.DataSetName = "QLKSDataSet_HeSoPhong";
            this.qlksDataSet_HeSoPhong1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_HE_SO_SU_DUNG_PHONGTableAdapter
            // 
            this.sP_HE_SO_SU_DUNG_PHONGTableAdapter.ClearBeforeFill = true;
            // 
            // Report_HeSoPhong_Chart
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataAdapter = this.sP_HE_SO_SU_DUNG_PHONGTableAdapter;
            this.DataMember = "SP_HE_SO_SU_DUNG_PHONG";
            this.DataSource = this.qlksDataSet_HeSoPhong1;
            this.Margins = new System.Drawing.Printing.Margins(100, 58, 52, 26);
            this.Version = "9.3";
            this.Watermark.ShowBehind = false;
            this.Watermark.Text = "Etak Hotel Management";
            this.Watermark.TextTransparency = 210;
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bar3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bar3DSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bar3DSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlksDataSet_HeSoPhong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLabel lbAddress;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRPictureBox pic_logo;
        private DevExpress.XtraReports.UI.XRLabel lbDate;
        private QLKS.DataSets.QLKSDataSet_HeSoPhong qlksDataSet_HeSoPhong1;
        private QLKS.DataSets.QLKSDataSet_HeSoPhongTableAdapters.SP_HE_SO_SU_DUNG_PHONGTableAdapter sP_HE_SO_SU_DUNG_PHONGTableAdapter;
        private DevExpress.XtraReports.UI.XRChart xrChart1;
    }
}
