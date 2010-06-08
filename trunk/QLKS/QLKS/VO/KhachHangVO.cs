using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.VO
{
    class KhachHangVO
    {
        public KhachHangVO()
        {

        }
        private int ma_khach_hang;
        public int MA_KHACH_HANG
        {
            get { return ma_khach_hang; }
            set { ma_khach_hang = value; }
        }

        private int ma_quoc_gia;
        public int MA_QUOC_GIA
        {
            get { return ma_quoc_gia; }
            set { ma_quoc_gia = value; }
        }

        private String ho_khach_hang;
        public String HO_KHACH_HANG
        {
            get { return ho_khach_hang; }
            set { ho_khach_hang = value; }
        }

        private String ten_khach_hang;
        public String TEN_KHACH_HANG
        {
            get { return ten_khach_hang; }
            set { ten_khach_hang = value; }
        }

        private String cmnd;

        public String CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        private String ho_chieu;
        public String HO_CHIEU
        {
            get { return ho_chieu; }
            set { ho_chieu = value; }
        }

        private String dien_thoai;
        public String DIEN_THOAI
        {
            get { return dien_thoai; }
            set { dien_thoai = value; }
        }

        private bool hieu_luc;

        public bool HIEU_LUC
        {
            get { return hieu_luc; }
            set { hieu_luc = value; }
        }

       
       
    }
}
