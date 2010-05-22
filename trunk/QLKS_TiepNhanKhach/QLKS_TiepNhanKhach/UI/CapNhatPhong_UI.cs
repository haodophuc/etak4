using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using QLKS_TiepNhanKhach.BUS;

namespace QLKS_TiepNhanKhach.UI
{
    public partial class CapNhatPhong_UI : UserControl
    {
         DBConnection dbConnection;
         PhongBUS phongBUS;

        public CapNhatPhong_UI(DBConnection dbConnection)
        {
            InitializeComponent();
             this.dbConnection = dbConnection;
        }

        private void CapNhatPhong_UI_Load(object sender, EventArgs e)
        {
            phongBUS = new PhongBUS(dbConnection);
            DataTable dataTable = phongBUS.getAllFromPhong();
            if (dataTable == null)
            {
                MessageBox.Show(dbConnection.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                grd_Phong.DataSource = dataTable;
            }
        }
       

      
 


      
    }
}
