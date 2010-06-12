using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;

namespace QLKS.DAO
{
   
    class CatrucDAO
    {
        public CatrucDAO()
        {
 
        }
        public DataTable SelectMaCTAndTenThuNgan()
        {
            try
            {
                string query = "Select 'CT'+Replace(STR(MA_CA_TRUC,2),' ','0')AS MA_CA_TRUC,USER_NAME AS TEN_THU_NGAN "+
                                "From CA_TRUC,USERS "+
                                "Where CA_TRUC.USERID= USERS.USERID";

                return Program.DBConnection.ExecuteSelectQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }


        }
    }
    
}
