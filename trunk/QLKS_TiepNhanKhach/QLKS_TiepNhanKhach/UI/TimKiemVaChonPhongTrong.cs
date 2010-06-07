using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS_TiepNhanKhach.BUS;

namespace QLKS_TiepNhanKhach.UI
{
    public partial class TimKiemVaChonPhongTrong : UserControl
    {
        private PhongBUS phongBUS = new PhongBUS();
        public TimKiemVaChonPhongTrong()
        {
            InitializeComponent();
            grdCtrl_CapNhatPhong.DataSource = phongBUS.GetEmptyRoom();
        }
    }
}
