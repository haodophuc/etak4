using System;
using System.Collections.Generic;
using System.Text;
using QLKS_TiepNhanKhach.DAO;
using System.Data;
using System.Data.SqlClient;
using QLKS_TiepNhanKhach.VO;

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

        public int Insert(PhongVO phongVO)
        {
            try
            {
                return phongDAO.Insert(phongVO);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
        public int Delete(string soPhong)
        {
            try
            {
                return phongDAO.Delete(soPhong);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public int Update(PhongVO phongVO)
        {
            try
            {
                return phongDAO.Update(phongVO);
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
                return phongDAO.GetLastIdentity() + 1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
