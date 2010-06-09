using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using QLKS.BUS;
using QLKS.VO;
using QLKS.UIControl;

namespace QLKS.UI
{
    public partial class ServicesManagementForm : DevExpress.XtraEditors.XtraForm
    {
        #region Constructors

        public ServicesManagementForm()
        {
            InitializeComponent();
            // Load controls
            UIServicesManagement mainUI = new UIServicesManagement(this);
            mainUI.Dock = DockStyle.Fill;
            this.Controls.Add(mainUI);
        }// end default constructor

        #endregion // end region Constructors


        #region Methods
        #endregion // end region Methods


        #region Attributes

        #endregion // end region Attributes
        

        #region Event-Handling Methods

        private void ServicesManagementForm_Load(object sender, EventArgs e)
        {
            //LoadData();
            
            //panelDataEditor.Controls.Add( serviceInput );
        }// end method ServicesManagementForm_Load

        private void ServicesManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }// end method ServicesManagementForm_FormClosed

        private void gridViewService_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int row = e.ControllerRow;
            //DataRow dataRow = gridViewService.GetDataRow(row);
        }// end method gridViewService_SelectionChanged

        private void gridViewService_Click(object sender, EventArgs e)
        {
            //textBox3.Text = GetServiceID( gridViewService );
        }// end method gridViewService_Click

        #endregion


        #region Instance Fields

        #endregion //end region Instance Fields

    }// end class ServicesManagementForm
}// end namespace QLKS.UI