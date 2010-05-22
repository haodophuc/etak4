using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_TiepNhanKhach.DAO
{
    class PhongDAO
    {
        private DBConnection dbConnection;

        public PhongDAO(DBConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public DataTable selectAllFromPhong()
        {
            string query = "Select * From Phong";
            return dbConnection.executeSelectQuery(query);    
        }
    }
}
