using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace QLKS_DichVu.VO
{
    public class ServiceOrderVO
    {
        private DataTable phieuThuePhongDataTable;
        public DataTable PhieuThuePhongDataTable
        {
            get { return phieuThuePhongDataTable; }
            set { phieuThuePhongDataTable = value; }
        }

        private DataTable phieuDangKyDichVuDataTable;
        public DataTable PhieuDangKyDichVuDataTable
        {
            get { return phieuDangKyDichVuDataTable; }
            set { phieuDangKyDichVuDataTable = value; }
        }

        private DataTable dichVuDataTable;
        public DataTable DichVuDataTable
        {
            get { return dichVuDataTable; }
            set { dichVuDataTable = value; }
        }

        private DataSet dataSet;
        public DataSet DataSet
        {
            get { return dataSet; }
            set { dataSet = value; }
        }

    }
}
