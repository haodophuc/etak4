using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKS_TiepNhanKhach.BUS;
using QLKS_TiepNhanKhach.UI;

namespace QLKS_TiepNhanKhach
{
    public partial class Form_Test : Form
    {
        private TimKiemVaChonPhongTrongUI ui = new TimKiemVaChonPhongTrongUI();
        public Form_Test()
        {
            InitializeComponent();
        }

        private void Form_Test_Load(object sender, EventArgs e)
        {
            this.Controls.Add(ui);
            ui.Dock = DockStyle.Fill;
        }
    }
}