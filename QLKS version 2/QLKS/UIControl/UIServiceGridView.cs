using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using QLKS.VO;
using QLKS.BUS;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLKS.UIControl
{
    public partial class UIServiceGridView : DevExpress.XtraEditors.XtraUserControl
    {
       #region Constructors
       
        public UIServiceGridView()
        {
            InitializeComponent();
        }//end default constructor

        public UIServiceGridView( UIServicesManagement parent ) : this()
        {
            // Initialize BUS
            serviceBUS = new ServiceBUS();
            this.ParentUI = parent;
            LoadData();
        }//end constructor
        
       #endregion //end region Constructors


       #region Methods
        
        // Load data to grid view
        public void LoadData()
        {
            DataTable dt = serviceBUS.GetAllServices();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            this.gridControlServices.DataSource = bindingSource;
        }//end method LoadData
        
        // Return the focused row on the view
        public DataRow GetSelectedRow()
        {
            DataRow datarow;
            
            int selected = gridViewServices.FocusedRowHandle;

            if (selected == DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                datarow = null;
            }//end if
            else {
                // Get row data
                datarow = gridViewServices.GetDataRow(selected);
            }//end else

            return datarow;
        }//end method GetSelectedRow

        // Delete a given service
        public void DeleteService( ServiceVO service )
        {
            String serviceID = service.ID;
            int selectedrow = gridViewServices.FocusedRowHandle;
            try
            {
                int result = serviceBUS.DeleteService(service);
                if (result != -1)
                {
                    LoadData();
                    SelectRow(selectedrow - 1);
                    //ShowMessage("Xóa dịch vụ thành công");                    
                }// end if
            }//end try
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    ShowError("Dịch vụ đã được sử dụng ở dữ liệu khác. Vui lòng dùng \"Tắt dịch vụ\"");
                }//end case: error 547
            }//end catch SqlException
            catch (Exception ex)
            {
                ShowError( ex.Message );
            }//end catch Exception
        }//end method DeleteSelected

        // Insert a new service
        public void InsertNewService( ServiceVO service )
        {
            try
            {
                int result = serviceBUS.InsertService( service );
                if (result == -1) {
                    ShowError("Không thể thêm dịch vụ mới");
                }// end if
                else {
                    LoadData();
                    SelectRow(gridViewServices.RowCount - 1);
                }
            }//end try
            catch ( Exception exp )
            {
                ShowError( exp.Message );
            }//end catch
        }//end method InsertNewService

        // Update a service
        public void UpdateSevice( ServiceVO service )
        {
            int selectedrow = gridViewServices.FocusedRowHandle;
            try {
                int result = serviceBUS.UpdateService( service );
                if (result == -1) {
                    ShowError("Không thể cập nhật dịch vụ");
                }//end if
                else {
                    LoadData();
                    SelectRow(selectedrow);
                }//end else
            }//end try
            catch (Exception e) {
                ShowError(e.Message);
            }//end catch
        }//end method UpdateService

        // Show a regular message box
        private void ShowMessage( String message )
        {
            MessageBox.Show(message, "Quản Lý Dịch Vụ Khách Sạn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//end method ShowMessage

        // Show a error message box
        private void ShowError( String error ) {
            MessageBox.Show( this.Parent, error, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }//end method ShowError

        // Return values of focused row but as a ServiceVO object
        public ServiceVO GetSelectedService()
        {
            // Get row data
            DataRow datarow = GetSelectedRow();

            if (datarow == null) {
                return null;
            }//end if
            else {
                String id = datarow[0].ToString();
                String name = datarow[1].ToString();
                Double price = Double.Parse(datarow[2].ToString());
                bool state = Boolean.Parse(datarow[3].ToString());

                return new ServiceVO(id, name, price, state);
            }//end else            
        }//end method GetSelectedService

        // Send values to Update Editor
        private void SendData()
        {
            if (ParentUI.IsLoaded())
                ParentUI.LoadUpdatePanel();
        }//end method 

        // Select a row in view
        public void SelectRow(int row)
        {
            gridViewServices.FocusedRowHandle = row;
            gridViewServices.SelectRow(row);
        }//end method SelectRow

        // Switch current view mode to another mode
        public void SwitchViewMode(ViewMode mode)
        {
            switch (mode) { 
                case ViewMode.AllItems:
                    ClearAllFilter();
                    break;
                case ViewMode.ContinuedItems:
                    break;
                case ViewMode.DiscontinuedItems:
                    SetFilter("HIEU_LUC", "[HIEU_LUC] = false", "Hiển thị các dịch vụ ngừng hoạt động");
                    break;
            }//end switch
        }//end method SwitchViewMode

        public void SetFilter(String column, String filterString, String filterName)
        {
            DevExpress.XtraGrid.Columns.ColumnFilterInfo filter = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(filterString, filterName);
            gridViewServices.Columns[column].FilterInfo = filter;
        }//end method SetFilter

        public void ClearAllFilter()
        {
            gridViewServices.ActiveFilterString = String.Empty;
        }//end method ClearAllFilter

       #endregion //end region Methods


       #region Event Handling Methods

        private void gridViewServices_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SendData();
        }//end method gridViewServices_FocusedRowChanged

        private void gridViewServices_ColumnFilterChanged(object sender, EventArgs e)
        {
            SendData();
        }//end methdo gridViewServices_ColumnFilterChanged

        private void radioGroupViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchViewMode((ViewMode)radioGroupViewMode.SelectedIndex);
        }//end method radioGroupViewMode_SelectedIndexChanged

       #endregion //end region Event Handling Methods


       #region Attributes
        public enum ViewMode:int { AllItems, ContinuedItems, DiscontinuedItems };
        public UIServicesManagement ParentUI {
            get { return this.parentUI; }
            set { this.parentUI = value; }
        }//end attribute ParentUI
       #endregion //end region Attributes


       #region Instance Fields
        private ServiceBUS serviceBUS;
        private UIServicesManagement parentUI;
       #endregion //end region Instance Fields


    }//end class ServiceGridView
}//end namespace QLKS.UIControl
