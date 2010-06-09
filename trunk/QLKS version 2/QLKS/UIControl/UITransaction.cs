using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.Base;

namespace QLKS.UIControl
{
    public partial class UITransaction : DevExpress.XtraEditors.XtraUserControl
    {
       #region Constructors
        
        public UITransaction()
        {
            InitializeComponent();

            // Prepare all data;
            DataRegister = new RegData();

            LoadControls();
        }//end default constructor

        public UITransaction(Mode.SubmitMode mode) : this()
        {
            SubmitMode = mode;
        }//end constructor

       #endregion //end region Constructors


       #region Methods

        private void LoadControls()
        {
            roomInfo = new UIRoomInfoPanel( this, this.SubmitMode, DataRegister.Rooms );
            roomInfo.Dock = DockStyle.Fill;
            tabPageRoom.Controls.Add( roomInfo );

            groupInfo = new UIGroupInfoPanel(this.SubmitMode);
            groupInfo.Dock = DockStyle.Fill;
            tabPageGroup.Controls.Add(groupInfo);

            customerInfo = new UICustomerInfoPanel(this, DataRegister.Customers);
            customerInfo.Dock = DockStyle.Fill;
            tabPageCustomer.Controls.Add(customerInfo); 
            
        }//end method LoadControls

        public void Submit()
        {

            if (SubmitMode == Mode.SubmitMode.CheckIn)
                SubmitCheckIn();
            else
                SubmitBooking();

        }//end method Submit

        private void SubmitCheckIn()
        {
            DataRegister.UpdateCustomers();
            bool IsGroup = groupInfo.IsAGroup();
            int groupID = -1;
            if (IsGroup == true)
            {
                groupID = groupInfo.GetGroupID();
            }

            int numOfRooms = DataRegister.Rooms.Rows.Count;

            // Scan room list
            for (int i = 0; i < numOfRooms; i++)
            {
                string roomNumber = DataRegister.Rooms.Rows[i]["RoomID"].ToString();
                int ticketID = -1;
                int numOfCustomers = DataRegister.Customers.Rows.Count;
                
                // Scan customer list
                for (int j = 0; j < numOfCustomers; j++)
                {
                    string roomNumber2 = DataRegister.Customers.Rows[j]["RoomNumber"].ToString();
                    if (roomNumber2.Equals(roomNumber))
                    {
                        if (ticketID == -1)
                        {
                            VO.PhieuThuePhongVO item = new VO.PhieuThuePhongVO();
                            if (groupID != -1)
                                item.MA_DOAN_KHACH = groupID;
                            item.MA_KHACH_HANG = Int32.Parse(DataRegister.Customers.Rows[j]["CustomerID"].ToString());
                            item.MA_PHONG = Int32.Parse(DataRegister.Customers.Rows[j]["RoomNumber"].ToString());
                            item.NGAY_NHAN_PHONG = DateTime.Parse(dateCheckIn.Text);
                            item.NGAY_TRA_PHONG = DateTime.Parse(dateCheckOut.Text);
                            BUS.PhieuThuePhongBUS bus = new BUS.PhieuThuePhongBUS();
                            try
                            {
                                int result = bus.Insert(item);
                                if (result == 0)
                                {
                                    //code here
                                }//end if there're some errors

                                ticketID = result;
                            }//end try
                            catch (Exception e)
                            {
                                MessageBox.Show(e.Message);
                            }//end catch
                        }//end if : set owner
                        else
                        {
                            VO.KhachTroVO ktItem = new VO.KhachTroVO();
                            ktItem.MA_PHIEU = ticketID;
                            ktItem.MA_KHACH_HANG = Int32.Parse(DataRegister.Customers.Rows[j]["CustomerID"].ToString());
                            BUS.KhachTroBUS ktBus = new BUS.KhachTroBUS();
                            try {
                                int result2 = ktBus.Insert(ktItem);
                                if (result2 != 0)
                                {
                                   
                                }//end if
                            }//end try
                            catch( Exception e ) {
                                MessageBox.Show(e.Message);                      
                            }//end catch                         

                        }//end else

                    }//end if : room number matched
                }//end for : customers

            }//end for : rooms
        }//end method SubmitCheckIn

        private void SubmitBooking()
        {

        }//end method SubmitBooking

       #endregion //end region Methods


       #region Event Handling Methods

        private void tabContainer_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {

        }//end method tabContainer_SelectedPageChanged

       #endregion //end region Event Handling Methods


       #region Attributes

        public RegData DataRegister
        {
            get { return dataRegister; }
            set { this.dataRegister = value; }
        }//end attribute DataRegister

        public Mode.SubmitMode SubmitMode
        {
            get { return this.submitMode; }
            set { this.submitMode = value; }
        }//end attribute SubmitMode

       #endregion //end region Attributes


       #region Instance Fields

        private Mode.SubmitMode submitMode;

        private UIGroupInfoPanel groupInfo;
        private UIRoomInfoPanel roomInfo;
        private UICustomerInfoPanel customerInfo;

        private RegData dataRegister;
       #endregion Instance Fields

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            SubmitCheckIn();
        }


    }//end class UITransaction
}//end namespace
