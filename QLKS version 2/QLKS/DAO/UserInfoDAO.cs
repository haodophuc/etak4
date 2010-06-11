using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLKS.DAO
{
    public class UserInfoDAO
    {
        public bool databaseContainsUser(String username, String password)
        {
            SqlCommand cmd = new SqlCommand
                ("SELECT dbo.FN_DATABASE_CONTAINS_USER(@USER_NAME, @USER_PASSWORD)",
                Program.DBConnection.Connection);
            cmd.Parameters.AddWithValue("@USER_NAME", username);
            cmd.Parameters.AddWithValue("@USER_PASSWORD", MyUtilities.encrypt(password));

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

        public bool userHasRole(String username, String roleName)
        {
            SqlCommand cmd = new SqlCommand
                ("SELECT dbo.FN_USER_HAS_ROLE(@ROLE_NAME, @USER_NAME)",
                Program.DBConnection.Connection);
            cmd.Parameters.AddWithValue("@ROLE_NAME", roleName);
            cmd.Parameters.AddWithValue("@USER_NAME", username);

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

        public bool isAdmin(String userName)
        {
            SqlCommand cmd = new SqlCommand
                ("SELECT dbo.FN_IS_ADMIN(@USER_NAME)",
                Program.DBConnection.Connection);
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

            return false; ;
        }

        public void changePassword(String userName, String oldPassword, String newPassword)
        {
            SqlCommand cmd = new SqlCommand("SP_CHANGE_PASSWORD", Program.DBConnection.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USER_NAME", userName);
            cmd.Parameters.AddWithValue("@OLD_PASSWORD", MyUtilities.encrypt(oldPassword));
            cmd.Parameters.AddWithValue("@NEW_PASSWORD", MyUtilities.encrypt(newPassword));

            try
            {
                Program.DBConnection.Connect();
                int r = cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                Program.DBConnection.Disconnect();
            }
        }
    }
}
