using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;

namespace QLKS.BUS
{
    public class UserInfoBUS
    {
        private UserInfoDAO userInfoDAO;
        public UserInfoBUS()
        {
            userInfoDAO = new UserInfoDAO();
        }

        public bool databaseContainsUser(String username, String password)
        {
            return userInfoDAO.databaseContainsUser(username, password);
        }

        public bool userHasRole(String username, String roleName)
        {
            return userInfoDAO.userHasRole(username, roleName);
        }

        public bool isAdmin(String userName)
        {
            return userInfoDAO.isAdmin(userName);
        }

        public void changePassword(String userName, String oldPassword, String newPassword)
        {
            userInfoDAO.changePassword(userName, oldPassword, newPassword);
        }
    }
}
