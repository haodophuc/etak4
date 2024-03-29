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
