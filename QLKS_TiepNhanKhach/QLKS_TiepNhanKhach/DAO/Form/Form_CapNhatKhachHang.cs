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
    public partial class Form_CapNhatKhachHang : Form
    {
        private CapNhatKhachHang_UI khachHangUI;
       

        public Form_CapNhatKhachHang()
        {
            InitializeComponent();
            khachHangUI = new CapNhatKhachHang_UI();
        }

        private void Form_CapNhatKhachHang_Load(object sender, EventArgs e)
        {
            panelControl_CapNHatKhachHang.Controls.Add(khachHangUI);
            khachHangUI.Dock = DockStyle.Fill;
        }

    }
  
}