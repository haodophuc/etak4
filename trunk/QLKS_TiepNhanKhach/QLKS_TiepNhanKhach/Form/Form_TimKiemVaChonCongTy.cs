using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKS_TiepNhanKhach.UI;

namespace QLKS_TiepNhanKhach
{
   
    public partial class  Form_TimKiemVaChonCongTy : Form
    {
        private TimkiemvaChonCongTyUI timkiemvachonCongTyUI = new TimkiemvaChonCongTyUI();
        static public DataRow dtRow;
        static public int i;
        public  Form_TimKiemVaChonCongTy()
        {
            InitializeComponent();
        }

        private void  Form_TimKiemVaChonCongTy_Load(object sender, EventArgs e)
        {
            this.Controls.Add(timkiemvachonCongTyUI);
            timkiemvachonCongTyUI.Dock = DockStyle.Fill;

        }

        public DataRow ShowModal()
        {
            ShowDialog();
            return dtRow ;
        }
    }
}