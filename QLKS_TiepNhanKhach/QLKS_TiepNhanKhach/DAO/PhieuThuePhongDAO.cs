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
                               "NGAY_NHAN_PHONG,NGAY_TRA_PHONG,DON_GIA_PHONG,GHI_CHU,THANH_TOAN_TIEN_PHONG,THANH_TOAN_DICH_VU,DA_TRA_PHONG " +
                               "FROM PHIEU_THUE_PHONG ";
                             

                return Program.dbConnection.ExecuteSelectQuery(query);
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
                String query = "INSERT INTO PHIEU_THUE_PHONG VALUES(@MA_KHACH_HANG,@MA_DOAN_KHACH,@MA_PHONG,@NGAY_NHAN_PHONG,@NGAY_TRA_PHONG,@DON_GIA_PHONG,@GHI_CHU,@THANH_TOAN_TIEN_PHONG,@THANH_TOAN_DICH_VU,@DA_TRA_PHONG)";
                SqlParameter[] sqlParameters = new SqlParameter[10];

                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", phieuthuephongVO.MA_KHACH_HANG);
                sqlParameters[1] = new SqlParameter("@MA_DOAN_KHACH", phieuthuephongVO.MA_DOAN_KHACH);
                sqlParameters[2] = new SqlParameter("@MA_PHONG", phieuthuephongVO.MA_PHONG);
                sqlParameters[3] = new SqlParameter("@NGAY_NHAN_PHONG", phieuthuephongVO.NGAY_NHAN_PHONG);
                sqlParameters[4] = new SqlParameter("@NGAY_TRA_PHONG", phieuthuephongVO.NGAY_TRA_PHONG);
                sqlParameters[5] = new SqlParameter("@DON_GIA_PHONG", phieuthuephongVO.DON_GIA_PHONG);
                sqlParameters[6] = new SqlParameter("@GHI_CHU", phieuthuephongVO.GHI_CHU);
                sqlParameters[7] = new SqlParameter("@THANH_TOAN_TIEN_PHONG", phieuthuephongVO.THANH_TOAN_TIEN_PHONG);
                sqlParameters[8] = new SqlParameter("@THANH_TOAN_DICH_VU", phieuthuephongVO.THANH_TOAN_DICH_VU);
                sqlParameters[9] = new SqlParameter("@DA_TRA_PHONG", phieuthuephongVO.DA_TRA_PHONG);

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
                String query = "UPDATE PHIEU_THUE_PHONG SET MA_KHACH_HANG=@MA_KHACH_HANG,MA_DOAN_KHACH=@MA_DOAN_KHACH,MA_PHONG=@MA_PHONG,NGAY_NHAN_PHONG=@NGAY_NHAN_PHONG,NGAY_TRA_PHONG=@NGAY_TRA_PHONG,DON_GIA_PHONG=@DON_GIA_PHONG,GHI_CHU=@GHI_CHU,THANH_TOAN_TIEN_PHONG=@THANH_TOAN_TIEN_PHONG,THANH_TOAN_DICH_VU=@THANH_TOAN_DICH_VU,DA_TRA_PHONG=@DA_TRA_PHONG WHERE MA_PHIEU=@MA_PHIEU";
                SqlParameter[] sqlParameters = new SqlParameter[11];
                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", phieuthuephongVO.MA_KHACH_HANG);
                sqlParameters[1] = new SqlParameter("@MA_DOAN_KHACH", phieuthuephongVO.MA_DOAN_KHACH);
                sqlParameters[2] = new SqlParameter("@MA_PHONG", phieuthuephongVO.MA_PHONG);
                sqlParameters[3] = new SqlParameter("@NGAY_NHAN_PHONG", phieuthuephongVO.NGAY_NHAN_PHONG);
                sqlParameters[4] = new SqlParameter("@NGAY_TRA_PHONG", phieuthuephongVO.NGAY_TRA_PHONG);
                sqlParameters[5] = new SqlParameter("@DON_GIA_PHONG", phieuthuephongVO.DON_GIA_PHONG);
                sqlParameters[6] = new SqlParameter("@GHI_CHU", phieuthuephongVO.GHI_CHU);
                sqlParameters[7] = new SqlParameter("@THANH_TOAN_TIEN_PHONG", phieuthuephongVO.THANH_TOAN_TIEN_PHONG);
                sqlParameters[8] = new SqlParameter("@THANH_TOAN_DICH_VU", phieuthuephongVO.THANH_TOAN_DICH_VU);
                sqlParameters[9] = new SqlParameter("@DA_TRA_PHONG", phieuthuephongVO.DA_TRA_PHONG);
                sqlParameters[10] = new SqlParameter("@MA_PHIEU", phieuthuephongVO.MA_PHIEU);
                return Program.dbConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}

//MA_PHIEU	int	Unchecked
//MA_KHACH_HANG	int	Checked
//MA_DOAN_KHACH	int	Checked
//MA_PHONG	int	Checked
//NGAY_NHAN_PHONG	datetime	Checked
//NGAY_TRA_PHONG	datetime	Checked
//DON_GIA_PHONG	money	Checked
//GHI_CHU	nvarchar(50)	Checked
//THANH_TOAN_TIEN_PHONG	bit	Checked
//THANH_TOAN_DICH_VU	bit	Checked
//DA_TRA_PHONG	bit	Checked
/*
 using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS_TiepNhanKhach.VO;

namespace QLKS_TiepNhanKhach.DAO
{
    class CongtyDAO
    {
        public CongtyDAO()
        {
           
        }
        public DataTable SelectAll()
        {
            try
            {
                string query = " SELECT 'CT' + REPLACE(STR(MA_CONG_TY,4),' ','0') AS MaCT," +
                               "'QG' + REPLACE(STR(MA_QUOC_GIA,2),' ','0') AS MaQG," +
                               "'KH' + REPLACE(STR(MA_NGUOI_DAI_DIEN,4),' ','0') AS MaKH," +
                               "TEN_CONG_TY,DIA_CHI,DIEN_THOAI,EMAIL,FAX,SO_TAI_KHOAN,MA_SO_THUE " +
                               "FROM CONG_TY " +
                               "WHERE HIEU_LUC = '1'";

                return Program.dbConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Insert(CongtyVO congtyVO)
        {
            try
            {
                String query = "INSERT INTO CONG_TY VALUES(@MA_QUOC_GIA,@MA_NGUOI_DAI_DIEN,@TEN_CONG_TY,@DIA_CHI,@DIEN_THOAI,@EMAIL,@FAX,@SO_TAI_KHOAN,@MA_SO_THUE,@HIEU_LUC)";
                SqlParameter[] sqlParameters = new SqlParameter[10];

                sqlParameters[0] = new SqlParameter("@MA_QUOC_GIA", congtyVO.MA_QUOC_GIA);
                sqlParameters[1] = new SqlParameter("@MA_NGUOI_DAI_DIEN", congtyVO.MA_NGUOI_DAI_DIEN);
                sqlParameters[2] = new SqlParameter("@TEN_CONG_TY", congtyVO.TEN_CONG_TY);
                sqlParameters[3] = new SqlParameter("@DIA_CHI", congtyVO.DIA_CHI);
                sqlParameters[4] = new SqlParameter("@DIEN_THOAI", congtyVO.DIEN_THOAI);
                sqlParameters[5] = new SqlParameter("@EMAIL", congtyVO.EMAIL);
                sqlParameters[6] = new SqlParameter("@FAX", congtyVO.FAX);
                sqlParameters[7] = new SqlParameter("@SO_TAI_KHOAN", congtyVO.SO_TAI_KHOAN);
                sqlParameters[8] = new SqlParameter("@MA_SO_THUE", congtyVO.MA_SO_THUE);
                sqlParameters[9] = new SqlParameter("@HIEU_LUC", congtyVO.HIEU_LUC);

                return Program.dbConnection.ExecuteNonQuery(query, sqlParameters);
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
                sqlParameters[0] = new SqlParameter("@table", "CONG_TY");
                return Program.dbConnection.ExecuteScalar(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public int Update(CongtyVO congtyVO)
        {
            try
            {
                String query = "UPDATE CONG_TY SET MA_QUOC_GIA=@MA_QUOC_GIA,MA_NGUOI_DAI_DIEN=@MA_NGUOI_DAI_DIEN,TEN_CONG_TY=@TEN_CONG_TY,DIA_CHI=@DIA_CHI,DIEN_THOAI=@DIEN_THOAI,EMAIL=@EMAIL,FAX=@FAX,SO_TAI_KHOAN=@SO_TAI_KHOAN,MA_SO_THUE=@MA_SO_THUE WHERE MA_CONG_TY=@MA_CONG_TY";
                SqlParameter[] sqlParameters = new SqlParameter[10];
                sqlParameters[0] = new SqlParameter("@MA_CONG_TY", congtyVO.MA_CONG_TY);
                sqlParameters[1] = new SqlParameter("@MA_QUOC_GIA", congtyVO.MA_QUOC_GIA);
                sqlParameters[2] = new SqlParameter("@MA_NGUOI_DAI_DIEN", congtyVO.MA_NGUOI_DAI_DIEN);
                sqlParameters[3] = new SqlParameter("@TEN_CONG_TY", congtyVO.TEN_CONG_TY);
                sqlParameters[4] = new SqlParameter("@DIA_CHI", congtyVO.DIA_CHI);
                sqlParameters[5] = new SqlParameter("@DIEN_THOAI", congtyVO.DIEN_THOAI);
                sqlParameters[6] = new SqlParameter("@EMAIL", congtyVO.EMAIL);
                sqlParameters[7] = new SqlParameter("@FAX", congtyVO.FAX);
                sqlParameters[8] = new SqlParameter("@SO_TAI_KHOAN", congtyVO.SO_TAI_KHOAN);
                sqlParameters[9] = new SqlParameter("@MA_SO_THUE", congtyVO.MA_SO_THUE);
          

                return Program.dbConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Delete(int maCongty)
        {
            try
            {
                String query = "UPDATE CONG_TY SET HIEU_LUC = '0' WHERE MA_CONG_TY = @MA_CONG_TY";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@MA_CONG_TY", maCongty);
                return Program.dbConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

       


    }
}

 */