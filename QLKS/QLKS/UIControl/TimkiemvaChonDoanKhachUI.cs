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
    public partial class TimkiemvaChonDoanKhachUI : UserControl
    {
 
        private DoanKhachBUS doankhachBUS = new DoanKhachBUS();
        public TimkiemvaChonDoanKhachUI()
        {
            InitializeComponent();
            grdCtrlDoanKhach.DataSource = doankhachBUS.LoadFind();
            
        }

        private void btt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btt_Select_Click(object sender, EventArgs e)
        {
            if (gridView_DoanKhach.RowCount != 0)
            {
                UI.Form_TimKiemVaChonDoanKhach.dtRow = gridView_DoanKhach.GetFocusedDataRow();

                Close();
            }
       
        }
        private void Close()
        {
            this.ParentForm.Dispose();
        }
    }
}

