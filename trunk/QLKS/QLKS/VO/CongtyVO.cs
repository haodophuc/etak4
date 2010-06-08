using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.VO
{
    class CongtyVO
    {
        private int ma_cong_ty;
        private int ma_quoc_gia;
        private int ma_nguoi_dai_dien;
        private String ten_cong_ty;
        private String dia_chi;
        private String dien_thoai;
        private String email;
        private String fax;
        private String so_tai_khoan;
        private String ma_so_thue;

        private bool hieu_luc;

	public int MA_CONG_TY
	{
		get { return ma_cong_ty;}
		set { ma_cong_ty = value;}
	}

        

	public int MA_QUOC_GIA
	{
		get { return ma_quoc_gia;}
		set { ma_quoc_gia = value;}
	}
      

	public int MA_NGUOI_DAI_DIEN
	{
		get { return ma_nguoi_dai_dien;}
		set { ma_nguoi_dai_dien = value;}
	}


    public String TEN_CONG_TY
    {
        get { return ten_cong_ty; }
        set { ten_cong_ty = value; }
    }



    public String DIA_CHI
    {
        get { return dia_chi; }
        set { dia_chi = value; }
    }


    public String DIEN_THOAI
    {
        get { return dien_thoai; }
        set { dien_thoai = value; }
    }


    public String EMAIL
    {
        get { return email; }
        set { email = value; }
    }


    public String FAX
    {
        get { return fax; }
        set { fax = value; }
    }
 

    public String SO_TAI_KHOAN
    {
        get { return so_tai_khoan; }
        set { so_tai_khoan = value; }
    }


    public String MA_SO_THUE
    {
        get { return ma_so_thue; }
        set { ma_so_thue = value; }
    }


    public bool HIEU_LUC
    {
        get { return hieu_luc; }
        set { hieu_luc = value; }
    }
	
	
    
    }
}



