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

        public PhongBUS()
        {   
            phongDAO = new PhongDAO();
        }

        public DataTable GetAll()
        {
            try
            {
                return phongDAO.SelectAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }   
    }
}
