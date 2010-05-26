using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_TiepNhanKhach.DAO
{
    class PhongDAO
    {
       

        public PhongDAO()
        {
           
        }

        public DataTable SelectAll()
        {
            try
            {
                string query = "Select * From Phong";
                return Program.dbConnection.ExecuteSelectQuery(query);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
