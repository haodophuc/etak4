using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLKS.UIControl;


namespace QLKS.UI
{
    public partial class Form_CapNhatPhieuThuDoanKhach : DevExpress.XtraEditors.XtraForm
    {

        public Form_CapNhatPhieuThuDoanKhach()
        {
            InitializeComponent();
        }

        private void CapNhatPhieuThuDoanKhach_Load(object sender, EventArgs e)
        {
            CapNhatPhieuThuDoanKhachUI phieuThuDoanKhachUI = new CapNhatPhieuThuDoanKhachUI();
            this.Controls.Add(phieuThuDoanKhachUI);
            phieuThuDoanKhachUI.Dock = DockStyle.Fill;
        }
    }
}