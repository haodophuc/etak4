using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS_DichVu.VO;


namespace QLKS_DichVu.UIControl
{
    public partial class UIServicesManagement : UserControl
    {
       #region Constructors

        public UIServicesManagement()
        {
            InitializeComponent();
            isLoaded = false;
            LoadControls();           
           
        }//end default constructor

        public UIServicesManagement(Form parent) : this()
        {
            this.Parent = parent;
            UIServicesInputAdd panel = (UIServicesInputAdd)tabAddService.Controls[0];
            SetParentAcceptButton(panel.AcceptButton);
        }//end constructor

       #endregion //end region Constructors


       #region Methods

        public void InsertService() {
            ServiceVO service = inputAddUI.Data;
            try
            {
                gridViewUI.InsertNewService(service);
            }//end try
            catch( Exception e )
            {
                MessageBox.Show(e.Message);
            }//end catch
        }//end method Insert

        public void DeleteService() {
            ServiceVO service = inputUpdateUI.GetData();
            gridViewUI.DeleteService(service);
        }//end method DeleteService

        public void UpdateService() {
            ServiceVO service = inputUpdateUI.GetData();
            gridViewUI.UpdateSevice(service);
        }//end method UpdateService

        private void LoadControls() {
            // Plug data grid view
            gridViewUI = new UIServiceGridView(this);
            gridViewUI.Dock = DockStyle.Fill;
            mainContainer.Panel1.Controls.Add(gridViewUI);

            // Plug adding panel
            inputAddUI = new UIServicesInputAdd(this);
            inputAddUI.Dock = DockStyle.Fill;
            tabAddService.Controls.Add(inputAddUI);

            // Plug updating panel
            inputUpdateUI = new UIServicesInputUpdate(this);
            inputUpdateUI.Dock = DockStyle.Fill;
            tabUpdateService.Controls.Add(inputUpdateUI);

            isLoaded = true;
        }//end method LoadControls

        // Load data from grid view to updating panel
        public void LoadUpdatePanel()
        {
            ServiceVO service = gridViewUI.GetSelectedService();
            inputUpdateUI.SetData( service );
        }//end method LoadUpdatePanel

        // Check if all controls were fully loaded or not.
        public bool IsLoaded()
        {
            return isLoaded;
        }//end method IsLoaded

        public void SetParentAcceptButton(Button button)
        {
            Form parentForm = (Form)this.Parent;
            parentForm.AcceptButton = button;
        }//end method SetParentAcceptButton

       #endregion //end region Methods


       #region Event Handling Methods

        private void tabContainer_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (tabContainer.SelectedTabPage.Name == "tabAddService")
            {
                UIServicesInputAdd panel = (UIServicesInputAdd)tabAddService.Controls[0];
                SetParentAcceptButton(panel.AcceptButton);
            }//end if
            else
            {
                UIServicesInputUpdate panel = (UIServicesInputUpdate)tabUpdateService.Controls[0];
                SetParentAcceptButton(panel.AcceptButton);
            }//end else                
        }//end method tabContainer_SelectedPageChanged

       #endregion //end region Event Handling Methods


       #region Attributes
       #endregion //end region Attributes
        

       #region Instance Fields
        private UIServiceGridView gridViewUI;
        private UIServicesInputAdd inputAddUI;
        private UIServicesInputUpdate inputUpdateUI;
        private bool isLoaded;
       #endregion Instance Fields


    }//end class UIServicesManagement
}//end namespace QLKS_DichVu.UIControl
