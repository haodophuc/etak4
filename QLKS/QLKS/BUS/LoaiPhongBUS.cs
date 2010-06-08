using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS.DAO;

namespace QLKS.BUS
{
    class LoaiPhongBUS
    {
        private LoaiPhongDAO loaiPhongDAO;
        

        public LoaiPhongBUS()
        {
            loaiPhongDAO = new LoaiPhongDAO();
        }

        public DataTable GetAll()
        {
            try
            {
                return loaiPhongDAO.SelectAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }   
    }
}
