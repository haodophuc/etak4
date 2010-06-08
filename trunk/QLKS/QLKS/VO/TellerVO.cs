using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace QLKS.VO
{
    class TellerVO
    {
        private DataTable tellerDataTable;
        public DataTable TellerDataTable
        {
            get { return tellerDataTable; }
            set { tellerDataTable = value; }
        }

        private DataTable tellerRoleDataTable;
        public DataTable TellerRoleDataTable
        {
            get { return tellerRoleDataTable; }
            set { tellerRoleDataTable = value; }
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
