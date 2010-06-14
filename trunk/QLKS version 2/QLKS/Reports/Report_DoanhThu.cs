using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLKS.Reports
{
    public partial class Report_DoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_DoanhThu(int year)
        {
            InitializeComponent();
            try
            {
                QLKS.DataSets.QLKSDataSet_DoanhThuTableAdapters.SP_DOANH_THUTableAdapter adapter = new QLKS.DataSets.QLKSDataSet_DoanhThuTableAdapters.SP_DOANH_THUTableAdapter();
                adapter.Fill(this.qlksDataSet_DoanhThu1.SP_DOANH_THU, year);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
