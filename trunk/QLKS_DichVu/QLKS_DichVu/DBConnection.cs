using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_DichVu
{
    public class DBConnection
    {
       #region Constructors

        public DBConnection()
        {
            Connection = new SqlConnection();
        }//end default constructor

        public DBConnection(String connectionString) : this()
        {
            try {
                Connection.ConnectionString = connectionString;    
            }//end try
            catch {
                throw;
            }//end catch
            
        }//end method 

       #endregion //end region Constructors

       #region Methods
                
        public void Connect()
        {
            if ( Connection == null)
            {
                throw new Exception("Connection haven't initialized");
            }// end if
            else if ( Connection.State == ConnectionState.Closed )
            {
                try
                {
                    Connection.Open();                        
                }
                catch (Exception e)
                {
                    throw e;
                }
            }// end if #2
            else
            {
                throw new Exception("Cannot connect with connection");
            }// end else
        }//end method Connect



        public void Disconnect()
        {
            if (Connection == null)
            {
                throw new Exception( "Connection haven't initialized" );
            }//end if sqlconnection is null
            if (Connection.State == ConnectionState.Open)
            {
                try
                {
                    Connection.Close();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }//end if connection is opened
            else
            {
                throw new Exception( "Cannot disconnect with connection" );
            }//end else
        }//end method Disconnect

        public DataTable ExecuteSelectQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                dataAdapter = new SqlDataAdapter(query, Connection);
                dataAdapter.Fill(dataTable);
            }//end try
            catch (SqlException e)
            {
                throw e;
            }//end catch
            finally
            {
                if (dataAdapter != null)
                    dataAdapter.Dispose();
                //Connection.Close();
            }//end finally
            return dataTable;
        }//end method ExecuteSelectQuery

        public int ExecuteNonQuery(String query, SqlParameter[] sqlParameters )
        {
            int result = 0;
            try {
                // Open a connection
                Connect();
                // Construct SqlCommand
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddRange(sqlParameters);                

                // Execute query
                result = Command.ExecuteNonQuery();

            }//end try
            catch( SqlException e ) {
                throw e;
            }//end catch
            finally {
                Command.Dispose();
                Disconnect();
            }//end finally

            return result;
        }//end method ExecuteNonQuery

        public object ExecuteScalar(String query, SqlParameter[] sqlParameters)
        {
            object result = null;
            try
            {
                // Open a connection
                Connect();

                // Construct SqlCommand
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddRange(sqlParameters);

                // Execute query
                result = Command.ExecuteScalar();

            }//end try
            catch (SqlException e)
            {
                throw e;
            }//end catch
            finally
            {
                Command.Dispose();
                Disconnect();
            }//end finally

            return result;
        }//end method ExecuteScalar

        public object ExecuteScalar(String query)
        {
            object result = null;
            try
            {
                Connect();
                Command = new SqlCommand(query, Connection);
                result = Command.ExecuteScalar();
            }//end try
            catch (SqlException e)
            {
                throw e;
            }//end catch
            finally
            {
                Command.Dispose();
                Disconnect();
            }//end finally

            return result;    
        }

       #endregion //end region Methods
        
       #region Attributes

        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }//end attribute Connection

        public SqlCommand Command
        {
            get { return command; }
            set { command = value; }
        }//end attribute Command

        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; }
        }//end attribute ErrorMessage

       #endregion //end region Attributes

       #region Instance Fields
        private SqlDataAdapter dataAdapter;
        private SqlConnection connection;
        private SqlCommand command;
        private String errorMessage;
       #endregion //end region Instance Fields
  
    }//end class DBConnection
}//end namespace QLKS_DichVu
