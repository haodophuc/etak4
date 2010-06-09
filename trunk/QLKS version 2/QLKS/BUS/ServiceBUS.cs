using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS.DAO;
using QLKS.VO;
using QLKS;

namespace QLKS.BUS
{
    class ServiceBUS
    {
       #region Constructors

        public ServiceBUS()
        {
            this.serviceDAO = new ServiceDAO();
        }// end constructor

       #endregion //end region Constructors
        

       #region Methods

        public DataTable GetAllServices()
        {
            try {
                return serviceDAO.GetAllServices();
            } catch( SqlException e ) {
                throw e;
            }// end catch
        }// end method GetAllServices

        public int DeleteService(ServiceVO service)
        {
            try {
                return serviceDAO.DeleteService(service);
            }// end try
            catch (SqlException e) {
                throw e;
            }// end catch
        }// end method DeleteServiceByID

        public int InsertService( ServiceVO service )
        {
            try
            {
                return this.serviceDAO.InsertService(service);
            }// end try
            catch (SqlException e)
            {
                throw e;
            }// end catch
        }// end method InsertService

        public int UpdateService(ServiceVO service)
        {
            return serviceDAO.UpdateService(service);
        }//end method UpdateService

       #endregion // end region Methods


       #region Attributes

       #endregion // end region Attributes


       #region Instance Fields
        private ServiceDAO serviceDAO;
       #endregion // end region Instance Fields


    }// end class ServiceBUS
}//end namespace QLKS.BUS
