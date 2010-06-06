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


        public TinhTrangBUS()
        {
            tinhTrangDAO = new TinhTrangDAO();
        }

        public DataTable GetAll()
        {
            try
            {
                return tinhTrangDAO.SelectAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }   
    }
}
