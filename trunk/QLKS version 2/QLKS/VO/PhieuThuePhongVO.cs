using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.VO
{
    class PhieuThuePhongVO
    {
        #region Properties
        private int ma_phieu;
        private int ma_khach_hang;
        private int ma_doan_khach;
        private int ma_phong;
        private DateTime ngay_nhan_phong;
        private bool da_tra_phong;
        private DateTime ngay_tra_phong;

        private String ghi_chu;
        private bool thanh_toan_tien_phong;
        private bool thanh_toan_dich_vu; 
        #endregion

        #region Methods
        public PhieuThuePhongVO()
        {
        }

        public int MA_PHIEU
        {
            get { return ma_phieu; }
            set { ma_phieu = value; }
        }


        public int MA_KHACH_HANG
        {
            get { return ma_khach_hang; }
            set { ma_khach_hang = value; }
        }



        public int MA_DOAN_KHACH
        {
            get { return ma_doan_khach; }
            set { ma_doan_khach = value; }
        }

        public int MA_PHONG
        {
            get { return ma_phong; }
            set { ma_phong = value; }
        }


        public DateTime NGAY_NHAN_PHONG
        {
            get { return ngay_nhan_phong; }
            set { ngay_nhan_phong = value; }
        }


        public DateTime NGAY_TRA_PHONG
        {
            get { return ngay_tra_phong; }
            set { ngay_tra_phong = value; }
        }


        public String GHI_CHU
        {
            get { return ghi_chu; }
            set { ghi_chu = value; }
        }

        public bool THANH_TOAN_TIEN_PHONG
        {
            get { return thanh_toan_tien_phong; }
            set { thanh_toan_tien_phong = value; }
        }


        public bool THANH_TOAN_DICH_VU
        {
            get { return thanh_toan_dich_vu; }
            set { thanh_toan_dich_vu = value; }
        }


        public bool DA_TRA_PHONG
        {
            get { return da_tra_phong; }
            set { da_tra_phong = value; }
        }

        #endregion	
	
    }
}
