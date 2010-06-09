using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

namespace QLKS.Base
{
    public class TableCustomers : DataTable
    {

        public TableCustomers()
            : base("Customers")
        {
            AddColumn();
        }//end default constructor

        private void AddColumn()
        {

            DataColumnCollection cols = this.Columns;

            // Identify column
            DataColumn customerId = cols.Add("CustomerID", typeof(Int32));
            customerId.AllowDBNull = false;
            customerId.AutoIncrement = true;
            customerId.AutoIncrementSeed = -1;
            customerId.AutoIncrementStep = -1;
            //customerId.ReadOnly = true;
            customerId.Caption = "Mã Khách Hàng";

            // Add other columns
            cols.Add("RoomNumber", typeof(String)).Caption = "Số Phòng";
            cols.Add("RoomID", typeof(Int32)).ColumnMapping = MappingType.Hidden;
            cols.Add("GroupID", typeof(Int32)).ColumnMapping = MappingType.Hidden;
            cols.Add("CountryID", typeof(Int32)).Caption = "Mã Quốc Gia";
            cols.Add("LastName", typeof(String)).Caption = "Họ Khách Hàng";
            cols.Add("FirstName", typeof(String)).Caption = "Tên Khách Hàng";
            cols.Add("SocialID", typeof(String)).Caption = "CMND";
            cols.Add("PassPort", typeof(String)).Caption = "Hộ Chiếu";
            cols.Add("Phone", typeof(String)).Caption = "Điện Thoại";
            cols.Add("IsNew", typeof(Boolean));

            // Add primary column
            this.PrimaryKey = new DataColumn[] { cols["CustomerID"] };

        }//end method AddColumn

        public DataTableMapping GetTableMapping()
        {

            DataTableMapping dtm = new DataTableMapping("KHACH_HANG", "Customers");

            dtm.ColumnMappings.Add("MA_KHACH_HANG", "CustomerID");
            dtm.ColumnMappings.Add("MA_QUOC_GIA", "CountryID");
            dtm.ColumnMappings.Add("HO_KHACH_HANG", "LastName");
            dtm.ColumnMappings.Add("TEN_KHACH_HANG", "FirstName");
            dtm.ColumnMappings.Add("CMND", "SocialID");
            dtm.ColumnMappings.Add("HO_CHIEU", "PassPort");
            dtm.ColumnMappings.Add("DIEN_THOAI", "Phone");

            return dtm;
        }//end method GetTableMapping

        public String SelectCommand
        {
            get
            {
                return "SELECT MA_KHACH_HANG, MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI " +
                       "FROM KHACH_HANG";
            }//end method get
        }//end attribute SelectCommand

        public String SourceTableName {
            get { return "KHACH_HANG"; }
        }//end attribute SourceTableName

    }//end class TableCustomers
}//end namespace
