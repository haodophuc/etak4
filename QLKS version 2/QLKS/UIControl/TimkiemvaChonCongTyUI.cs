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
    public partial class TimkiemvaChonCongTyUI : DevExpress.XtraEditors.XtraUserControl
    {
        CongtyBus congtyBUS = new CongtyBus();
       
        public TimkiemvaChonCongTyUI()
        {
            InitializeComponent();
            grdCtrlCongTy.DataSource = congtyBUS.GetAll();
        }

        private void btt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
  

      
        private void btt_Select_Click(object sender, EventArgs e)
        {
            if (gridView_CongTy.RowCount != 0)
            {
                Form_TimKiemVaChonCongTy.dtRow = gridView_CongTy.GetFocusedDataRow();

                Close();
            }

        }
        private void Close()
        {
            this.ParentForm.Dispose();
        }

       

      
    }
}
