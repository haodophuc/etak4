using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;

namespace QLKS.DAO
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

                return Program.DBConnection.ExecuteSelectQuery(query);
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
                String query = "INSERT INTO CONG_TY VALUES(@TEN_CONG_TY,@MA_QUOC_GIA,@MA_NGUOI_DAI_DIEN,@DIA_CHI,@DIEN_THOAI,@EMAIL,@FAX,@SO_TAI_KHOAN,@MA_SO_THUE,@HIEU_LUC)";
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

                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
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
                String query = "SELECT last_value FROM sys.identity_columns WHERE [objeCT_id] = objeCT_id(@table)";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@table", "CONG_TY");
                return (int)Program.DBConnection.ExecuteScalar(query, sqlParameters);
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
                sqlParameters[9] = new SqlParameter("@MA_CONG_TY", congtyVO.MA_CONG_TY);
                sqlParameters[0] = new SqlParameter("@MA_QUOC_GIA", congtyVO.MA_QUOC_GIA);
                sqlParameters[1] = new SqlParameter("@MA_NGUOI_DAI_DIEN", congtyVO.MA_NGUOI_DAI_DIEN);
                sqlParameters[2] = new SqlParameter("@TEN_CONG_TY", congtyVO.TEN_CONG_TY);
                sqlParameters[3] = new SqlParameter("@DIA_CHI", congtyVO.DIA_CHI);
                sqlParameters[4] = new SqlParameter("@DIEN_THOAI", congtyVO.DIEN_THOAI);
                sqlParameters[5] = new SqlParameter("@EMAIL", congtyVO.EMAIL);
                sqlParameters[6] = new SqlParameter("@FAX", congtyVO.FAX);
                sqlParameters[7] = new SqlParameter("@SO_TAI_KHOAN", congtyVO.SO_TAI_KHOAN);
                sqlParameters[8] = new SqlParameter("@MA_SO_THUE", congtyVO.MA_SO_THUE);


                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
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
                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataRow LoadDetail(int companyid)
        {
            try {
                String query = "SELECT CTX.TEN_CONG_TY, QG.TEN_QUOC_GIA, CTX.DIA_CHI, CTX.DIEN_THOAI, CTX.EMAIL, CTX.FAX, CTX.HO_KHACH_HANG, CTX.TEN_KHACH_HANG, CTX.DIEN_THOAI_KHACH_HANG " +
                               "FROM QUOC_GIA QG INNER JOIN (	SELECT CTS.TEN_CONG_TY, CTS.MA_QUOC_GIA, CTS.DIA_CHI, CTS.DIEN_THOAI, CTS.EMAIL, CTS.FAX, " +
                                                                       "KH.HO_KHACH_HANG, KH.TEN_KHACH_HANG, KH.DIEN_THOAI AS DIEN_THOAI_KHACH_HANG " +
                                                                "FROM KHACH_HANG KH INNER JOIN ( SELECT * FROM CONG_TY WHERE MA_CONG_TY = @MA_CONG_TY ) CTS ON KH.MA_KHACH_HANG = CTS.MA_NGUOI_DAI_DIEN ) CTX " +
                                                 "ON QG.MA_QUOC_GIA = CTX.MA_QUOC_GIA";
                SqlParameter param = new SqlParameter("@MA_CONG_TY", companyid);
                DataTable result = Program.DBConnection.ExecuteSelectQuery(query, new SqlParameter[] { param });
                return result.Rows[0];
            }//end try
            catch {
                throw;
            }//end catch
        }//end method LoadDetail
    }
}
