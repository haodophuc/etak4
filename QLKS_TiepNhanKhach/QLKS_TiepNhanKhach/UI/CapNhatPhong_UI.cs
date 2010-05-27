using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using QLKS_TiepNhanKhach.BUS;

namespace QLKS_TiepNhanKhach.UI
{
    public partial class CapNhatPhong_UI : UserControl
    {
    
        private PhongBUS phongBUS;
        private LoaiPhongBUS loaiPhongBUS;
        private TinhTrangBUS tinhTrangBUS;

        public CapNhatPhong_UI()
        {
            InitializeComponent();
            phongBUS = new PhongBUS();
            loaiPhongBUS = new LoaiPhongBUS();
            tinhTrangBUS = new TinhTrangBUS();
        }

        private void CapNhatPhong_UI_Load(object sender, EventArgs e)
        {
            LoadComboBoxLoaiPhong();
            LoadComboBoxTinhTrang();
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                DataTable dTablePhong = new DataTable();
                dTablePhong = phongBUS.GetAll();
                grdCtrl_CapNhatPhong.DataSource = dTablePhong;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxLoaiPhong()
        {
            try
            {
                DataTable dtTableLoaiPhong = new DataTable();
                dtTableLoaiPhong = loaiPhongBUS.GetAll();

                cbo_LoaiPhong.DataSource = dtTableLoaiPhong;
                cbo_LoaiPhong.ValueMember = "MA_LOAI_PHONG";
                cbo_LoaiPhong.DisplayMember = "TEN_LOAI_PHONG";

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxTinhTrang()
        {
            try
            {
                DataTable dtTableTinhTrang = new DataTable();
                dtTableTinhTrang = tinhTrangBUS.GetAll();

                cbo_TinhTrang.DataSource = dtTableTinhTrang;
                cbo_TinhTrang.ValueMember = "MA_TINH_TRANG";
                cbo_TinhTrang.DisplayMember = "TINH_TRANG";

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void grdView_Phong_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                DataRow dtRow;
                dtRow = grdView_Phong.GetFocusedDataRow();

                txt_MaPhong.Text = dtRow[0].ToString();
                txt_SoPhong.Text = dtRow[3].ToString();

                cbo_LoaiPhong.SelectedValue = dtRow[1].ToString();
                cbo_TinhTrang.SelectedValue = dtRow[2].ToString();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
      
       

      
 


      
    }
}
