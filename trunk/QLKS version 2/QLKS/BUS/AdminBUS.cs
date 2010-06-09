using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using QLKS.VO;

namespace QLKS.BUS
{
    class AdminBUS
    {
        private AdminDAO adminDAO;
        public AdminBUS()
        {
            adminDAO = new AdminDAO();
        }

        public AdminVO getVO()
        {
            AdminVO adminVO = new AdminVO();

            adminVO.AdminDataTable = adminDAO.DataSet.Tables["ADMINS"];
            adminVO.AdminRoleDataTable = adminDAO.DataSet.Tables["QUYEN_ADMIN"];
            adminVO.RoleDataTable = adminDAO.DataSet.Tables["QUYEN"];
            adminVO.DataSet = adminDAO.DataSet;

            return adminVO;
        }

        public void updateAdmins()
        {
            adminDAO.updateAdmins();
        }

        public void updateAdminRoles()
        {
            adminDAO.updateAdminRoles();
        }
    }
}
