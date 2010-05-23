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

        public bool connect()
        {
            if (connection == null)
            {
                errorMessage = "Connection haven't initialized";
                return false;
            }
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception e)
                {
                    errorMessage = e.Message;
                    return false;
                }
            }
            errorMessage = "Cannot connect with connection";
            return false;
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
                    errorMessage = e.Message;
                    return false;
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

                command.ExecuteNonQuery();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];

                
            }
            catch (SqlException e)
            {
                errorMessage = e.Message;
                return null;
            }
            finally
            {
                command.Dispose();
            }
            return dataTable;
        }

        public int executeInsertQuery(String _sqlText, SqlParameter[] sqlParameters)
        {
            SqlCommand myComnand = new SqlCommand();
            int num = 0;
            try
            {
                myComnand.Connection = connection;
                myComnand.CommandText = _sqlText;
                myComnand.Parameters.AddRange(sqlParameters);
                dataAdapter.InsertCommand = myComnand;
                num = myComnand.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                errorMessage = e.Message;
            }
            finally
            {
                command.Dispose();
            }
            return num;
        }

        public int executeUpdateQuery(string _sqlText, SqlParameter[] sqlParameters)
        {
            SqlCommand myComand = new SqlCommand();
            int num = 0;
            try
            {
                myComand.Connection = connection;
                myComand.CommandText = _sqlText;
                myComand.Parameters.AddRange(sqlParameters);
                dataAdapter.UpdateCommand = myComand;
                num = myComand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                errorMessage = e.Message;
            }
            finally
            {
                command.Dispose();
            }
            return num;
        }

        public int executeDeleteQuery(string _sqlText, SqlParameter[] sqlParameters)
        {
            SqlCommand myComand = new SqlCommand();
            int num = 0;
            try
            {
                myComand.Connection = connection;
                myComand.CommandText = _sqlText;
                myComand.Parameters.AddRange(sqlParameters);
                dataAdapter.DeleteCommand = myComand;
                num = myComand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                errorMessage = e.Message;
            }
            finally
            {
                command.Dispose();
            }
            return num;
        }

    
        #endregion
    }
}
