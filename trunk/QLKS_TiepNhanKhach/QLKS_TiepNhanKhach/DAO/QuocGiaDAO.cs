using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKS_TiepNhanKhach.DAO
{
    class QuocGiaDAO
    {
       

        public QuocGiaDAO()
        {
           
        }

        public DataTable SelectAll()
        {
            try
            {
                string query = "Select * From QUOC_GIA";
                return Program.dbConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

}
