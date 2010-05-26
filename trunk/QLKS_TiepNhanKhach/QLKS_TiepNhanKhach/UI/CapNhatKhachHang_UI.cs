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

        #region properties

        private KhachHangBUS khachHangBUS;
        private QuocGiaBUS quocGiaBUS;
        private MyUtilities myUtilities = new MyUtilities();
       
        private bool isAdded = false;
        private bool isModified = false;

        private string[] khachHangInfo;

        #endregion

        #region methods
        public CapNhatKhachHang_UI()
        {
            InitializeComponent();
            khachHangBUS = new KhachHangBUS();
            quocGiaBUS = new QuocGiaBUS();
        }

        private void CapNhatKhachHang_UI_Load(object sender, EventArgs e)
        {
            LoadInit();  
       
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
            txt_MaKhachHang.Enabled = false;
            txt_HoKhachHang.Enabled = false;
            txt_TenKhachHang.Enabled = false;
            txt_SoCMND.Enabled = false;
            txt_HoChieu.Enabled = false;
            txt_DienThoai.Enabled = false;
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

        private string[] GetKhachHangInfo()
        {

            khachHangInfo = new string[7];
            khachHangInfo[0] = (int.Parse(txt_MaKhachHang.Text.Substring(2))).ToString();
            khachHangInfo[1] = cbo_QuocGia.SelectedValue.ToString();
            khachHangInfo[2] = txt_HoKhachHang.Text;
            khachHangInfo[3] = txt_TenKhachHang.Text;
            khachHangInfo[4] = txt_SoCMND.Text;
            khachHangInfo[5] = txt_HoChieu.Text;
            khachHangInfo[6] = txt_DienThoai.Text;
            return khachHangInfo;
        }

       
        #endregion

        #region EventHandler
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
                txt_HoKhachHang.Enabled = true;
                txt_TenKhachHang.Enabled = true;
                txt_SoCMND.Enabled = true;
                txt_HoChieu.Enabled = true;
                txt_DienThoai.Enabled = true;
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
                  int A=  Int32.Parse(GetKhachHangInfo()[0]);
                    khachHangBUS.Delete(Int32.Parse(GetKhachHangInfo()[0]));
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
            txt_HoKhachHang.Enabled = true;
            txt_TenKhachHang.Enabled = true;
            txt_SoCMND.Enabled = true;
            txt_HoChieu.Enabled = true;
            txt_DienThoai.Enabled = true;
            cbo_QuocGia.Enabled = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdded)
                {
                    isAdded = false;
                    khachHangBUS.Insert(GetKhachHangInfo());
                }
                if (isModified)
                {
                    isModified = false;
                    khachHangBUS.Update(GetKhachHangInfo());
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
