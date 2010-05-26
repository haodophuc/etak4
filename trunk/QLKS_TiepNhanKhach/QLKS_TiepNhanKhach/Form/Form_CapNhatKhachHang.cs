using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKS_TiepNhanKhach
{
    public partial class Form_CapNhatKhachHang : Form
    {
        UI.CapNhatKhachHang_UI khachHangUI;
        public Form_CapNhatKhachHang()
        {
            InitializeComponent();
            khachHangUI = new UI.CapNhatKhachHang_UI();
        }

        private void Form_CapNhatKhachHang_Load(object sender, EventArgs e)
        {
            this.Controls.Add(khachHangUI);
            khachHangUI.Dock = DockStyle.Fill;
        }

    }
  
}