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
    public partial class Form_CapNhatKhachHang : Form
    {
        CapNhatKhachHang_UI khachHangUI;

        public Form_CapNhatKhachHang()
        {
            InitializeComponent();
            khachHangUI = new CapNhatKhachHang_UI();
        }

        private void Form_CapNhatKhachHang_Load(object sender, EventArgs e)
        {
            this.Controls.Add(khachHangUI);
            khachHangUI.Dock = DockStyle.Fill;
            this.MinimumSize = khachHangUI.MinimumSize;
        }

    }
  
}