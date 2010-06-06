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
          
        public CheckOutUI()
        {
            InitializeComponent();
            LoadComboCongTy();
      
          
                
        }

        private void btt_Search_Click(object sender, EventArgs e)
        {
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
                 
            }
        }

        private void check_KhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (check_KhachHang.Checked == true)
            {
                txt_MaDoanKhach.Text = "";
                cbo_CongTy.Text = "";
                MakeGridNull();
            }
        }

        private void MakeGridNull()
        {
            grdCtrlPhieuThue.DataSource = null;
        }
        private void LoadGridByKhachHang(int maKhachHang)
        {
            grdCtrlPhieuThue.DataSource = phieuTPBUS.GetUnPaidRoomByKhachHang(maKhachHang);
            
        }
        private void LoadGridByDoanKhach(int maDoanKhach)
        {
            grdCtrlPhieuThue.DataSource = phieuTPBUS.GetUnPaidRoomByDoanKhach(maDoanKhach);

        }

        private void gridView_PhieuThuePhongChuaThanhToan_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }
    }
}
