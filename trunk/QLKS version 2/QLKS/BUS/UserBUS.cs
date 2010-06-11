using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using QLKS.VO;

namespace QLKS.BUS
{
    class UserBUS
    {
        #region Data Members
        private UserDAO userDAO;
        #endregion

        #region Constructors
        public UserBUS()
        {
            userDAO = new UserDAO();
        }
        #endregion

        #region Methods
        public UserVO getVO()
        {
            UserVO userVO = new UserVO();

            userVO.UserDataTable = userDAO.DataSet.Tables["USERS"];
            userVO.UserRoleDataTable = userDAO.DataSet.Tables["USER2ROLE"];
            userVO.RoleDataTable = userDAO.DataSet.Tables["ROLES"];
            userVO.DataSet = userDAO.DataSet;

            return userVO;
        }

        public void setInitialPassword(String initialPass)
        {
            userDAO.setInitialPassword(initialPass);
        }

        public bool didThisUserExist(String userName)
        {
            return userDAO.didThisUserExist(userName);
        }
        #endregion

        #region Update DataSet Methods
        public void updateUsers()
        {
            userDAO.updateUsers();
        }

        public void updateUserRoles()
        {
            userDAO.updateUserRoles();
        }
        #endregion
    }
}
