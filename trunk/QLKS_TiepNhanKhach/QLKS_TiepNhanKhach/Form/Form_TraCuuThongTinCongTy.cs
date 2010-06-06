using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKS_TiepNhanKhach.UI;

namespace QLKS_TiepNhanKhach
{
    public partial class Form_TraCuuThongTinCongTy : Form
    {
        TraCuuCongTyUI traCuuCongTyUI = new TraCuuCongTyUI();
        public Form_TraCuuThongTinCongTy()
        {
            InitializeComponent();
        }

        private void Form_TraCuuThongTinCongTy_Load(object sender, EventArgs e)
        {
            this.Controls.Add(traCuuCongTyUI);
            traCuuCongTyUI.Dock = DockStyle.Fill;
        }
    }
}