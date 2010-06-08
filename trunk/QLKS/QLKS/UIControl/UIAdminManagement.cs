using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.BUS;
using QLKS.VO;

namespace QLKS.UIControl
{
    public partial class UIAdminManagement : UserControl
    {
        #region Data members
        private AdminBUS adminBUS;
        private AdminVO adminVO;
        private BindingSource adminBindingSource = new BindingSource();
        private BindingSource adminRoleBindingSource = new BindingSource();
        #endregion

        public UIAdminManagement()
        {
            InitializeComponent();    
            adminBUS = new AdminBUS();
        }

        #region Helpers
        private void loadGrid()
        {
            adminVO = adminBUS.getVO();

            adminBindingSource.DataSource = adminVO.DataSet;
            adminBindingSource.DataMember = "ADMINS";

            adminRoleBindingSource.DataSource = adminBindingSource;
            adminRoleBindingSource.DataMember = "ADMINS__QUYEN_ADMIN";

            adminGridControl.DataSource = adminBindingSource;
            adminRoleGridControl.DataSource = adminRoleBindingSource;

        }
        #endregion

        #region Event Handlers
        #endregion


    }
}
