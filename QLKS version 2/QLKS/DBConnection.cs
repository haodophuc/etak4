using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS
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

        public DataTable ExecuteSelectQuery(string query, SqlParameter[] sqlParameters)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            try
            {
                command = new SqlCommand();
                command.CommandText = query;
                command.Connection = connection;
                command.Parameters.AddRange(sqlParameters);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                dataAdapter.Dispose();
            }
            return dataTable;
        }

        public DataTable ExecuteSelectQuerySP(string query, SqlParameter[] sqlParameters)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            try
            {
                command = new SqlCommand();
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddRange(sqlParameters);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                dataAdapter.Dispose();
            }
            return dataTable;
        }

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

        public Int64 ExecuteScalarByProcedure(string storeprocedure, SqlParameter[] sqlParameters)
        {
            Int64 result = 0;
            try
            {
                Connect();
                command = new SqlCommand(storeprocedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(sqlParameters);
                result = Int64.Parse(command.ExecuteScalar().ToString());
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                command.Dispose();
                Disconnect();
            }
            return result;
        }

        //public Int32 ExecuteSPReturnsID() { }

        public bool databaseContainsUser(String username, String password)
        {
            SqlCommand cmd = new SqlCommand("", Program.DBConnection.Connection);

            // add username and password as parameters
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@USERNAME", username);
            parameters[1] = new SqlParameter("@PASSWORD", password);
            cmd.Parameters.AddRange(parameters);
            
            try
            {
                Connect();                
                cmd.CommandText = "SELECT COUNT(1) FROM ADMINS" +
                                        " WHERE TEN_DANG_NHAP = @USERNAME AND MAT_KHAU = @PASSWORD";
                if ( (int)cmd.ExecuteScalar() > 0 )
                    return true;

                cmd.CommandText = "SELECT COUNT(1) FROM THU_NGAN" +
                                        " WHERE TEN_DANG_NHAP = @USERNAME AND MAT_KHAU = @PASSWORD";
                if ( (int)cmd.ExecuteScalar() > 0 )
                    return true;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                Disconnect();             
            }

            return false;
        }

        public bool userHasRole(String roleName, String username)
        {
            SqlCommand cmd = new SqlCommand("", Program.DBConnection.Connection);

            // add role as parameters
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@ROLENAME", roleName);
            parameters[1] = new SqlParameter("@USERNAME", username);
            cmd.Parameters.AddRange(parameters);            

            try
            {
                Connect();
                cmd.CommandText = "SELECT COUNT(1)" +
                        " FROM (QUYEN_ADMIN A INNER JOIN QUYEN B ON A.MA_QUYEN = B.MA_QUYEN)" +
                        " INNER JOIN ADMINS C ON A.MA_ADMIN = C.MA_ADMIN" + 
                        " WHERE TEN_QUYEN = @ROLENAME AND C.TEN_DANG_NHAP = @USERNAME";
                if ((int)cmd.ExecuteScalar() > 0)
                    return true;

                cmd.CommandText = "SELECT COUNT(1)" +
                    " FROM (QUYEN_THU_NGAN A INNER JOIN QUYEN B ON A.MA_QUYEN = B.MA_QUYEN)" +
                    " INNER JOIN THU_NGAN C ON A.MA_THU_NGAN = C.MA_THU_NGAN" +
                    " WHERE TEN_QUYEN = @ROLENAME AND C.TEN_DANG_NHAP = @USERNAME";
                if ((int)cmd.ExecuteScalar() > 0)
                    return true;
            }
            catch (SqlException e)
            {                
                throw e;
            }
            finally
            {
                Disconnect();
            }

            return false;
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
}//end namespace QLKS
