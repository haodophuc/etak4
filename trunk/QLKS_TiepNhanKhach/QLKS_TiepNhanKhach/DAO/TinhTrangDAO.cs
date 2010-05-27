using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_TiepNhanKhach.DAO
{
    class TinhTrangDAO
    {
        public DataTable SelectAll()
        {
            try
            {
                string query = "Select * From TINH_TRANG";
                return Program.dbConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
