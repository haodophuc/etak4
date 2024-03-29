using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.BUS;
using QLKS.VO;

namespace QLKS.UI
{
    public partial class CheckOutUI : DevExpress.XtraEditors.XtraUserControl
    {
        #region Properties
        private DataRow dtRowTemp;
        private KhachHangBUS khachHangBUS = new KhachHangBUS();
        private DoanKhachBUS doankhachBUS = new DoanKhachBUS();
        private CongtyBus congTyBUS = new CongtyBus();
        private PhongBUS phongBUS = new PhongBUS();
        private PhieuThuePhongBUS phieuTPBUS = new PhieuThuePhongBUS();
        private PhieuDatPhongBUS phieuDPBUS = new PhieuDatPhongBUS();
        private Double TienPhongTongCong = 0;
        private Double TienDichVuTongCong = 0;
        private Double TienCoc = 0;
        private Double TongCong = 0; 
        #endregion

        #region Methods
        public CheckOutUI()
        {
            InitializeComponent();
            LoadComboCongTy();



        }



        private void OnButtonSearch()
        {

            
            MakeEmptyDetail();
            if (chk_DoanKhach.Checked == true)
            {
                
                Form_TimKiemVaChonDoanKhach frm = new Form_TimKiemVaChonDoanKhach();
                dtRowTemp = frm.ShowModal();
                if (dtRowTemp != null)
                {
                    txt_MaDoanKhach.Properties.Mask.UseMaskAsDisplayFormat = true;
                    txt_MaDoanKhach.Text = dtRowTemp["Ma_DOAN_KHACH"].ToString();
                    cbo_CongTy.SelectedValue = dtRowTemp["Ma_CONG_TY"].ToString();
                    LoadGridByDoanKhach(int.Parse(txt_MaDoanKhach.EditValue.ToString()));

                }



            }
            else
            {
                Form_TimKiemVaChonKhachHang frm = new Form_TimKiemVaChonKhachHang();
                dtRowTemp = frm.ShowModal();
                if (dtRowTemp != null)
                {
                    txt_MaKhachHang.Properties.Mask.UseMaskAsDisplayFormat = true;
                    txt_MaKhachHang.Text = dtRowTemp["Ma_KHACH_HANG"].ToString();
                    txt_TenKhachHang.Text = dtRowTemp["TEN_KHACH_HANG"].ToString();
                    LoadGridByKhachHang(int.Parse(txt_MaKhachHang.EditValue.ToString()));


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
        private void OnDoanKhachChange()
        {
            if (chk_DoanKhach.Checked == true)
            {
                txt_MaKhachHang.Properties.Mask.UseMaskAsDisplayFormat = false;
                txt_MaKhachHang.Text = "";
              
                txt_TenKhachHang.Text = "";
                MakeGridNull();
                MakeEmptyDetail();

            }
        }
        private void OnCheckKhachHangChange()
        {
            if (check_KhachHang.Checked == true)
            {
                txt_MaDoanKhach.Properties.Mask.UseMaskAsDisplayFormat = false;
               
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
            TienCoc = 0;
            grdCtrlPhieuThue.DataSource = phieuTPBUS.GetUnPaidRoomByKhachHang(maKhachHang);
            if (CheckHiring() == false)
            {
                return;
            }
            btt_CheckOut.Enabled = true;
            for (int i = 0; i < gridView_PhieuThuePhongChuaThanhToan.RowCount; i++)
            {
                int MP = int.Parse(gridView_PhieuThuePhongChuaThanhToan.GetDataRow(i)["MaP"].ToString().Substring(1));
                if (CheckHiring() == false)
                {
                    return;
                }
                TienDichVuTongCong += phieuTPBUS.GetTienDichVu(MP);
                TienPhongTongCong += phieuTPBUS.GetTienPhong(MP);
            }
            TienCoc = khachHangBUS.GetTienCoc(int.Parse(txt_MaKhachHang.EditValue.ToString()));

            txt_TienCoc.Text = TienCoc.ToString();
            txt_TienPhongTongCong.Text = TienPhongTongCong.ToString();
            txt_TienDichVuTongCong.Text = TienDichVuTongCong.ToString();
            TongCong = TienPhongTongCong + TienDichVuTongCong - TienCoc;
            txt_TongCong.Text = TongCong.ToString();
        }
        private void LoadGridByDoanKhach(int maDoanKhach)
        {
            TienDichVuTongCong = 0;
            TienPhongTongCong = 0;
            TienCoc = 0;
            grdCtrlPhieuThue.DataSource = phieuTPBUS.GetUnPaidRoomByDoanKhach(maDoanKhach);
            if (CheckHiring() == false)
            {
                return;
            }
            btt_CheckOut.Enabled = true;
            for (int i = 0; i < gridView_PhieuThuePhongChuaThanhToan.RowCount; i++)
            {
                int MP = int.Parse(gridView_PhieuThuePhongChuaThanhToan.GetDataRow(i)["MaP"].ToString().Substring(1));
                TienDichVuTongCong += phieuTPBUS.GetTienDichVu(MP);
                TienPhongTongCong += phieuTPBUS.GetTienPhong(MP);
            }
            TienCoc = doankhachBUS.GetTienCoc(int.Parse(txt_MaDoanKhach.EditValue.ToString()));

            txt_TienCoc.Text = TienCoc.ToString();
            txt_TienPhongTongCong.Text = TienPhongTongCong.ToString();
            txt_TienDichVuTongCong.Text = TienDichVuTongCong.ToString();
            TongCong = TienPhongTongCong + TienDichVuTongCong - TienCoc;
            txt_TongCong.Text = TongCong.ToString();


        }

        private bool CheckHiring()
        {
            if (gridView_PhieuThuePhongChuaThanhToan.RowCount == 0)
            {
                MessageBox.Show("Chưa Thuê phòng");

                MakeEmptyDetail();
                return false;


            }
            return true;
        }

        private void gridView_PhieuThuePhongChuaThanhToan_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            OnGridViewPhieuThuePhongChange();

        }

        private void OnGridViewPhieuThuePhongChange()
        {
            txt_RoomNo.Text = gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["SO_PHONG"].ToString();
            txt_LoaiPhong.Text = gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["TEN_LOAI_PHONG"].ToString();
            txt_DonGia.Text = gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["GIA_THAM_KHAO"].ToString();
            date_NgayNhanPhong.DateTime = DateTime.Parse(gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["NGAY_NHAN_PHONG"].ToString());
            if (gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["NGAY_TRA_PHONG"].ToString() != "")
            {
                date_NgayTraPhong.DateTime = DateTime.Parse(gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["NGAY_TRA_PHONG"].ToString());
            }
            else
            {
                date_NgayTraPhong.DateTime = System.DateTime.Now;
            }
            int maphieu = int.Parse(gridView_PhieuThuePhongChuaThanhToan.GetFocusedDataRow()["MaP"].ToString().Substring(1));
            Int64 tienphong = phieuTPBUS.GetTienPhong(maphieu);
            Int64 tiendichvu = phieuTPBUS.GetTienDichVu(maphieu);
            txt_TienPhong.Text = tienphong.ToString();
            txt_TienDichVu.Text = tiendichvu.ToString();
            TimeSpan ts = date_NgayTraPhong.DateTime.Subtract(date_NgayNhanPhong.DateTime);
            int ngayo = int.Parse(ts.Days.ToString());
            if (ngayo == 0)
            {
                ngayo = 1;
            }
            txt_NgayO.Text = ngayo.ToString();

        }
        private void MakeEmptyDetail()
        {
            txt_TienPhong.Text = "";
            txt_TienDichVu.Text = "";
            txt_RoomNo.Text = "";
            txt_NgayO.Text = "";
            txt_DonGia.Text = "";
            txt_LoaiPhong.Text = "";
            date_NgayNhanPhong.Text = "";
            date_NgayTraPhong.Text = "";
            txt_TienDichVuTongCong.Text = "";
            txt_TienPhongTongCong.Text = "";
            txt_TienCoc.Text = "";
            txt_TongCong.Text = "";
            btt_CheckOut.Enabled = false;
        }
        private List<PhieuThuePhongVO> GetListPhieuThuePhongVO()
        {
            List<PhieuThuePhongVO> pttVOList = new List<PhieuThuePhongVO>();
            for (int i = 0; i < gridView_PhieuThuePhongChuaThanhToan.RowCount; i++)
            {
                PhieuThuePhongVO ptVO = new PhieuThuePhongVO();
                DataRow dtRow = gridView_PhieuThuePhongChuaThanhToan.GetDataRow(i);
                ptVO.MA_PHIEU = int.Parse(dtRow["MaP"].ToString().Substring(1));
                if (dtRow["MaKH"].ToString() != "")
                ptVO.MA_KHACH_HANG = int.Parse(dtRow["MaKH"].ToString().Substring(2));
                if(dtRow["MaDK"].ToString()!="")
                ptVO.MA_DOAN_KHACH = int.Parse(dtRow["MaDK"].ToString().Substring(2));
                ptVO.MA_PHONG = int.Parse(dtRow["SO_PHONG"].ToString().Substring(2));
                ptVO.NGAY_NHAN_PHONG = DateTime.Parse(dtRow["NGAY_NHAN_PHONG"].ToString());
                if (dtRow["NGAY_TRA_PHONG"].ToString() != "")
                {
                    ptVO.NGAY_TRA_PHONG = DateTime.Parse(dtRow["NGAY_TRA_PHONG"].ToString());
                }
                else
                {
                    ptVO.NGAY_TRA_PHONG = DateTime.Now;
                }
                ptVO.GHI_CHU = dtRow["GHI_CHU"].ToString();
                ptVO.THANH_TOAN_DICH_VU = true;
                ptVO.THANH_TOAN_TIEN_PHONG = true;
                ptVO.DA_TRA_PHONG = true;
                pttVOList.Add(ptVO);

            }
            return pttVOList;
        } 
        #endregion
        #region EventHandler

        private void btt_Search_Click(object sender, EventArgs e)
        {
            OnButtonSearch();

        }
        private void check_KhachHang_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckKhachHangChange();
        }
        private void chk_DoanKhach_CheckedChanged(object sender, EventArgs e)
        {
            OnDoanKhachChange();
        }

        private void btt_CheckOut_Click(object sender, EventArgs e)
        {
            List<PhieuThuePhongVO> pttVOList = GetListPhieuThuePhongVO();
            foreach (PhieuThuePhongVO ptVO in pttVOList)
            {
                phieuTPBUS.Update(ptVO);
            }

            if (check_KhachHang.Checked == true)
            {
                phieuDPBUS.UpdateDaGiaiQuyetForCustomerAfterCheckOut(int.Parse(txt_MaKhachHang.EditValue.ToString()));
            }
            else
            {
                phieuDPBUS.UpdateDaGiaiQuyetForGroupAfterCheckOut(int.Parse(txt_MaDoanKhach.EditValue.ToString()));
            }
            MessageBox.Show("Succefully!");
            MakeGridNull();
            MakeEmptyDetail();

        } 
        #endregion

       
    }
}
