using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;

namespace QLKS_TiepNhanKhach
{
    public partial class Form_DemoSelect : Form
    {
        public Form_DemoSelect()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form_TimKiemVaChonKhachHang frm = new Form_TimKiemVaChonKhachHang();

            DataRow dtrow = frm.ShowModal();
            if (dtrow != null)
            {
                textEdit1.Text = dtrow[0].ToString();
            }

       
         


        }
    }
}