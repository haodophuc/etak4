using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLKS.DAO
{
    class AdminDAO
    {
         #region data members
        private SqlDataAdapter adminAdapter;
        private SqlDataAdapter adminRoleAdapter;
        private SqlDataAdapter roleAdapter;
        #endregion

        #region accessor properties
        private DataSet dataSet;
        public DataSet DataSet
        {
            get { return dataSet; }
        }
        #endregion

        #region constructors
        public AdminDAO()
        {
            dataSet = new DataSet();
            initTablesAndRelations();
        }
        #endregion

        #region methods
        private void initTablesAndRelations()
        {
            adminAdapter = new SqlDataAdapter("SELECT MA_ADMIN, TEN_DANG_NHAP, MAT_KHAU, TEN_ADMIN, DIA_CHI, DIEN_THOAI", Program.DBConnection.Connection);
            adminAdapter.Fill(dataSet, "ADMINS");

            adminRoleAdapter = new SqlDataAdapter("SELECT MA_ADMIN, MA_QUYEN FROM QUYEN_ADMIN", Program.DBConnection.Connection);
            adminRoleAdapter.Fill(dataSet, "QUYEN_ADMIN");

            DataColumn admin_maAdmin = dataSet.Tables["ADMINS"].Columns["MA_ADMIN"];
            DataColumn quyenAdmin_maAdmin = dataSet.Tables["QUYEN_ADMIN"].Columns["MA_ADMIN"];
            dataSet.Relations.Add("ADMINS__QUYEN_ADMIN", admin_maAdmin, quyenAdmin_maAdmin);

            roleAdapter = new SqlDataAdapter("SELECT MA_QUYEN, TEN_QUYEN, QUYEN_LUC, GHI_CHU FROM QUYEN", Program.DBConnection.Connection);
            roleAdapter.Fill(dataSet, "QUYEN");
        }

        public void updateAdmins()
        {            
            SqlCommandBuilder cb = new SqlCommandBuilder(adminAdapter);            
            cb.ConflictOption = ConflictOption.OverwriteChanges;
            adminAdapter.ContinueUpdateOnError = true;
            adminAdapter.Update(dataSet, "ADMINS");
        }

        public void updateAdminRoles()
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(adminRoleAdapter);
            cb.ConflictOption = ConflictOption.OverwriteChanges;
            adminRoleAdapter.ContinueUpdateOnError = true;
            adminRoleAdapter.Update(dataSet, "QUYEN_ADMIN");
        }

        #endregion
    }
}
