using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKS_TiepNhanKhach
{
    public partial class Form_Main : Form
    {
       
        public Form_Main()
        {
          
            InitializeComponent();
            
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void StripMenu_CapNhatPhong_Click(object sender, EventArgs e)
        {
            Form_CapNhatPhong frmCapNhatPhong = new Form_CapNhatPhong();
            frmCapNhatPhong.MdiParent = this;
            frmCapNhatPhong.Show();
        }

        private void StripMenu_DatPhong_Click(object sender, EventArgs e)
        {
            Form_DatPhong frmDatPhong = new Form_DatPhong();
            frmDatPhong.MdiParent = this;
            frmDatPhong.Show();
        }

        private void cậpNhậtKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CapNhatKhachHang frmCapNhatKhachHang = new Form_CapNhatKhachHang();
            frmCapNhatKhachHang.MdiParent = this;
            frmCapNhatKhachHang.Show();
        }

        private void cậpNhậtĐoànKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CapNhatDoanKhach frmCapNhatDoanKhach = new Form_CapNhatDoanKhach();
            frmCapNhatDoanKhach.MdiParent = this;
            frmCapNhatDoanKhach.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Form_TraCuuThongTinKhachHang frmTraCuuThongTinKhachHang = new Form_TraCuuThongTinKhachHang();
            frmTraCuuThongTinKhachHang.MdiParent = this;
            frmTraCuuThongTinKhachHang.Show();
        }
    }
}