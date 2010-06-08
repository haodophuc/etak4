using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;


namespace QLKS.BUS
{
    class DoanKhachBUS
    {
        #region Properties
        private DoanKhachDAO doankhachDAO;
        #endregion

        #region Methos
        public DoanKhachBUS()
        {
            doankhachDAO = new DoanKhachDAO();
        }
        public DataTable GetAll()
        {
            try
            {
                return doankhachDAO.SelectAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Insert(DoanKhachVO doankhachVO)
        {
            try
            {
                return doankhachDAO.Insert(doankhachVO);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int GetNewIndentity()
        {
            try
            {
                return doankhachDAO.GetLastIdentity() + 1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(DoanKhachVO doankhachVO)
        {
            try
            {
                return doankhachDAO.Update(doankhachVO);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Delete(int maDoanKhach)
        {
            try
            {
                return doankhachDAO.Delete(maDoanKhach);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Int64 GetTienCoc(int madoankhach)
        {
            return doankhachDAO.GetTienCoc(madoankhach);
        }
        #endregion
    }
}
