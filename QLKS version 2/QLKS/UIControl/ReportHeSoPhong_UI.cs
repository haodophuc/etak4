using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.Reports;

namespace QLKS.UIControl
{
    public partial class ReportHeSoPhong_UI : DevExpress.XtraEditors.XtraUserControl
    {
        private Report_HeSoSuDungPhong reportPhong;

        public ReportHeSoPhong_UI()
        {
            InitializeComponent();
        }

        private void InitControl()
        {
            spinEditMonthYear.Properties.MinValue = DateTime.MinValue.Year;
            spinEditMonthYear.Properties.MaxValue = DateTime.MaxValue.Year;
            spinEditMonthYear.Value = DateTime.Today.Year;
        }

        private void EnableControl()
        {
            //Radio Button FROM TO
            labelControl_From.Enabled = radioButton_FromTo.Checked;
            date_From.Enabled = radioButton_FromTo.Checked;
            labelControl_To.Enabled = radioButton_FromTo.Checked;
            date_To.Enabled = radioButton_FromTo.Checked;

            //Radio Button Month Year
            labelControl_Month.Enabled = radioButton_MonthYear.Checked;
            cbo_Month.Enabled = radioButton_MonthYear.Checked;
            labelControl_MonthYear.Enabled = radioButton_MonthYear.Checked;
            spinEditMonthYear.Enabled = radioButton_MonthYear.Checked;

            //Radio Button Quarter Year
            labelControl_Quarter.Enabled = radioButton_QuarterYear.Checked;
            cbo_Quarter.Enabled = radioButton_QuarterYear.Checked;
            labelControl_QuarterYear.Enabled = radioButton_QuarterYear.Checked;
            spinEditQuarterYear.Enabled = radioButton_QuarterYear.Checked;

            //Radio Button Year
            labelControl_Year.Enabled = radioButton_Year.Checked;
            spinEdit_Year.Enabled = radioButton_Year.Checked;
        }

        private void LoadDataReport()
        {
            DateTime f = new DateTime();
            DateTime t = new DateTime();
            int year, month;
            if (radioButton_FromTo.Checked)
            {
                f = (DateTime)date_From.DateTime;
                t = (DateTime)date_To.DateTime;
            }
            else if (radioButton_MonthYear.Checked)
            {
                year = Convert.ToInt32(spinEditMonthYear.Value);
                month = Convert.ToInt32(cbo_Month.EditValue);
                int daysOfMonth = DateTime.DaysInMonth(year, month);
                f = new DateTime(year, month, 1);
                t = new DateTime(year, month, daysOfMonth);
            }
            else if (radioButton_QuarterYear.Checked)
            {
                int fromMonth = 1, toMonth = 1;
                year = Convert.ToInt32(spinEditQuarterYear.EditValue);
                switch (Convert.ToInt32(cbo_Quarter.EditValue))
                {
                    case 1:
                        fromMonth = 1;
                        toMonth = 3;
                        break;
                    case 2:
                        fromMonth = 4;
                        toMonth = 6;
                        break;
                    case 3:
                        fromMonth = 7;
                        toMonth = 9;
                        break;
                    case 4:
                        fromMonth = 10;
                        toMonth = 12;
                        break;
                }
                int daysOfMonth = DateTime.DaysInMonth(year, toMonth);
                f = new DateTime(year, fromMonth, 1);
                t = new DateTime(year, toMonth, daysOfMonth);
            }
            else if (radioButton_Year.Checked)
            {
                year = Convert.ToInt32(spinEdit_Year.EditValue);
                int daysOfMonth = DateTime.DaysInMonth(year, 12);
                f = new DateTime(year, 1, 1);
                t = new DateTime(year, 12, daysOfMonth);
            }
            reportPhong = new Report_HeSoSuDungPhong(f, t);
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            LoadDataReport();
            reportPhong.ShowPreview();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            LoadDataReport();
            reportPhong.Print();
        }

        private void radioButton_FromTo_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl();
        }

        private void radioButton_MonthYear_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl();
        }

        private void radioButton_QuarterYear_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl();
        }

        private void radioButton_Year_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl();
        }
    }
}
