using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

namespace QLKS_TiepNhanKhach.Base
{
    public class TableCompanies : DataTable
    {
        public TableCompanies()
            : base("Companies")
        {
            AddColumn();
        }//end default constructor

        private void AddColumn()
        {

            DataColumnCollection cols = this.Columns;

            // Create identify field
            DataColumn id = new DataColumn("CompanyID");
            id.DataType = typeof(Int32);
            id.AutoIncrement = true;
            id.AutoIncrementSeed = -1;
            id.AutoIncrementStep = -1;
            id.ColumnMapping = MappingType.Hidden;

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
            DataTableMapping dtm = new DataTableMapping("CONG_TY", "Companies");

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

        public String SelectCommand
        {
            get
            {
                return "SELECT MA_CONG_TY, TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE,HIEU_LUC " +
                         "FROM CONG_TY"; }
        }//end attribute SelectCommand

        public String SourceTableName
        {
            get { return "CONG_TY"; }
        }//end attribute SourceTableName

    }//end class CompanyTable
}//end namespace
