using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKS.DAO
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
                return Program.DBConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

}
