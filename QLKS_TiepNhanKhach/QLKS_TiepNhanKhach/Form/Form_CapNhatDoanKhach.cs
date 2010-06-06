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
    public partial class Form_CapNhatDoanKhach : Form
    {

        CapNhatCongTy_UI congtyUI = new CapNhatCongTy_UI();
        CapNhatDoanKhach_UI doankhachUI = new CapNhatDoanKhach_UI();
        CapNhatKhachHang_UI khachhangUI = new CapNhatKhachHang_UI();
        CapNhatDoanKhachChiTiet_UI ct = new CapNhatDoanKhachChiTiet_UI();
        public Form_CapNhatDoanKhach()
        {
            InitializeComponent();
        }

        private void Form_CapNhatDoanKhach_Load(object sender, EventArgs e)
        {
            this.Controls.Add(ct);
            ct.Dock = DockStyle.Fill;
            this.MinimumSize = ct.MinimumSize;
        }
    }
}