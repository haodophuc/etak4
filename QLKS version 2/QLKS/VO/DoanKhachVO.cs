using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.VO
{
    class DoanKhachVO
    {
        private int ma_doan_khach;

        public int MA_DOAN_KHACH
        {
            get { return ma_doan_khach; }
            set { ma_doan_khach = value; }
        }
        private int ma_cong_ty;

        public int MA_CONG_TY
        {
            get { return ma_cong_ty; }
            set { ma_cong_ty = value; }
        }

        private DateTime ngay_Den;

        public DateTime NGAY_DEN
        {
            get { return ngay_Den; }
            set { ngay_Den = value; }
        }
        private bool hieu_luc;
        public bool HIEU_LUC
        {
            get { return hieu_luc; }
            set { hieu_luc = value; }
        }
	
        
    }
}
