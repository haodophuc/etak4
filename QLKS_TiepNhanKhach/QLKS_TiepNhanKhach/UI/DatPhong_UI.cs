using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QLKS_TiepNhanKhach.UI
{
    public partial class DatPhong_UI : UserControl
    {
        private DBConnection dbConnection;

        public DatPhong_UI(DBConnection dbConnection)
        {
            InitializeComponent();
            this.dbConnection = dbConnection;
        }

        private void DatPhong_UI_Load(object sender, EventArgs e)
        {

        }

        

      

      
    }
}
