using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;


namespace QLKS.BUS
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
       #endregion
    }
}
