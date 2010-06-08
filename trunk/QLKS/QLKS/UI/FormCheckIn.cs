using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKS.UI
{
    public partial class FormCheckIn : Form
    {
        public FormCheckIn()
        {
            InitializeComponent();
            UIControl.UITransaction panel = new QLKS.UIControl.UITransaction(Base.Mode.SubmitMode.CheckIn);
            panel.Dock = DockStyle.Fill;
            this.Size = panel.Size;
            this.panelMainContainer.Controls.Add(panel);
        }
    }
}