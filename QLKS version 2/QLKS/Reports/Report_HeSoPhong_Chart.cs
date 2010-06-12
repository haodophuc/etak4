using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLKS.Reports
{
    public partial class Report_HeSoPhong_Chart : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_HeSoPhong_Chart(DateTime fromTime,DateTime toTime)
        {
            InitializeComponent();
            try
            {
                QLKS.DataSets.QLKSDataSet_HeSoPhongTableAdapters.SP_HE_SO_SU_DUNG_PHONGTableAdapter adapter = new QLKS.DataSets.QLKSDataSet_HeSoPhongTableAdapters.SP_HE_SO_SU_DUNG_PHONGTableAdapter();
                adapter.Fill(this.qlksDataSet_HeSoPhong1.SP_HE_SO_SU_DUNG_PHONG, fromTime, toTime);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
