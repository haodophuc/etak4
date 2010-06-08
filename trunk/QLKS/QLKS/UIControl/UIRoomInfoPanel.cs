using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using QLKS.Base;
using QLKS.Controls;

namespace QLKS.UIControl
{
    public partial class UIRoomInfoPanel : UserControl
    {

       #region Constructors

        public UIRoomInfoPanel()
        {
            InitializeComponent();
            if( SubmitMode == Mode.SubmitMode.Booking )
                LoadRoomTypes();
            room = null;           
        }//end default constructor

        public UIRoomInfoPanel( UITransaction parent, Mode.SubmitMode mode, DataTable table ) : this()
        {
            this.ParentUI = parent;
            this.SubmitMode = mode;
            GridControl.DataSource = table;
            IniGrid();
        }//end constructor

       #endregion //end region Constructors


       #region Methods

        private void IniGrid()
        {
            GridView.Columns["RoomID"].Visible = false;
            GridView.Columns["RoomTypeID"].Visible = false;
            if( SubmitMode == Mode.SubmitMode.Booking )
                GridView.Columns["Quantity"].Visible = true;
            else
                GridView.Columns["Quantity"].Visible = true;

        }//end method IniGrid

        private void LoadCheckingControls()
        {
            textBoxQuantity.Enabled = false;

        }//end method CheckingControls

        private void LoadBookingControls()
        {
            textBoxQuantity.Enabled = true;
        }//end method BookingControls

        private void LoadRoomTypes()
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

        private void LoadData( DataRow row )
        {
            room = row;
            textBoxRoomType.Text = row["TEN_LOAI_PHONG"].ToString();
            textBoxRoomNumber.Text = row["SO_PHONG"].ToString();
            textBoxBeds.Text = row["SO_GIUONG"].ToString();
            textBoxPrice.Text = row["GIA_THAM_KHAO"].ToString();
        }//end method LoadData

        private void AddRoom()
        {
            if (SubmitMode == Mode.SubmitMode.CheckIn)
            {
                DataRow row = ParentUI.DataRegister.Rooms.NewRow();
                row["RoomID"] = room["MA_PHONG"];
                row["RoomType"] = room["TEN_LOAI_PHONG"];
                row["RoomNumber"] = room["SO_PHONG"];
                row["Beds"] = room["SO_GIUONG"];
                row["Price"] = room["GIA_THAM_KHAO"];
                try {
                    ParentUI.DataRegister.Rooms.Rows.Add(row);
                }//end try
                catch {
                    MessageBox.Show("Phòng đã có trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }//end catch                
                Reset();
            }//end if
            else
            {

            }//end else
        }//end method AddRoom

        private void Reset()
        {
            room = null;
            textBoxRoomNumber.Text = String.Empty;
            textBoxRoomType.Text = String.Empty;
            textBoxQuantity.Text = String.Empty;
            textBoxPrice.Text = String.Empty;
            textBoxBeds.Text = String.Empty;
        }//end method Reset

       #endregion //end region Methods


       #region Event Handling Methods

        private void textBoxRoomType_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (SubmitMode == Mode.SubmitMode.Booking)
            {
                // Get selected DataRow
                DataRowView rowView = (DataRowView)textBoxRoomType.Properties.GetDataSourceRowByKeyValue(textBoxRoomType.EditValue);
                DataRow row = rowView.Row;

                textBoxBeds.Text = row["SO_GIUONG"].ToString();
                textBoxPrice.Text = row["GIA_THAM_KHAO"].ToString();
            }//end if
        }//end method textBoxRoomType_Properties_EditValueChanged

        private void buttonPick_Click(object sender, EventArgs e)
        {
            UI.Form_TimKiemvaChonPhongTrong form = new UI.Form_TimKiemvaChonPhongTrong();
            DataRow row = form.ShowModal();
            if (row != null)
            {
                LoadData(row);
            }//end if
        }//end method buttonPick_Click]

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (room != null)
                AddRoom();
        }//end method buttonAdd_Click

        private void buttonDel_Click(object sender, EventArgs e)
        {
            GridView.DeleteRow(GridView.FocusedRowHandle);
        }//end method buttonDel_Click

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
        }//end attribute SubmitMode

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
        private Mode.SubmitMode submitMode;
        private UITransaction parentUI;
        private DataRow room;
       #endregion Instance Fields

    }//end class UIRoomInfoPanel
}//end namespace
