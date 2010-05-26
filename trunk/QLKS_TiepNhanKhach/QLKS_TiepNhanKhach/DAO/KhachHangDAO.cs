using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKS_TiepNhanKhach.DAO
{
    class KhachHangDAO
    {
      

        public KhachHangDAO()
        {
           
        }

        public DataTable SelectAll()
        {
            try
            {
                string query = "Select * From KHACH_HANG";
                return Program.dbConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Insert(string[] khachHangInfo)
        {
            try
            {
                String query = "INSERT INTO KHACH_HANG VALUES(@MA_QUOC_GIA,@HO_KHACH_HANG,@TEN_KHACH_HANG,@CMND,@HO_CHIEU,@DIEN_THOAI)";
                SqlParameter[] sqlParameters = new SqlParameter[6];

                sqlParameters[0] = new SqlParameter("@MA_QUOC_GIA", khachHangInfo[1]);
                sqlParameters[1] = new SqlParameter("@HO_KHACH_HANG", khachHangInfo[2]);
                sqlParameters[2] = new SqlParameter("@TEN_KHACH_HANG", khachHangInfo[3]);
                sqlParameters[3] = new SqlParameter("@CMND", khachHangInfo[4]);
                sqlParameters[4] = new SqlParameter("@HO_CHIEU", khachHangInfo[5]);
                sqlParameters[5] = new SqlParameter("@DIEN_THOAI", khachHangInfo[6]);

                return Program.dbConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Delete(int maKhachHang)
        {
            try
            {
                String query = "DELETE FROM KHACH_HANG WHERE MA_KHACH_HANG=@MA_KHACH_HANG";
                SqlParameter[] sqlParameters = new SqlParameter[1];

                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", maKhachHang);

                return Program.dbConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(string[] khachHangInfo)
        {
            try
            {
                String query = "UPDATE KHACH_HANG SET MA_QUOC_GIA=@MA_QUOC_GIA,HO_KHACH_HANG=@HO_KHACH_HANG,TEN_KHACH_HANG=@TEN_KHACH_HANG,CMND=@CMND,HO_CHIEU=@HO_CHIEU,DIEN_THOAI=@DIEN_THOAI WHERE MA_KHACH_HANG=@MA_KHACH_HANG";
                SqlParameter[] sqlParameters = new SqlParameter[7];

                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", khachHangInfo[0]);
                sqlParameters[1] = new SqlParameter("@MA_QUOC_GIA", khachHangInfo[1]);
                sqlParameters[2] = new SqlParameter("@HO_KHACH_HANG", khachHangInfo[2]);
                sqlParameters[3] = new SqlParameter("@TEN_KHACH_HANG", khachHangInfo[3]);
                sqlParameters[4] = new SqlParameter("@CMND", khachHangInfo[4]);
                sqlParameters[5] = new SqlParameter("@HO_CHIEU", khachHangInfo[5]);
                sqlParameters[6] = new SqlParameter("@DIEN_THOAI", khachHangInfo[6]);

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
                sqlParameters[0] = new SqlParameter("@table", "KHACH_HANG");
                return Program.dbConnection.ExecuteScalar(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}