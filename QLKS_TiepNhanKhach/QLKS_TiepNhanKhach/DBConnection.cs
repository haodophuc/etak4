using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_TiepNhanKhach
{
    public class DBConnection
    {
        #region properties

      

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
        #endregion

        #region methods
        public DBConnection()
        {
            connection = new SqlConnection();
        }

        public void Connect()
        {
            Exception exception;
            if (connection == null)
            {
                exception = new Exception("Connection haven't initialized");
                throw exception;
            }
            else if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                exception = new Exception("Connection has already connected");
                throw exception;
            }
        }

        public void Disconnect()
        {
            Exception exception;
            if (connection == null)
            {
                exception = new Exception("Connection haven't initialized");
                throw exception;
            }
            else if (connection.State == ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                exception = new Exception("Connection has disconnected");
                throw exception;
            }
        }

        public DataTable ExecuteSelectQuery(string query)
        {
            DataTable dataTable = null;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            try
            {
               
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];    
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

        public int ExecuteNonQuery(String query, SqlParameter[] sqlParameters)
        {
            int rows = 0;
            try
            {
                Connect();
                command = new SqlCommand(query,connection);
                command.Parameters.AddRange(sqlParameters);
                rows = command.ExecuteNonQuery();
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
            return rows;
        }

        public int ExecuteScalar(string query, SqlParameter[] sqlParameters)
        {
            int result = 0;
            try
            {
                Connect();
                command = new SqlCommand(query,connection);
                command.Parameters.AddRange(sqlParameters);
                result = Int32.Parse(command.ExecuteScalar().ToString());  
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

        public Int64 ExecuteScalarByProcedue(string storeprocedure, SqlParameter[] sqlParameters)
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
        #endregion
    }
}
