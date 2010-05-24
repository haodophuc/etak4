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
        #endregion

        #region methods
        public DBConnection()
        {
            dataAdapter = new SqlDataAdapter();
        }

        public void Connect()
        {
            Exception exception;
            if (connection == null)
            {
                exception = new Exception("Connection haven't initialized");
                throw exception;
            }
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

        public int ExecuteInsertQuery(String query, SqlParameter[] sqlParameters)
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

        public int ExecuteUpdateQuery(string query, SqlParameter[] sqlParameters)
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

        public int ExecuteDeleteQuery(string query, SqlParameter[] sqlParameters)
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

        public int ExecuteScalar(string query, SqlParameter[] sqlParameters)
        {
            int result = 0;
            try
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddRange(sqlParameters);
                dataAdapter.SelectCommand = command;
                result = Int32.Parse(command.ExecuteScalar().ToString());
                /*
                rows = Int32.Parse(command.ExecuteScalar().ToString());
                dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddRange(sqlParameters);
                rows = Int32.Parse(dataAdapter.SelectCommand.ExecuteScalar().ToString());
               */
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                command.Dispose();
            }
            return result;
        }
        #endregion
    }
}
