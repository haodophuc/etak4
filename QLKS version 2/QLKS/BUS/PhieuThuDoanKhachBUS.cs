using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;

namespace QLKS.BUS
{
    class PhieuThuDoanKhachBUS
    {
         private PhieuThuDoanKhachDAO phieuThuDoanKhachDAO;

        public PhieuThuDoanKhachBUS()
        {
            phieuThuDoanKhachDAO = new PhieuThuDoanKhachDAO();
        }
        public DataTable GetAll()
        {
            try
            {
                return phieuThuDoanKhachDAO.SelectAll(); ;
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
                return phieuThuDoanKhachDAO.GetLastIdentity() + 1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Insert(PhieuThuDoanKhachVO phieuthudoankhachVO)
        {
            try
            {

                return phieuThuDoanKhachDAO.Insert(phieuthudoankhachVO);
            }
            catch (Exception e)
            {
               
                throw e;
            }
        }
        public int Delete(int soPhieu)
        {
            try
            {
                return phieuThuDoanKhachDAO.Delete(soPhieu);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(PhieuThuDoanKhachVO phieuthudoankhachVO)
        {
            try
            {
                return phieuThuDoanKhachDAO.Update(phieuthudoankhachVO);
            }
            catch (SqlException e)
            {
                
                throw e;
            }
        }
    }
}
