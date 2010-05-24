using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_DichVu
{
    public class DBConnection
    {
        #region properties

        private SqlDataAdapter dataAdapter;

        private SqlConnection connection;

        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        private SqlCommand command;

        public SqlCommand Command
        {
            get { return command; }
            set { command = value; }
        }
	

        
        private string errorMessage;

        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; }
        }

        #endregion

        #region methods
        public DBConnection()
        {
            dataAdapter = new SqlDataAdapter();
        }

        public DBConnection(SqlConnection connection) : this()
        {
            this.connection = connection;
        }
        
        public void connect()
        {
            if (connection == null)
            {
                 throw new Exception("Connection haven't initialized");                
            }// end if
            else if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
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
        }

        public bool disconnect()
        {
            if (connection == null)
            {
                errorMessage = "Connection haven't initialized";
                return false;
            }
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            errorMessage = "Cannot disconnect with connection";
            return false;
        }

        public DataTable executeSelectQuery(string query)
        {
            DataTable dataTable = null;
            try
            {
                command = new SqlCommand(query,connection);
                DataSet dataSet = new DataSet();
                dataAdapter.SelectCommand = command;                
                dataAdapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];    
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                command.Dispose();
            }
            return dataTable;
        }

        public int executeInsertQuery(String query, SqlParameter[] sqlParameters)
        {
            int rows = 0;
            try
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddRange(sqlParameters);
                dataAdapter.InsertCommand = command;
                rows = command.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                command.Dispose();
            }
            return rows;
        }

        public int executeUpdateQuery(string query, SqlParameter[] sqlParameters)
        {
            int rows = 0;
            try
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddRange(sqlParameters);
                dataAdapter.UpdateCommand = command;
                rows = command.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                command.Dispose();
            }
            return rows;
        }

        public int executeDeleteQuery(string query, SqlParameter[] sqlParameters)
        {
            int rows = 0;
            try
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddRange(sqlParameters);
                dataAdapter.DeleteCommand = command;
                rows = command.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                command.Dispose();
            }
            return rows;
        }

    
        #endregion
    }
}
