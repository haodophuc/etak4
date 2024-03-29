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
    public partial class CapNhatPhieuThuKhachHangUI : DevExpress.XtraEditors.XtraUserControl
    {
        #region Properties
        private PhieuThuKhachHangBUS phieuThuKhachHangBUS = new PhieuThuKhachHangBUS();
        private PhieuThuePhongBUS phieuthuePhongBUS = new PhieuThuePhongBUS();
        private KhachHangBUS khachHangBUS = new KhachHangBUS();
        private CaTrucBus catrucBUS = new CaTrucBus();
        private MyUtilities myUtilities = new MyUtilities();

        private bool isAdded = false;
        private bool isModified = false; 
        #endregion

        #region Methods
        public CapNhatPhieuThuKhachHangUI()
        {
            InitializeComponent();
            isAdded = false;
            isModified = false;

        }

        private void LoadInit()
        {
            isAdded = false;
            isModified = false;
            UnabledTextbox();
            LoadGrid();
            myUtilities.EnableSimpleButton(bttThem, bttXoa, bttSua, bttLuu, bttHuy, true);
            grdCtrlPhieuThuKhachHang.Enabled = true;

        }

        private void LoadKhachHang()
        {

            try
            {
                DataTable dtTableKH = new DataTable();
                dtTableKH = phieuthuePhongBUS.GetMaPhieu_KhachHanginfo();
                cbo_PhieuThue.DataSource = dtTableKH;
                cbo_PhieuThue.DisplayMember = "MaP";
                cbo_PhieuThue.ValueMember = "MaP";
                txt_MaKhachHang.DataBindings.Add("Text", dtTableKH, "MaKH");
                txt_TenKhachHang.DataBindings.Add("Text", dtTableKH, "HO_TEN");
                txt_SoCMND.DataBindings.Add("Text", dtTableKH, "CMND");
                txt_HoChieu.DataBindings.Add("Text", dtTableKH, "HO_CHIEU");


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCatruc()
        {
            DataTable dtTableCaTruc = new DataTable();
            dtTableCaTruc = catrucBUS.GetMaCaTrucAndTenThuNgan();
            cbo_Catruc.DataSource = dtTableCaTruc;
            cbo_Catruc.DisplayMember = "MA_CA_TRUC";
            cbo_Catruc.ValueMember = "MA_CA_TRUC";
            txt_TenThuNgan.DataBindings.Add("Text", dtTableCaTruc, "TEN_THU_NGAN");
        }

        private void LoadGrid()
        {
            try
            {
                DataTable dtTablePhieuThuKH = new DataTable();
                dtTablePhieuThuKH = phieuThuKhachHangBUS.GetAll();


                grdCtrlPhieuThuKhachHang.DataSource = dtTablePhieuThuKH;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UnabledTextbox()
        {
            txt_SoPhieu.Properties.ReadOnly = true;
            txt_Sotien.Properties.ReadOnly = true;
            txt_NoiDungThu.Properties.ReadOnly = true;
            txt_HinhThucThu.Properties.ReadOnly = true;
            date_NgayPhieu.Properties.ReadOnly = true;


            cbo_PhieuThue.Enabled = false;
            cbo_Catruc.Enabled = false;

        }
        private PhieuThuKhachHangVO GetPhieuThuKhachHangVO()
        {
            PhieuThuKhachHangVO phieuVO = new PhieuThuKhachHangVO();
            phieuVO.SO_PHIEU = int.Parse(txt_SoPhieu.Text.Substring(2));
            phieuVO.MA_CA_TRUC = int.Parse(cbo_Catruc.SelectedValue.ToString().Substring(2));
            phieuVO.MA_PHIEU = int.Parse(cbo_PhieuThue.SelectedValue.ToString().Substring(1));
            phieuVO.NGAY_PHIEU = date_NgayPhieu.DateTime;
            if (txt_Sotien.Text == "")
            {
                txt_Sotien.Text = "0";
            }
            phieuVO.SO_TIEN = Double.Parse(txt_Sotien.Text.ToString());
            phieuVO.NOI_DUNG_THU = txt_NoiDungThu.Text;
            phieuVO.HINH_THUC_THU = txt_HinhThucThu.Text;
            return phieuVO;
        }
        #endregion

        #region EventHandler
        private void CapNhatPhieuThuKhachHangUI_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadCatruc();
            LoadInit();
        }
        private void gridView_PhieuThuKhachHang_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                DataRow dtrow;
                dtrow = gridView_PhieuThuKhachHang.GetFocusedDataRow();

                txt_SoPhieu.Text = dtrow[0].ToString();
                date_NgayPhieu.DateTime = DateTime.Parse(dtrow["NGAY_PHIEU"].ToString());
                txt_Sotien.Text = dtrow["SO_TIEN"].ToString();

                txt_HinhThucThu.Text = dtrow["HINH_THUC_THU"].ToString();
                cbo_Catruc.SelectedValue = dtrow["MA_CA_TRUC"].ToString();
                cbo_PhieuThue.SelectedValue = dtrow["Ma_PHIEU"].ToString();
                txt_NoiDungThu.Text = dtrow["NOI_DUNG_THU"].ToString();





            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bttThem_Click(object sender, EventArgs e)
        {
            try
            {
                isAdded = true;

                myUtilities.EnableSimpleButton(bttThem, bttXoa, bttSua, bttLuu, bttHuy, false);

                txt_Sotien.Properties.ReadOnly = false;
                txt_NoiDungThu.Properties.ReadOnly = false;
                txt_HinhThucThu.Properties.ReadOnly = false;
                date_NgayPhieu.Properties.ReadOnly = false;


                cbo_PhieuThue.Enabled = true;
                cbo_Catruc.Enabled = true;

                txt_SoPhieu.Text = "";
                txt_Sotien.Text = "";
                txt_TenKhachHang.Text = "";
                txt_NoiDungThu.Text = "";
                txt_HinhThucThu.Text = "";
                date_NgayPhieu.DateTime = DateTime.Now;

                date_NgayPhieu.Focus();
                txt_SoPhieu.Text = myUtilities.FormatID(phieuThuKhachHangBUS.GetNewIndentity().ToString(), "PT");

                grdCtrlPhieuThuKhachHang.Enabled = false;



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bttHuy_Click(object sender, EventArgs e)
        {
            LoadInit();
        }
        private void bttSua_Click(object sender, EventArgs e)
        {
            isModified = true;
            myUtilities.EnableSimpleButton(bttThem, bttXoa, bttSua, bttLuu, bttHuy, false);
            txt_Sotien.Properties.ReadOnly = false;
            txt_NoiDungThu.Properties.ReadOnly = false;
            txt_HinhThucThu.Properties.ReadOnly = false;
            date_NgayPhieu.Properties.ReadOnly = false;


            cbo_PhieuThue.Enabled = true;
            cbo_Catruc.Enabled = true;

        }
        private void bttLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdded)
                {
                    isAdded = false;

                    phieuThuKhachHangBUS.Insert(GetPhieuThuKhachHangVO());
                }
                if (isModified)
                {
                    isModified = false;
                    phieuThuKhachHangBUS.Update(GetPhieuThuKhachHangVO());
                }

                LoadInit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Bạn có muốn xóa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    phieuThuKhachHangBUS.Delete(GetPhieuThuKhachHangVO().SO_PHIEU);
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
