using System;
using System.Collections.Generic;
using System.Text;
using QLKS_TiepNhanKhach.DAO;
using System.Data;
using System.Data.SqlClient;
using QLKS_TiepNhanKhach.VO;

namespace QLKS_TiepNhanKhach.BUS
{
     
    class PhieuDatPhongBUS
    {
        private PhieuDatPhongDAO phieuDatPhongDAO;
        public PhieuDatPhongBUS()
        {
            phieuDatPhongDAO = new PhieuDatPhongDAO();
        }
        public DataTable GetAll()
        {
            try
            {
                return phieuDatPhongDAO.SelectAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int UpdateDaGiaiQuyetForCustomerAfterCheckOut(int makhachhang)
        {
            return phieuDatPhongDAO.UpdateFieldDA_GIAI_QUYETNotTruebyMaKH(makhachhang, true);
        }
        public int UpdateDaGiaiQuyetForGroupAfterCheckOut(int madoankhach)
        {
            return phieuDatPhongDAO.UpdateFieldDA_GIAI_QUYETNotTruebyMaDK(madoankhach, true);
        }
        public int GetNewIndentity()
        {
            try
            {
                return phieuDatPhongDAO.GetLastIdentity() + 1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Insert(PhieuDatPhongVO phieuDatPhongVO)
        {
            try
            {
                return phieuDatPhongDAO.Insert(phieuDatPhongVO);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(PhieuDatPhongVO phieuDatPhongVO)
        {
            try
            {
                return phieuDatPhongDAO.Update(phieuDatPhongVO);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Delete(int maPhieu)
        {
            try
            {
                return phieuDatPhongDAO.Delete(maPhieu);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}


