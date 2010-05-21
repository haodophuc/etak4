using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLKS_DichVu.DAO
{
    public class ServiceOrderDAO
    {
        private DBConnection dbConnection;
        private DatabaseMaster databaseMaster;

        public ServiceOrderDAO(DBConnection dbConnection)
        {
            this.dbConnection = dbConnection;
            databaseMaster = new DatabaseMaster(dbConnection.Connection);
        }

        public DataTable getServiceOrderByRoomID(String roomID)
        {
            // build query
            String query = "SELECT * " + 
                           "FROM PHIEU_DANG_KY_DICH_VU A INNER JOIN PHIEU_THUE_PHONG B ON A.MA_PHIEU = B.MA_PHIEU " +
                           "WHERE B.MA_PHONG = @MA_PHONG";
            SqlCommand cmd = databaseMaster.getCommand(query);
            cmd.Parameters.AddWithValue("@MA_PHONG", roomID);

            // get data table
            SqlDataAdapter da = databaseMaster.getDataAdapter(cmd);
            DataSet ds = databaseMaster.getDataSet(da, "ServiceOrders");
            return ds.Tables["ServiceOrders"];
        }
    }
}
