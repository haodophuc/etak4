using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS_TiepNhanKhach.VO
{
    class PhongVO
    {
        private int maphong;

        public int MaPhong
        {
            get { return maphong; }
            set { maphong = value; }
        }

        private string sophong;

        public string SoPhong
        {
            get { return sophong; }
            set { sophong = value; }
        }

        private int maloaiphong;

        public int MaLoaiPhong
        {
            get { return maloaiphong; }
            set { maloaiphong = value; }
        }

        private int matinhtrang;

        public int MaTinhTrang
        {
            get { return matinhtrang; }
            set { matinhtrang = value; }
        }
	
	
	
        public PhongVO()
        {

        }

    }
}
