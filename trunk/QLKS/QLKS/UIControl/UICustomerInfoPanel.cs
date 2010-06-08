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

        public UICustomerInfoPanel(UITransaction parent, DataTable table )
            : this()
        {
            this.ParentUI = parent;
            GridControl.DataSource = table;
            IniGridView();
            LoadCountries();
        }//end constructor

       #endregion //end region Constructors


       #region Methods

        private void IniGridView() {

            RepositoryItemLookUpEdit lookupRoom = new RepositoryItemLookUpEdit();
            lookupRoom.DataSource = ParentUI.DataRegister.Rooms;
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
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
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
            isNewCustomer = true;

        }//end method NewCustomer

        private void Reset()
        {
            customer = null;
            textBoxCustomerID.Text = String.Empty;
            textBoxFirstName.Text = String.Empty;
            textBoxLastName.Text = String.Empty;
            textBoxPassPort.Text = String.Empty;
            textBoxPhone.Text = String.Empty;
            textBoxCMND.Text = String.Empty;

            textBoxFirstName.Properties.ReadOnly = true;
            textBoxLastName.Properties.ReadOnly = true;
            textBoxPassPort.Properties.ReadOnly = true;
            textBoxPhone.Properties.ReadOnly = true;
            textBoxCMND.Properties.ReadOnly = true;
            isNewCustomer = false;
        }//end method Reset

        private void AddCustomer()
        {
            DataRow row = ParentUI.DataRegister.Customers.NewRow();
            if (!isNewCustomer)
            {
                row["CustomerID"] = customer["MA_KHACH_HANG"];
                row["LastName"] = customer["HO_KHACH_HANG"];
                row["FirstName"] = customer["TEN_KHACH_HANG"];
                row["SocialID"] = customer["CMND"];
                row["PassPort"] = customer["HO_CHIEU"];
                row["Phone"] = customer["DIEN_THOAI"];
                row["CountryID"] = customer["MA_QUOC_GIA"];
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
            }//end else

            try {
                ParentUI.DataRegister.Customers.Rows.Add(row);
            }//end try
            catch( ConstraintException ) {
                MessageBox.Show("Khách hàng đã có trong danh sách", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }//end catch 

            Reset();
            
        }//end method AddCustomer

       #endregion //end region Methods


       #region Event Handling Methods

        private void buttonFind_Click(object sender, EventArgs e)
        {
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

       #endregion //end region Attributes


       #region Instance Fields
        private UITransaction parentUI;
        private DataRow customer;
        private bool isNewCustomer;
       #endregion Instance Fields

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if( customer != null )
                AddCustomer();
        }//end method buttonAdd_Click

        private void styledButton1_Click(object sender, EventArgs e)
        {
            ParentUI.DataRegister.UpdateCustomers();
        }

        private void styledButton2_Click(object sender, EventArgs e)
        {
            //DataRow row = GridView.GetFocusedDataRow();
            //MessageBox.Show(row["RoomNumber"].ToString());
            //LoadCountries();
        }
        
    }//end class UICustomerInfoPanel
}//end namespace
