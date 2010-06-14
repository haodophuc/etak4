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

        public int InsertAndGetID(VO.PhieuDatPhongVO valueObject)
        {
            try
            {
                string sp = "SP_INSERT_PHIEU_DAT_PHONG";

                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@IDENTITY", SqlDbType.Int);
                param[0].Direction = ParameterDirection.Output;

                param[1] = new SqlParameter("@MA_KHACH_HANG", valueObject.MA_KHACH_HANG);
                if (valueObject.MA_KHACH_HANG == -1)
                    param[1].Value = DBNull.Value;

                param[2] = new SqlParameter("@MA_DOAN_KHACH", valueObject.MA_DOAN_KHACH);
                if (valueObject.MA_DOAN_KHACH == -1)
                    param[2].Value = DBNull.Value;

                param[3] = new SqlParameter("@TIEN_COC", valueObject.TIEN_COC);

                return Program.DBConnection.ExecuteSPReturnsID(sp, param);
            }//end try
            catch
            {
                throw;
            }//end catch

        }//end method InsertAndGetID


        public int InsertBookingDetail(VO.BookingDetailVO detail)
        {
            try {
                string insert = "INSERT INTO CHI_TIET_DAT_PHONG " +
                                "VALUES (@MA_PHIEU, @MA_LOAI_PHONG, @NGAY_DEN, @NGAY_DI, @SO_LUONG)";

                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@MA_PHIEU", detail.IssueID);
                param[1] = new SqlParameter("@MA_LOAI_PHONG", detail.RoomTypeID);
                param[2] = new SqlParameter("@NGAY_DEN", detail.CheckInDay);
                param[3] = new SqlParameter("@NGAY_DI", detail.CheckOutDay);
                param[4] = new SqlParameter("@SO_LUONG", detail.Quantity);

                return Program.DBConnection.ExecuteNonQuery(insert, param);
                
            }//end try
            catch {
                throw;                            
            }//end catch
        }//end method InsertBookingDetail


    }
}
