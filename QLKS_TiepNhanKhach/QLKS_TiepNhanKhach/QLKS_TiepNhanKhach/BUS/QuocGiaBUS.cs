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

        public QuocGiaBUS(DBConnection dbConnection)
        {
            quocGiaDAO = new QuocGiaDAO(dbConnection);

        }

        public DataTable getAllFromQuocGia()
        {
            try
            {
                return quocGiaDAO.selectAllFromQuocGia();
            }
            catch (Exception e)
            {
                throw e;
            }
        } 
    }
}
