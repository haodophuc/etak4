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
    public partial class ReportKhachHang_UI : DevExpress.XtraEditors.XtraUserControl
    {
        private Report_TongSoKhachHang reportKH;
        private Report_TSKhachHangFilterRoom reportTSKhachHangFilterRoom;

        public ReportKhachHang_UI()
        {
            InitializeComponent();
            reportKH = new Report_TongSoKhachHang();
            reportTSKhachHangFilterRoom = new Report_TSKhachHangFilterRoom();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            try
            {
                switch (radioGroup_ReportKH.SelectedIndex)
                {
                    case 0:
                        reportKH.ShowPreview();
                        break;
                    case 1:
                        reportTSKhachHangFilterRoom.ShowPreview();
                        break;
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
                switch (radioGroup_ReportKH.SelectedIndex)
                {
                    case 0:
                        reportKH.Print();
                        break;
                    case 1:
                        reportTSKhachHangFilterRoom.Print();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
    }
}
