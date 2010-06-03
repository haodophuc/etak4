using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKS_DichVu.UI
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void menuItemRunSM_Click(object sender, EventArgs e)
        {
            ServicesManagementForm sm = new ServicesManagementForm();
            sm.MdiParent = this;
            sm.Show();
        }

        private void menuItemRunSR_Click(object sender, EventArgs e)
        {
            ServicesOrderForm so = new ServicesOrderForm();
            so.MdiParent = this;
            so.Show();
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }


    }//end class MainForm
}//end namespace