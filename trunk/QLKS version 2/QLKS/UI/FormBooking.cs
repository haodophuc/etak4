using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKS.UI
{
    public partial class FormBooking : Form
    {
        public FormBooking()
        {
            InitializeComponent();
            UIControl.UITransaction mainUI = new QLKS.UIControl.UITransaction(Base.Mode.SubmitMode.Booking);
            mainUI.Dock = DockStyle.Fill;
            Controls.Add(mainUI);
        }
    }
}