using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_TiepNhanKhach.DAO
{
    class TinhTrangDAO
    {
        private DBConnection dbConnection;

        public TinhTrangDAO(DBConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public DataTable selectAll()
        {
            try
            {
                string query = "Select * From TINH_TRANG";
                return dbConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
