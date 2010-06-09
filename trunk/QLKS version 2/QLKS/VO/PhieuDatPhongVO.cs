using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.VO
{
    class PhieuDatPhongVO
    {

        #region Properties
        private int ma_phieu;
        private int ma_khach_hang;
        private int ma_doan_khach;
        private int tien_coc;
        private bool da_giai_quyet; 
        #endregion

        #region Methods
        public PhieuDatPhongVO()
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


        public int TIEN_COC
        {
            get { return tien_coc; }
            set { tien_coc = value; }
        }


        public bool DA_GIAI_QUYET
        {
            get { return da_giai_quyet; }
            set { da_giai_quyet = value; }
        }

        #endregion
	
	
	
	
    }
}
