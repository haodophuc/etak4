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
        private DBConnection dbConnection;

        public KhachHangBUS(DBConnection dbConnection)
        {
            khachHangDAO = new KhachHangDAO(dbConnection);
            this.dbConnection = dbConnection;
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
       
        public int Insert(KhachHangVO khachhangVO)
        {
            try
            {
                return khachHangDAO.Insert(khachhangVO.MA_QUOC_GIA, khachhangVO.HO_KHACH_HANG, khachhangVO.TEN_KHACH_HANG, khachhangVO.CMND, khachhangVO.HO_CHIEU, khachhangVO.DIEN_THOAI);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Delete(KhachHangVO khachhangVO)
        {
            try
            {
                return khachHangDAO.Delete(khachhangVO.MA_KHACH_HANG);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Update(KhachHangVO khachhangVO)
        {
            try
            {
                return khachHangDAO.Update(khachhangVO.MA_KHACH_HANG, khachhangVO.MA_QUOC_GIA, khachhangVO.HO_KHACH_HANG, khachhangVO.TEN_KHACH_HANG, khachhangVO.CMND, khachhangVO.HO_CHIEU, khachhangVO.DIEN_THOAI);
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
