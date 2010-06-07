using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS_TiepNhanKhach.BUS;

namespace QLKS_TiepNhanKhach.UI
{
    public partial class CheckOutUI : UserControl
    {
        private DataRow dtRowTemp;
        private CongtyBus congTyBUS = new CongtyBus();
        private PhongBUS phongBUS = new PhongBUS();
        private PhieuThuePhongBUS phieuTPBUS = new PhieuThuePhongBUS();
        private Int64 TienPhongTongCong = 0;
        private Int64 TienDichVuTongCong = 0;
        public CheckOutUI()
        {
            InitializeComponent();
            LoadComboCongTy();
      
          
                
        }

        private void btt_Search_Click(object sender, EventArgs e)
        {
            MakeEmptyDetail();
            if (chk_DoanKhach.Checked == true)
            {
                Form_TimKiemVaChonDoanKhach frm = new Form_TimKiemVaChonDoanKhach();
                dtRowTemp = frm.ShowModal();
                if(dtRowTemp!= null)
                {
                    txt_MaDoanKhach.Text = dtRowTemp["MaDK"].ToString();
                    cbo_CongTy.SelectedValue = dtRowTemp["MaCT"].ToString();
                    LoadGridByDoanKhach(int.Parse(txt_MaDoanKhach.Text.Substring(2)));
     
                }
                


            }
            else
            {
                Form_TimKiemVaChonKhachHang frm = new Form_TimKiemVaChonKhachHang();
                dtRowTemp= frm.ShowModal();
                if(dtRowTemp!= null)
                {
                txt_MaKhachHang.Text = dtRowTemp["MaKH"].ToString();
                txt_TenKhachHang.Text = dtRowTemp["TEN_KHACH_HANG"].ToString();
                LoadGridByKhachHang(int.Parse(txt_MaKhachHang.Text.Substring(2)));
  
              
                }
                
            }
           
            
        }
        private void LoadComboCongTy()
        {
        
            try
            {
                DataTable dtTableCT = new DataTable();
                dtTableCT = congTyBUS.GetAll();
                cbo_CongTy.DataSource = dtTableCT;
                cbo_CongTy.DisplayMember = "TEN_CONG_TY";
                cbo_CongTy.ValueMember = "MaCT";
                cbo_CongTy.Text = "";
               

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
   

        private void chk_DoanKhach_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_DoanKhach.Checked == true)
            {
                txt_MaKhachHang.Text = "";
                txt_TenKhachHang.Text = "";
                MakeGridNull();
                MakeEmptyDetail();
                 
            }
        }

        private void check_KhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (check_KhachHang.Checked == true)
            {
                txt_MaDoanKhach.Text = "";
                cbo_CongTy.Text = "";
                MakeGridNull();
                MakeEmptyDetail();
            }
        }

        private void MakeGridNull()
        {
            grdCtrlPhieuThue.DataSource = null;
        }
        private void LoadGridByKhachHang(int maKhachHang)
        {
            TienDichVuTongCong = 0;
            TienPhongTongCong = 0;
            grdCtrlPhieuThue.DataSource = phieuTPBUS.GetUnPaidRoomByKhachHang(maKhachHang);
            for (int i = 0; i < gridView_PhieuThuePhongChuaThanhToan.RowCount; i++)
            {
                int MP = int.Parse( gridView_PhieuThuePhongChuaThanhToan.GetDataRow(i)["MaP"].ToString().Substring(1));
                TienDichVuTongCong += phieuTPBUS.GetTienDichVu(MP);
                TienPhongTongCong += phieuTPBUS.GetTienPhong(MP);
            }
            txt_TienPhongTongCong.Text = TienPhongTongCong.ToString();
            txt_TienDichVuTongCong.Text = TienDichVuTongCong.ToString();
            
        }
        private void LoadGridByDoanKhach(int maDoanKhach)
        {
            TienDichVuTongCong = 0;
            TienPhongTongCong = 0;
            grdCtrlPhieuThue.DataSource = phieuTPBUS.GetUnPaidRoomByDoanKhach(maDoanKhach);
            for (int i = 0; i < gridView_PhieuThuePhongChuaThanhToan.RowCount; i++)
            {
                int MP = int.Parse(gridView_PhieuThuePhongChuaThanhToan.GetDataRow(i)["MaP"].ToString().Substring(1));
                TienDichVuTongCong += phieuTPBUS.GetTienDichVu(MP);
                TienPhongTongCong += phieuTPBUS.GetTienPhong(MP);
            }
            txt_TienPhongTongCong.Text = TienPhongTongCong.ToString();
            txt_TienDichVuTongCong.Text = TienDichVuTongCong.ToString();
        }

        private void gridView_PhieuThuePhongChuaThanhToan_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            txt_RoomNo.Text = gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["SO_PHONG"].ToString();
            txt_LoaiPhong.Text = gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["TEN_LOAI_PHONG"].ToString();
            txt_DonGia.Text = gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["GIA_THAM_KHAO"].ToString();
            date_NgayNhanPhong.DateTime = DateTime.Parse( gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["NGAY_NHAN_PHONG"].ToString());
            if (gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["NGAY_TRA_PHONG"].ToString() != "")
            {
                date_NgayTraPhong.DateTime = DateTime.Parse(gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["NGAY_TRA_PHONG"].ToString());
            }
            else
            {
                date_NgayTraPhong.DateTime = System.DateTime.Now;
            }
            int maphieu=int.Parse( gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["MaP"].ToString().Substring(1));
            Int64 tienphong = phieuTPBUS.GetTienPhong(maphieu);
            Int64 tiendichvu = phieuTPBUS.GetTienDichVu(maphieu);
            txt_TienPhong.Text = tienphong.ToString();
            txt_TienDichVu.Text = tiendichvu.ToString();
            TimeSpan ts = date_NgayTraPhong.DateTime.Subtract(date_NgayNhanPhong.DateTime);
            txt_NgayO.Text = ts.Days.ToString();

        }
       private void MakeEmptyDetail()
       {
           txt_TienPhong.Text="";
           txt_TienDichVu.Text="";
           txt_RoomNo.Text="";
           txt_NgayO.Text="";
           txt_DonGia.Text="";
           txt_LoaiPhong.Text="";
           date_NgayNhanPhong.Text = "";
           date_NgayTraPhong.Text = "";
           txt_TienDichVuTongCong.Text = "";
           txt_TienPhongTongCong.Text = "";
       }

    }
}
