using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using QLKS_DichVu.BUS;
using QLKS_DichVu.VO;
using QLKS_DichVu.UIControl;

namespace QLKS_DichVu.UI
{
    public partial class ServicesManagementForm : Form
    {
        #region Constructors
        public ServicesManagementForm()
        {
            InitializeComponent();
        }// end default constructor

        public ServicesManagementForm( Form main ) :  this()
        {
            this.MainForm = main;

            // Load controls
            UIServicesManagement mainUI = new UIServicesManagement();
            mainUI.Dock = DockStyle.Fill;
            this.Controls.Add(mainUI);
        }// end constructor

        #endregion // end region Constructors

        #region Methods
           
        #endregion // end region Methods

        #region Attributes
        public Form MainForm
        {
            get { return mainForm; }
            set { this.mainForm = value; }
        }// end attribute MainForm

        //public DBConnection Connection
        //{
        //    get { return connection; }
        //    set { this.connection = value; }
        //}// end attribute Connection
        #endregion // end region Attributes
        
        #region Event-Handling Methods
        private void ServicesManagementForm_Load(object sender, EventArgs e)
        {
            //LoadData();
            
            //panelDataEditor.Controls.Add( serviceInput );
        }// end method ServicesManagementForm_Load

        private void ServicesManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Close();
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
        private Form mainForm;              // main application's form.
        #endregion //end region Instance Fields

        #region temp
        
        #endregion // end region temp
    }// end class ServicesManagementForm
}// end namespace QLKS_DichVu.UI