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
    public partial class TraCuuCongTyUI : UserControl
    {
        CongtyBus congtyBUS = new CongtyBus();
       
        public TraCuuCongTyUI()
        {
            InitializeComponent();
            grdCtrlCongTy.DataSource= congtyBUS.GetAll();
        }

        private void btt_Cancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.Dispose();
        }
  
     
    

       
       

      
    }
}
