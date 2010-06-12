using System;
using System.Collections.Generic;
using System.Text;
using QLKS.DAO;
using System.Data;
using System.Data.SqlClient;
using QLKS.VO;

namespace QLKS.BUS
{

    class CaTrucBus
    {
        private CatrucDAO catrucDAO;
        public CaTrucBus()
        {
            catrucDAO = new CatrucDAO();
        }

        public DataTable GetMaCaTrucAndTenThuNgan()
        {
            return catrucDAO.SelectMaCTAndTenThuNgan();
        }
    }
}
