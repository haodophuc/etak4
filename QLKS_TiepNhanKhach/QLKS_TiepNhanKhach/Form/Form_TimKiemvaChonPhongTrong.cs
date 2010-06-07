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
   
    public partial class  Form_TimKiemvaChonPhongTrong : Form
    {
        private TimKiemVaChonPhongTrongUI timkiemvachonphongtrongUI = new TimKiemVaChonPhongTrongUI();
        static public DataRow dtRow;
        static public int i;
        public  Form_TimKiemvaChonPhongTrong()
        {
            InitializeComponent();
        }

        private void  Form_TimKiemvaChonPhongTrong_Load(object sender, EventArgs e)
        {
            this.Controls.Add(timkiemvachonphongtrongUI);
            timkiemvachonphongtrongUI.Dock = DockStyle.Fill;

        }

        public DataRow ShowModal()
        {
            ShowDialog();
            return dtRow ;
        }
    }
}