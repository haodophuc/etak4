using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKS_TiepNhanKhach
{
    public partial class FormCheckIn : Form
    {
        public FormCheckIn()
        {
            InitializeComponent();
            UI.UITransaction panel = new QLKS_TiepNhanKhach.UI.UITransaction();
            panel.Dock = DockStyle.Fill;
            this.Size = panel.Size;
            this.panelMainContainer.Controls.Add(panel);
        }
    }
}