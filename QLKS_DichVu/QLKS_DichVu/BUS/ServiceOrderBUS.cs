using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QLKS_DichVu.DAO;
using QLKS_DichVu.VO;

namespace QLKS_DichVu.BUS
{
    public class ServiceOrderBUS
    {
        private ServiceOrderDAO serviceOrderDAO;
        public ServiceOrderBUS(DBConnection dbConnection)
        {
            serviceOrderDAO = new ServiceOrderDAO(dbConnection);
        }

        public ServiceOrderVO getVO()
        {            
            ServiceOrderVO serviceOrderVO = new ServiceOrderVO();

            serviceOrderVO.PhieuThuePhongDataTable =
                serviceOrderDAO.DataSet.Tables["PHIEU_THUE_PHONG"];

            serviceOrderVO.PhieuDangKyDichVuDataTable =
                serviceOrderDAO.DataSet.Tables["PHIEU_DANG_KY_DICH_VU"];

            serviceOrderVO.DichVuDataTable = 
                serviceOrderDAO.DataSet.Tables["DICH_VU"];

            serviceOrderVO.DataSet = serviceOrderDAO.DataSet;

            return serviceOrderVO;
        }

        public int getLastIdentity()
        {
            return serviceOrderDAO.getLastIdentity();
        }

        public void update()
        {
            serviceOrderDAO.update();
        }
    }
}
