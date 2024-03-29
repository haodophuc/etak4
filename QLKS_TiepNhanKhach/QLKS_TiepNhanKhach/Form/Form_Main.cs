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

        private void tìmVàChọnKháchHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DemoSelect frm = new Form_DemoSelect();
            frm.Show();
        }

        private void côngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TraCuuThongTinCongTy frmTraCuuThongTinCongTy = new Form_TraCuuThongTinCongTy();
            frmTraCuuThongTinCongTy.MdiParent = this;
            frmTraCuuThongTinCongTy.Show();
        }

        private void đoànKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TraCuuThongTinDoanKhach frmTraCuuThongTinDoanKhach = new Form_TraCuuThongTinDoanKhach();
            frmTraCuuThongTinDoanKhach.MdiParent = this;
            frmTraCuuThongTinDoanKhach.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CheckOut frmCheckOut = new Form_CheckOut();
            frmCheckOut.MdiParent = this;
            frmCheckOut.Show();
        }

        private void menuItemCheckIn_Click(object sender, EventArgs e)
        {
            FormCheckIn checkIn = new FormCheckIn();
            checkIn.MdiParent = this;
            checkIn.Show();
        }

        private void MenuItem_SoLuongKhach_Click(object sender, EventArgs e)
        {
            Form_ReportKhachHang reportKH = new Form_ReportKhachHang();
            reportKH.MdiParent = this;
            reportKH.Show();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTest testForm = new FormTest();
            testForm.MdiParent = this;
            testForm.Show();
        }
    }
}