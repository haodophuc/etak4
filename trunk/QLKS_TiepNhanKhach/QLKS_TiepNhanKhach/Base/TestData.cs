using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace QLKS_TiepNhanKhach.Base
{
    class TestData
    {
        public TestData() {
            //CreateTables();
            IniAdapter();
        }//end default constructor

        public DataSet GetDataSet()
        {            
            adapter.Fill(dataset, "KHACH_HANG");
            // Hide Identify column
            //dataset.Tables["Company"].Columns["CompanyID"].ColumnMapping = MappingType.Hidden;
            return dataset;
        }//end method GetDataSet

        public void Update()
        {
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(dataset.Tables["Company"]);
            dataset.AcceptChanges();
        }//end method Update

        public void IniAdapter() {
            TableCustomers customers = new TableCustomers();

            adapter = new SqlDataAdapter(customers.SelectCommand, Program.dbConnection.Connection);

            dataset = new DataSet();
            dataset.Tables.Add(customers);
            adapter.TableMappings.Add(customers.GetTableMapping());
        
        }//end method IniAdapter

        public void CreateTables() {
            dataset = new DataSet();
            //dataset.Tables.Add(new CompanyTable());
        }//end method CreateTable

        #region Instance Fields
        public DataSet dataset;
        public SqlDataAdapter adapter;
        #endregion

    }//end class TestData

    

}//end namespace
