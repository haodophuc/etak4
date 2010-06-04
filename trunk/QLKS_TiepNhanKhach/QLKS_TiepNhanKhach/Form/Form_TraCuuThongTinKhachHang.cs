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
    public partial class Form_TraCuuThongTinKhachHang : Form
    {
        TraCuuKhachHangUI tracuukhachhangUI = new TraCuuKhachHangUI();
        public Form_TraCuuThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void Form_TraCuuThongTinKhachHang_Load(object sender, EventArgs e)
        {
            this.Controls.Add(tracuukhachhangUI);
            tracuukhachhangUI.Dock = DockStyle.Fill;
        }
       
    }
}