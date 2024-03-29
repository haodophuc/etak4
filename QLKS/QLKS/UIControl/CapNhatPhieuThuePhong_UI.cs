using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.BUS;
using QLKS.VO;

namespace QLKS.UIControl
{
    public partial class CapNhatPhieuThuePhong_UI : UserControl
    {
        #region Properties
        private PhieuThuePhongBUS phieuThuePhongBUS;
        private KhachHangBUS khachHangBUS;
        private DoanKhachBUS doankhachBUS;
        private PhongBUS phongBUS;
        private MyUtilities myUtilities = new MyUtilities(); 
        #endregion
        #region Methods
        public CapNhatPhieuThuePhong_UI()
        {
            InitializeComponent();
            khachHangBUS = new KhachHangBUS();
            doankhachBUS = new DoanKhachBUS();
            phieuThuePhongBUS = new PhieuThuePhongBUS();
            phongBUS = new PhongBUS();


        }

        private void LoadInit()
        {

            UnabledTextbox();

            LoadGrid();
            myUtilities.EnableSimpleButton(new DevExpress.XtraEditors.SimpleButton(), bttXoa, bttSua, bttLuu, bttHuy, true);
            grdCtrlPhieuThuePhong.Enabled = true;
        }
        private void LoadGrid()
        {
            try
            {
                DataTable dtTablePhieuTP = new DataTable();
                dtTablePhieuTP = phieuThuePhongBUS.GetAll();

                grdCtrlPhieuThuePhong.DataSource = dtTablePhieuTP;


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void LoadKhachHangInFo()
        {
            DataTable dtTableKhachHang = new DataTable();
            dtTableKhachHang = khachHangBUS.GetAll();


            cbo_KhachHang.DataSource = dtTableKhachHang;
            cbo_KhachHang.ValueMember = "MaKH";
            cbo_KhachHang.DisplayMember = "MaKH";

            txt_TenKhachHang.DataBindings.Add("Text", dtTableKhachHang, "TEN_KHACH_HANG");
            txt_SOCMND.DataBindings.Add("Text", dtTableKhachHang, "CMND");
            txt_HoChieu.DataBindings.Add("Text", dtTableKhachHang, "HO_CHIEU");


        }
        private void LoadPhongInFo()
        {

            DataTable dtTablePhong = new DataTable();
            dtTablePhong = phongBUS.GetAll();


            cbo_Phong.DataSource = dtTablePhong;
            cbo_Phong.ValueMember = "SO_PHONG";
            cbo_KhachHang.DisplayMember = "SO_PHONG";
        }
        private void LoadDoanKhachInfo()
        {
            DataTable dtTableDoanKhach = new DataTable();
            dtTableDoanKhach = doankhachBUS.GetAllDetail();


            cbo_DoanKhach.DataSource = dtTableDoanKhach;
            cbo_DoanKhach.ValueMember = "MaDK";
            cbo_DoanKhach.DisplayMember = "MaDK";

            txt_TenCongTy.DataBindings.Add("Text", dtTableDoanKhach, "TEN_CONG_TY");

            txt_TenNguoiDD.DataBindings.Add("Text", dtTableDoanKhach, "TEN_KHACH_HANG");
        }
        private void UnabledTextbox()
        {
            txt_MaPhieu.Properties.ReadOnly = true;
            date_NgayNhan.Properties.ReadOnly = true;
            date_NgayTra.Properties.ReadOnly = true;

            txt_GhiChu.Properties.ReadOnly = true;

            chk_DaTraPhong.Enabled = false;

            chk_ThanhToanDichVU.Enabled = false;
            chk_ThanhToanTienPhong.Enabled = false;

            cbo_Phong.Enabled = false;
            cbo_KhachHang.Enabled = false;
            cbo_DoanKhach.Enabled = false;



        }
        private PhieuThuePhongVO GetPhieuThuePhongVO()
        {
            PhieuThuePhongVO phieuthuephongVO = new PhieuThuePhongVO();
            phieuthuephongVO.MA_PHIEU = int.Parse(txt_MaPhieu.Text.Substring(1));
            phieuthuephongVO.MA_PHONG = int.Parse(cbo_Phong.SelectedValue.ToString().Substring(2));
            phieuthuephongVO.GHI_CHU = txt_GhiChu.Text;
            phieuthuephongVO.NGAY_NHAN_PHONG = date_NgayNhan.DateTime;
            phieuthuephongVO.NGAY_TRA_PHONG = date_NgayTra.DateTime;
            phieuthuephongVO.THANH_TOAN_TIEN_PHONG = chk_ThanhToanTienPhong.Checked;
            phieuthuephongVO.THANH_TOAN_DICH_VU = chk_ThanhToanDichVU.Checked;
            if (cbo_KhachHang.Text != "")
                phieuthuephongVO.MA_KHACH_HANG = int.Parse(cbo_KhachHang.SelectedValue.ToString().Substring(2));
            if (cbo_DoanKhach.Text != "")
                phieuthuephongVO.MA_DOAN_KHACH = int.Parse(cbo_DoanKhach.SelectedValue.ToString().Substring(2));
            return phieuthuephongVO;
        } 
        #endregion

        #region Event Handler
        private void CapNhatPhieuThuePhong_UI_Load(object sender, EventArgs e)
        {
            LoadKhachHangInFo();
            LoadDoanKhachInfo();
            LoadPhongInFo();
            LoadInit();
        }
        private void gridView_PhieuThuePhong_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataRow dtrow;
            dtrow = gridView_PhieuThuePhong.GetFocusedDataRow();

            txt_MaPhieu.Text = dtrow[0].ToString();

            date_NgayNhan.Text = dtrow[4].ToString();
            date_NgayTra.Text = dtrow[5].ToString();
            txt_GhiChu.Text = dtrow[6].ToString();
            chk_ThanhToanTienPhong.Checked = bool.Parse(dtrow[7].ToString());
            chk_ThanhToanDichVU.Checked = bool.Parse(dtrow[8].ToString());
            chk_DaTraPhong.Checked = bool.Parse(dtrow[9].ToString());

            cbo_Phong.SelectedValue = "PH" + dtrow[3].ToString().Substring(1);
            cbo_KhachHang.SelectedValue = dtrow[1].ToString();
            cbo_DoanKhach.SelectedValue = dtrow[2].ToString();
        }
        private void bttThem_Click(object sender, EventArgs e)
        {

        }
        private void bttHuy_Click(object sender, EventArgs e)
        {
            LoadInit();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {

            myUtilities.EnableSimpleButton(new DevExpress.XtraEditors.SimpleButton(), bttXoa, bttSua, bttLuu, bttHuy, false);

            date_NgayNhan.Properties.ReadOnly = false;
            date_NgayTra.Properties.ReadOnly = false;
            txt_GhiChu.Properties.ReadOnly = false;
            chk_DaTraPhong.Enabled = false;
            chk_ThanhToanDichVU.Enabled = true;
            chk_ThanhToanTienPhong.Enabled = true;
            cbo_Phong.Enabled = true;
            cbo_KhachHang.Enabled = true;
            cbo_DoanKhach.Enabled = true;

        }

        private void bttLuu_Click(object sender, EventArgs e)
        {

            try
            {



                phieuThuePhongBUS.Update(GetPhieuThuePhongVO());



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadInit();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Bạn có muốn xóa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    phieuThuePhongBUS.Delete(GetPhieuThuePhongVO().MA_PHIEU);
                    LoadInit();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion
       
     


    }
}
