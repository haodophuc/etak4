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
    public partial class TimKiemVaChonPhongTrongUI : UserControl
    {
        private PhongBUS phongBUS = new PhongBUS();
        public TimKiemVaChonPhongTrongUI()
        {
            InitializeComponent();
            grdCtrl_CapNhatPhong.DataSource = phongBUS.GetEmptyRoom();
        }

        private void btt_Select_Click(object sender, EventArgs e)
        {
            if (grdView_Phong.RowCount != 0)
            {
                Form_TimKiemvaChonPhongTrong.dtRow = grdView_Phong.GetFocusedDataRow();

                Close();
            }
        }
        private void Close()
        {
            this.ParentForm.Dispose();
        }

   
        private void bt_Cancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
/*
 * 
namespace QLKS_TiepNhanKhach.UI
{
    public partial class TimkiemvaChonKhachHangUI : UserControl
    {
        KhachHangBUS khachhangBUS = new KhachHangBUS();
        QuocGiaBUS quocGiaBUS = new QuocGiaBUS();
        public DataRow row;
        public TimkiemvaChonKhachHangUI()
        {
            InitializeComponent();
            grdCtrlKhachHang.DataSource = khachhangBUS.GetAll();
          
        }

        private void btt_Select_Click(object sender, EventArgs e)
        {
            if (gridView_KhachHang.RowCount != 0)
            {
                Form_TimKiemVaChonKhachHang.dtRow = gridView_KhachHang.GetFocusedDataRow();

                Close();
            }
        }
        private void Close()
        {
            this.ParentForm.Dispose();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    

      
    }
}

 */