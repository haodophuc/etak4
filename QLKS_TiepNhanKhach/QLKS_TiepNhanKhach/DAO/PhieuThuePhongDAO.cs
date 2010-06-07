using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS_TiepNhanKhach.VO;

namespace QLKS_TiepNhanKhach.DAO
{
    class PhieuThuePhongDAO
    {
        public PhieuThuePhongDAO()
        {
           
        }
        public DataTable SelectAll()
        {
            try
            {
                string query = " SELECT 'P' + REPLACE(STR(MA_PHIEU,4),' ','0') AS MaP," +
                                "'KH' + REPLACE(STR(MA_KHACH_HANG,4),' ','0') AS MaKH," +
                               "'DK' + REPLACE(STR(MA_DOAN_KHACH,4),' ','0') AS MaDK," +
                               "NGAY_NHAN_PHONG,NGAY_TRA_PHONG,GHI_CHU,THANH_TOAN_TIEN_PHONG,THANH_TOAN_DICH_VU,DA_TRA_PHONG " +
                               "FROM PHIEU_THUE_PHONG ";
                             

                return Program.dbConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DataTable SelectUnpaidRoomByMaKhachHang(int makhachhang)
        {
            try
            {
                string query = " SELECT 'P' + REPLACE(STR(MA_PHIEU,4),' ','0') AS MaP," +
                                "'KH' + REPLACE(STR(MA_KHACH_HANG,4),' ','0') AS MaKH," +
                               "'DK' + REPLACE(STR(MA_DOAN_KHACH,4),' ','0') AS MaDK," +
                               "SO_PHONG,TEN_LOAI_PHONG,GIA_THAM_KHAO,NGAY_NHAN_PHONG,NGAY_TRA_PHONG,GHI_CHU,THANH_TOAN_TIEN_PHONG,THANH_TOAN_DICH_VU,DA_TRA_PHONG " +
                               "FROM PHIEU_THUE_PHONG,PHONG,LOAI_PHONG " +
                               "WHERE PHIEU_THUE_PHONG.MA_PHONG =PHONG.MA_PHONG AND PHONG.MA_LOAI_PHONG=LOAI_PHONG.MA_LOAI_PHONG "+
                               "AND (THANH_TOAN_TIEN_PHONG=0 OR THANH_TOAN_DICH_VU=0) AND MA_KHACH_HANG=@MA_KHACH_HANG";

                SqlParameter[] sqlParameters = new SqlParameter[1];

                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG",makhachhang);

                return Program.dbConnection.ExecuteSelectQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DataTable SelectUnpaidRoomByMaDoanKhach(int maDoanKhach)
        {
            try
            {
                string query = " SELECT 'P' + REPLACE(STR(MA_PHIEU,4),' ','0') AS MaP," +
                                "'KH' + REPLACE(STR(MA_KHACH_HANG,4),' ','0') AS MaKH," +
                               "'DK' + REPLACE(STR(MA_DOAN_KHACH,4),' ','0') AS MaDK," +
                               "SO_PHONG,TEN_LOAI_PHONG,GIA_THAM_KHAO,NGAY_NHAN_PHONG,NGAY_TRA_PHONG,GHI_CHU,THANH_TOAN_TIEN_PHONG,THANH_TOAN_DICH_VU,DA_TRA_PHONG " +
                               "FROM PHIEU_THUE_PHONG,PHONG,LOAI_PHONG " +
                               "WHERE PHIEU_THUE_PHONG.MA_PHONG =PHONG.MA_PHONG AND PHONG.MA_LOAI_PHONG=LOAI_PHONG.MA_LOAI_PHONG " +
                               "AND (THANH_TOAN_TIEN_PHONG=0 OR THANH_TOAN_DICH_VU=0) AND MA_DOAN_KHACH=@MA_DOAN_KHACH";

                SqlParameter[] sqlParameters = new SqlParameter[1];

                sqlParameters[0] = new SqlParameter("@MA_DOAN_KHACH", maDoanKhach);

                return Program.dbConnection.ExecuteSelectQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int GetLastIdentity()
        {
            try
            {
                String query = "SELECT last_value FROM sys.identity_columns WHERE [object_id] = object_id(@table)";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@table", "PHIEU_THUE_PHONG");
                return Program.dbConnection.ExecuteScalar(query, sqlParameters);
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
                String query = "INSERT INTO PHIEU_THUE_PHONG VALUES(@MA_KHACH_HANG,@MA_DOAN_KHACH,@MA_PHONG,@NGAY_NHAN_PHONG,@NGAY_TRA_PHONG,@GHI_CHU,@THANH_TOAN_TIEN_PHONG,@THANH_TOAN_DICH_VU,@DA_TRA_PHONG )";
                SqlParameter[] sqlParameters = new SqlParameter[9];

                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", phieuthuephongVO.MA_KHACH_HANG);
                sqlParameters[1] = new SqlParameter("@MA_DOAN_KHACH", phieuthuephongVO.MA_DOAN_KHACH);
                sqlParameters[2] = new SqlParameter("@MA_PHONG", phieuthuephongVO.MA_PHONG);
                sqlParameters[3] = new SqlParameter("@NGAY_NHAN_PHONG", phieuthuephongVO.NGAY_NHAN_PHONG);
                sqlParameters[4] = new SqlParameter("@NGAY_TRA_PHONG", phieuthuephongVO.NGAY_TRA_PHONG);
                sqlParameters[5] = new SqlParameter("@GHI_CHU", phieuthuephongVO.GHI_CHU);
                sqlParameters[6] = new SqlParameter("@THANH_TOAN_TIEN_PHONG", phieuthuephongVO.THANH_TOAN_TIEN_PHONG);
                sqlParameters[7] = new SqlParameter("@THANH_TOAN_DICH_VU", phieuthuephongVO.THANH_TOAN_DICH_VU);
                sqlParameters[8] = new SqlParameter("@DA_TRA_PHONG", phieuthuephongVO.DA_TRA_PHONG);

                return Program.dbConnection.ExecuteNonQuery(query, sqlParameters);
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
                String query = "UPDATE PHIEU_THUE_PHONG SET MA_KHACH_HANG=@MA_KHACH_HANG,MA_DOAN_KHACH=@MA_DOAN_KHACH,MA_PHONG=@MA_PHONG,NGAY_NHAN_PHONG=@NGAY_NHAN_PHONG,NGAY_TRA_PHONG=@NGAY_TRA_PHONG,GHI_CHU=@GHI_CHU,THANH_TOAN_TIEN_PHONG=@THANH_TOAN_TIEN_PHONG,THANH_TOAN_DICH_VU=@THANH_TOAN_DICH_VU,DA_TRA_PHONG=@DA_TRA_PHONG WHERE MA_PHIEU=@MA_PHIEU";
                SqlParameter[] sqlParameters = new SqlParameter[10];
                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", phieuthuephongVO.MA_KHACH_HANG);
                sqlParameters[1] = new SqlParameter("@MA_DOAN_KHACH", phieuthuephongVO.MA_DOAN_KHACH);
                sqlParameters[2] = new SqlParameter("@MA_PHONG", phieuthuephongVO.MA_PHONG);
                sqlParameters[3] = new SqlParameter("@NGAY_NHAN_PHONG", phieuthuephongVO.NGAY_NHAN_PHONG);
                sqlParameters[4] = new SqlParameter("@NGAY_TRA_PHONG", phieuthuephongVO.NGAY_TRA_PHONG);
                sqlParameters[5] = new SqlParameter("@GHI_CHU", phieuthuephongVO.GHI_CHU);
                sqlParameters[6] = new SqlParameter("@THANH_TOAN_TIEN_PHONG", phieuthuephongVO.THANH_TOAN_TIEN_PHONG);
                sqlParameters[7] = new SqlParameter("@THANH_TOAN_DICH_VU", phieuthuephongVO.THANH_TOAN_DICH_VU);
                sqlParameters[8] = new SqlParameter("@DA_TRA_PHONG", phieuthuephongVO.DA_TRA_PHONG);
                sqlParameters[9] = new SqlParameter("@MA_PHIEU", phieuthuephongVO.MA_PHIEU);
                return Program.dbConnection.ExecuteNonQuery(query, sqlParameters);
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
                String query = "DELETE FROM PHIEU_THUE_PHONG WHERE MA_PHIEU = @MA_PHIEU";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@MA_PHIEU", maPhieu);
                return Program.dbConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Int64 TienPhong(int maphieu)
        {
             SqlParameter[] sqlParameters = new SqlParameter[1];
               sqlParameters[0]= new SqlParameter("@MA_PHIEU",maphieu);
               return Program.dbConnection.ExecuteScalarByProcedue("sp_tienphong", sqlParameters);
        }
        public Int64 TienDichVU(int maphieu)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MA_PHIEU", maphieu);
            return Program.dbConnection.ExecuteScalarByProcedue("sp_tiendichvu", sqlParameters);
        }

    }
}

