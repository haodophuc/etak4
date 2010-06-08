using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;

namespace QLKS.DAO
{
    class PhieuDatPhongDAO
    {
        public PhieuDatPhongDAO()
        {
        }
        public DataTable SelectAll()
        {
            try
            {
                string query = " SELECT 'P' + REPLACE(STR(MA_PHIEU,4),' ','0') AS MaP," +
                               "'KH' + REPLACE(STR(MA_KHACH_HANG,4),' ','0') AS MaKH," +
                                "'DK' + REPLACE(STR(MA_DOAN_KHACH,4),' ','0') AS MaDK," +
                               "TIEN_COC,DA_GIAI_QUYET " +
                               "FROM PHIEU_DAT_PHONG ";
                             

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
                sqlParameters[0] = new SqlParameter("@table", "PHIEU_DAT_PHONG");
                return (int)Program.DBConnection.ExecuteScalar(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Insert(PhieuDatPhongVO phieudatphongVO)
        {
            try
            {
                String query = "INSERT INTO PHIEU_DAT_PHONG VALUES(@MA_KHACH_HANG,@MA_DOAN_KHACH,@TIEN_COC,@DA_GIAI_QUYET)";
                SqlParameter[] sqlParameters = new SqlParameter[4];

                sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", phieudatphongVO.MA_KHACH_HANG);
                sqlParameters[1] = new SqlParameter("@MA_DOAN_KHACH", phieudatphongVO.MA_DOAN_KHACH);
                sqlParameters[2] = new SqlParameter("@TIEN_COC", phieudatphongVO.TIEN_COC);
                sqlParameters[3] = new SqlParameter("@DA_GIAI_QUYET", phieudatphongVO.DA_GIAI_QUYET);

                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(PhieuDatPhongVO phieudatphongVO)
        {
            try
            {
                String query = "UPDATE PHIEU_DAT_PHONG SET MA_KHACH_HANG=@MA_KHACH_HANG,MA_DOAN_KHACH=@MA_DOAN_KHACH,TIEN_COC=@TIEN_COC,DA_GIAI_QUYET=@DA_GIAI_QUYET WHERE MA_PHIEU=@MA_PHIEU";
                SqlParameter[] sqlParameters = new SqlParameter[5];
                sqlParameters[0] = new SqlParameter("@MA_PHIEU", phieudatphongVO.MA_PHIEU);
                sqlParameters[1] = new SqlParameter("@MA_KHACH_HANG", phieudatphongVO.MA_KHACH_HANG);
                sqlParameters[2] = new SqlParameter("@MA_DOAN_KHACH", phieudatphongVO.MA_DOAN_KHACH);
                sqlParameters[3] = new SqlParameter("@TIEN_COC", phieudatphongVO.TIEN_COC);
                sqlParameters[4] = new SqlParameter("@DA_GIAI_QUYET", phieudatphongVO.DA_GIAI_QUYET);


                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int UpdateFieldDA_GIAI_QUYETNotTruebyMaKH( int makhachhang,bool DA_GIAI_QUYET)
        {
            try
            {
                String query = "UPDATE PHIEU_DAT_PHONG SET DA_GIAI_QUYET=@DA_GIAI_QUYET WHERE  DA_GIAI_QUYET = 'False' AND MA_KHACH_HANG=@MA_KHACH_HANG";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MA_KHACH_HANG", makhachhang);
            sqlParameters[1] = new SqlParameter("@DA_GIAI_QUYET", DA_GIAI_QUYET);
            return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int UpdateFieldDA_GIAI_QUYETNotTruebyMaDK(int maDoanKhach, bool DA_GIAI_QUYET)
        {
            try
            {
                String query = "UPDATE PHIEU_DAT_PHONG SET DA_GIAI_QUYET=@DA_GIAI_QUYET WHERE DA_GIAI_QUYET = 'False' AND MA_DOAN_KHACH=@MA_DOAN_KHACH";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@MA_DOAN_KHACH", maDoanKhach);
                sqlParameters[1] = new SqlParameter("@DA_GIAI_QUYET", DA_GIAI_QUYET);
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
                String query = "DELETE FROM PHIEU_DAT_PHONG WHERE MA_PHIEU = @MA_PHIEU";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@MA_PHIEU", maPhieu);
                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        


    }
}
