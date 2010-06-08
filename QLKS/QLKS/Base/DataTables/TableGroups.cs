using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

namespace QLKS.Base
{
    public class TableGroups : DataTable
    {

        public TableGroups()
            : base("Groups")
        {
            AddColumn();
        }//end default constructor

        private void AddColumn()
        {
            DataColumnCollection cols = this.Columns;

            // Create identify field
            DataColumn groupId = cols.Add("GroupID", typeof(Int32));
            groupId.AllowDBNull = false;
            groupId.AutoIncrement = true;
            groupId.AutoIncrementSeed = -1;
            groupId.AutoIncrementStep = -1;

            // Create other fields
            cols.Add("CompanyID", typeof(Int32));
            cols.Add("CheckInDay", typeof(DateTime));

            // Set primary key
            this.PrimaryKey = new DataColumn[] { cols["GroupID"] };
        }//end methd 

        public DataTableMapping GetTableMapping()
        {
            DataTableMapping dtm = new DataTableMapping("DOAN_KHACH", "Groups");

            dtm.ColumnMappings.Add("MA_DOAN_KHACH", "GroupID");
            dtm.ColumnMappings.Add("MA_CONG_TY", "CompanyID");
            dtm.ColumnMappings.Add("NGAY_DEN", "CheckInDay");

            return dtm;
        }//end method GetTableMapping

        public String SelectCommand {
            get {
                return "SELECT * FROM DOAN_KHACH";               
            }//end method get
        }//end attribute SelectCommand

    }//end class TableGroups
}//end namespace
