using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using QLKS.UI;
using QLKS.Controls;
using QLKS.Base;

namespace QLKS.UIControl
{
    public partial class UICustomerInfoPanel : UserControl
    {

       #region Constructors

        public UICustomerInfoPanel()
        {
            InitializeComponent();

            customer = null;
            isNewCustomer = false;
        }//end default constructor

        public UICustomerInfoPanel(UITransaction parent, Mode.SubmitMode mode  )
            : this()
        {
            this.ParentUI = parent;
            SubmitMode = mode;
            GridControl.DataSource = ParentUI.RegData.Customers;
            IniGridView();
            LoadCountries();
        }//end constructor

       #endregion //end region Constructors


       #region Methods

        private void LoadContols()
        {
            if (SubmitMode == Mode.SubmitMode.Booking)
                LoadBookingControls();
            else
                LoadCheckingControls();
        }//end method LoadControls

        private void LoadBookingControls()
        {

        }

        private void LoadCheckingControls()
        {

        }


        private void IniGridView() {

            RepositoryItemLookUpEdit lookupRoom = new RepositoryItemLookUpEdit();
            lookupRoom.DataSource = ParentUI.RegData.Rooms;
            lookupRoom.DisplayMember = "RoomNumber";
            lookupRoom.ValueMember = "RoomID";

            LookUpColumnInfoCollection cols = lookupRoom.Columns;
            cols.Add(new LookUpColumnInfo("RoomNumber", "Số Phòng", 0));
            cols.Add(new LookUpColumnInfo("RoomType", "Loại Phòng", 0));
            cols.Add(new LookUpColumnInfo("Beds", "Số Giường", 0));
            lookupRoom.BestFitMode = BestFitMode.BestFitResizePopup;
            lookupRoom.NullText = "Chưa chọn phòng";
            GridView.Columns["RoomNumber"].ColumnEdit = lookupRoom;
            GridView.Columns["CustomerID"].Visible = false;
            GridView.Columns["IsNew"].Visible = false;

        }//end method SetLookUpEdit

        private void LoadCountries()
        {
            try {
                // Get table data
                BUS.QuocGiaBUS bus = new BUS.QuocGiaBUS();
                DataTable countries = bus.GetAll();

                countries.TableName = "Countries";

                // Create BindingSource
                DataSet ds = new DataSet();
                ds.Tables.Add(countries);
                BindingSource binding = new BindingSource(ds, "Countries");

                // Add binding data source to LookUpEdit
                textBoxCountry.DataBindings.Add("EditValue", binding, "MA_QUOC_GIA");
                textBoxCountry.Properties.DataSource = binding;

                // Set ValueMember and DisplayMember
                textBoxCountry.Properties.DisplayMember = "TEN_QUOC_GIA";
                textBoxCountry.Properties.ValueMember = "MA_QUOC_GIA";

                LookUpColumnInfoCollection cols = textBoxCountry.Properties.Columns;
                cols.Add(new LookUpColumnInfo("TEN_QUOC_GIA", "Quốc Gia", 0));

                textBoxCountry.EditValue = 0;
            
            }//end try
            catch ( Exception ex ) {
                Notice.ShowError(ex.Message);            
            }//end catch
           

        }//end method LoadCountries

        private void LoadData( DataRow row )
        {
            customer = row;
            isNewCustomer = false;
            textBoxCustomerID.Text = customer["MA_KHACH_HANG"].ToString();
            textBoxFirstName.Text = customer["TEN_KHACH_HANG"].ToString();
            textBoxLastName.Text = customer["HO_KHACH_HANG"].ToString();
            textBoxCountry.Text = customer["TEN_QUOC_GIA"].ToString();
            textBoxPhone.Text = customer["DIEN_THOAI"].ToString();
            textBoxPassPort.Text = customer["HO_CHIEU"].ToString();
            textBoxCMND.Text = customer["CMND"].ToString();
        }//end method LoadData

        private void NewCustomer()
        {
            Reset();
            textBoxFirstName.Properties.ReadOnly = false;
            textBoxLastName.Properties.ReadOnly = false;
            textBoxPassPort.Properties.ReadOnly = false;
            textBoxPhone.Properties.ReadOnly = false;
            textBoxCMND.Properties.ReadOnly = false;
            buttonCancel.Visible = true;
            isNewCustomer = true;

        }//end method NewCustomer

        public void Reset()
        {
            customer = null;
            textBoxCustomerID.Text = null;
            textBoxFirstName.Text = null;
            textBoxLastName.Text = null;
            textBoxPassPort.Text = null;
            textBoxPhone.Text = null;
            textBoxCMND.Text = null;
            textBoxDeposit.Text = null;

            textBoxFirstName.Properties.ReadOnly = true;
            textBoxLastName.Properties.ReadOnly = true;
            textBoxPassPort.Properties.ReadOnly = true;
            textBoxPhone.Properties.ReadOnly = true;
            textBoxCMND.Properties.ReadOnly = true;

            buttonCancel.Visible = false;
            isNewCustomer = false;
        }//end method Reset

        private void AddCustomer()
        {
            DataRow row = ParentUI.RegData.Customers.NewRow();
            //ParentUI.RegData.Deposit = Decimal.Parse(textBoxDeposit.Text);
            if (!isNewCustomer)
            {
                row["CustomerID"] = customer["MA_KHACH_HANG"];
                row["LastName"] = customer["HO_KHACH_HANG"];
                row["FirstName"] = customer["TEN_KHACH_HANG"];
                row["SocialID"] = customer["CMND"];
                row["PassPort"] = customer["HO_CHIEU"];
                row["Phone"] = customer["DIEN_THOAI"];
                row["CountryID"] = customer["MA_QUOC_GIA"];
                row["Country"] = customer["TEN_QUOC_GIA"];
                row["IsOwner"] = false;
            }//end if
            else
            {
                //row["CustomerID"] = textBoxCustomerID.Text;
                row["LastName"] = textBoxLastName.Text;
                row["FirstName"] = textBoxFirstName.Text;
                row["SocialID"] = textBoxCMND.Text;
                row["PassPort"] = textBoxPassPort.Text;
                row["Phone"] = textBoxPhone.Text;
                row["CountryID"] = textBoxCountry.EditValue;
                row["IsNew"] = true;
                row["IsOwner"] = false;
            }//end else

            try {
                ParentUI.RegData.Customers.Rows.Add(row);
            }//end try
            catch( ConstraintException ) {
                Notice.ShowError("Khách hàng đã có trong danh sách!");                
            }//end catch 

            Reset();
            
        }//end method AddCustomer

        private void SetRoomOwner()
        {
            DataRow row = GridView.GetFocusedDataRow();

            //String value = row["RoomNumber"].ToString();

            if (row["RoomNumber"].ToString() == String.Empty)
                Notice.ShowWarning("Khách hàng chưa được sắp phòng");
            else
            {
                int roomNumber = (int)row["RoomNumber"];
                int customerID = (int)row["CustomerID"];
                ParentUI.RegData.SetRoomOwner((int)row["RoomNumber"], (int)row["CustomerID"]);
            }//end else
                

        }//end method SetRoomOwner

        private bool VerifyData()
        {
            bool valid = true;
            if (isNewCustomer)
            {
                if (textBoxFirstName.Text == StyledTextBox.DefaultNullText ||
                    textBoxLastName.Text == StyledTextBox.DefaultNullText ||
                    textBoxCMND.Text == StyledTextBox.DefaultNullText ||
                    textBoxPassPort.Text == StyledTextBox.DefaultNullText)
                {
                    valid = false;
                }//end if : check data                    
            }//end if : new customer
            else
            {
                if( customer == null)
                    valid = false;
            }//end else
            return valid;
        }//end method Validate

       #endregion //end region Methods


       #region Event Handling Methods

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Reset();
            Form_TimKiemVaChonKhachHang form = new Form_TimKiemVaChonKhachHang();
            DataRow row = form.ShowModal();
            if (row != null)
            {
                LoadData(row);
            }//end if
        }//end method buttonFind_Click

        private void buttonNew_Click(object sender, EventArgs e)
        {
              NewCustomer();
        }//end method buttonNew_Click

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Reset();
            buttonCancel.Visible = false;
        }//end method buttonCancel_Click

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (VerifyData() == true)
            {
                AddCustomer();
            }//end if
            else
            {
                Notice.ShowError("Hãy điền hết thông tin cần thiết");
            }//end else
        }//end method buttonAdd_Click

        private void buttonSetOwner_Click(object sender, EventArgs e)
        {
            SetRoomOwner();
        }//end method buttonSetOwner_Click

        private void buttonDel_Click(object sender, EventArgs e)
        {
            GridView.DeleteRow(GridView.FocusedRowHandle);
        }//end method buttonDel_Click

       #endregion //end region Event Handling Methods


       #region Attributes

        public DevExpress.XtraGrid.GridControl GridControl
        {
            get { return gridControl; }
        }//end attribute GridControl

        public DevExpress.XtraGrid.Views.Grid.GridView GridView
        {
            get { return gridView; }
        }//end attribute GridView

        public UITransaction ParentUI
        {
            get { return parentUI; }
            set { this.parentUI = value; }
        }//end attribute UIParent

        public Base.Mode.SubmitMode SubmitMode
        {
            get { return submitMode; }
            set { this.submitMode = value; }
        }//end attribute SubmitMode

       #endregion //end region Attributes


       #region Instance Fields
        private UITransaction parentUI;
        private DataRow customer;
        private bool isNewCustomer;
        private Mode.SubmitMode submitMode;
       #endregion Instance Fields


        
        
    }//end class UICustomerInfoPanel
}//end namespace
