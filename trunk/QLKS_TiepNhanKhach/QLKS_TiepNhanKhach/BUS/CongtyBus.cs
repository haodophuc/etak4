using System;
using System.Collections.Generic;
using System.Text;
using QLKS_TiepNhanKhach.DAO;
using System.Data;
using System.Data.SqlClient;
using QLKS_TiepNhanKhach.VO;


namespace QLKS_TiepNhanKhach.BUS
{
   
    class CongtyBus
    {
       #region Properties
       private CongtyDAO congtyDAO;
    #endregion

       #region methods
       public CongtyBus()
        {
            congtyDAO = new CongtyDAO();    
        }
        public DataTable GetAll()
        {
            try
            {
                return congtyDAO.SelectAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Insert(CongtyVO congtyVO)
        {
            try
            {
                return congtyDAO.Insert(congtyVO);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(CongtyVO congtyVO)
        {
            try
            {
                return congtyDAO.Update(congtyVO);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Delete(int maCongty)
        {
            try
            {
                return congtyDAO.Delete(maCongty);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int GetNewIndentity()
        {
            try
            {
                return congtyDAO.GetLastIdentity() + 1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DataTable GetCongTyByIndicator(CongtyVO congtyVO, bool bMaCT, bool bMaQG, bool bMNDD, bool bTenCT, bool bDiaChi,bool bDienThoai, bool bEmail, bool bFax,bool bSoTaiKhoan,bool bMaSoThue)
        {
            return congtyDAO.SearchByIndicator(congtyVO, bMaCT, bMaQG, bMNDD, bTenCT, bDiaChi, bDienThoai, bEmail, bFax, bSoTaiKhoan, bMaSoThue);
        }

        
       #endregion
    }
}
