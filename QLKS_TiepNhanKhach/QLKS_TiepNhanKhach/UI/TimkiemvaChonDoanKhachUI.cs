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
    public partial class TimkiemvaChonDoanKhachUI : UserControl
    {
 
        private DoanKhachBUS doankhachBUS = new DoanKhachBUS();
        public TimkiemvaChonDoanKhachUI()
        {
            InitializeComponent();
            grdCtrlDoanKhach.DataSource = doankhachBUS.GetAll();
            
        }

        private void btt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btt_Select_Click(object sender, EventArgs e)
        {
            if (gridView_DoanKhach.RowCount != 0)
            {
                Form_TimKiemVaChonDoanKhach.dtRow = gridView_DoanKhach.GetFocusedDataRow();

                Close();
            }
       
        }
        private void Close()
        {
            this.ParentForm.Dispose();
        }
    }
}

