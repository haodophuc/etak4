using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLKS.DAO
{
    class TellerDAO
    {
         #region data members
        private SqlDataAdapter tellerAdapter;
        private SqlDataAdapter tellerRoleAdapter;
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
        public TellerDAO()
        {
            dataSet = new DataSet();
            initTablesAndRelations();
        }
        #endregion

        #region methods
        private void initTablesAndRelations()
        {
            tellerAdapter = new SqlDataAdapter("SELECT MA_THU_NGAN, TEN_DANG_NHAP, MAT_KHAU, HO_TEN, DIA_CHI, DIEN_THOAI", Program.DBConnection.Connection);
            tellerAdapter.Fill(dataSet, "THU_NGAN");

            tellerRoleAdapter = new SqlDataAdapter("SELECT MA_THU_NGAN, MA_QUYEN FROM QUYEN_THU_NGAN", Program.DBConnection.Connection);
            tellerRoleAdapter.Fill(dataSet, "QUYEN_THU_NGAN");

            roleAdapter = new SqlDataAdapter("SELECT MA_QUYEN, TEN_QUYEN, QUYEN_LUC, GHI_CHU FROM QUYEN", Program.DBConnection.Connection);
            roleAdapter.Fill(dataSet, "QUYEN");
        }

        public void updateTellers()
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(tellerAdapter);
            cb.ConflictOption = ConflictOption.OverwriteChanges;
            tellerAdapter.ContinueUpdateOnError = true;
            tellerAdapter.Update(dataSet, "THU_NGAN");
        }

        public void updateTellerRoles()
        {            
            SqlCommandBuilder cb = new SqlCommandBuilder(tellerRoleAdapter);            
            cb.ConflictOption = ConflictOption.OverwriteChanges;
            tellerRoleAdapter.ContinueUpdateOnError = true;
            tellerRoleAdapter.Update(dataSet, "QUYEN_THU_NGAN");
        }
        
        #endregion
    }
}
