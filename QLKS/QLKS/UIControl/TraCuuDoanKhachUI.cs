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
    public partial class TraCuuDoanKhachUI : UserControl
    {
    
        private DoanKhachBUS doankhachBUS = new DoanKhachBUS();
        public TraCuuDoanKhachUI()
        {
            InitializeComponent();
            grdCtrlDoanKhach.DataSource = doankhachBUS.GetAll();
            
        }

        private void btt_Cancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.Dispose();
        }


      

       
      
    }
}
