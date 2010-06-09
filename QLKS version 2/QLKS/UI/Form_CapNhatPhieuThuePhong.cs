using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKS.UIControl;

namespace QLKS.UI
{
    public partial class Form_CapNhatPhieuThuePhong : DevExpress.XtraEditors.XtraForm
    {

        CapNhatPhieuThuePhong_UI capNhatPhieuThuePhongUI = new CapNhatPhieuThuePhong_UI();
   
    
        public Form_CapNhatPhieuThuePhong()
        {
            InitializeComponent();
        }

        private void Form_CapNhatPhieuThuePhong_Load(object sender, EventArgs e)
        {
            this.Controls.Add(capNhatPhieuThuePhongUI);
            capNhatPhieuThuePhongUI.Dock = DockStyle.Fill;
            this.MinimumSize = capNhatPhieuThuePhongUI.MinimumSize;
        }
    }
}