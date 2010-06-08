using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;

namespace QLKS.DAO
{
    class DoanKhachDAO
    {
        public DoanKhachDAO()
        {

        }

        public DataTable SelectAll()
        {
            try
            {
                string query = " SELECT 'DK' + REPLACE(STR(MA_DOAN_KHACH,4),' ','0') AS MaDK," +
                               "'CT' + REPLACE(STR(MA_CONG_TY,4),' ','0') AS MaCT," +
                               "NGAY_DEN " +
                               "FROM DOAN_KHACH " +
                               "WHERE HIEU_LUC = '1'";

                return Program.DBConnection.ExecuteSelectQuery(query);
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
                sqlParameters[0] = new SqlParameter("@table", "DOAN_KHACH");
                return (int)Program.DBConnection.ExecuteScalar(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public int Insert(DoanKhachVO doankhachVO)
        {
            try
            {
                String query = "INSERT INTO DOAN_KHACH VALUES(@MA_CONGTY,@NGAY_DEN,@HIEU_LUC)";
                SqlParameter[] sqlParameters = new SqlParameter[3];

                sqlParameters[0] = new SqlParameter("@MA_CONGTY", doankhachVO.MA_CONG_TY);
                sqlParameters[1] = new SqlParameter("@NGAY_DEN", doankhachVO.NGAY_DEN);
                sqlParameters[2] = new SqlParameter("@HIEU_LUC", doankhachVO.HIEU_LUC);
            

                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(DoanKhachVO doankhachVO)
        {
            try
            {
                String query = "UPDATE DOAN_KHACH SET MA_CONG_TY=@MA_CONG_TY,NGAY_DEN=@NGAY_DEN WHERE MA_DOAN_KHACH=@MA_DOAN_KHACH";
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@MA_DOAN_KHACH", doankhachVO.MA_DOAN_KHACH);
                sqlParameters[1] = new SqlParameter("@MA_CONG_TY", doankhachVO.MA_CONG_TY);
                sqlParameters[2] = new SqlParameter("@NGAY_DEN", doankhachVO.NGAY_DEN);
            
         
                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Delete(int maDoanKhach)
        {
            try
            {
                String query = "UPDATE DOAN_KHACH SET HIEU_LUC = '0' WHERE MA_DOAN_KHACH = @MA_DOAN_KHACH";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@MA_DOAN_KHACH", maDoanKhach);
                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Int64 GetTienCoc(int madoankhach)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MA_DOAN_KHACH", madoankhach);
            return Program.DBConnection.ExecuteScalarByProcedure("sp_tiencocDK", sqlParameters);
        }

        public DataTable LoadFind()
        {
            try
            {
                String query = "SELECT DOAN_KHACH.MA_DOAN_KHACH, DOAN_KHACH.MA_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, NGAY_DEN, TEN_CONG_TY " +
                               "FROM DOAN_KHACH, CONG_TY " +
                               "WHERE DOAN_KHACH.MA_CONG_TY = CONG_TY.MA_CONG_TY";
                return Program.DBConnection.ExecuteSelectQuery(query);
            }//end try
            catch
            {
                throw;
            }//end catch


        }//end method LoadFind
    }//end class DoanKhachDAO
}//end namespace