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
    public partial class Form_TraCuuThongTinDoanKhach : DevExpress.XtraEditors.XtraForm
    {
        private TraCuuDoanKhachUI tracuuDoanKhachUI = new TraCuuDoanKhachUI();
        public Form_TraCuuThongTinDoanKhach()
        {
            InitializeComponent();
        }

        private void Form_TraCuuThongTinDoanKhach_Load(object sender, EventArgs e)
        {
            this.Controls.Add(tracuuDoanKhachUI);
            tracuuDoanKhachUI.Dock = DockStyle.Fill;
        }
    }
}