using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLKS.DAO
{
    class UserDAO
    {
        #region Data Members
        private SqlDataAdapter userAdapter;
        private SqlDataAdapter userRoleAdapter;
        private SqlDataAdapter roleAdapter;
        #endregion

        #region Accessor Properties
        private DataSet dataSet;
        public DataSet DataSet
        {
            get { return dataSet; }
        }
        #endregion

        #region Constructors
        public UserDAO()
        {
            dataSet = new DataSet();
            initTablesAndRelations();
        }
        #endregion

        #region Methods
        private void initTablesAndRelations()
        {
            userAdapter = new SqlDataAdapter("SELECT USERID, USER_NAME, "
                + " LAST_NAME, FIRST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS"
                + " FROM USERS"
                + " WHERE DELETED = 0", Program.DBConnection.Connection);
            userAdapter.Fill(dataSet, "USERS");

            userRoleAdapter = new SqlDataAdapter("SELECT USERID, ROLEID FROM USER2ROLE", Program.DBConnection.Connection);
            userRoleAdapter.Fill(dataSet, "USER2ROLE");

            DataColumn user_userid = dataSet.Tables["USERS"].Columns["USERID"];
            DataColumn userRole_userid = dataSet.Tables["USER2ROLE"].Columns["USERID"];
            dataSet.Relations.Add("USERS__USER2ROLE", user_userid, userRole_userid);

            roleAdapter = new SqlDataAdapter("SELECT ROLEID, ROLE_NAME, DETAILS FROM ROLES ORDER BY ROLE_NAME", Program.DBConnection.Connection);
            roleAdapter.Fill(dataSet, "ROLES");

            ///// prepare insert command for userAdapter
            prepareInsertCommand();

            ///// prepare delete command for userAdapter
            prepareDeleteCommand();
        }

        private void prepareDeleteCommand()
        {
            SqlCommand cmd2 = new SqlCommand("SP_DELETE_USER", Program.DBConnection.Connection);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("@USERID", SqlDbType.NVarChar, 255, "USERID");
            userAdapter.DeleteCommand = cmd2;
        }

        private void prepareInsertCommand()
        {
            SqlCommand cmd = new SqlCommand("SP_INSERT_USER", Program.DBConnection.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = cmd.Parameters.Add("@IDENTITY", SqlDbType.Int, Int32.MaxValue, "USERID");
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@USER_NAME", SqlDbType.NVarChar, 50, "USER_NAME");

            // encrypt initial password here
            cmd.Parameters.AddWithValue("@USER_PASSWORD", MyUtilities.encrypt(Properties.Settings.Default.InitialPassword));

            cmd.Parameters.Add("@FIRST_NAME", SqlDbType.NVarChar, 50, "FIRST_NAME");
            cmd.Parameters.Add("@LAST_NAME", SqlDbType.NVarChar, 50, "LAST_NAME");
            cmd.Parameters.Add("@IS_ADMIN", SqlDbType.Bit, Int32.MaxValue, "IS_ADMIN");
            cmd.Parameters.Add("@ADDRESS_STREET", SqlDbType.NVarChar, 50, "ADDRESS_STREET");
            cmd.Parameters.Add("@PHONE", SqlDbType.NVarChar, 50, "PHONE");
            cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 50, "EMAIL");
            cmd.Parameters.Add("@DETAILS", SqlDbType.NVarChar, 255, "DETAILS");
            userAdapter.InsertCommand = cmd;
        }

        public void setInitialPassword(String initialPass)
        {
            userAdapter.InsertCommand.Parameters["@USER_PASSWORD"].Value = MyUtilities.encrypt(initialPass);
        }

        public bool didThisUserExist(String userName)
        {
            SqlCommand cmd = new SqlCommand
                ("SELECT dbo.FN_DID_THIS_USER_EXIST(@USER_NAME)", Program.DBConnection.Connection);
            cmd.Parameters.AddWithValue("@USER_NAME", userName);

            try
            {
                Program.DBConnection.Connect();
                if ((bool)cmd.ExecuteScalar())
                    return true;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                Program.DBConnection.Disconnect();
            }

            return false;
        }
        #endregion

        #region Update DataSet
        public void updateUsers()
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(userAdapter);
            cb.ConflictOption = ConflictOption.OverwriteChanges;
            userAdapter.ContinueUpdateOnError = true;
            userAdapter.Update(dataSet, "USERS");
        }

        public void updateUserRoles()
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(userRoleAdapter);
            cb.ConflictOption = ConflictOption.OverwriteChanges;
            userRoleAdapter.ContinueUpdateOnError = true;
            userRoleAdapter.Update(dataSet, "USER2ROLE");
        }
        #endregion
    }
}
