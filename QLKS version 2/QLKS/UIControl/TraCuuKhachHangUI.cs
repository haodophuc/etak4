using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.BUS;
using QLKS.VO;
using DevExpress.XtraEditors;

namespace QLKS.UIControl
{
    public partial class TraCuuKhachHangUI : DevExpress.XtraEditors.XtraUserControl
    {
        KhachHangBUS khachhangBUS = new KhachHangBUS();

        public TraCuuKhachHangUI()
        {
            InitializeComponent();


        }

        private void TraCuuKhachHangUI_Load(object sender, EventArgs e)
        {
            grdCtrlKhachHang.DataSource = khachhangBUS.GetAll();
        }
    }
}