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
    public partial class FormCheckIn : Form
    {
        public FormCheckIn()
        {
            InitializeComponent();
            UITransaction panel = new UITransaction();
            panel.Dock = DockStyle.Fill;
            this.Size = panel.Size;
            this.panelMainContainer.Controls.Add(panel);
        }
    }
}