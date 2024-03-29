using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using QLKS.BUS;
using QLKS.VO;

namespace QLKS.UIControl
{
    public partial class CapNhatPhong_UI : DevExpress.XtraEditors.XtraUserControl
    {
    
        private PhongBUS phongBUS;
        private LoaiPhongBUS loaiPhongBUS;
        private TinhTrangBUS tinhTrangBUS;
        private MyUtilities myUtilities;
      

        private bool isAdded = false;
        private bool isModified = false;

        public CapNhatPhong_UI()
        {
            InitializeComponent();
            phongBUS = new PhongBUS();
            loaiPhongBUS = new LoaiPhongBUS();
            tinhTrangBUS = new TinhTrangBUS();
            myUtilities = new MyUtilities();           
        }

        private void CapNhatPhong_UI_Load(object sender, EventArgs e)
        {
            LoadInit();
        }

        private void LoadInit()
        {
            isAdded = false;
            isModified = false;
            UnableTextBox();
            LoadComboBoxLoaiPhong();
            LoadComboBoxTinhTrang();
            LoadGrid();
            myUtilities.EnableSimpleButton(btn_Them, btn_Xoa, btn_Sua, btn_Luu, btn_Huy, true);
            grdCtrl_CapNhatPhong.Enabled = true;
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

        private void UnableTextBox()
        {
            txt_SoPhong.Properties.ReadOnly = true;
            cbo_LoaiPhong.Enabled = false;
            cbo_TinhTrang.Enabled = false;
        }

        private PhongVO GetPhongVO()
        {
            PhongVO phongVO = new PhongVO();
            phongVO.SoPhong = txt_SoPhong.Text;
            phongVO.MaLoaiPhong = Int32.Parse(cbo_LoaiPhong.SelectedValue.ToString());
            phongVO.MaTinhTrang = Int32.Parse(cbo_TinhTrang.SelectedValue.ToString());
            return phongVO;
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

                txt_SoPhong.Text = dtRow[0].ToString();

                cbo_LoaiPhong.SelectedValue = dtRow[1].ToString();
                cbo_TinhTrang.SelectedValue = dtRow[2].ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            isAdded = true;
            cbo_TinhTrang.Enabled = true;
            cbo_LoaiPhong.Enabled = true;
            txt_SoPhong.Text = myUtilities.FormatID(phongBUS.GetNewIndentity().ToString(), "PH");
            grdCtrl_CapNhatPhong.Enabled = false;
            myUtilities.EnableSimpleButton(btn_Them, btn_Xoa, btn_Sua, btn_Luu, btn_Huy, false);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Bạn có muốn xóa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    phongBUS.Delete(GetPhongVO().SoPhong);
                    LoadInit();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
       
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdded)
                {
                    phongBUS.Insert(GetPhongVO());
                }
                if (isModified)
                {
                    phongBUS.Update(GetPhongVO());
                }
                LoadInit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            isModified = true;
            cbo_TinhTrang.Enabled = true;
            cbo_LoaiPhong.Enabled = true;
            myUtilities.EnableSimpleButton(btn_Them, btn_Xoa, btn_Sua, btn_Luu, btn_Huy,false);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            LoadInit();
        }

       

      
 


      
    }
}
