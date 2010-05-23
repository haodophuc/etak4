using System;
using System.Collections.Generic;
using System.Text;
using QLKS_TiepNhanKhach.DAO;
using System.Data;
using System.Data.SqlClient;

namespace QLKS_TiepNhanKhach.BUS
{
    class KhachHangBUS
    {
         private KhachHangDAO khachHangDAO;

        public KhachHangBUS(DBConnection dbConnection)
        {
            khachHangDAO = new KhachHangDAO(dbConnection);

        }

        public DataTable getAllFromKhachHang()
        {
            return khachHangDAO.selectAllFromKhachHang();
        } 
    }
}
