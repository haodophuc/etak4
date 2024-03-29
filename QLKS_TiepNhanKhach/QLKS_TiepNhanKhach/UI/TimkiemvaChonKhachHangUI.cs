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
