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
            UI.UICheckIn mainUI = new QLKS_TiepNhanKhach.UI.UICheckIn();
            mainUI.Dock = DockStyle.Fill;
            this.Size = mainUI.Size;
            this.panelMainContainer.Controls.Add(mainUI);
        }
    }
}