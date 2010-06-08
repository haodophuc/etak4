using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;


namespace QLKS.BUS
{
    class KhachTroBUS
    {
        private KhachTroDAO khachtroDAO;
        public KhachTroBUS()
        {
            khachtroDAO = new KhachTroDAO();    
        }
        public DataTable GetAll()
        {
            try
            {
                return khachtroDAO.SelectAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Insert(KhachTroVO khachtroVO)
        {
            try
            {
                return khachtroDAO.Insert(khachtroVO);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
