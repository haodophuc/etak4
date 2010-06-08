using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS.DAO
{
    class TinhTrangDAO
    {
        public DataTable SelectAll()
        {
            try
            {
                string query = "Select * From TINH_TRANG";
                return Program.DBConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
