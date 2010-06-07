using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

namespace QLKS_TiepNhanKhach.Base
{
    class RegData
    {
       #region Constructors

        public RegData() {

            // Create dataset
            checkInData = new DataSet("CheckIn");

            // Create tables
            Customers = new TableCustomers();
            Groups = new TableGroups();
            Rooms = new TableRooms();

            // Add tables to dataset
            CheckInData.Tables.AddRange( new DataTable[] { Customers, Groups, Rooms } );

            string selectCmd = Customers.SelectCommand;

            agent = new RegDataDAO(selectCmd);

            agent.FillDataSet(CheckInData, Customers.GetTableMapping(), Customers.SourceTableName);

        }//end method RegData

       #endregion //end region Constructors


       #region Methods

        public void CreateTables() { 
                   
        }//end method CreateTables

        public void Update() {
            //agent.Update(DataSet);
        }//emd method Update

       #endregion //end region Methods


       #region Event Handling Methods

       #endregion //end region Event Handling Methods


       #region Attributes

        public DataSet CheckInData
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

       #endregion //end region Attributes


       #region Instance Fields
        private TableCustomers customers;
        private TableGroups groups;
        private TableRooms rooms;
        private DataSet checkInData;
        private RegDataDAO agent;
       #endregion Instance Fields

    }//end class RegData

}//end namespace
