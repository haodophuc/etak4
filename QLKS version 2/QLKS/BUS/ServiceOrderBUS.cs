using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QLKS.DAO;
using QLKS.VO;

namespace QLKS.BUS
{
    public class ServiceOrderBUS
    {
        private ServiceOrderDAO serviceOrderDAO;
        public ServiceOrderBUS()
        {
            serviceOrderDAO = new ServiceOrderDAO();
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

        public void update()
        {
            serviceOrderDAO.update();
        }
    }
}
