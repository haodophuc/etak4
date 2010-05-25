using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS_TiepNhanKhach.DAO;

namespace QLKS_TiepNhanKhach.BUS
{
    class LoaiPhongBUS
    {
        private LoaiPhongDAO loaiPhongDAO;
        private DBConnection dbConnection;

        public LoaiPhongBUS(DBConnection dbConnection)
        {
            this.dbConnection = dbConnection;
            loaiPhongDAO = new LoaiPhongDAO(dbConnection);
        }

        public DataTable getAllFromLoaiPhong()
        {
            try
            {
                return loaiPhongDAO.selectAllFromLoaiPhong();
            }
            catch (Exception e)
            {
                throw e;
            }
        }   
    }
}
