using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using QLKS.VO;


namespace QLKS.BUS
{
    class TellerBUS
    {
        private TellerDAO tellerDAO;
        public TellerBUS()
        {
            tellerDAO = new TellerDAO();
        }

        public TellerVO getVO()
        {
            TellerVO tellerVO = new TellerVO();

            tellerVO.TellerDataTable = tellerDAO.DataSet.Tables["THU_NGAN"];
            tellerVO.TellerRoleDataTable = tellerDAO.DataSet.Tables["QUYEN_THU_NGAN"];
            tellerVO.RoleDataTable = tellerDAO.DataSet.Tables["QUYEN"];
            tellerVO.DataSet = tellerDAO.DataSet;

            return tellerVO;
        }

        public void updateTellers()
        {
            tellerDAO.updateTellers();
        }

        public void updateTellerRoles()
        {
            tellerDAO.updateTellerRoles();
        }
    }
}
