using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS_TiepNhanKhach.VO;

namespace QLKS_TiepNhanKhach.DAO
{
    class PhongDAO
    {
       

        public PhongDAO()
        {
           
        }

        public DataTable SelectAll()
        {
            try
            {
                string query = "Select SO_PHONG,MA_LOAI_PHONG,MA_TINH_TRANG From Phong";
                return Program.dbConnection.ExecuteSelectQuery(query);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public int Insert(PhongVO phongVO)
        {
            try
            {
                String query = "INSERT INTO PHONG VALUES(@MA_LOAIPHONG,@MA_TINH_TRANG, '')";
                SqlParameter[] sqlParameters = new SqlParameter[2];

                sqlParameters[0] = new SqlParameter("@MA_LOAIPHONG", phongVO.MaLoaiPhong);
                sqlParameters[1] = new SqlParameter("@MA_TINH_TRANG", phongVO.MaTinhTrang);
                
                return Program.dbConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public int Delete(string soPhong)
        {
            try
            {
                String query = "DELETE FROM PHONG WHERE SO_PHONG = @SO_PHONG";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@SO_PHONG", soPhong);
                return Program.dbConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
         
        public int Update(PhongVO phongVO)
        {
            try
            {
                String query = "UPDATE PHONG SET MA_LOAI_PHONG=@MA_LOAI_PHONG,MA_TINH_TRANG = @MA_TINH_TRANG WHERE SO_PHONG=@SO_PHONG";
                SqlParameter[] sqlParameters = new SqlParameter[3];

                sqlParameters[0] = new SqlParameter("@SO_PHONG", phongVO.SoPhong);
                sqlParameters[1] = new SqlParameter("@MA_LOAI_PHONG", phongVO.MaLoaiPhong);
                sqlParameters[2] = new SqlParameter("@MA_TINH_TRANG", phongVO.MaTinhTrang);
               

                return Program.dbConnection.ExecuteNonQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
       
        public int GetLastIdentity()
        {
            try
            {
                String query = "SELECT last_value FROM sys.identity_columns WHERE [object_id] = object_id(@table)";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@table", "PHONG");
                return Program.dbConnection.ExecuteScalar(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
