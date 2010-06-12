using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;

namespace QLKS.DAO
{
    class PhieuThuDoanKhachDAO
    {
        public PhieuThuDoanKhachDAO()
        {
 
        }
        public DataTable SelectAll()
        {
            try
            {
                string query = " SELECT 'PT' + REPLACE(STR(SO_PHIEU,6),' ','0') AS SO_PHIEU," +
                                "'DK' + REPLACE(STR(MA_DOAN_KHACH,4),' ','0') AS MA_DOAN_KHACH ," +
                               "'CT' + REPLACE(STR(MA_CA_TRUC,2),' ','0') AS MA_CA_TRUC," +
                               "NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU " +
                               "FROM PHIEU_THU_DOAN_KHACH ";
                              

                return Program.DBConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Insert(PhieuThuDoanKhachVO phieuThuDoanKhachVO)
        {
            try
            {
                String query = "INSERT INTO PHIEU_THU_DOAN_KHACH VALUES(@MA_DOAN_KHACH,@MA_CA_TRUC,@NGAY_PHIEU,@SO_TIEN,@NOI_DUNG_THU,@HINH_THUC_THU)";
                SqlParameter[] sqlParameters = new SqlParameter[6];

                sqlParameters[0] = new SqlParameter("@MA_DOAN_KHACH", phieuThuDoanKhachVO.MA_DOAN_KHACH);
                sqlParameters[1] = new SqlParameter("@MA_CA_TRUC", phieuThuDoanKhachVO.MA_CA_TRUC);
                sqlParameters[2] = new SqlParameter("@NGAY_PHIEU", phieuThuDoanKhachVO.NGAY_PHIEU);
                sqlParameters[3] = new SqlParameter("@SO_TIEN", phieuThuDoanKhachVO.SO_TIEN);
                sqlParameters[4] = new SqlParameter("@NOI_DUNG_THU", phieuThuDoanKhachVO.NOI_DUNG_THU);
                sqlParameters[5] = new SqlParameter("@HINH_THUC_THU", phieuThuDoanKhachVO.HINH_THUC_THU);
            
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
                String query = "DELETE FROM PHIEU_THU_DOAN_KHACH WHERE SO_PHIEU = @SO_PHIEU";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@SO_PHIEU", soPhieu);
                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(PhieuThuDoanKhachVO phieuThuDoanKhachVO)
        {
            try
            {
                String query = "UPDATE PHIEU_THU_DOAN_KHACH SET MA_DOAN_KHACH=@MA_DOAN_KHACH,MA_CA_TRUC=@MA_CA_TRUC,NGAY_PHIEU=@NGAY_PHIEU,SO_TIEN=@SO_TIEN,NOI_DUNG_THU=@NOI_DUNG_THU,HINH_THUC_THU=@HINH_THUC_THU WHERE SO_PHIEU=@SO_PHIEU";
                SqlParameter[] sqlParameters = new SqlParameter[7];
                sqlParameters[0] = new SqlParameter("@SO_PHIEU", phieuThuDoanKhachVO.SO_PHIEU);
                sqlParameters[1] = new SqlParameter("@MA_DOAN_KHACH", phieuThuDoanKhachVO.MA_DOAN_KHACH);
                sqlParameters[2] = new SqlParameter("@MA_CA_TRUC", phieuThuDoanKhachVO.MA_CA_TRUC);
                sqlParameters[3] = new SqlParameter("@NGAY_PHIEU", phieuThuDoanKhachVO.NGAY_PHIEU);
                sqlParameters[4] = new SqlParameter("@SO_TIEN", phieuThuDoanKhachVO.SO_TIEN);
                sqlParameters[5] = new SqlParameter("@NOI_DUNG_THU", phieuThuDoanKhachVO.NOI_DUNG_THU);
                sqlParameters[6] = new SqlParameter("@HINH_THUC_THU", phieuThuDoanKhachVO.HINH_THUC_THU);

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
                sqlParameters[0] = new SqlParameter("@table", "PHIEU_THU_DOAN_KHACH");
                return (int)Program.DBConnection.ExecuteScalar(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
