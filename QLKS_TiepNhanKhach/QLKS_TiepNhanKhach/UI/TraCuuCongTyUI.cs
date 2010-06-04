using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS_TiepNhanKhach.BUS;
using QLKS_TiepNhanKhach.VO;
using DevExpress.XtraEditors;

namespace QLKS_TiepNhanKhach.UI
{
    public partial class TraCuuCongTyUI : UserControl
    {
        CongtyBus congtyBUS = new CongtyBus();
        QuocGiaBUS quocGiaBUS = new QuocGiaBUS();
        public TraCuuCongTyUI()
        {
            InitializeComponent();
            LoadComboBoxQuocGia();
        }

        private void btt_Cancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.Dispose();
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

        private void btt_Search_Click(object sender, EventArgs e)
        {

            try
            {
                CongtyVO congtyVO = GetCongtyVO();
                DataTable dtTable = new DataTable();
               dtTable= congtyBUS.GetCongTyByIndicator(congtyVO, chk_MaCT.Checked, chk_MaQG.Checked, chk_MaNDD.Checked, chk_TenCongTy.Checked, chk_DiaChi.Checked, chk_DienThoai.Checked, chk_Email.Checked, chk_Fax.Checked, chk_SoTaiKhoan.Checked, chk_MaSoThue.Checked);

                if (dtTable.Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy Công Ty");
                grdCtrlCongTy.DataSource = dtTable;
            }//end try
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch

        }
        private CongtyVO GetCongtyVO()
        {
            int idCT = 0;
            int idNDD = 0; 
            try
            {
                idCT = int.Parse(txt_MaCongTy.Text.Substring(2));
                idNDD = int.Parse(txt_MaNDD.Text.Substring(2));
            }//end try
            catch (Exception e)
            {
                if (e is FormatException)
                    throw new FormatException("Nhập sai Mã Công Ty", e);
            }//end catch
            try
            {
            
                idNDD = int.Parse(txt_MaNDD.Text.Substring(2));
            }//end try
            catch (Exception e)
            {
                if (e is FormatException)
                    throw new FormatException("Nhập sai Mã Người Đại Diện", e);
            }//end catch
            CongtyVO congtyVO = new CongtyVO();
            congtyVO.MA_CONG_TY = idCT;
            congtyVO.MA_NGUOI_DAI_DIEN = idNDD;
            congtyVO.MA_QUOC_GIA = int.Parse(cbo_QuocGia.SelectedValue.ToString());
            congtyVO.TEN_CONG_TY= txt_TenCongTy.Text;
            congtyVO.DIA_CHI = txt_DiaChi.Text;
            congtyVO.DIEN_THOAI = txt_DienThoai.Text;
            congtyVO.EMAIL = txt_Email.Text;
            congtyVO.FAX = txt_Fax.Text;
            congtyVO.SO_TAI_KHOAN = txt_SoTaiKhoan.Text;
            congtyVO.MA_SO_THUE = txt_MaSoThue.Text;
            congtyVO.HIEU_LUC = true;
            return congtyVO;
        }

       

      
    }
}
