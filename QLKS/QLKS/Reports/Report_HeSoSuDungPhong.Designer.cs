namespace QLKS.Reports
{
    partial class Report_HeSoSuDungPhong
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.XRTable_Content = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.qlksDataSet_HeSoPhong1 = new QLKS.DataSets.QLKSDataSet_HeSoPhong();
            this.sP_HE_SO_SU_DUNG_PHONGTableAdapter = new QLKS.DataSets.QLKSDataSet_HeSoPhongTableAdapters.SP_HE_SO_SU_DUNG_PHONGTableAdapter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.lbAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.lbDate = new DevExpress.XtraReports.UI.XRLabel();
            this.pic_logo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.XRTable_Header = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.XRTable_Content)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlksDataSet_HeSoPhong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XRTable_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.XRTable_Content});
            this.Detail.HeightF = 27F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XRTable_Content
            // 
            this.XRTable_Content.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.XRTable_Content.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.XRTable_Content.Name = "XRTable_Content";
            this.XRTable_Content.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100F);
            this.XRTable_Content.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.XRTable_Content.SizeF = new System.Drawing.SizeF(684.1666F, 25F);
            this.XRTable_Content.StylePriority.UseBorders = false;
            this.XRTable_Content.StylePriority.UsePadding = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.StylePriority.UseBorders = false;
            this.xrTableRow1.Weight = 1;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_HE_SO_SU_DUNG_PHONG.SO_PHONG")});
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 1.2226737714799438;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_HE_SO_SU_DUNG_PHONG.TEN_LOAI_PHONG")});
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 1.5080053371855791;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_HE_SO_SU_DUNG_PHONG.SO_LAN_SU_DUNG")});
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 1.2566708593863334;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.lbAddress,
            this.xrPageInfo1,
            this.lbDate,
            this.pic_logo,
            this.xrLabel4});
            this.ReportHeader.HeightF = 147F;
            this.ReportHeader.Name = "ReportHeader";
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
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.xrPageInfo1.Format = "{0:dd-MM-yyyy}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(550F, 112.5F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(87F, 20.00002F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseForeColor = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.lbDate.LocationFloat = new DevExpress.Utils.PointFloat(487.5F, 112.5F);
            this.lbDate.Name = "lbDate";
            this.lbDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDate.SizeF = new System.Drawing.SizeF(49F, 20F);
            this.lbDate.StylePriority.UseFont = false;
            this.lbDate.StylePriority.UseForeColor = false;
            this.lbDate.Text = "Date:";
            this.lbDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pic_logo
            // 
            this.pic_logo.ImageUrl = "E:\\STUDY\\Open University\\HK6\\Lap Trinh CSDL\\ADO.NET project\\QLKS_TiepNhanKhach\\QL" +
                "KS_TiepNhanKhach\\Image\\logo.jpg";
            this.pic_logo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.pic_logo.SizeF = new System.Drawing.SizeF(133.3333F, 96.875F);
            this.pic_logo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(375F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(260.4167F, 39.66667F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Hệ Số Sử Dụng Phòng";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.XRTable_Header});
            this.PageHeader.HeightF = 43F;
            this.PageHeader.Name = "PageHeader";
            // 
            // XRTable_Header
            // 
            this.XRTable_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.XRTable_Header.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(177)))), ((int)(((byte)(183)))));
            this.XRTable_Header.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.XRTable_Header.BorderWidth = 2;
            this.XRTable_Header.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.XRTable_Header.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.XRTable_Header.Name = "XRTable_Header";
            this.XRTable_Header.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.XRTable_Header.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.XRTable_Header.SizeF = new System.Drawing.SizeF(684.1666F, 43F);
            this.XRTable_Header.StylePriority.UseFont = false;
            this.XRTable_Header.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7});
            this.xrTableRow2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow2.Weight = 1;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.xrTableCell5.BorderColor = System.Drawing.Color.White;
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.BorderWidth = 1;
            this.xrTableCell5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.xrTableCell5.ForeColor = System.Drawing.Color.White;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.StylePriority.UseBorderColor = false;
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseForeColor = false;
            this.xrTableCell5.Text = "Số Phòng";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.32275641234848407;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.xrTableCell6.BorderColor = System.Drawing.Color.White;
            this.xrTableCell6.BorderWidth = 1;
            this.xrTableCell6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.xrTableCell6.ForeColor = System.Drawing.Color.White;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.StylePriority.UseBorderColor = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseForeColor = false;
            this.xrTableCell6.Text = "Loại Phòng";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell6.Weight = 0.39807687375356149;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.xrTableCell7.BorderColor = System.Drawing.Color.White;
            this.xrTableCell7.BorderWidth = 1;
            this.xrTableCell7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.xrTableCell7.ForeColor = System.Drawing.Color.White;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell7.StylePriority.UseBackColor = false;
            this.xrTableCell7.StylePriority.UseBorderColor = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseForeColor = false;
            this.xrTableCell7.Text = "Số Lần Sử Dụng";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 0.33173080081201689;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.ReportFooter.HeightF = 54F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.xrLabel2.BorderColor = System.Drawing.Color.White;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "HE_SO_SU_DUNG_PHONG.SO_PHONG")});
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.ForeColor = System.Drawing.Color.White;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(456.6666F, 10.00001F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(227.5F, 33.41669F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:Tổng số phòng: 0}";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel2.Summary = xrSummary1;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Report_HeSoSuDungPhong
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter});
            this.DataAdapter = this.sP_HE_SO_SU_DUNG_PHONGTableAdapter;
            this.DataMember = "SP_HE_SO_SU_DUNG_PHONG";
            this.DataSource = this.qlksDataSet_HeSoPhong1;
            this.Margins = new System.Drawing.Printing.Margins(100, 57, 100, 100);
            this.Version = "9.3";
            ((System.ComponentModel.ISupportInitialize)(this.XRTable_Content)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlksDataSet_HeSoPhong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XRTable_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private QLKS.DataSets.QLKSDataSet_HeSoPhong qlksDataSet_HeSoPhong1;
        private QLKS.DataSets.QLKSDataSet_HeSoPhongTableAdapters.SP_HE_SO_SU_DUNG_PHONGTableAdapter sP_HE_SO_SU_DUNG_PHONGTableAdapter;
        private DevExpress.XtraReports.UI.XRTable XRTable_Content;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel lbAddress;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLabel lbDate;
        private DevExpress.XtraReports.UI.XRPictureBox pic_logo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable XRTable_Header;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    }
}
