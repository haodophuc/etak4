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
 
    public partial class Form_DatPhong : Form
    {
        private DatPhong_UI datphongUI;
      
        public Form_DatPhong()
        {
            InitializeComponent(); 
            datphongUI = new DatPhong_UI();
        }

        private void Form_DatPhong_Load(object sender, EventArgs e)
        {
            this.Controls.Add(datphongUI);
        }
    }
}