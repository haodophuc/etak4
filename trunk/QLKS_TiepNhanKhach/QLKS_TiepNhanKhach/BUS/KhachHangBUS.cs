using System;
using System.Collections.Generic;
using System.Text;
using QLKS_TiepNhanKhach.DAO;
using System.Data;
using System.Data.SqlClient;
using QLKS_TiepNhanKhach.VO;

namespace QLKS_TiepNhanKhach.BUS
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

       
    }
}
