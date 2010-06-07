using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS_TiepNhanKhach.VO;

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
                string query = " SELECT 'KH' + REPLACE(STR(MA_KHACH_HANG,4),' ','0') AS MaKH,"+
                               "'QG' + REPLACE(STR(MA_QUOC_GIA,2),' ','0') AS MaQG,"+
                               "HO_KHACH_HANG,TEN_KHACH_HANG,CMND,HO_CHIEU,DIEN_THOAI "+
                               "FROM KHACH_HANG " +
                               "WHERE HIEU_LUC = '1'";

                return Program.dbConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Insert(KhachHangVO khachHangVO)
        {
            try
            {
                String query = "INSERT INTO KHACH_HANG VALUES(@MA_QUOC_GIA,@HO_KHACH_HANG,@TEN_KHACH_HANG,@CMND,@HO_CHIEU,@DIEN_THOAI,@HIEU_LUC)";
                SqlParameter[] sqlParameters = new SqlParameter[7];

                sqlParameters[0] = new SqlParameter("@MA_QUOC_GIA", khachHangVO.MA_QUOC_GIA);
                sqlParameters[1] = new SqlParameter("@HO_KHACH_HANG", khachHangVO.HO_KHACH_HANG);
                sqlParameters[2] = new SqlParameter("@TEN_KHACH_HANG", khachHangVO.TEN_KHACH_HANG);
                sqlParameters[3] = new SqlParameter("@CMND", khachHangVO.CMND);
                sqlParameters[4] = new SqlParameter("@HO_CHIEU", khachHangVO.HO_CHIEU);
                sqlParameters[5] = new SqlParameter("@DIEN_THOAI", khachHangVO.DIEN_THOAI);
                sqlParameters[6] = new SqlParameter("@HIEU_LUC", khachHangVO.HIEU_LUC);
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
                String query = "UPDATE KHACH_HANG SET HIEU_LUC = '0' WHERE MA_KHACH_HANG = @MA_KHACH_HANG";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", maKhachHang);
                return Program.dbConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(KhachHangVO khachHangVO)
        {
            try
            {
                String query = "UPDATE KHACH_HANG SET MA_QUOC_GIA=@MA_QUOC_GIA,HO_KHACH_HANG=@HO_KHACH_HANG,TEN_KHACH_HANG=@TEN_KHACH_HANG,CMND=@CMND,HO_CHIEU=@HO_CHIEU,DIEN_THOAI=@DIEN_THOAI WHERE MA_KHACH_HANG=@MA_KHACH_HANG";
                SqlParameter[] sqlParameters = new SqlParameter[7];

                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", khachHangVO.MA_KHACH_HANG);
                sqlParameters[1] = new SqlParameter("@MA_QUOC_GIA", khachHangVO.MA_QUOC_GIA);
                sqlParameters[2] = new SqlParameter("@HO_KHACH_HANG", khachHangVO.HO_KHACH_HANG);
                sqlParameters[3] = new SqlParameter("@TEN_KHACH_HANG", khachHangVO.TEN_KHACH_HANG);
                sqlParameters[4] = new SqlParameter("@CMND", khachHangVO.CMND);
                sqlParameters[5] = new SqlParameter("@HO_CHIEU", khachHangVO.HO_CHIEU);
                sqlParameters[6] = new SqlParameter("@DIEN_THOAI", khachHangVO.DIEN_THOAI);

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
      
        public Int64 TienCoc(int makhachhang)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", makhachhang);
            return Program.dbConnection.ExecuteScalarByProcedue("sp_tiencocKH", sqlParameters);
        }

      

    }
}
