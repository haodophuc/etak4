using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS.DAO
{
    class LoaiPhongDAO
    {
       

        public LoaiPhongDAO()
        {
            
        }

        public DataTable SelectAll()
        {
            try
            {
                string query = "Select * From LOAI_PHONG";
                return Program.DBConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
