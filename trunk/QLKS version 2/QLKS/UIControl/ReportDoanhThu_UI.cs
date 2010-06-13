using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QLKS.UIControl
{
    public partial class ReportDoanhThu_UI : UserControl
    {
        public ReportDoanhThu_UI()
        {
            InitializeComponent();
            InitControl();
        }

        private void InitControl()
        {
            spinEdit_Year.Properties.MinValue = DateTime.MinValue.Year;
            spinEdit_Year.Properties.MaxValue = DateTime.MaxValue.Year;
            spinEdit_Year.Value = DateTime.Today.Year;
        }
    }
}
