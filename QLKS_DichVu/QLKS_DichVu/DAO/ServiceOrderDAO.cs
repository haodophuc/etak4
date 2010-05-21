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

        public DataTable getServiceOrderByRoomID(String roomNumber)
        {
            // build query
            String storeProcedure = "SP_PHIEU_DANG_KY_DICH_VU_THEO_SO_PHONG";
            SqlCommand cmd = databaseMaster.getCommand(storeProcedure);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SO_PHONG", roomNumber);

            // get data table
            SqlDataAdapter da = databaseMaster.getDataAdapter(cmd);
            DataSet ds = databaseMaster.getDataSet(da, "ServiceOrders");
            return ds.Tables["ServiceOrders"];
        }
    }
}
