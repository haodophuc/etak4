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

    public partial class Form_TimKiemVaChonDoanKhach : DevExpress.XtraEditors.XtraForm
    {
        private TimkiemvaChonDoanKhachUI timkiemvachondoankhachhUI = new TimkiemvaChonDoanKhachUI();
        static public DataRow dtRow;
        static public int i;
        public  Form_TimKiemVaChonDoanKhach()
        {
            InitializeComponent();
        }

        private void  Form_TimKiemVaChonDoanKhach_Load(object sender, EventArgs e)
        {
            this.Controls.Add(timkiemvachondoankhachhUI);
            timkiemvachondoankhachhUI.Dock = DockStyle.Fill;

        }

        public DataRow ShowModal()
        {
            ShowDialog();
            return dtRow ;
        }
    }
}