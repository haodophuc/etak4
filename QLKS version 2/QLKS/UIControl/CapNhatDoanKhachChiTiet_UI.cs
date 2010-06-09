using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.UI;

namespace QLKS.UIControl
{
    public partial class CapNhatDoanKhachChiTiet_UI : DevExpress.XtraEditors.XtraUserControl
    {
        private CapNhatDoanKhach_UI capnhatdoankhachUI = new CapNhatDoanKhach_UI();
        private CapNhatCongTy_UI capnhatcongtyUI = new CapNhatCongTy_UI();
        private CapNhatKhachHang_UI capnhatnguoidaidienUI = new CapNhatKhachHang_UI();
        public CapNhatDoanKhachChiTiet_UI()
        {
            InitializeComponent();

            panelControl3.Controls.Add(capnhatdoankhachUI);
            capnhatdoankhachUI.Dock = DockStyle.Fill;
        }

   
        private void chk_CapNhatDoanKhach_CheckStateChanged(object sender, EventArgs e)
        {
          
            if (chk_CapNhatDoanKhach.Checked == true)
            {
                panelControl3.Controls.Clear();
                panelControl3.Controls.Add(capnhatdoankhachUI);
                capnhatdoankhachUI.Dock = DockStyle.Fill;
                chk_CapNhatNguoiDaiDien.Visible = false;
            }
        }

        private void chk_CapNhatCongTy_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_CapNhatCongTy.Checked == true)
            {
                panelControl3.Controls.Clear();
                panelControl3.Controls.Add(capnhatcongtyUI);
                capnhatcongtyUI.Dock = DockStyle.Fill;
                chk_CapNhatNguoiDaiDien.Visible = true;
              
            }
        }
        private void chk_CapNhatNguoiDaiDien_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_CapNhatNguoiDaiDien.Checked == true)
            {
                panelControl3.Controls.Clear();
                panelControl3.Controls.Add(capnhatnguoidaidienUI);
                capnhatnguoidaidienUI.Dock = DockStyle.Fill;
            }
        }

        


   


    }
}
