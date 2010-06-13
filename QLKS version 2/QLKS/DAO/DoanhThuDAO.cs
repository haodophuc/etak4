using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLKS.DAO
{
    class DoanhThuDAO
    {
        public DoanhThuDAO()
        {

        }

        public DataTable GetDoanhThu(int year)
        {
            try
            {
                string query = "SP_DOANH_THU";
                SqlParameter[] sqlParameters = new SqlParameter[1];

                sqlParameters[0] = new SqlParameter("@YEAR", year);

                return Program.DBConnection.ExecuteSelectQuerySP(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
