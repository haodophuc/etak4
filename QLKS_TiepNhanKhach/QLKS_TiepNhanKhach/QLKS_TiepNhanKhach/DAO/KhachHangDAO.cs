using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKS_TiepNhanKhach.DAO
{
    class KhachHangDAO
    {
        private DBConnection dbConnection;

        public KhachHangDAO()
        {
            dbConnection = new DBConnection();
        }

        public DataTable SelectAll()
        {
            try
            {
                string query = "Select * From KHACH_HANG";
                return dbConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Insert(int MA_QUOC_GIA, String HO_KHACH_HANG, String TEN_KHACH_HANG, String CMND, String HO_CHIEU, String DIEN_THOAI)
        {
            try
            {
                String query = "INSERT INTO KHACH_HANG VALUES(@MA_QUOC_GIA,@HO_KHACH_HANG,@TEN_KHACH_HANG,@CMND,@HO_CHIEU,@DIEN_THOAI)";
                SqlParameter[] sqlParameters = new SqlParameter[6];

                sqlParameters[0] = new SqlParameter("@MA_QUOC_GIA", MA_QUOC_GIA);
                sqlParameters[1] = new SqlParameter("@HO_KHACH_HANG", HO_KHACH_HANG);
                sqlParameters[2] = new SqlParameter("@TEN_KHACH_HANG", TEN_KHACH_HANG);
                sqlParameters[3] = new SqlParameter("@CMND", CMND);
                sqlParameters[4] = new SqlParameter("@HO_CHIEU", HO_CHIEU);
                sqlParameters[5] = new SqlParameter("@DIEN_THOAI", DIEN_THOAI);

                return dbConnection.ExecuteInsertQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Delete(int MA_KHACH_HANG)
        {
            try
            {
                String query = "DELETE FROM KHACH_HANG WHERE MA_KHACH_HANG=@MA_KHACH_HANG";
                SqlParameter[] sqlParameters = new SqlParameter[1];

                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", MA_KHACH_HANG);

                return dbConnection.ExecuteDeleteQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(int MA_KHACH_HANG, int MA_QUOC_GIA, String HO_KHACH_HANG, String TEN_KHACH_HANG, String CMND, String HO_CHIEU, String DIEN_THOAI)
        {
            try
            {
                String query = "UPDATE KHACH_HANG SET MA_QUOC_GIA=@MA_QUOC_GIA,HO_KHACH_HANG=@HO_KHACH_HANG,TEN_KHACH_HANG=@TEN_KHACH_HANG,CMND=@CMND,HO_CHIEU=@HO_CHIEU,DIEN_THOAI=@DIEN_THOAI WHERE MA_KHACH_HANG=@MA_KHACH_HANG";
                SqlParameter[] sqlParameters = new SqlParameter[7];

                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", MA_KHACH_HANG);
                sqlParameters[1] = new SqlParameter("@MA_QUOC_GIA", MA_QUOC_GIA);
                sqlParameters[2] = new SqlParameter("@HO_KHACH_HANG", HO_KHACH_HANG);
                sqlParameters[3] = new SqlParameter("@TEN_KHACH_HANG", TEN_KHACH_HANG);
                sqlParameters[4] = new SqlParameter("@CMND", CMND);
                sqlParameters[5] = new SqlParameter("@HO_CHIEU", HO_CHIEU);
                sqlParameters[6] = new SqlParameter("@DIEN_THOAI", DIEN_THOAI);

                return dbConnection.ExecuteUpdateQuery(query, sqlParameters);
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
                sqlParameters[0] = new SqlParameter("@table", "KHACH_HANG");
                return dbConnection.ExecuteScalar(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
