using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.VO
{
    class CaTrucVO
    {
        private int ma_ca_truc;

        public int MA_CA_TRUC
        {
            get { return ma_ca_truc; }
            set { ma_ca_truc = value; }
        }
        private int ma_thu_ngan;

        public int MA_THU_NGAN
        {
            get { return ma_thu_ngan; }
            set { ma_thu_ngan = value; }
        }
        private DateTime gio_vao_ca;

        public DateTime GIO_VAO_CA
        {
            get { return gio_vao_ca; }
            set { gio_vao_ca = value; }
        }
        private DateTime gio_xuong_ca;

        public DateTime GIO_XUONG_CA
        {
            get { return gio_xuong_ca; }
            set { gio_xuong_ca = value; }
        }
        private bool da_giai_quyet;

        public bool DA_KET_TOAN
        {
            get { return da_giai_quyet; }
            set { da_giai_quyet = value; }
        }
	
	
    }
}
