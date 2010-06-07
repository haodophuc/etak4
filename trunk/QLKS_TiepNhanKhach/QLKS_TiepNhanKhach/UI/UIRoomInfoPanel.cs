using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using QLKS_TiepNhanKhach.Base;
using QLKS_TiepNhanKhach.Controls;

namespace QLKS_TiepNhanKhach.UI
{
    public partial class UIRoomInfoPanel : UserControl
    {

       #region Constructors

        public UIRoomInfoPanel()
        {
            InitializeComponent();
            LoadCountry();
        }//end default constructor

        public UIRoomInfoPanel(Mode.SubmitMode mode) : this()
        {
            this.SubmitMode = mode;
        }//end constructor

       #endregion //end region Constructors


       #region Methods

        private void LoadCheckingControls()
        {
            textBoxQuantity.Enabled = false;

        }//end method CheckingControls

        private void LoadBookingControls()
        {
            textBoxQuantity.Enabled = true;
        }//end method BookingControls

        private void LoadCountry()
        {
            // Get table data
            DataTable types = new DataTable();
            BUS.LoaiPhongBUS bus = new BUS.LoaiPhongBUS();
            types = bus.GetAll();

            // Create BindingSource
            DataSet ds = types.DataSet;
            BindingSource binding = new BindingSource(ds, "Table");

            // Add binding data source to LookUpEdit
            textBoxRoomType.DataBindings.Add("EditValue", binding, "MA_LOAI_PHONG");
            textBoxRoomType.Properties.DataSource = binding;

            // Set ValueMember and DisplayMember
            textBoxRoomType.Properties.DisplayMember = "TEN_LOAI_PHONG";
            textBoxRoomType.Properties.ValueMember = "MA_LOAI_PHONG";

            LookUpColumnInfoCollection cols = textBoxRoomType.Properties.Columns;
            cols.Add( new LookUpColumnInfo("TEN_LOAI_PHONG", "Loại Phòng", 0));
            cols.Add(new LookUpColumnInfo("SO_GIUONG", "Số Giường", 0));
            cols.Add(new LookUpColumnInfo("GIA_THAM_KHAO", "Đơn Giá", 0));
            

            // Let LookUpEdit control automically chooses the best size for columns and popup window
            textBoxRoomType.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }//end method LoadComboBox

       #endregion //end region Methods


       #region Event Handling Methods

        private void textBoxRoomType_Properties_EditValueChanged(object sender, EventArgs e)
        {
            // Get selected DataRpw
            DataRowView rowView = (DataRowView)textBoxRoomType.Properties.GetDataSourceRowByKeyValue(textBoxRoomType.EditValue);
            DataRow row = rowView.Row;

            textBoxBeds.Text = row["SO_GIUONG"].ToString();
            textBoxPrice.Text = row["GIA_THAM_KHAO"].ToString();
        }//end method textBoxRoomType_Properties_EditValueChanged

       #endregion //end region Event Handling Methods


       #region Attributes
        public Mode.SubmitMode SubmitMode
        {
            get { return this.submitMode; }
            set
            {
                this.submitMode = value;
                if (SubmitMode == Mode.SubmitMode.CheckIn)
                {
                    LoadCheckingControls();
                }//end if
                else
                {
                    LoadBookingControls();
                }//end else
            }//end method set
        }//end attribute Mode
       #endregion //end region Attributes


       #region Instance Fields
        private Mode.SubmitMode submitMode;       

       #endregion Instance Fields


    }//end class UIRoomInfoPanel
}//end namespace
