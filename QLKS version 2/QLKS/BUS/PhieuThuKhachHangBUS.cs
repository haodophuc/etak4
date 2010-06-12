using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;

namespace QLKS.BUS
{
    class PhieuThuKhachHangBUS
    {
         private PhieuThuKhachHangDAO phieuThuKhachHangDAO;

        public PhieuThuKhachHangBUS()
        {
            phieuThuKhachHangDAO = new PhieuThuKhachHangDAO();
        }
        public DataTable GetAll()
        {
            try
            {
                return phieuThuKhachHangDAO.SelectAll();
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
                return phieuThuKhachHangDAO.GetLastIdentity() + 1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Insert(PhieuThuKhachHangVO phieuthukhachhangVO)
        {
            try
            {

                return phieuThuKhachHangDAO.Insert(phieuthukhachhangVO);
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
                return phieuThuKhachHangDAO.Delete(soPhieu);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(PhieuThuKhachHangVO phieuthukhachhangVO)
        {
            try
            {
                return phieuThuKhachHangDAO.Update(phieuthukhachhangVO);
            }
            catch (SqlException e)
            {
                
                throw e;
            }
        }
    }
}
