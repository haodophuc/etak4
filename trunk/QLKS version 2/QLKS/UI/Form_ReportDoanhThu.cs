using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKS.UIControl;

namespace QLKS.UI
{
    public partial class Form_ReportDoanhThu : Form
    {
        private ReportDoanhThu_UI reportDoanhThu;
        public Form_ReportDoanhThu()
        {
            InitializeComponent();
        }

        private void Form_ReportDoanhThu_Load(object sender, EventArgs e)
        {
            reportDoanhThu = new ReportDoanhThu_UI();
            this.Controls.Add(reportDoanhThu);
            reportDoanhThu.Dock = DockStyle.Fill;
        }
    }
}