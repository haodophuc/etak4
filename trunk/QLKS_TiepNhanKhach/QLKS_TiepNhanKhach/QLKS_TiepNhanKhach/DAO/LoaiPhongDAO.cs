using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_TiepNhanKhach.DAO
{
    class LoaiPhongDAO
    {
         private DBConnection dbConnection;

        public LoaiPhongDAO()
        {
            this.dbConnection = new DBConnection();
        }

        public DataTable selectAllFromLoaiPhong()
        {
            try
            {
                string query = "Select * From LOAI_PHONG";
                return dbConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
