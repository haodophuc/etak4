using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;

namespace QLKS.DAO
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
                               "'P' + REPLACE(STR(MA_PHONG,4),' ','0') AS Ma_PHONG," +
                               "NGAY_NHAN_PHONG,NGAY_TRA_PHONG,GHI_CHU,THANH_TOAN_TIEN_PHONG,THANH_TOAN_DICH_VU,DA_TRA_PHONG " +
                               "FROM PHIEU_THUE_PHONG ";
                             

                return Program.DBConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DataTable SelectMaPhieu_MaKH_HoTen_CMND_HoChieu()
        {
            try
            {
                string query = " SELECT 'P' + REPLACE(STR(MA_PHIEU,4),' ','0') AS MaP," +
                                "'KH' + REPLACE(STR(KHACH_HANG.MA_KHACH_HANG,4),' ','0') AS MaKH," +            
                               "HO_KHACH_HANG+' '+TEN_KHACH_HANG AS HO_TEN,CMND,HO_CHIEU " +
                               "FROM PHIEU_THUE_PHONG,KHACH_HANG "+
                               "WHERE PHIEU_THUE_PHONG.MA_KHACH_HANG=KHACH_HANG.MA_KHACH_HANG";


                return Program.DBConnection.ExecuteSelectQuery(query);
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

                return Program.DBConnection.ExecuteSelectQuery(query, sqlParameters);
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

                return Program.DBConnection.ExecuteSelectQuery(query, sqlParameters);
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
                return (int)Program.DBConnection.ExecuteScalar(query, sqlParameters);
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
                String query = "INSERT INTO PHIEU_THUE_PHONG (MA_KHACH_HANG,MA_DOAN_KHACH,MA_PHONG,NGAY_NHAN_PHONG,GHI_CHU,THANH_TOAN_TIEN_PHONG,THANH_TOAN_DICH_VU,DA_TRA_PHONG) VALUES(@MA_KHACH_HANG,@MA_DOAN_KHACH,@MA_PHONG,@NGAY_NHAN_PHONG,@GHI_CHU,@THANH_TOAN_TIEN_PHONG,@THANH_TOAN_DICH_VU,'False')";
                SqlParameter[] sqlParameters = new SqlParameter[7];
                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", phieuthuephongVO.MA_KHACH_HANG);
                sqlParameters[1] = new SqlParameter("@MA_DOAN_KHACH", phieuthuephongVO.MA_DOAN_KHACH);
                sqlParameters[2] = new SqlParameter("@MA_PHONG", phieuthuephongVO.MA_PHONG);
                sqlParameters[3] = new SqlParameter("@NGAY_NHAN_PHONG", phieuthuephongVO.NGAY_NHAN_PHONG);
                sqlParameters[4] = new SqlParameter("@GHI_CHU", phieuthuephongVO.GHI_CHU);
                sqlParameters[5] = new SqlParameter("@THANH_TOAN_TIEN_PHONG", phieuthuephongVO.THANH_TOAN_TIEN_PHONG);
                sqlParameters[6] = new SqlParameter("@THANH_TOAN_DICH_VU", phieuthuephongVO.THANH_TOAN_DICH_VU);


                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        } //By zu~
        public int Update(PhieuThuePhongVO phieuthuephongVO)
        {
            try
            {
                String query = "UPDATE PHIEU_THUE_PHONG SET MA_KHACH_HANG=@MA_KHACH_HANG,MA_DOAN_KHACH=@MA_DOAN_KHACH,MA_PHONG=@MA_PHONG,NGAY_NHAN_PHONG=@NGAY_NHAN_PHONG,NGAY_TRA_PHONG=@NGAY_TRA_PHONG,GHI_CHU=@GHI_CHU,THANH_TOAN_TIEN_PHONG=@THANH_TOAN_TIEN_PHONG,THANH_TOAN_DICH_VU=@THANH_TOAN_DICH_VU,DA_TRA_PHONG=@DA_TRA_PHONG WHERE MA_PHIEU=@MA_PHIEU";
                if (phieuthuephongVO.NGAY_TRA_PHONG == DateTime.MinValue)
                {

                    query = "UPDATE PHIEU_THUE_PHONG SET MA_KHACH_HANG=@MA_KHACH_HANG,MA_DOAN_KHACH=@MA_DOAN_KHACH,MA_PHONG=@MA_PHONG,NGAY_NHAN_PHONG=@NGAY_NHAN_PHONG,GHI_CHU=@GHI_CHU,THANH_TOAN_TIEN_PHONG=@THANH_TOAN_TIEN_PHONG,THANH_TOAN_DICH_VU=@THANH_TOAN_DICH_VU,DA_TRA_PHONG=@DA_TRA_PHONG WHERE MA_PHIEU=@MA_PHIEU";
                }

                SqlParameter[] sqlParameters = new SqlParameter[10];
                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", phieuthuephongVO.MA_KHACH_HANG);
                sqlParameters[1] = new SqlParameter("@MA_DOAN_KHACH", phieuthuephongVO.MA_DOAN_KHACH);
                sqlParameters[2] = new SqlParameter("@MA_PHONG", phieuthuephongVO.MA_PHONG);
                sqlParameters[3] = new SqlParameter("@NGAY_NHAN_PHONG", phieuthuephongVO.NGAY_NHAN_PHONG);

                if (phieuthuephongVO.NGAY_TRA_PHONG != DateTime.MinValue)
                    sqlParameters[4] = new SqlParameter("@NGAY_TRA_PHONG", phieuthuephongVO.NGAY_TRA_PHONG);
                else
                {
                    sqlParameters[4] = new SqlParameter("@NGAY_TRA_PHONG", "");
                }

                sqlParameters[5] = new SqlParameter("@GHI_CHU", phieuthuephongVO.GHI_CHU);
                sqlParameters[6] = new SqlParameter("@THANH_TOAN_TIEN_PHONG", phieuthuephongVO.THANH_TOAN_TIEN_PHONG);
                sqlParameters[7] = new SqlParameter("@THANH_TOAN_DICH_VU", phieuthuephongVO.THANH_TOAN_DICH_VU);
                sqlParameters[8] = new SqlParameter("@DA_TRA_PHONG", phieuthuephongVO.DA_TRA_PHONG);
                sqlParameters[9] = new SqlParameter("@MA_PHIEU", phieuthuephongVO.MA_PHIEU);
                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
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
                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
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
               return Program.DBConnection.ExecuteScalarByProcedure("sp_tienphong", sqlParameters);
        }
        public Int64 TienDichVU(int maphieu)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MA_PHIEU", maphieu);
            return Program.DBConnection.ExecuteScalarByProcedure("sp_tiendichvu", sqlParameters);
        }

        // Created by G
        public int InsertBySP(PhieuThuePhongVO valueObject)
        {
            try
            {
                // Set procedure name
                String sp = "SP_INSERT_PHIEU_THUE_PHONG";

                // Create parameters
                SqlParameter[] param = new SqlParameter[5];

                // Return value
                param[0] = new SqlParameter("@IDENTITY", valueObject.MA_PHIEU);
                param[0].Direction = ParameterDirection.Output;

                param[1] = new SqlParameter("@MA_KHACH_HANG", valueObject.MA_KHACH_HANG);
                param[2] = new SqlParameter("@MA_DOAN_KHACH", valueObject.MA_DOAN_KHACH);
                if (valueObject.MA_DOAN_KHACH == -1)
                    param[2].Value = DBNull.Value;
                param[3] = new SqlParameter("@MA_PHONG", valueObject.MA_PHONG);
                param[4] = new SqlParameter("@NGAY_NHAN_PHONG", valueObject.NGAY_NHAN_PHONG);

                return (int)Program.DBConnection.ExecuteSPReturnsID(sp, param);

            }//end try
            catch (Exception e)
            {
                throw e;
            }//end catch
        }//end method InsertBySP

    }//end class PhieuThuePhongDAO
}//end namespace

