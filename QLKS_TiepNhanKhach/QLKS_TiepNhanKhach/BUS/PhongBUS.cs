using System;
using System.Collections.Generic;
using System.Text;
using QLKS_TiepNhanKhach.DAO;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_TiepNhanKhach.BUS
{
    class PhongBUS
    {
        private PhongDAO phongDAO;
        private DBConnection dbConnection;

        public PhongBUS(DBConnection dbConnection)
        {
            this.dbConnection = dbConnection;
            phongDAO = new PhongDAO(dbConnection);
        }

        public DataTable getAllFromPhong()
        {
            try
            {
                return phongDAO.selectAllFromPhong();
            }
            catch (Exception e)
            {
                throw e;
            }
        }   
    }
}
