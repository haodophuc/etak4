using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_TiepNhanKhach.DAO
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
                return Program.dbConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
