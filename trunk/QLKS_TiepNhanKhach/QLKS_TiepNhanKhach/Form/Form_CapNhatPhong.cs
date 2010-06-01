using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKS_TiepNhanKhach
{
    public partial class Form_CapNhatPhong : Form
    {
        UI.CapNhatPhong_UI phongUI;

        public Form_CapNhatPhong()
        {
            InitializeComponent();
            phongUI = new UI.CapNhatPhong_UI();
        }

        private void Form_CapNhatPhong_Load(object sender, EventArgs e)
        {
            this.Controls.Add(phongUI);
            phongUI.Dock = DockStyle.Fill;
            this.MinimumSize = phongUI.MinimumSize;
        }
    }
}