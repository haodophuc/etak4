using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;

namespace QLKS.BUS
{
    class KhachHangBUS
    {
        private KhachHangDAO khachHangDAO;

        public KhachHangBUS()
        {
            khachHangDAO = new KhachHangDAO();    
        }

        public DataTable GetAll()
        {
            try
            {
                return khachHangDAO.SelectAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Int64 GetTienCoc(int makhachhang)
        {
            return khachHangDAO.GetTienCoc(makhachhang);
        }
       
        public int Insert(KhachHangVO khachHangVO)
        {
            try
            {
                return khachHangDAO.Insert(khachHangVO);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Delete(int maKhachHang)
        {
            try
            {
                return khachHangDAO.Delete(maKhachHang);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Update(KhachHangVO khachHangVO)
        {
            try
            {
                return khachHangDAO.Update(khachHangVO);
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
                return khachHangDAO.GetLastIdentity() + 1;
            }
            catch (Exception e)
            {
                throw e;
            } 
        }

        public DataTable GetKhachHangByIndicator(KhachHangVO khachHangVO, bool bMKH, bool bMaQG, bool bHo, bool bTen, bool bCMND, bool bHochieu, bool bDienThoai)
        {
            return khachHangDAO.SearchByIndicator( khachHangVO, bMKH, bMaQG, bHo, bTen, bCMND, bHochieu, bDienThoai);
        }
    }
}
