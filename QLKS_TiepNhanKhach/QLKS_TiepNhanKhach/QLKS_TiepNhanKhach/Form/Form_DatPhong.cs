using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKS_TiepNhanKhach
{
    public partial class Form_DatPhong : Form
    {
        UI.DatPhong_UI datphongUI;
        public Form_DatPhong(DBConnection dbconnection)
        {
            InitializeComponent();
            datphongUI = new UI.DatPhong_UI(dbconnection);
        }

        private void Form_DatPhong_Load(object sender, EventArgs e)
        {
            this.Controls.Add(datphongUI);
        }
    }
}