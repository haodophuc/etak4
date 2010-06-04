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
   
    public partial class Form_TimKiemVaChonKhachHang : Form
    {
        private TimkiemvaChonKhachHangUI timkiemvachonkhachhangUI = new TimkiemvaChonKhachHangUI();
        static public DataRow dtRow;
        static public int i;
        public Form_TimKiemVaChonKhachHang()
        {
            InitializeComponent();
        }

        private void Form_TimKiemVaChonKhachHang_Load(object sender, EventArgs e)
        {
            this.Controls.Add(timkiemvachonkhachhangUI);
            timkiemvachonkhachhangUI.Dock = DockStyle.Fill;

        }

        public DataRow ShowModal()
        {
            ShowDialog();
            return dtRow ;
        }
    }
}