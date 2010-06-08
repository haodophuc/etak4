using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;

namespace QLKS.DAO
{
    class KhachTroDAO
    {
        public KhachTroDAO()
        {

        }
         public DataTable SelectAll()
        {
            try
            {
                string query = " SELECT 'KH' + REPLACE(STR(MA_KHACH_HANG,4),' ','0') AS MaKH,"+
                                  " 'P' + REPLACE(STR(MA_PHIEU,4),' ','0') AS MaP"+
                               "FROM KHACH_TRO ";
                             

                return Program.DBConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Insert(KhachTroVO khachtroVO)
        {
            try
            {
                String query = "INSERT INTO KHACH_TRO VALUES(@MA_KHACH_HANG,@MA_PHIEU)";
                SqlParameter[] sqlParameters = new SqlParameter[2];

                sqlParameters[0] = new SqlParameter("@MA_PHIEU", khachtroVO.MA_PHIEU);
                sqlParameters[1] = new SqlParameter("@MA_KHACH_HANG", khachtroVO.MA_KHACH_HANG);
             
                return Program.DBConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
