using System;
using System.Collections.Generic;
using System.Text;
using QLKS_TiepNhanKhach.DAO;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_TiepNhanKhach.BUS
{
    class TinhTrangBUS
    {
        private TinhTrangDAO tinhTrangDAO;

        public TinhTrangBUS(DBConnection dbConnection)
        {
            tinhTrangDAO = new TinhTrangDAO(dbConnection);
        }

        public DataTable getAll()
        {
            try
            {
                return tinhTrangDAO.selectAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }   
    }
}
