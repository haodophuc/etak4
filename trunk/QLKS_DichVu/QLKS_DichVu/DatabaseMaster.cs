using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLKS_DichVu
{
    public class DatabaseMaster
    {
        private SqlConnection connection;
        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }
	
        public DatabaseMaster(SqlConnection connection)
        {
            this.connection = connection;
        }

        #region getDataAdapter overloads
        public SqlDataAdapter getDataAdapter(String query)
        {
            return new SqlDataAdapter(query, connection);
        }

        public SqlDataAdapter getDataAdapter(SqlCommand command)
        {
            return new SqlDataAdapter(command);
        }
        #endregion

        #region getDataSet overloads
        public DataSet getDataSet(SqlDataAdapter dataAdapter, String sourceTable)
        {
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, sourceTable);
            return ds;
        }

        public DataSet getDataSet(SqlDataReader dr, String tableName)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(new DataTable(tableName));
            ds.Load(dr, LoadOption.PreserveChanges, ds.Tables[tableName]);
            return ds;
        }
        #endregion

        public SqlCommand getCommand(String query)
        {
            return new SqlCommand(query, connection);
        }

        public SqlDataReader getDataReader(String query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void updateDataSet(SqlDataAdapter dataAdapter, DataSet dataSet, String sourceTable)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataSet, sourceTable);
        }
    }
}
