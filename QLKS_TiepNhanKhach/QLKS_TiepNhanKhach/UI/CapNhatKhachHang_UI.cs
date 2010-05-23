using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS_TiepNhanKhach.BUS;

namespace QLKS_TiepNhanKhach.UI
{
    public partial class CapNhatKhachHang_UI : UserControl
    {
        DBConnection dbConnection;
        KhachHangBUS khachHangBUS;
        QuocGiaBUS quocGiaBUS;
        
        public CapNhatKhachHang_UI(DBConnection dbConnection)
        {
            InitializeComponent();
            this.dbConnection = dbConnection;
            khachHangBUS = new KhachHangBUS(dbConnection);
            quocGiaBUS = new QuocGiaBUS(dbConnection);
        }

        private void CapNhatKhachHang_UI_Load(object sender, EventArgs e)
        {
            DataTable dtTableKH = new DataTable();
            dtTableKH = khachHangBUS.getAllFromKhachHang();
            bindingSourceKhachHang.DataSource = dtTableKH;
            bindingNavigatorKhachHang.BindingSource =bindingSourceKhachHang;
            grdKhachHang.DataSource = bindingNavigatorKhachHang.BindingSource;

            DataTable dtTableQG = new DataTable();
            dtTableQG = quocGiaBUS.getAllFromQuocGia();


            lkMaQuocGia.Properties.DataSource = dtTableQG;

            lkMaQuocGia.Properties.DisplayMember = dtTableQG.Columns[1].ToString();
            lkMaQuocGia.Properties.ValueMember = dtTableQG.Columns[0].ToString();
            

        }

      

     

        
    }
}
