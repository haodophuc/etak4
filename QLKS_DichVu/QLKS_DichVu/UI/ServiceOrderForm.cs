using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKS_DichVu.BUS;

namespace QLKS_DichVu.UI
{
    public partial class ServiceOrderForm : Form
    {
        private LoginForm loginForm;
        private ServiceOrderBUS serviceOrderBUS;

        public ServiceOrderForm(LoginForm loginForm, DBConnection dbConnection)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            serviceOrderBUS = new ServiceOrderBUS(dbConnection);
        }

        #region Helpers
        public void loadServiceDataGridView()
        {
            DataTable dt = serviceOrderBUS.getServiceOrderByRoomID(roomIDTextBox.Text);
            serviceOrderDataGridView.DataSource = dt;
        }
        #endregion

        #region Event Handlers
        private void ServiceOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
        }

        private void ServiceOrderForm_Load(object sender, EventArgs e)
        {
            CenterToParent();            
        }

        private void searchServiceOrderButton_Click(object sender, EventArgs e)
        {
            loadServiceDataGridView();
        }
        #endregion

    }
}