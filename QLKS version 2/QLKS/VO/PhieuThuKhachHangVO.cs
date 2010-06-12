using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.VO
{
    class PhieuThuKhachHangVO
    {
        private int so_phieu;

        public int SO_PHIEU
        {
            get { return so_phieu; }
            set { so_phieu = value; }
        }
        private int ma_phieu;

        public int MA_PHIEU
        {
            get { return ma_phieu; }
            set { ma_phieu = value; }
        }
        private int ma_ca_truc;

        public int MA_CA_TRUC
        {
            get { return ma_ca_truc; }
            set { ma_ca_truc = value; }
        }
        private DateTime ngay_phieu;

        public DateTime NGAY_PHIEU
        {
            get { return ngay_phieu; }
            set { ngay_phieu = value; }
        }
       
        private Double so_tien;

        public Double SO_TIEN
        {
            get { return so_tien; }
            set { so_tien = value; }
        }

        private string noi_dung_thu;

        public string NOI_DUNG_THU
        {
            get { return noi_dung_thu; }
            set { noi_dung_thu = value; }
        }

        private string hinh_thuc_thu;

        public string HINH_THUC_THU
        {
            get { return hinh_thuc_thu; }
            set { hinh_thuc_thu = value; }
        }	      	
    }

}

