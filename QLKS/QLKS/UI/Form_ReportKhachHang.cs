using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKS.Reports;
using QLKS.UIControl;

namespace QLKS
{
    public partial class Form_ReportKhachHang : Form
    {

        private ReportKhachHang_UI reportKH;
        public Form_ReportKhachHang()
        {
            InitializeComponent();

        }

        private void Form_ReportKhachHang_Load(object sender, EventArgs e)
        {
            reportKH = new ReportKhachHang_UI();
            this.Controls.Add(reportKH);
            reportKH.Dock = DockStyle.Fill;
        }    
    }
}