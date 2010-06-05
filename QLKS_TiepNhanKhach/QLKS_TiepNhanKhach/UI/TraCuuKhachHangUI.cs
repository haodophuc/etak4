using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS_TiepNhanKhach.BUS;
using QLKS_TiepNhanKhach.VO;
using DevExpress.XtraEditors;

namespace QLKS_TiepNhanKhach.UI
{
    public partial class TraCuuKhachHangUI : UserControl
    {
        KhachHangBUS khachhangBUS = new KhachHangBUS();
       
        public TraCuuKhachHangUI()
        {
            InitializeComponent();
            grdCtrlKhachHang.DataSource=khachhangBUS.GetAll();
          
        }
        
    }
}