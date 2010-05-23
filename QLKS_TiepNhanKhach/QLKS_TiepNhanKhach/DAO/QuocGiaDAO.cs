using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKS_TiepNhanKhach.DAO
{
    class QuocGiaDAO
    {
        private DBConnection dbConnection;

        public QuocGiaDAO(DBConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public DataTable selectAllFromQuocGia()
        {
            string query = "Select * From QUOC_GIA";
            return dbConnection.executeSelectQuery(query);    
        }
    }

}
