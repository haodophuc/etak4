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
        DBConnection dbConnection;
        PhongBUS phongBUS;
        LoaiPhongBUS loaiPhongBUS;
        TinhTrangBUS tinhTrangBUS;

        public CapNhatPhong_UI(DBConnection dbConnection)
        {
            InitializeComponent();
            this.dbConnection = dbConnection;
            phongBUS = new PhongBUS(dbConnection);
            loaiPhongBUS = new LoaiPhongBUS(dbConnection);
            tinhTrangBUS = new TinhTrangBUS(dbConnection);
        }

        private void CapNhatPhong_UI_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadComboBox();
        }

        private void LoadGrid()
        {
            try
            {
                DataTable dTablePhong = new DataTable();
                dTablePhong = phongBUS.getAllFromPhong();
                grdCtrl_CapNhatPhong.DataSource = dTablePhong;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBox()
        {
            try
            {
                DataTable dtTableLoaiPhong = new DataTable();
                dtTableLoaiPhong = loaiPhongBUS.getAllFromLoaiPhong();

                cbo_LoaiPhong.DataSource = dtTableLoaiPhong;
                cbo_LoaiPhong.ValueMember = "MA_LOAI_PHONG";
                cbo_LoaiPhong.DisplayMember = "TEN_LOAI_PHONG";

                DataTable dtTableTinhTrang = new DataTable();
                dtTableTinhTrang = tinhTrangBUS.getAll();

                cbo_TinhTrang.DataSource = dtTableTinhTrang;
                cbo_TinhTrang.ValueMember = "MA_TINH_TRANG";
                cbo_TinhTrang.DisplayMember = "TEN_TINH_TRANG";
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
