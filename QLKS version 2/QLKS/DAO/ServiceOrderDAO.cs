using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLKS.DAO
{
    public class ServiceOrderDAO
    {       
        #region data members
        private DBConnection dbConnection;    
        private SqlDataAdapter phieuThuePhongAdapter;
        private SqlDataAdapter phieuDangKyDichVuAdapter;
        private SqlDataAdapter dichVuAdapter;
        //private SqlDataAdapter idAdapter;
        #endregion

        #region accessor properties
        private DataSet dataSet;
        public DataSet DataSet
        {
            get { return dataSet; }
        }
        #endregion

        #region constructors
        public ServiceOrderDAO(DBConnection dbConnection)
        {
            this.dbConnection = dbConnection;
            dataSet = new DataSet();

            initTablesAndRelations();
        }
        #endregion

        #region methods
        private void initTablesAndRelations()
        {
            phieuThuePhongAdapter = new SqlDataAdapter("SELECT MA_PHIEU, SO_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG FROM PHIEU_THUE_PHONG A INNER JOIN PHONG B ON A.MA_PHONG = B.MA_PHONG WHERE DA_TRA_PHONG = 0", dbConnection.Connection);
            phieuThuePhongAdapter.Fill(dataSet, "PHIEU_THUE_PHONG");

            phieuDangKyDichVuAdapter = new SqlDataAdapter("SELECT SO_PHIEU, MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU FROM PHIEU_DANG_KY_DICH_VU", dbConnection.Connection);
            phieuDangKyDichVuAdapter.Fill(dataSet, "PHIEU_DANG_KY_DICH_VU");

            dichVuAdapter = new SqlDataAdapter("SELECT MA_DICH_VU, TEN_DICH_VU, DON_GIA, HIEU_LUC FROM DICH_VU ORDER BY TEN_DICH_VU", dbConnection.Connection);
            dichVuAdapter.Fill(dataSet, "DICH_VU");

            DataColumn phieuThuePhong_maPhieu = dataSet.Tables["PHIEU_THUE_PHONG"].Columns["MA_PHIEU"];
            DataColumn phieuDangKyDichVu_maPhieu = dataSet.Tables["PHIEU_DANG_KY_DICH_VU"].Columns["MA_PHIEU"];
            dataSet.Relations.Add("PHIEU_THUE_PHONG__PHIEU_DANG_KY_DICH_VU", phieuThuePhong_maPhieu, phieuDangKyDichVu_maPhieu, false);

            DataColumn dichVu_maDichVu = dataSet.Tables["DICH_VU"].Columns["MA_DICH_VU"];
            DataColumn phieuDangKyDichVu_maDichVu = dataSet.Tables["PHIEU_DANG_KY_DICH_VU"].Columns["MA_DICH_VU"];
            dataSet.Relations.Add("DICH_VU__PHIEU_DANG_KY_DICH_VU", dichVu_maDichVu, phieuDangKyDichVu_maDichVu, false);

            // prepare insert command for phieuDangKyDichVu adapter
            SqlCommand cmd = new SqlCommand("SP_INSERT_SERVICE_ORDER_BILL", Program.DBConnection.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = cmd.Parameters.Add("@IDENTITY", SqlDbType.Int, Int32.MaxValue, "SO_PHIEU");
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@MA_PHIEU", SqlDbType.Int, Int32.MaxValue, "MA_PHIEU");
            cmd.Parameters.Add("@MA_DICH_VU", SqlDbType.Int, Int32.MaxValue, "MA_DICH_VU");
            cmd.Parameters.Add("@NGAY_PHUC_VU", SqlDbType.DateTime,Int32.MaxValue, "NGAY_PHUC_VU");
            cmd.Parameters.Add("@SO_LUONG", SqlDbType.Int, Int32.MaxValue, "SO_LUONG");
            cmd.Parameters.Add("@GHI_CHU", SqlDbType.NVarChar, Int32.MaxValue, "GHI_CHU");
            phieuDangKyDichVuAdapter.InsertCommand = cmd;
        }

        public int getLastIdentity()
        {
            int last_id = (int)dbConnection.ExecuteScalar("SELECT last_value FROM sys.identity_columns WHERE object_id = object_id('PHIEU_DANG_KY_DICH_VU')");
            return last_id;
        }

        public void update()
        {            
            SqlCommandBuilder cb = new SqlCommandBuilder(phieuDangKyDichVuAdapter);            
            cb.ConflictOption = ConflictOption.OverwriteChanges;
            phieuDangKyDichVuAdapter.ContinueUpdateOnError = true;
            phieuDangKyDichVuAdapter.Update(dataSet, "PHIEU_DANG_KY_DICH_VU");            
        }
        #endregion
    }
}
