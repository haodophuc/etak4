using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace QLKS.VO
{
    class UserVO
    {
        private DataTable userDataTable;
        public DataTable UserDataTable
        {
            get { return userDataTable; }
            set { userDataTable = value; }
        }

        private DataTable userRoleDataTable;
        public DataTable UserRoleDataTable
        {
            get { return userRoleDataTable; }
            set { userRoleDataTable = value; }
        }

        private DataTable roleDataTable;
        public DataTable RoleDataTable
        {
            get { return roleDataTable; }
            set { roleDataTable = value; }
        }

        private DataSet dataSet;
        public DataSet DataSet
        {
            get { return dataSet; }
            set { dataSet = value; }
        }
	
    }
}
