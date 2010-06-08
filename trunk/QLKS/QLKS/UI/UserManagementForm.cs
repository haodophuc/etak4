using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKS.UIControl;
using QLKS.BUS;
using QLKS.VO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;

namespace QLKS.UI
{
    public partial class UserManagementForm : DevExpress.XtraEditors.XtraForm
    {
        #region constructors
        public UserManagementForm()
        {
            InitializeComponent();
        }
        #endregion

        private void loadUIControl()
        {
            UIAdminManagement adminManagementUI = new UIAdminManagement();
            adminManagementUI.Dock = DockStyle.Fill;
            adminTabPage.Controls.Add(adminManagementUI);

            UITellerManagement tellerManagementUI = new UITellerManagement();
            tellerManagementUI.Dock = DockStyle.Fill;
            tellerTabPage.Controls.Add(tellerManagementUI);
        }


    }
}