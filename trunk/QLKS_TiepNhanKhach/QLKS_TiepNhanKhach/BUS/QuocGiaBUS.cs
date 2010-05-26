using System;
using System.Collections.Generic;
using System.Text;
using QLKS_TiepNhanKhach.DAO;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_TiepNhanKhach.BUS
{
    class QuocGiaBUS
    {
         private QuocGiaDAO quocGiaDAO;
       

        public QuocGiaBUS()
        {  
            quocGiaDAO = new QuocGiaDAO();
        }

        public DataTable GetAll()
        {
            try
            {
                return quocGiaDAO.SelectAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        } 
    }
}
