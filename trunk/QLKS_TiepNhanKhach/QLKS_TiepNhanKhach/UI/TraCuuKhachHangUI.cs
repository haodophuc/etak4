using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS_TiepNhanKhach.BUS;
using QLKS_TiepNhanKhach.VO;

namespace QLKS_TiepNhanKhach.UI
{
    public partial class TraCuuKhachHangUI : UserControl
    {
        KhachHangBUS khachhangBUS = new KhachHangBUS();
        QuocGiaBUS quocGiaBUS = new QuocGiaBUS();
        public TraCuuKhachHangUI()
        {
            InitializeComponent();
            LoadComboBoxQuocGia();
        }

        private void btt_Search_Click(object sender, EventArgs e)
        {
            try {
                KhachHangVO khachHangVO = GetKhachHangVO();
                DataTable dtTable = new DataTable();
                dtTable = khachhangBUS.GetKhachHangByIndicator(khachHangVO, chk_MaKhachHang.Checked, chk_MaQG.Checked, chk_HoKhachHang.Checked, chk_TenKhachHang.Checked, chk_CMND.Checked, chk_HoCHieu.Checked, chk_DienThoai.Checked);

                if (dtTable.Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy khách hàng");
                grdCtrlKhachHang.DataSource = dtTable;
            }//end try
            catch( FormatException ex ) {
                MessageBox.Show(ex.Message);
            }//end catch
        }//end method btt_Search_Click

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
            int id = 0;
            try {
                id = int.Parse(txt_MaKhachHang.Text.Substring(2));
            }//end try
            catch( Exception e ) {
                if (e is FormatException)
                    throw new FormatException("Nhập sai Mã Khách Hàng", e);
            }//end catch
            KhachHangVO khachHangVO = new KhachHangVO();
            khachHangVO.MA_KHACH_HANG = id;
            khachHangVO.MA_QUOC_GIA = int.Parse(cbo_QuocGia.SelectedValue.ToString());
            khachHangVO.HO_KHACH_HANG = txt_HoKhachHang.Text;
            khachHangVO.TEN_KHACH_HANG = txt_TenKhachHang.Text;
            khachHangVO.CMND = txt_TenKhachHang.Text;
            khachHangVO.HO_CHIEU = txt_HoChieu.Text;
            khachHangVO.DIEN_THOAI = txt_DienThoai.Text;
            khachHangVO.HIEU_LUC = true;
            return khachHangVO;
        }

        private void txt_MaKhachHang_TextChanged(object sender, EventArgs e)
        {
            //nothing to do
        }

        private void Checkbox_Validate(object sender, EventArgs e)
        {

        }//end method Checkbox_Validate
        
    }
}
     /*   private KhachHangVO GetKhachHangVO()
        {
            KhachHangVO khachHangVO = new KhachHangVO();
            khachHangVO.MA_KHACH_HANG = int.Parse(txt_MaKhachHang.Text.Substring(2));
            khachHangVO.MA_QUOC_GIA = int.Parse(cbo_QuocGia.SelectedValue.ToString());
            khachHangVO.HO_KHACH_HANG = txt_HoKhachHang.Text;
            khachHangVO.TEN_KHACH_HANG = txt_TenKhachHang.Text;
            khachHangVO.CMND = txt_TenKhachHang.Text;
            khachHangVO.HO_CHIEU = txt_HoChieu.Text;
            khachHangVO.DIEN_THOAI = txt_DienThoai.Text;
            khachHangVO.HIEU_LUC = true;
            return khachHangVO;
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
        }*/