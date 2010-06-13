using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;

namespace QLKS.BUS
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

        public int InsertAndGetID(VO.PhieuDatPhongVO valueObject)
        {
            try {
                return phieuDatPhongDAO.InsertAndGetID(valueObject);
            }//end try
            catch {
                throw;
            }//end catch
        }//end method InsertAndGetID

        public int InsertBookingDetail(VO.BookingDetailVO valueObject)
        {
            try
            {
                return phieuDatPhongDAO.InsertBookingDetail(valueObject);
            }//end try
            catch
            {
                throw;
            }//end catch
        }//end method InsertBookingDetail

    }
}


