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

        public QuocGiaDAO()
        {
            this.dbConnection = new DBConnection();
        }

        public DataTable selectAllFromQuocGia()
        {
            try
            {
                string query = "Select * From QUOC_GIA";
                return dbConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

}
