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
    public partial class Form_TraCuuThongTinCongTy : DevExpress.XtraEditors.XtraForm
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