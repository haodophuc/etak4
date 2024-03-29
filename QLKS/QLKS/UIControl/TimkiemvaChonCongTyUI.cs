using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.BUS;
using QLKS.VO;
using DevExpress.XtraEditors;

namespace QLKS.UIControl
{
    public partial class TimkiemvaChonCongTyUI : UserControl
    {
        CongtyBus congtyBUS = new CongtyBus();
       
        public TimkiemvaChonCongTyUI()
        {
            InitializeComponent();
            grdCtrlCongTy.DataSource = congtyBUS.GetAll();
        }

        private void btt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
  

      
        private void btt_Select_Click(object sender, EventArgs e)
        {
            if (gridView_CongTy.RowCount != 0)
            {
                Form_TimKiemVaChonCongTy.dtRow = gridView_CongTy.GetFocusedDataRow();

                Close();
            }

        }
        private void Close()
        {
            this.ParentForm.Dispose();
        }

       

      
    }
}
/*
 * public partial class TimkiemvaChonDoanKhachUI : UserControl
    {
        private DoanKhachVO doankhachVO = new DoanKhachVO();
        private DoanKhachBUS doankhachBUS = new DoanKhachBUS();
        public TimkiemvaChonDoanKhachUI()
        {
            InitializeComponent();
            date_NgayDen.DateTime = System.DateTime.Today;
        }

        private void btt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btt_Search_Click(object sender, EventArgs e)
        {
            try
            {
                DoanKhachVO doankhachVO = GetDoanKhachVO();
                DataTable dtTable = new DataTable();
                dtTable = doankhachBUS.GetDoanKhachByIndicator(doankhachVO, chk_MaDoanKhach.Checked, chk_MaCT.Checked, chk_NgayDen.Checked);

                if (dtTable.Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy đoàn khách");
                grdCtrlDoanKhach.DataSource = dtTable;
            }//end try
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch
        }
        private DoanKhachVO GetDoanKhachVO()
        {
            int idDK = 0;
            int idCT = 0;
            try
            {
                idCT = int.Parse(txt_MaCongty.Text.Substring(2));

            }//end try
            catch (Exception e)
            {
                if (e is FormatException)
                    throw new FormatException("Nhập sai Mã Công Ty", e);
            }//end catch
            try
            {

                idDK = int.Parse(txt_MaDoanKhach.Text.Substring(2));
            }//end try
            catch (Exception e)
            {
                if (e is FormatException)
                    throw new FormatException("Nhập sai Mã Công Ty", e);
            }//end catch
            DoanKhachVO doankhachVO = new DoanKhachVO();
            doankhachVO.MA_DOAN_KHACH = idDK;
            doankhachVO.MA_CONG_TY = idCT;
            doankhachVO.NGAY_DEN = date_NgayDen.DateTime;
           // doankhachVO.NGAY_DEN = DateTime.ParseExact(date_NgayDen.Text, "dd/MM/yyyy hh:mm:ss tt", null);
          doankhachVO.HIEU_LUC = true;
            return doankhachVO;
        }

        private void btt_Select_Click(object sender, EventArgs e)
        {
            if (gridView_DoanKhach.RowCount != 0)
            {
                Form_TimKiemVaChonDoanKhach.dtRow = gridView_DoanKhach.GetFocusedDataRow();

                Close();
            }
       
        }
        private void Close()
        {
            this.ParentForm.Dispose();
        }
    }
}
 */