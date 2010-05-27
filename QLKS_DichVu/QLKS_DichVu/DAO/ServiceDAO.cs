using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_DichVu.DAO
{
    class ServiceDAO
    {
       #region Constructors
        public ServiceDAO()
        {
            Connection = Program.DBConnection;
        }// end constructor
       #endregion // end region Constructors


       #region Methods

        public DataTable GetAllServices()
        {
            try
            {
                DataTable tableResult = new DataTable();

                // build & execute sql query
                String query = "SELECT MA_DICH_VU, TEN_DICH_VU, DON_GIA, HIEU_LUC FROM DICH_VU";
                Connection = new DBConnection();
                tableResult = Connection.ExecuteSelectQuery(query);
                return tableResult;
            }
            catch (SqlException e)
            {
                throw e;
            }// end catch
        }// end method getAllServices

        public int DeleteServiceByID( String serviceID )
        {
            try {
                // build delete query
                String delete = "DELETE FROM DICH_VU WHERE MA_DICH_VU = @MA_DICH_VU";
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@MA_DICH_VU", serviceID);
                Connection = new DBConnection();
                int result = Connection.ExecuteNonQuery( delete, param );
                return result;
            }// end try
            catch (SqlException e) {
                throw e;
            }// end catch
        }// end method DeleteService

        public int InsertService( String name, Double price )
        {
            try
            {
                // build insert query
                String insert = "INSERT INTO DICH_VU(TEN_DICH_VU, DON_GIA) "+
                                "VALUES(@TEN_DICH_VU, @DON_GIA)";
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@TEN_DICH_VU", name);
                param[1] = new SqlParameter("@DON_GIA", price);
                Connection = new DBConnection();
                int result = Connection.ExecuteNonQuery(insert, param);
                return result;
            }// end try
            catch (SqlException e)
            {
                throw e;
            }// end catch
        }// end method InsertService

        public int UpdateService(String id, String name, Double price, bool state)
        {
            try {
                //build query
                String update = "UPDATE DICH_VU" +
                                "SET TEN_DICH_VU = @TEN_DICH_VU, DON_GIA = @DON_GIA, HIEU_LUC = @HIEU_LUC" +
                                "WHERE MA_DICH_VU = @MA_DICH_VU";
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@MA_DICH_VU", id);
                param[1] = new SqlParameter("@TEN_DICH_VU", name);
                param[2] = new SqlParameter("@DON_GIA", price);
                param[3] = new SqlParameter("@HIEU_LUC", state);

                Connection = new DBConnection();
                int result = Connection.ExecuteNonQuery(update, param);
                return result;
            }//end try
            catch( SqlException e ) {
                throw e;
            }//end catch
            
        }//end method UpdateService
                
       #endregion // end region methods


       #region Attributes
        public DBConnection Connection
        {
            get { return connection; }
            set { this.connection = value; }
        }
       #endregion // end region Attributes


       #region Instance Fields
        private DBConnection connection;
       #endregion // end region Instance Fields


    }// end class ServiceDAO
}// end namespaceQLKS_DichVu.DAO
