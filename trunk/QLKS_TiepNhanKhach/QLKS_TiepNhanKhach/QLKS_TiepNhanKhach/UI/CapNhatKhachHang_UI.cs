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
    public partial class CapNhatKhachHang_UI : UserControl
    {
        DBConnection dbConnection;
        KhachHangBUS khachHangBUS;
        QuocGiaBUS quocGiaBUS;
        MyUtilities myUtilities = new MyUtilities();

        bool isAdded = false;
        bool isModified = false;

        public CapNhatKhachHang_UI(DBConnection dbConnection)
        {
            InitializeComponent();
            this.dbConnection = dbConnection;
            khachHangBUS = new KhachHangBUS(dbConnection);
            quocGiaBUS = new QuocGiaBUS(dbConnection);
        }

        private void CapNhatKhachHang_UI_Load(object sender, EventArgs e)
        {
            LoadInit();    
        }

        private void LoadInit()
        {
            UnabledTextbox();
            LoadGird();
            myUtilities.VisibleToolStripButton(bttThem, bttXoa, bttSua, bttLuu, bttHuy, true);
            grdCtrlKhachHang.Visible = true;
        }

        private void UnabledTextbox()
        {
            txt_MaKhachHang.Enabled = false;
            txtHoKhachHang.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtSoCMND.Enabled = false;
            txtHoChieu.Enabled = false;
            txtDienThoai.Enabled = false;
            cboQuocGia.Enabled = false;
        }

        private void LoadGird()
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

        private void LoadKhachHangInFo()
        {
            txt_MaKhachHang.Text = gridView_KhachHang.Columns["MA_KHACH_HANG"].FieldName.ToString();
        }

        private void gridView_KhachHang_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                DataRow dtrow;
                dtrow = gridView_KhachHang.GetFocusedDataRow();

                txt_MaKhachHang.Text = dtrow[0].ToString();
                txtHoKhachHang.Text = dtrow[2].ToString();
                txtTenKhachHang.Text = dtrow[3].ToString();
                txtSoCMND.Text = dtrow[4].ToString();
                txtHoChieu.Text = dtrow[5].ToString();
                txtDienThoai.Text = dtrow[6].ToString();

                DataTable dtTableQG = new DataTable();
                dtTableQG = quocGiaBUS.getAllFromQuocGia();


                cboQuocGia.DataSource = dtTableQG;
                cboQuocGia.DisplayMember = "TEN_QUOC_GIA";
                cboQuocGia.ValueMember = "MA_QUOC_GIA";

                cboQuocGia.SelectedValue = dtrow[1].ToString();
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

                myUtilities.VisibleToolStripButton(bttThem, bttXoa, bttSua, bttLuu, bttHuy, false);
                txtHoKhachHang.Enabled = true;
                txtTenKhachHang.Enabled = true;
                txtSoCMND.Enabled = true;
                txtHoChieu.Enabled = true;
                txtDienThoai.Enabled = true;
                cboQuocGia.Enabled = true;
                txt_MaKhachHang.Text = "";
                txtHoKhachHang.Text = "";
                txtTenKhachHang.Text = "";
                txtSoCMND.Text = "";
                txtHoChieu.Text = "";
                txtDienThoai.Text = "";

                txtHoKhachHang.Focus();
                txt_MaKhachHang.Text = khachHangBUS.GetNewIndentity().ToString();
                grdCtrlKhachHang.Visible = false;
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

        private void bttLuu_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHangVO khachHangVO = GetKhachHangVOFromTextBoxs();
                if (isAdded)
                {
                    isAdded = false;

                    khachHangBUS.Insert(khachHangVO);
                }
                if (isModified)
                {
                    isModified = false;
                    khachHangBUS.Update(khachHangVO);
                }

                LoadInit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private KhachHangVO GetKhachHangVOFromTextBoxs()
        {
            KhachHangVO khachHangVO = new KhachHangVO();
            khachHangVO.MA_KHACH_HANG = Int32.Parse(txt_MaKhachHang.Text);
            khachHangVO.MA_QUOC_GIA = Int32.Parse(cboQuocGia.SelectedValue.ToString());
            khachHangVO.HO_KHACH_HANG = txtHoKhachHang.Text;
            khachHangVO.TEN_KHACH_HANG = txtTenKhachHang.Text;
            khachHangVO.DIEN_THOAI = txtDienThoai.Text;
            khachHangVO.HO_CHIEU = txtHoChieu.Text;
            khachHangVO.CMND = txtSoCMND.Text;
            return khachHangVO;

        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Are you sure", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    KhachHangVO khachHangVO = GetKhachHangVOFromTextBoxs();
                    khachHangBUS.Delete(khachHangVO);
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
            myUtilities.VisibleToolStripButton(bttThem, bttXoa, bttSua, bttLuu, bttHuy, false);
            txtHoKhachHang.Enabled = true;
            txtTenKhachHang.Enabled = true;
            txtSoCMND.Enabled = true;
            txtHoChieu.Enabled = true;
            txtDienThoai.Enabled = true;
            cboQuocGia.Enabled = true;
        }

        
      

    
      

     

  

       

      

     

        
    }
}
