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
    public partial class Form_ReportHeSoPhong : Form
    {
        
        public Form_ReportHeSoPhong()
        {
            InitializeComponent();
        }

        private void Form_ReportHeSoPhong_Load(object sender, EventArgs e)
        {
            ReportHeSoPhong_UI reportPhongUI = new ReportHeSoPhong_UI();
            this.Controls.Add(reportPhongUI);
            reportPhongUI.Dock = DockStyle.Fill;
        }

    }
}