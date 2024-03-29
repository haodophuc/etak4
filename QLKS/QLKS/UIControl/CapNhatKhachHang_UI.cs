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
    public partial class CapNhatKhachHang_UI : UserControl
    {

        #region properties

        private KhachHangBUS khachHangBUS;
        private QuocGiaBUS quocGiaBUS;
        private MyUtilities myUtilities = new MyUtilities();
      
        private bool isAdded = false;
        private bool isModified = false;

        #endregion

        #region methods
        public CapNhatKhachHang_UI()
        {
            InitializeComponent();
            khachHangBUS = new KhachHangBUS();
            quocGiaBUS = new QuocGiaBUS();
        }

       

        private void LoadInit()
        {
            isAdded = false;
            isModified = false;
            UnabledTextbox();
            LoadComboBoxQuocGia();
            LoadGrid();
            myUtilities.EnableSimpleButton(bttThem, bttXoa, bttSua, bttLuu, bttHuy, true);
            grdCtrlKhachHang.Enabled = true;
       
        }

        private void UnabledTextbox()
        {
            txt_MaKhachHang.Properties.ReadOnly = true;
            txt_HoKhachHang.Properties.ReadOnly = true;
            txt_TenKhachHang.Properties.ReadOnly = true;
            txt_SoCMND.Properties.ReadOnly = true;
            txt_HoChieu.Properties.ReadOnly = true;
            txt_DienThoai.Properties.ReadOnly = true;
            cbo_QuocGia.Enabled = false;
          
        }

        private void LoadGrid()
        {
            try
            {
               DataTable dtTableKH = new DataTable();
                dtTableKH = khachHangBUS.GetAll();
              
              
                grdCtrlKhachHang.DataSource = dtTableKH;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private KhachHangVO GetKhachHangVO()
        {
            KhachHangVO khachHangVO = new KhachHangVO();
            khachHangVO.MA_KHACH_HANG = int.Parse(txt_MaKhachHang.Text.Substring(2));
            khachHangVO.MA_QUOC_GIA = int.Parse(cbo_QuocGia.SelectedValue.ToString());
            khachHangVO.HO_KHACH_HANG = txt_HoKhachHang.Text;
            khachHangVO.TEN_KHACH_HANG = txt_TenKhachHang.Text;
            khachHangVO.CMND = txt_SoCMND.Text;
            khachHangVO.HO_CHIEU = txt_HoChieu.Text;
            khachHangVO.DIEN_THOAI = txt_DienThoai.Text;
            khachHangVO.HIEU_LUC = true;
            return khachHangVO;
        }
       
        #endregion

        #region EventHandler
        private void CapNhatKhachHang_UI_Load(object sender, EventArgs e)
        {
            LoadInit();

        }
        private void gridView_KhachHang_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                DataRow dtrow;
                dtrow = gridView_KhachHang.GetFocusedDataRow();
                
                txt_MaKhachHang.Text = dtrow[0].ToString();
                txt_HoKhachHang.Text = dtrow[2].ToString();
                txt_TenKhachHang.Text = dtrow[3].ToString();
                txt_SoCMND.Text = dtrow[4].ToString();
                txt_HoChieu.Text = dtrow[5].ToString();
                txt_DienThoai.Text = dtrow[6].ToString();

              
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
                txt_HoKhachHang.Properties.ReadOnly = false;
                txt_TenKhachHang.Properties.ReadOnly = false;
                txt_SoCMND.Properties.ReadOnly = false;
                txt_HoChieu.Properties.ReadOnly = false;
                txt_DienThoai.Properties.ReadOnly = false;
                cbo_QuocGia.Enabled = true;

                txt_MaKhachHang.Text = "";
                txt_HoKhachHang.Text = "";
                txt_TenKhachHang.Text = "";
                txt_SoCMND.Text = "";
                txt_HoChieu.Text = "";
                txt_DienThoai.Text = "";

                txt_HoKhachHang.Focus();
                txt_MaKhachHang.Text = myUtilities.FormatID(khachHangBUS.GetNewIndentity().ToString(),"KH");

                grdCtrlKhachHang.Enabled = false;
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
                if (MessageBox.Show(this, "Bạn có muốn xóa không?", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    khachHangBUS.Delete(GetKhachHangVO().MA_KHACH_HANG);
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
            txt_HoKhachHang.Properties.ReadOnly = false;
            txt_TenKhachHang.Properties.ReadOnly = false;
            txt_SoCMND.Properties.ReadOnly = false;
            txt_HoChieu.Properties.ReadOnly = false;
            txt_DienThoai.Properties.ReadOnly = false;
            cbo_QuocGia.Enabled = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdded)
                {
                    isAdded = false;
                    khachHangBUS.Insert(GetKhachHangVO());
                }
                if (isModified)
                {
                    isModified = false;
                    khachHangBUS.Update(GetKhachHangVO());
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

     #endregion
        
    }
}
