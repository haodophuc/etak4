using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using System.Data.SqlClient;
using System.Data;

namespace QLKS.BUS
{
    class DoanhThuBUS
    {
        private DoanhThuDAO doanhThuDAO;
        public DoanhThuBUS()
        {
            doanhThuDAO = new DoanhThuDAO();
        }

        public DataTable GetDoanhThu(int year)
        {
            try
            {
                return doanhThuDAO.GetDoanhThu(year);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
