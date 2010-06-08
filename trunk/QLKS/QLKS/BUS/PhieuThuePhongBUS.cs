using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;
namespace QLKS.BUS
{
    class PhieuThuePhongBUS
    {
        private PhieuThuePhongDAO phieuthuephongDAO;
        public PhieuThuePhongBUS()
        {
            phieuthuephongDAO = new PhieuThuePhongDAO();
        }
        public DataTable GetAll()
        {
            try
            {
                return phieuthuephongDAO.SelectAll();
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
                return phieuthuephongDAO.GetLastIdentity() + 1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Insert(PhieuThuePhongVO phieuthuephongVO)
        {
            try
            {
                return phieuthuephongDAO.Insert(phieuthuephongVO);
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
                return phieuthuephongDAO.Delete(maPhieu);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(PhieuThuePhongVO phieuthuephongVO)
        {
            try
            {
                return phieuthuephongDAO.Update(phieuthuephongVO);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DataTable GetUnPaidRoomByKhachHang(int maKhachHang)
        {
            try
            {
                return phieuthuephongDAO.SelectUnpaidRoomByMaKhachHang(maKhachHang);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DataTable GetUnPaidRoomByDoanKhach(int maDoanKhach)
        {
            try
            {
                return phieuthuephongDAO.SelectUnpaidRoomByMaDoanKhach(maDoanKhach);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Int64 GetTienPhong(int maPhieu)
        {
           return phieuthuephongDAO.TienPhong(maPhieu);
        }
        public Int64 GetTienDichVu(int maPhieu)
        {
            return phieuthuephongDAO.TienDichVU(maPhieu);
        }

    }
}
