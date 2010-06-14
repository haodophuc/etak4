using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

namespace QLKS.Base
{
    public class RegData
    {
       #region Constructors

        public RegData() {

            // Create dataset
            checkInData = new DataSet("CheckIn");

            // Create tables
            Customers = new TableCustomers();
            Rooms = new TableRooms();
            Groups = new TableGroups();           
            //Companies = new TableCompanies();

            // Add tables to dataset
            CheckInDataSet.Tables.AddRange( new DataTable[] { Customers, Rooms, Groups } );

            DataRelation relation = new DataRelation("OwnerIDRelation", Customers.Columns["CustomerID"], Rooms.Columns["OwnerID"], true);

            CheckInDataSet.Relations.Add(relation);

            agent = new RegDataDAO(this);

        }//end method RegData

       #endregion //end region Constructors


       #region Methods

        public void VerifyData( Mode.SubmitMode mode )
        {
            //bool hasErrors = false;
            if (mode == Mode.SubmitMode.CheckIn)
                VerifyCheckingData();
            else
                VerifyBookingData();
        }//end method VerifyData

        private void VerifyBookingData()
        {
            if (Groups.Rows.Count == 0 && Customers.Rows.Count == 0)
                throw new Exception("Chưa có thông tin khách hàng hay đoàn khách");
            if (Rooms.Rows.Count == 0)
                throw new Exception("Chưa có thông tin đăng ký phòng");
        }//end method VerifyBookingData

        private void VerifyCheckingData()
        {
            if (Customers.Rows.Count == 0)
            {
                //errorMessage = "Chưa có khách hàng";
                //hasErrors = true;
                throw new Exception("Chưa có khách hàng");
            }//end if : no customer

            if (Rooms.Rows.Count == 0)
            {
                throw new Exception("Chưa có phòng");
            }//end 

            int item = 0;
            for (int i = 0; i < Customers.Rows.Count; i++)
            {
                String text = Customers.Rows[i]["RoomNumber"].ToString();
                if (text == String.Empty)
                    item++;
            }//end for
            if (item > 0)
            {
                String message = String.Format("Có {0} khách hàng chưa được sắp phòng.", item);
                throw new Exception(message);
            }//end if
        }//end method VerifyCheckingData

        public void UpdateCustomers()
        {

            try {
                int numOfCustomers = Customers.Rows.Count;

                for (int i = 0; i < numOfCustomers; i++)
                {
                    if (Customers.Rows[i]["IsNew"].ToString().Equals(Boolean.TrueString))
                    {
                        VO.KhachHangVO customer = new QLKS.VO.KhachHangVO();
                        BUS.KhachHangBUS bus = new QLKS.BUS.KhachHangBUS();

                        customer.MA_QUOC_GIA = (int)Customers.Rows[i]["CountryID"];
                        customer.HO_KHACH_HANG = Customers.Rows[i]["LastName"].ToString();
                        customer.TEN_KHACH_HANG = Customers.Rows[i]["FirstName"].ToString();
                        customer.CMND = Customers.Rows[i]["SocialID"].ToString();
                        customer.HO_CHIEU = Customers.Rows[i]["PassPort"].ToString();
                        customer.DIEN_THOAI = Customers.Rows[i]["Phone"].ToString();

                        // Get new identity
                        int newid = bus.InsertAndGetID(customer);

                        // Sync new identity with table on memory
                        Customers.Rows[i]["CustomerID"] = newid;
                        Customers.Rows[i]["IsNew"] = false;

                    }//end if: new customers
                }//end for
            }//end try
            catch {
                throw;
            }//end catch          
            
        }//emd method Update

        public void SetRoomOwner(int roomID, int ownerID )
        {
            string roomfilter = "RoomID =" + roomID.ToString();
            DataRow room = Rooms.Select(roomfilter)[0];

            // Get given owner's name
            string customerfilter = "CustomerID = " + ownerID.ToString();
            DataRow newOwner = Customers.Select(customerfilter)[0];
            string newOwnerName = newOwner["LastName"].ToString() + newOwner["FirstName"].ToString();

            int oldOwnerID = -1;

            if (room["Owner"].ToString() != String.Empty)
            {
                oldOwnerID = (int)room["OwnerID"];
                customerfilter = "CustomerID =" + oldOwnerID.ToString();
                DataRow oldOwner = Customers.Select(customerfilter)[0];
                oldOwner["IsOwner"] = false;
            }//end if : room has an owner

            room["OwnerID"] = ownerID;
            room["Owner"] = newOwnerName;
            newOwner["IsOwner"] = true;
        }//end method SetOwner

        public void SubmitCheckIn()
        {
            try {
                // Update table Customers, if there are new customers, add to database.
                UpdateCustomers();

                int groupID = -1;

                // Check if there is group
                if (Groups.Rows.Count == 1)
                    groupID = (int)Groups.Rows[0]["GroupID"];

                // Get rooms
                int numOfRooms = Rooms.Rows.Count;

                // Scan room list to register to PHIEU_THUE_PHONG
                for (int i = 0; i < numOfRooms; i++)
                {
                    VO.PhieuThuePhongVO ticket = new VO.PhieuThuePhongVO();
                    BUS.PhieuThuePhongBUS bus = new QLKS.BUS.PhieuThuePhongBUS();

                    // Set customer id
                    ticket.MA_KHACH_HANG = (int)Rooms.Rows[i]["OwnerID"];

                    // Set group id
                    if (groupID != -1)
                        ticket.MA_DOAN_KHACH = groupID;
                    else
                        ticket.MA_DOAN_KHACH = groupID;
                    ticket.MA_PHONG = (int)Rooms.Rows[i]["RoomID"];
                    ticket.NGAY_NHAN_PHONG = CheckInDay;

                    // Insert and get the new id
                    int ticketID = bus.InsertAndGetID(ticket);
                    
                    // Update room ticker id
                    Rooms.Rows[i]["TicketID"] = ticketID;

                    // Set room state to busy
                    BUS.PhongBUS roomBus = new QLKS.BUS.PhongBUS();
                    roomBus.SetRoomState(ticket.MA_PHONG, TableRooms.RoomState.Busy);

                }//end for : scan all rooms

                // Scan all customer to register to table KHACH_TRO
                int numOfCustomers = Customers.Rows.Count;

                for (int j = 0; j < numOfCustomers; j++)
                {
                    int roomNumber = (int)Customers.Rows[j]["RoomNumber"];

                    string filter = "RoomID = " + roomNumber.ToString();
                    DataRow matchedRoom = Rooms.Select(filter)[0];

                    VO.KhachTroVO ktRow = new QLKS.VO.KhachTroVO();
                    ktRow.MA_KHACH_HANG = (int)Customers.Rows[j]["CustomerID"];
                    ktRow.MA_PHIEU = (int)matchedRoom["TicketID"];

                    BUS.KhachTroBUS ktBus = new QLKS.BUS.KhachTroBUS();
                    int result = ktBus.Insert(ktRow);
                    if (result <= 0)
                        throw new Exception("Không thể thêm dữ liệu vào bảng Khách Trọ");
                        
                }//end for : scan all customers

            
            }//end try
            catch {
                throw;            
            }//end catch
            


        }//end method SubmitCheckIn

        public void SubmitBooking()
        {
            try {
                VO.PhieuDatPhongVO item = new QLKS.VO.PhieuDatPhongVO();

                // Determine the CustomerMode wil be used
                Mode.CustomerMode mode;
                if (Groups.Rows.Count > 0)
                {
                    mode = Mode.CustomerMode.Group;
                    item.MA_KHACH_HANG = -1;
                }//end if: group mode
                else
                {
                    mode = Mode.CustomerMode.Customer;
                    item.MA_DOAN_KHACH = -1;
                }//end else: customer mode


                // Processing data
                if (mode == Mode.CustomerMode.Group)
                {
                    item.MA_DOAN_KHACH = (int)Groups.Rows[0]["GroupID"];
                }//end if: processing group mode
                else
                {
                    item.MA_KHACH_HANG = (int)Customers.Rows[0]["CustomerID"];
                }//end else: processing customer mode

                // Set the deposit
                item.TIEN_COC = (int)Deposit;

                BUS.PhieuDatPhongBUS bus = new QLKS.BUS.PhieuDatPhongBUS();
                int issueID = bus.InsertAndGetID(item);

                int numOfRoomTypes = Rooms.Rows.Count;

                for (int i = 0; i < numOfRoomTypes; i++)
                {
                    VO.BookingDetailVO detail = new QLKS.VO.BookingDetailVO();
                    detail.IssueID = issueID;
                    detail.RoomTypeID = (int)Rooms.Rows[i]["RoomTypeID"];
                    detail.CheckInDay = CheckInDay;
                    detail.CheckOutDay = CheckOutDay;
                    detail.Quantity = (int)Rooms.Rows[i]["Quantity"];

                    int result = bus.InsertBookingDetail(detail);
                    if (result <= 0)
                        throw new Exception("Không thể thêm dữ liệu vào bảng Chi Tiết Đặt Phòng");
                }//end for
                
            }//end try
            catch {
                throw;
            }//end catch
        }//end method SubmitBooking

        public void Reset()
        {
            Groups.Rows.Clear();
            Rooms.Rows.Clear();
            Customers.Rows.Clear();
            
        }//end method Reset()

       #endregion //end region Methods


       #region  Attributes

        public DataSet CheckInDataSet
        { 
           get { return checkInData; }
           //set { this.dataset = value; }
        }//end attribute DataSet

        public TableRooms Rooms
        {
            get { return this.rooms; }
            set { this.rooms = value; }
        }//end attribute Rooms

        public TableGroups Groups
        {
            get { return groups; }
            set { this.groups = value; }
        }//end attribute Groups

        public TableCustomers Customers
        {
            get { return customers; }
            set { this.customers = value; }
        }//end 

        public TableCompanies Companies
        {
            get { return companies; }
            set { this.companies = value; }
        }//end attribute Companies

        public DateTime CheckInDay
        {
            get { return checkInDay; }
            set { this.checkInDay = value; }
        }//end attribute CheckInDay

        public DateTime CheckOutDay
        {
            get { return checkOutDay; }
            set { this.checkOutDay = value; }
        }//end attribute CheckOutDay

        public Decimal Deposit
        {
            get { return deposit; }
            set { this.deposit = value; }
        }//end attribute Deposit

       #endregion //end region Attributes


       #region Instance Fields
        private TableCompanies companies;
        private TableCustomers customers;
        private TableGroups groups;
        private TableRooms rooms;

        private DataSet checkInData;
        private DateTime checkInDay;
        private DateTime checkOutDay;
        private Decimal deposit;
        private RegDataDAO agent;
       #endregion Instance Fields

    }//end class RegData

}//end namespace
