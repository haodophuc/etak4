using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.VO
{
    class BookingDetailVO
    {
       #region Constructors

        public BookingDetailVO()
        {

        }//end default constructor

       #endregion //end region Constructors


       #region Methods

       #endregion //end region Methods


       #region Attributes

        public int IssueID
        {
            get { return this.issueID; }
            set { this.issueID = value; }
        }//end attribute IssueID

        public int RoomTypeID
        {
            get { return this.roomTypeID; }
            set { this.roomTypeID = value; }
        }//end attribute RoomTypeID

        public DateTime CheckInDay
        {
            get { return this.checkInDay; }
            set { this.checkInDay = value; }
        }//end attribute CheckInDay

        public DateTime CheckOutDay
        {
            get { return this.checkOutDay; }
            set { this.checkOutDay = value; }
        }//end attribute CheckOutDay

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }//end attribute Quantity

       #endregion //end region Attributes


       #region Instance Fields
        
        private int issueID;
        private int roomTypeID;
        private DateTime checkInDay;
        private DateTime checkOutDay;
        private int quantity;

       #endregion Instance Fields


    }//end class BookingDetailVO
}//end namespace
