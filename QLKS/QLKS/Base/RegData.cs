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
            Groups = new TableGroups();
            Rooms = new TableRooms();
            Companies = new TableCompanies();

            // Add tables to dataset
            CheckInData.Tables.AddRange( new DataTable[] { Customers, Groups, Rooms, Companies } );

            string selectCmd = @Customers.SelectCommand + " " + Companies.SelectCommand +";";

            agent = new RegDataDAO(selectCmd);
            agent.Initialize(this);

            //agent.FillDataSet(CheckInData, Customers.GetTableMapping(), Customers.SourceTableName);

        }//end method RegData

       #endregion //end region Constructors


       #region Methods

        public void UpdateCustomers() {

            try {
                agent.UpdateCustomers();
            }//end try
            catch {
                throw;
            }//end catch          
            
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
