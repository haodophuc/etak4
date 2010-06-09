using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using System.Data;
using System.Data.SqlClient;

namespace QLKS.BUS
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
