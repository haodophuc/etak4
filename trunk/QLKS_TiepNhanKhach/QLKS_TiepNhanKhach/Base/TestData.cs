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
            dataset.Tables.Add(new CompanyTable());
        }//end method CreateTable

        #region Instance Fields
        public DataSet dataset;
        public SqlDataAdapter adapter;
        #endregion

    }//end class TestData

    class CompanyTable : DataTable
    {
        public CompanyTable() : base("Company")
        {
            AddColumn();
        }//end default constructor

        private void AddColumn() {

            DataColumnCollection cols = this.Columns;

            // Create identify field
            DataColumn id = new DataColumn("CompanyID");
            id.DataType = typeof(Int32);
            id.AutoIncrement = true;
            id.AutoIncrementSeed = -1;
            id.AutoIncrementStep = -1;
            //id.ColumnMapping = MappingType.Hidden;

            // Create other fields
            DataColumn name = cols.Add("CompanyName", typeof(String));
            name.AllowDBNull = false;

            DataColumn countryId = cols.Add("CountryID", typeof(Int32));
            countryId.AllowDBNull = false;

            DataColumn agentId = cols.Add("AgentID", typeof(Int32));
            agentId.AllowDBNull = false;

            cols.Add("Address", typeof(String));
            DataColumn phone = cols.Add("Phone", typeof(String));
            phone.ReadOnly = true;

            cols.Add("Email", typeof(String));
            cols.Add("Fax", typeof(String));
            cols.Add("Tax", typeof(String));
            cols.Add("Account", typeof(String));
            cols.Add("State", typeof(Boolean));
            cols.Add("Nothing", typeof(String));

            // Set the primary key
            this.PrimaryKey = new DataColumn[] { cols["CompanyID"] };        
        }//end method IniColumn

        public DataTableMapping GetTableMapping()
        {
            DataTableMapping dtm = new DataTableMapping("CONG_TY", "Company");

            // Map columns
            dtm.ColumnMappings.Add("MA_CONG_TY", "CompanyID");
            dtm.ColumnMappings.Add("TEN_CONG_TY", "CompanyName");
            dtm.ColumnMappings.Add("MA_QUOC_GIA", "CountryID");
            dtm.ColumnMappings.Add("MA_NGUOI_DAI_DIEN", "AgentID");
            dtm.ColumnMappings.Add("DIA_CHI", "Address");
            dtm.ColumnMappings.Add("DIEN_THOAI", "Phone");
            dtm.ColumnMappings.Add("EMAIL", "Email");
            dtm.ColumnMappings.Add("FAX", "Fax");
            dtm.ColumnMappings.Add("MA_SO_THUE", "Tax");
            dtm.ColumnMappings.Add("SO_TAI_KHOAN", "Account");
            dtm.ColumnMappings.Add("HIEU_LUC", "State");

            return dtm;
        }//end method GetTableMapping;

    }//end class CompanyTable

}//end namespace
