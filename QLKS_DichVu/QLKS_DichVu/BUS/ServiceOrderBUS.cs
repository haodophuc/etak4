using System;
using System.Collections.Generic;
using System.Text;
using QLKS_DichVu.DAO;
using System.Data;

namespace QLKS_DichVu.BUS
{
    public class ServiceOrderBUS
    {
        private ServiceOrderDAO serviceOrderDAO;
        public ServiceOrderBUS(DBConnection dbConnection)
        {
            serviceOrderDAO = new ServiceOrderDAO(dbConnection);
        }

        public DataTable getServiceOrderByRoomID(String roomID)
        {
            return serviceOrderDAO.getServiceOrderByRoomID(roomID);
        }
    }
}
