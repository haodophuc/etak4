using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLKS.BUS;
using QLKS.VO;
using QLKS.UIControl;

namespace QLKS
{
    public partial class Form_CapNhatPhieuThuKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public Form_CapNhatPhieuThuKhachHang()
        {
            InitializeComponent();
        }

        private void XtraForm_Test_Load(object sender, EventArgs e)
        {
            CapNhatPhieuThuKhachHangUI phieuThuKhachHangUI = new CapNhatPhieuThuKhachHangUI();
            this.Controls.Add(phieuThuKhachHangUI);
            phieuThuKhachHangUI.Dock = DockStyle.Fill;
        }
    }
}