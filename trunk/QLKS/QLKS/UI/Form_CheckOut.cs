using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKS.UI;

namespace QLKS
{
    public partial class Form_CheckOut : Form
    {
        private CheckOutUI checkoutUI = new CheckOutUI();
        public Form_CheckOut()
        {
            InitializeComponent();
        }

        private void Form_CheckOut_Load(object sender, EventArgs e)
        {
            this.Controls.Add(checkoutUI);
            checkoutUI.Dock = DockStyle.Fill;
            this.MinimumSize = checkoutUI.MinimumSize;
        }
    }
}