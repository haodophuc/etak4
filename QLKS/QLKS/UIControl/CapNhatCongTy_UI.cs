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
    public partial class CapNhatCongTy_UI : UserControl
    {
        #region Properties
        private CongtyBus congtyBUS;
        private QuocGiaBUS quocGiaBUS;
        private KhachHangBUS khachHangBUS;
        private MyUtilities myUtilities = new MyUtilities();
        private bool isAdded = false;
        private bool isModified = false;
        #endregion

        #region methods
        public CapNhatCongTy_UI()
        {
            InitializeComponent();
            congtyBUS = new CongtyBus();
            quocGiaBUS = new QuocGiaBUS();
            khachHangBUS = new KhachHangBUS();
        }
        private void LoadInit()
        {
            isAdded = false;
            isModified = false;
            UnabledTextbox();

            LoadGrid();
            myUtilities.EnableSimpleButton(bttThem, bttXoa, bttSua, bttLuu, bttHuy, true);
            grdCtrlCongTy.Enabled = true;
        }
        private void LoadGrid()
        {
            try
            {
                DataTable dtTableCT = new DataTable();
                dtTableCT = congtyBUS.GetAll();

                grdCtrlCongTy.DataSource = dtTableCT;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        private void UnabledTextbox()
        {
            txt_MaCongty.Properties.ReadOnly = true;
            txt_TenCongTy.Properties.ReadOnly = true;
            txt_DiaChi.Properties.ReadOnly = true;
            txt_DienThoai.Properties.ReadOnly = true;
            txt_Fax.Properties.ReadOnly = true;
            txt_Email.Properties.ReadOnly = true;
            txt_SoTaiKhoan.Properties.ReadOnly = true;
            txt_MaSoThue.Properties.ReadOnly = true;
            cbo_QuocGia.Enabled = false;
            cbo_MaNguoiDaiDien.Enabled = false;

        }
        private void LoadNguoiDaiDienInFo()
        {
            DataTable dtTableKh = new DataTable();
            dtTableKh = khachHangBUS.GetAll();


            cbo_MaNguoiDaiDien.DataSource = dtTableKh;
            cbo_MaNguoiDaiDien.ValueMember = "MaKH";
            cbo_MaNguoiDaiDien.DisplayMember = "MaKH";
            txt_HoNguoiDaiDien.DataBindings.Add("Text", dtTableKh, "HO_KHACH_HANG");
            txt_TenNguoiDaiDien.DataBindings.Add("Text", dtTableKh, "TEN_KHACH_HANG");
            txt_SOCMND.DataBindings.Add("Text", dtTableKh, "CMND");
            txt_HoChieu.DataBindings.Add("Text", dtTableKh, "HO_CHIEU");

        }
        private void LoadComboBoxQuocGia()
        {
            try
            {
                DataTable dtTableQG = new DataTable();
                dtTableQG = quocGiaBUS.GetAll();

                cbo_QuocGia.DataSource = dtTableQG;
                cbo_QuocGia.DisplayMember = "TEN_QUOC_GIA";
                cbo_QuocGia.ValueMember = "MA_QUOC_GIA";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private CongtyVO GetCongtyVO()
        {
            CongtyVO congtyVO = new CongtyVO();
            congtyVO.MA_CONG_TY = int.Parse(txt_MaCongty.Text.Substring(2));
            congtyVO.MA_QUOC_GIA = int.Parse(cbo_QuocGia.SelectedValue.ToString());
            congtyVO.MA_NGUOI_DAI_DIEN = int.Parse(cbo_MaNguoiDaiDien.SelectedValue.ToString().Substring(2));

            congtyVO.TEN_CONG_TY = txt_TenCongTy.Text;
            congtyVO.DIA_CHI = txt_DiaChi.Text;
            congtyVO.DIEN_THOAI = txt_DienThoai.Text;
            congtyVO.EMAIL = txt_Email.Text;
            congtyVO.FAX = txt_Fax.Text;
            congtyVO.SO_TAI_KHOAN = txt_SoTaiKhoan.Text;
            congtyVO.MA_SO_THUE = txt_MaSoThue.Text;
            congtyVO.HIEU_LUC = true;
            return congtyVO;
        }

        #endregion

        #region Event Handler
        private void CapNhatCongTy_UI_Load(object sender, EventArgs e)
        {
       
            LoadComboBoxQuocGia();
            LoadNguoiDaiDienInFo();
            LoadInit();
          
            
        }
      
    
     
        private void gridView_CongTy_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        { try
            {
                DataRow dtrow;
                dtrow = gridView_CongTy.GetFocusedDataRow();
                
              txt_MaCongty.Text = dtrow[0].ToString();
              txt_TenCongTy.Text = dtrow[3].ToString();
              txt_DiaChi.Text = dtrow[4].ToString();
              txt_DienThoai.Text = dtrow[5].ToString();
              txt_Email.Text = dtrow[6].ToString();
              txt_Fax.Text = dtrow[7].ToString();
              txt_SoTaiKhoan.Text = dtrow[8].ToString();
              txt_MaSoThue.Text = dtrow[9].ToString();


              cbo_MaNguoiDaiDien.SelectedValue = dtrow[2].ToString();
                cbo_QuocGia.SelectedValue = dtrow[1].ToString().Substring(2);
                
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

                txt_TenCongTy.Properties.ReadOnly = false;
                txt_DiaChi.Properties.ReadOnly = false;
                txt_DienThoai.Properties.ReadOnly = false;
                txt_Email.Properties.ReadOnly = false;
                txt_Fax.Properties.ReadOnly = false;
                txt_SoTaiKhoan.Properties.ReadOnly = false;
                txt_MaSoThue.Properties.ReadOnly = false;



                cbo_QuocGia.Enabled = true;
                cbo_MaNguoiDaiDien.Enabled = true;

                txt_TenCongTy.Text = "";
                txt_DiaChi.Text = "";
                txt_DienThoai.Text = "";
                txt_Email.Text = "";
                txt_Fax.Text = "";
                txt_SoTaiKhoan.Text = "";
                txt_MaSoThue.Text = "";



                txt_TenCongTy.Focus();
                txt_MaCongty.Text = myUtilities.FormatID(khachHangBUS.GetNewIndentity().ToString(), "CT");

                grdCtrlCongTy.Enabled = false;
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
                    congtyBUS.Delete(GetCongtyVO().MA_CONG_TY);
                    LoadInit();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            isModified = true;
            myUtilities.EnableSimpleButton(bttThem, bttXoa, bttSua, bttLuu, bttHuy, false);
            txt_TenCongTy.Properties.ReadOnly = false;
            txt_DiaChi.Properties.ReadOnly = false;
            txt_DienThoai.Properties.ReadOnly = false;
            txt_Email.Properties.ReadOnly = false;
            txt_Fax.Properties.ReadOnly = false;
            txt_SoTaiKhoan.Properties.ReadOnly = false;
            txt_MaSoThue.Properties.ReadOnly = false;



            cbo_QuocGia.Enabled = true;
            cbo_MaNguoiDaiDien.Enabled = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdded)
                {
                    isAdded = false;
                    CongtyVO vo = GetCongtyVO();
                    congtyBUS.Insert(GetCongtyVO());
                }
                if (isModified)
                {
                    isModified = false;
                    congtyBUS.Update(GetCongtyVO());
                }

                LoadInit();
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
        #endregion Event Handler


    }
}
