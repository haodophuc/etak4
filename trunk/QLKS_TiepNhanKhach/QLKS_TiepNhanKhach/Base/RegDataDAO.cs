using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace QLKS_TiepNhanKhach.Base
{
    public class RegDataDAO
    {
        #region Constructors

        public RegDataDAO(String selectCommand)
        {
            // Get the connection to the database
            Connection = Program.dbConnection;
            // Contruct the DataAdapter
            Adapter = new SqlDataAdapter(selectCommand, Connection.Connection);
        }//end default constructor

        public RegDataDAO(RegData regdata)
        {

        }//end constructor
        #endregion //end region Constructors


        #region Methods

        public void FillDataSet(DataSet dataset, DataTableMapping map, String sourceTableName )
        {
            Adapter.TableMappings.Add(map);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(Adapter);
            Adapter.Fill(dataset, sourceTableName);

        }//end method 

        public void Initialize(RegData dataset)
        {
            DataSource = dataset;
            Adapter.TableMappings.Add(dataset.Customers.GetTableMapping());
            Adapter.TableMappings.Add(dataset.Companies.GetTableMapping());
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(Adapter);
            Adapter.Fill(dataset.CheckInData, dataset.Customers.SourceTableName);
        }//end method Initialize

        public void Update()
        {
            Adapter.Update(DataSource.CheckInData, DataSource.Customers.SourceTableName);
            DataSource.CheckInData.AcceptChanges();
        }//end method Update(DataSet)

        public void Update(DataTable datatable)
        {
            Adapter.Update(datatable);
            datatable.AcceptChanges();
        }//end method Update(DataTable)

        #endregion //end region Methods


        #region Attributes

        public DBConnection Connection
        {
            get { return connection; }
            set { this.connection = value; }
        }//end attribute Connection

        public SqlDataAdapter Adapter
        {
            get { return this.adapter; }
            set { this.adapter = value; }
        }//end attribute Adapter

        public RegData DataSource
        {
            get { return this.dataSource; }
            set { this.dataSource = value; }
        }//end attribute CheckInData

        #endregion //end region Attributes


        #region Instance Fields
        private RegData dataSource;
        private SqlDataAdapter adapter;
        private DBConnection connection;
        #endregion Instance Fields

    }//end class RegDataDAO

}//end namespace
