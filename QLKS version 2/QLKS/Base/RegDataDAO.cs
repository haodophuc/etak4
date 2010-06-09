using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace QLKS.Base
{
    public class RegDataDAO
    {
        #region Constructors

        public RegDataDAO(String selectCommand)
        {
            // Get the connection to the database
            Connection = Program.DBConnection;
            // Contruct the DataAdapter
            Adapter = new SqlDataAdapter(selectCommand, Connection.Connection);
        }//end default constructor

        public RegDataDAO(RegData regdata)
        {

        }//end constructor
        #endregion //end region Constructors


        #region Methods

        public void Initialize(RegData dataset)
        {
            DataSource = dataset;
            Adapter.TableMappings.Add(dataset.Customers.GetTableMapping());
            Adapter.TableMappings.Add(dataset.Companies.GetTableMapping());
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(Adapter);
            //Adapter.Fill(dataset.CheckInData, dataset.Customers.SourceTableName);
        }//end method Initialize

        public void UpdateCustomers()
        {

            try
            {
                Program.DBConnection.Connect();

                int numOfRows = DataSource.Customers.Rows.Count;

                for (int i = 0; i < numOfRows; i++)
                {
                    if (DataSource.Customers.Rows[i]["IsNew"].ToString().Equals(Boolean.TrueString))
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_CUSTOMER", Program.DBConnection.Connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter param = cmd.Parameters.AddWithValue("@IDENTITY", DataSource.Customers.Rows[i]["CustomerID"]);

                        param.Direction = ParameterDirection.Output;

                        cmd.Parameters.AddWithValue("@MA_QUOC_GIA", DataSource.Customers.Rows[i]["CountryID"]);
                        cmd.Parameters.AddWithValue("@HO_KHACH_HANG", DataSource.Customers.Rows[i]["LastName"]);
                        cmd.Parameters.AddWithValue("@TEN_KHACH_HANG", DataSource.Customers.Rows[i]["FirstName"]);
                        cmd.Parameters.AddWithValue("@CMND", DataSource.Customers.Rows[i]["SocialID"]);
                        cmd.Parameters.AddWithValue("@HO_CHIEU", DataSource.Customers.Rows[i]["PassPort"]);
                        cmd.Parameters.AddWithValue("@DIEN_THOAI", DataSource.Customers.Rows[i]["Phone"]);
                        cmd.ExecuteNonQuery();
                        DataSource.Customers.Rows[i]["CustomerID"] = cmd.Parameters["@IDENTITY"].Value;

                        DataSource.Customers.Rows[i]["IsNew"] = false;
                    }//end if
                }//end for
            }//end try
            catch
            {
                throw;

            }//end catch
            finally
            {
                Program.DBConnection.Disconnect();
            }//end finally
        }//end method Update(DataSet)

        #endregion //end region Methods


        #region Attributes

        public DBConnection Connection
        {
            get { return connection; }
            set { this.connection = value; }
        }//end attribute Connection

        public SqlDataAdapter Adapter
        {
            get { return this.adapter; }
            set { this.adapter = value; }
        }//end attribute Adapter

        public RegData DataSource
        {
            get { return this.dataSource; }
            set { this.dataSource = value; }
        }//end attribute CheckInData

        #endregion //end region Attributes


        #region Instance Fields
        private RegData dataSource;
        private SqlDataAdapter adapter;
        private DBConnection connection;
        #endregion Instance Fields

    }//end class RegDataDAO

}//end namespace
