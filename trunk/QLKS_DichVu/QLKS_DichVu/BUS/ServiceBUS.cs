using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKS_DichVu.DAO;
using QLKS_DichVu.VO;
using QLKS_DichVu;

namespace QLKS_DichVu.BUS
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

        public int DeleteServiceByID(String serviceID)
        {
            try {
                return serviceDAO.DeleteServiceByID(serviceID);
            }// end try
            catch (SqlException e) {
                throw e;
            }// end catch
        }// end method DeleteServiceByID

        public int InsertService( ServiceVO service )
        {
            try
            {
                return this.serviceDAO.InsertService(service.Name, service.Price);
            }// end try
            catch (SqlException e)
            {
                throw e;
            }// end catch
        }// end method InsertService

        public int UpdateService(ServiceVO service)
        {
            return serviceDAO.UpdateService(service.ID, service.Name, service.Price, service.State);
        }//end method UpdateService

       #endregion // end region Methods


       #region Attributes

       #endregion // end region Attributes


       #region Instance Fields
        private ServiceDAO serviceDAO;
       #endregion // end region Instance Fields


    }// end class ServiceBUS
}//end namespace QLKS_DichVu.BUS
