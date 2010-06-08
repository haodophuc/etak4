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
    public partial class Form_CapNhatPhong : Form
    {
        CapNhatPhong_UI phongUI;

        public Form_CapNhatPhong()
        {
            InitializeComponent();
            phongUI = new CapNhatPhong_UI();
        }

        private void Form_CapNhatPhong_Load(object sender, EventArgs e)
        {
            this.Controls.Add(phongUI);
            phongUI.Dock = DockStyle.Fill;
            this.MinimumSize = phongUI.MinimumSize;
        }
    }
}