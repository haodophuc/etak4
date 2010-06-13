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

            agent = new RegDataDAO(this);

        }//end method RegData

       #endregion //end region Constructors


       #region Methods

        public void VerifyData()
        {
            //bool hasErrors = false;

            if (Customers.Rows.Count == 0)
            {
                //errorMessage = "Chưa có khách hàng";
                //hasErrors = true;
                throw new Exception("Chưa có khách hàng");
            }//end if : no customer

            if( Rooms.Rows.Count == 0 )
            {
                throw new Exception("Chưa có phòng");
            }//end 

            int item = 0;
            for (int i = 0; i < Customers.Rows.Count; i++)
            {
                String text = Customers.Rows[i]["RoomNumber"].ToString();
                if ( text == String.Empty)
                    item++;
            }//end for
            if (item > 0)
            {
                String message = String.Format("Có {0} khách hàng chưa được sắp phòng.", item);
                throw new Exception(message);
            }//end if
        }//end method VerifyData

        public void UpdateCustomers()
        {

            try {
                agent.UpdateCustomers();
            }//end try
            catch {
                throw;
            }//end catch          
            
        }//emd method Update

        public void SubmitCheckIn()
        {
            // Update table Customers, if there are new customers, add to database.
            UpdateCustomers();


        }//end method SubmitCheckIn

        public void SubmitBooking()
        {

        }//end method SubmitBooking

       #endregion //end region Methods


       #region Attributes

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

       #endregion //end region Attributes


       #region Instance Fields
        private TableCompanies companies;
        private TableCustomers customers;
        private TableGroups groups;
        private TableRooms rooms;

        private DataSet checkInData;

        private RegDataDAO agent;
       #endregion Instance Fields

    }//end class RegData

}//end namespace
