using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKS_TiepNhanKhach.DAO
{
    class KhachHangDAO
    {
        private DBConnection dbConnection;

        public KhachHangDAO(DBConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public DataTable selectAllFromKhachHang()
        {
            string query = "Select * From KHACH_HANG";
            return dbConnection.executeSelectQuery(query);    
        }
    }
}
