using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;

namespace QLKS.DAO
{
    class PhieuThuKhachHangDAO
    {
        public DataTable SelectAll()
        {
            try
            {
                string query = " SELECT 'PT' + REPLACE(STR(SO_PHIEU,6),' ','0') AS SO_PHIEU," +
                                "'P' + REPLACE(STR(MA_PHIEU,4),' ','0') AS MA_PHIEU ," +
                               "'CT' + REPLACE(STR(MA_CA_TRUC,2),' ','0') AS MA_CA_TRUC," +
                               "NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU " +
                               "FROM PHIEU_THU_KHACH_HANG ";
                              

                return Program.DBConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Insert(PhieuThuKhachHangVO phieuThuKhachHangVO)
        {
            try
            {
                String query = "INSERT INTO PHIEU_THU_KHACH_HANG VALUES(@MA_CA_TRUC,@MA_PHIEU,@NGAY_PHIEU,@SO_TIEN,@NOI_DUNG_THU,@HINH_THUC_THU)";
                SqlParameter[] sqlParameters = new SqlParameter[6];

                sqlParameters[0] = new SqlParameter("@MA_PHIEU", phieuThuKhachHangVO.MA_PHIEU);
                sqlParameters[1] = new SqlParameter("@MA_CA_TRUC", phieuThuKhachHangVO.MA_CA_TRUC);
                sqlParameters[2] = new SqlParameter("@NGAY_PHIEU", phieuThuKhachHangVO.NGAY_PHIEU);
                sqlParameters[3] = new SqlParameter("@SO_TIEN", phieuThuKhachHangVO.SO_TIEN);
                sqlParameters[4] = new SqlParameter("@NOI_DUNG_THU", phieuThuKhachHangVO.NOI_DUNG_THU);
                sqlParameters[5] = new SqlParameter("@HINH_THUC_THU", phieuThuKhachHangVO.HINH_THUC_THU);
            
                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public int Delete(int soPhieu)
        {
            try
            {
                String query = "DELETE FROM PHIEU_THU_KHACH_HANG WHERE SO_PHIEU = @SO_PHIEU";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@SO_PHIEU", soPhieu);
                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(PhieuThuKhachHangVO phieuThuKhachHangVO)
        {
            try
            {
                String query = "UPDATE PHIEU_THU_KHACH_HANG SET MA_PHIEU=@MA_PHIEU,MA_CA_TRUC=@MA_CA_TRUC,NGAY_PHIEU=@NGAY_PHIEU,SO_TIEN=@SO_TIEN,NOI_DUNG_THU=@NOI_DUNG_THU,HINH_THUC_THU=@HINH_THUC_THU WHERE SO_PHIEU=@SO_PHIEU";
                SqlParameter[] sqlParameters = new SqlParameter[7];
                sqlParameters[0] = new SqlParameter("@SO_PHIEU", phieuThuKhachHangVO.SO_PHIEU);
                sqlParameters[1] = new SqlParameter("@MA_PHIEU", phieuThuKhachHangVO.MA_PHIEU);
                sqlParameters[2] = new SqlParameter("@MA_CA_TRUC", phieuThuKhachHangVO.MA_CA_TRUC);
                sqlParameters[3] = new SqlParameter("@NGAY_PHIEU", phieuThuKhachHangVO.NGAY_PHIEU);
                sqlParameters[4] = new SqlParameter("@SO_TIEN", phieuThuKhachHangVO.SO_TIEN);
                sqlParameters[5] = new SqlParameter("@NOI_DUNG_THU", phieuThuKhachHangVO.NOI_DUNG_THU);
                sqlParameters[6] = new SqlParameter("@HINH_THUC_THU", phieuThuKhachHangVO.HINH_THUC_THU);

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
                String query = "SELECT last_value FROM sys.identity_columns WHERE [object_id] = object_id(@table)";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@table", "PHIEU_THU_KHACH_HANG");
                return (int)Program.DBConnection.ExecuteScalar(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
