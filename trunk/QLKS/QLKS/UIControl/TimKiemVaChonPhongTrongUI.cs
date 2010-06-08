using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.BUS;

namespace QLKS.UIControl
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
                UI.Form_TimKiemvaChonPhongTrong.dtRow = grdView_Phong.GetFocusedDataRow();

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