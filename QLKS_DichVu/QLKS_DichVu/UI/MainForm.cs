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
        private LoginForm loginForm;
        public MainForm()
        {
            InitializeComponent();
            loginForm = new LoginForm(this);
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            // show login form as modal dialog
            loginForm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
        }

        private void menuItemRunLogin_Click(object sender, EventArgs e)
        {
            // show login form as modal dialog
            loginForm.ShowDialog();
        }


    }//end class MainForm
}//end namespace