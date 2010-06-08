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
   
    public partial class Form_TimKiemVaChonKhachHang : Form
    {
        private TimkiemVaChonKhachHangUI timkiemvachonkhachhangUI = new TimkiemVaChonKhachHangUI();
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