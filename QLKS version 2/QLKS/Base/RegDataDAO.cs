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

        public RegDataDAO()
        {
            // Get the connection to the database
            Connection = Program.DBConnection;

        }//end default constructor

        public RegDataDAO(String selectCommand) : this()
        {
                       
            // Contruct the DataAdapter
            Adapter = new SqlDataAdapter(selectCommand, Connection.Connection);

        }//end constructor with a select command

        public RegDataDAO(RegData regdata) : this()
        {
            Initialize(regdata);
        }//end constructor with a register data package

        #endregion //end region Constructors


        #region Methods

        private void Initialize(RegData dataset)
        {
            RegData = dataset;

            //Adapter.TableMappings.Add(RegData.Customers.GetTableMapping());
            //Adapter.TableMappings.Add(RegData.Companies.GetTableMapping());
            //SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(Adapter);
            //Adapter.Fill(RegData.CheckInData, RegData.Customers.SourceTableName);

        }//end method Initialize

        public void UpdateCustomers()
        {

            try
            {
                // Open connection
                Connection.Connect();


                int numOfRows = RegData.Customers.Rows.Count;

                for (int i = 0; i < numOfRows; i++)
                {
                    if (RegData.Customers.Rows[i]["IsNew"].ToString().Equals(Boolean.TrueString))
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_CUSTOMER", Program.DBConnection.Connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter param = cmd.Parameters.AddWithValue("@IDENTITY", RegData.Customers.Rows[i]["CustomerID"]);

                        param.Direction = ParameterDirection.Output;

                        cmd.Parameters.AddWithValue("@MA_QUOC_GIA", RegData.Customers.Rows[i]["CountryID"]);
                        cmd.Parameters.AddWithValue("@HO_KHACH_HANG", RegData.Customers.Rows[i]["LastName"]);
                        cmd.Parameters.AddWithValue("@TEN_KHACH_HANG", RegData.Customers.Rows[i]["FirstName"]);
                        cmd.Parameters.AddWithValue("@CMND", RegData.Customers.Rows[i]["SocialID"]);
                        cmd.Parameters.AddWithValue("@HO_CHIEU", RegData.Customers.Rows[i]["PassPort"]);
                        cmd.Parameters.AddWithValue("@DIEN_THOAI", RegData.Customers.Rows[i]["Phone"]);
                        cmd.ExecuteNonQuery();
                        RegData.Customers.Rows[i]["CustomerID"] = cmd.Parameters["@IDENTITY"].Value;

                        RegData.Customers.Rows[i]["IsNew"] = false;
                    }//end if
                }//end for
            }//end try
            catch
            {
                throw;

            }//end catch
            finally
            {
                Connection.Disconnect();
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

        public RegData RegData
        {
            get { return this.regData; }
            set { this.regData = value; }
        }//end attribute CheckInData

        #endregion //end region Attributes


        #region Instance Fields
        private RegData regData;
        private SqlDataAdapter adapter;
        private DBConnection connection;
        #endregion Instance Fields

    }//end class RegDataDAO

}//end namespace
