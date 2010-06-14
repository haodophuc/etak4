using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.BUS;
using QLKS.Reports;

namespace QLKS.UIControl
{
    public partial class ReportDoanhThu_UI : UserControl
    {
        private Report_DoanhThu_Chart reportDoanhThuChart;
        private Report_DoanhThu reportDoanhThuTable;
        private DoanhThuBUS doanhThuBUS;
        private int year;
        private bool clicked = false;

        public ReportDoanhThu_UI()
        {
            InitializeComponent();
            InitControl();
            ShowControl();
        }

        private void InitControl()
        {
            spinEdit_Year.Properties.MinValue = DateTime.MinValue.Year;
            spinEdit_Year.Properties.MaxValue = DateTime.MaxValue.Year;
            spinEdit_Year.Value = DateTime.Today.Year;
        }

        private void ShowControl()
        {
            if (clicked)
            {
                panelControl_ViewMode.Visible = true;
            }
            else
            {
                panelControl_ViewMode.Visible = false;
            }

            if (radioBtn_TableMode.Checked == true)
            {
                panelControl_ViewMode.Controls.Add(gridControl_ViewMode);
                panelControl_ViewMode.Controls.Remove(chartControl_ViewMode);
            }
            if (radioBtn_ChartMode.Checked == true)
            {
                panelControl_ViewMode.Controls.Add(chartControl_ViewMode);
                panelControl_ViewMode.Controls.Remove(gridControl_ViewMode);
            }
        }

        private void LoadDataReport()
        {
            year = (int)spinEdit_Year.Value;

            doanhThuBUS = new DoanhThuBUS();
            gridControl_ViewMode.DataSource = doanhThuBUS.GetDoanhThu(year);
            reportDoanhThuChart = new Report_DoanhThu_Chart(year);
            reportDoanhThuTable = new Report_DoanhThu(year);
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            try
            {
                clicked = true;
                LoadDataReport();
                ShowControl();
                if (radioBtn_TableMode.Checked == true)
                {
                    gridControl_ViewMode.Dock = DockStyle.Fill;
                }
                if (radioBtn_ChartMode.Checked == true)
                {

                    QLKS.DataSets.QLKSDataSet_DoanhThuTableAdapters.SP_DOANH_THUTableAdapter adapter = new QLKS.DataSets.QLKSDataSet_DoanhThuTableAdapters.SP_DOANH_THUTableAdapter();
                    adapter.Fill(qLKSDataSet_DoanhThu.SP_DOANH_THU,year);
                    chartControl_ViewMode.DataAdapter = adapter;
                    chartControl_ViewMode.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDataReport();
                if (radioBtn_TableMode.Checked == true)
                     reportDoanhThuTable.ShowPreview();
                   if (radioBtn_ChartMode.Checked == true)
                        reportDoanhThuChart.ShowPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
