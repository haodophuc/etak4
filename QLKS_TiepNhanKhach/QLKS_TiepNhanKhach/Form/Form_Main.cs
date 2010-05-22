using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKS_TiepNhanKhach
{
    public partial class Form_Main : Form
    {
        DBConnection dbConnection;
        public Form_Main(DBConnection dbConnection)
        {
            this.dbConnection = dbConnection;
            InitializeComponent();
            
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void StripMenu_CapNhatPhong_Click(object sender, EventArgs e)
        {
            Form_CapNhatPhong frmCapNhatPhong = new Form_CapNhatPhong(dbConnection);
            frmCapNhatPhong.MdiParent = this;
            frmCapNhatPhong.Show();
        }

        private void StripMenu_DatPhong_Click(object sender, EventArgs e)
        {
            Form_DatPhong frmDatPhong = new Form_DatPhong(dbConnection);
            frmDatPhong.MdiParent = this;
            frmDatPhong.Show();
        }
    }
}