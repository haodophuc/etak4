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
