﻿using System;
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
            room = null;           
        }//end default constructor

        public UIRoomInfoPanel( UITransaction parent, Mode.SubmitMode mode ) : this()
        {
            this.ParentUI = parent;
            this.SubmitMode = mode;
            GridControl.DataSource = ParentUI.RegData.Rooms;
            IniGrid();
        }//end constructor

       #endregion //end region Constructors


       #region Methods

        private void IniGrid()
        {
            GridView.Columns["RoomID"].Visible = false;
            GridView.Columns["RoomTypeID"].Visible = false;
            GridView.Columns["TicketID"].Visible = false;
            GridView.Columns["OwnerID"].Visible = false;
            if (SubmitMode == Mode.SubmitMode.Booking)
            {
                GridView.Columns["Quantity"].Visible = true;
                GridView.Columns["Owner"].Visible = false;
                GridView.Columns["RoomNumber"].Visible = false;
                
            }//end if
            else
            {
                GridView.Columns["Quantity"].Visible = false;
            }//end else

        }//end method IniGrid

        private void LoadCheckingControls()
        {
            textBoxQuantity.Visible = false;
            labelQuatity.Visible = false;

            textBoxRoomType.EditValue = null;
            textBoxRoomType.Properties.NullText = "Chưa có thông tin";
        }//end method CheckingControls

        private void LoadBookingControls()
        {
            // Disable Picking rooms
            buttonPick.Enabled = false;

            // Enable Picking Room Types
            textBoxRoomType.Enabled = true;
            textBoxRoomType.Properties.ReadOnly = false;
            LoadRoomTypes();

            // Enable Inputting quantity
            textBoxQuantity.Visible = true;
            textBoxQuantity.Properties.ReadOnly = false;
            labelQuatity.Visible = true;
        }//end method BookingControls

        private void LoadRoomTypes()
        {
            // Get table data           
            BUS.LoaiPhongBUS bus = new BUS.LoaiPhongBUS();
            DataTable types = bus.GetAll();
            types.TableName = "RoomTypes";

            // Create BindingSource
            DataSet ds = new DataSet();
            ds.Tables.Add(types);
            BindingSource binding = new BindingSource(ds, "RoomTypes");

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
            textBoxRoomType.Properties.NullText = row["TEN_LOAI_PHONG"].ToString();
            textBoxRoomNumber.Text = row["SO_PHONG"].ToString();
            textBoxBeds.Text = row["SO_GIUONG"].ToString();
            textBoxPrice.Text = row["GIA_THAM_KHAO"].ToString();
        }//end method LoadData

        private void AddRoom()
        {
            if (SubmitMode == Mode.SubmitMode.CheckIn)
            {
                if (room != null)
                {
                    DataRow row = ParentUI.RegData.Rooms.NewRow();
                    row["RoomID"] = room["MA_PHONG"];
                    row["RoomType"] = room["TEN_LOAI_PHONG"];
                    row["RoomNumber"] = room["SO_PHONG"];
                    row["Beds"] = room["SO_GIUONG"];
                    row["Price"] = room["GIA_THAM_KHAO"];
                    try
                    {
                        ParentUI.RegData.Rooms.Rows.Add(row);
                    }//end try
                    catch
                    {
                        Notice.ShowWarning("Phòng đã có trong danh sách");
                    }//end catch                
                    Reset();
                }//end if: room has null value
            }//end if
            else
            {
                DataRow row = ParentUI.RegData.Rooms.NewRow();
                row["RoomTypeID"] = (int)textBoxRoomType.EditValue;
                row["Beds"] = Int32.Parse(textBoxBeds.Text);
                row["Price"] = Decimal.Parse(textBoxPrice.Text);
                row["Quantity"] = int.Parse(textBoxQuantity.Text);
                row["RoomType"] = textBoxRoomType.Text;
                try {
                    ParentUI.RegData.Rooms.Rows.Add(row);
                }//end try
                catch {
                    Notice.ShowWarning("Có lỗi xảy ra!");
                }//end catch
            }//end else
        }//end method AddRoom

        public void Reset()
        {
            room = null;
            textBoxRoomNumber.Text = null;
            textBoxRoomType.Text = null;
            textBoxQuantity.Text = null;
            textBoxPrice.Text = null;
            textBoxBeds.Text = null;
        }//end method Reset

        public void ResetAll()
        {
            Reset();
            //GridControl.RefreshDataSource();
            //GridView.RefreshEditor(true);
        }//end method ResetAll

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
