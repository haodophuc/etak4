using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace QLKS.VO
{
    class AdminVO
    {
        private DataTable adminDataTable;
        public DataTable AdminDataTable
        {
            get { return adminDataTable; }
            set { adminDataTable = value; }
        }

        private DataTable adminRoleDataTable;
        public DataTable AdminRoleDataTable
        {
            get { return adminRoleDataTable; }
            set { adminRoleDataTable = value; }
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
