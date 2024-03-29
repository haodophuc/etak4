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
    public partial class CapNhatPhieuThuDoanKhachUI : DevExpress.XtraEditors.XtraUserControl
    {
        #region Properties
        private PhieuThuDoanKhachBUS phieuThuDoanKhachBUS;
        private DoanKhachBUS doanKhachBUS = new DoanKhachBUS();
        private CaTrucBus catrucBUS = new CaTrucBus();
        private MyUtilities myUtilities = new MyUtilities();

        private bool isAdded = false;
        private bool isModified = false; 
        #endregion

        #region Methods
        public CapNhatPhieuThuDoanKhachUI()
        {
            InitializeComponent();
            phieuThuDoanKhachBUS = new PhieuThuDoanKhachBUS();
            isAdded = false;
            isModified = false;

        }

        private void LoadInit()
        {
            isAdded = false;
            isModified = false;
            UnabledTextbox();
            LoadGrid();
            myUtilities.EnableSimpleButton(bttThem, bttXoa, bttSua, bttLuu, bttHuy, true);
            grdCtrlPhieuThuDoanKhach.Enabled = true;

        }

        private void LoadDoanKhach()
        {

            try
            {
                DataTable dtTableDK = new DataTable();
                dtTableDK = doanKhachBUS.GetMaDKAndTenCT();
                cbo_DoanKhach.DataSource = dtTableDK;
                cbo_DoanKhach.DisplayMember = "MaDK";
                cbo_DoanKhach.ValueMember = "MaDK";
                txt_TenCongTy.DataBindings.Add("Text", dtTableDK, "TEN_CONG_TY");
              


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCatruc()
        {
            DataTable dtTableCaTruc = new DataTable();
            dtTableCaTruc = catrucBUS.GetMaCaTrucAndTenThuNgan();
            cbo_Catruc.DataSource = dtTableCaTruc;
            cbo_Catruc.DisplayMember = "MA_CA_TRUC";
            cbo_Catruc.ValueMember = "MA_CA_TRUC";
            txt_TenThuNgan.DataBindings.Add("Text", dtTableCaTruc, "TEN_THU_NGAN");
        }

        private void LoadGrid()
        {
            try
            {
                DataTable dtTablePhieuThuDK = new DataTable();
                dtTablePhieuThuDK = phieuThuDoanKhachBUS.GetAll();


                grdCtrlPhieuThuDoanKhach.DataSource = dtTablePhieuThuDK;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UnabledTextbox()
        {
            txt_SoPhieu.Properties.ReadOnly = true;
            txt_Sotien.Properties.ReadOnly = true;
            txt_NoiDungThu.Properties.ReadOnly = true;
            txt_HinhThucThu.Properties.ReadOnly = true;
            date_NgayPhieu.Properties.ReadOnly = true;


            cbo_DoanKhach.Enabled = false;
            cbo_Catruc.Enabled = false;

        }
        private PhieuThuDoanKhachVO GetPhieuThuDoanKhachVO()
        {
            PhieuThuDoanKhachVO phieuVO = new PhieuThuDoanKhachVO();
            phieuVO.SO_PHIEU = int.Parse(txt_SoPhieu.Text.Substring(2));
            phieuVO.MA_CA_TRUC = int.Parse(cbo_Catruc.SelectedValue.ToString().Substring(2));
            phieuVO.MA_DOAN_KHACH = int.Parse(cbo_DoanKhach.SelectedValue.ToString().Substring(2));
            phieuVO.NGAY_PHIEU = date_NgayPhieu.DateTime;
            if (txt_Sotien.Text == "")
            {
                txt_Sotien.Text = "0";
            }
            phieuVO.SO_TIEN = Double.Parse(txt_Sotien.Text.ToString());
            phieuVO.NOI_DUNG_THU = txt_NoiDungThu.Text;
            phieuVO.HINH_THUC_THU = txt_HinhThucThu.Text;
            return phieuVO;
        }
        #endregion

        #region EventHandler


        private void CapNhatPhieuThuDoanKhachUI_Load(object sender, EventArgs e)
        {
            LoadDoanKhach();
            LoadCatruc();
            LoadInit();
        }

        private void gridView_PhieuThuDoanKhach_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                DataRow dtrow;
                dtrow = gridView_PhieuThuDoanKhach.GetFocusedDataRow();

                txt_SoPhieu.Text = dtrow[0].ToString();
                date_NgayPhieu.DateTime = DateTime.Parse(dtrow["NGAY_PHIEU"].ToString());
                txt_Sotien.Text = dtrow["SO_TIEN"].ToString();

                txt_HinhThucThu.Text = dtrow["HINH_THUC_THU"].ToString();
                cbo_Catruc.SelectedValue = dtrow["MA_CA_TRUC"].ToString();
                cbo_DoanKhach.SelectedValue = dtrow["MA_DOAN_KHACH"].ToString();
                txt_NoiDungThu.Text = dtrow["NOI_DUNG_THU"].ToString();





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

                txt_Sotien.Properties.ReadOnly = false;
                txt_NoiDungThu.Properties.ReadOnly = false;
                txt_HinhThucThu.Properties.ReadOnly = false;
                date_NgayPhieu.Properties.ReadOnly = false;


                cbo_DoanKhach.Enabled = true;
                cbo_Catruc.Enabled = true;

                txt_SoPhieu.Text = "";
                txt_Sotien.Text = "";
                txt_TenCongTy.Text = "";
                txt_NoiDungThu.Text = "";
                txt_HinhThucThu.Text = "";
                date_NgayPhieu.DateTime = DateTime.Now;

                date_NgayPhieu.Focus();
                txt_SoPhieu.Text = myUtilities.FormatID(phieuThuDoanKhachBUS.GetNewIndentity().ToString(), "PT");

                grdCtrlPhieuThuDoanKhach.Enabled = false;



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
        private void bttSua_Click(object sender, EventArgs e)
        {
            isModified = true;
            myUtilities.EnableSimpleButton(bttThem, bttXoa, bttSua, bttLuu, bttHuy, false);
            txt_Sotien.Properties.ReadOnly = false;
            txt_NoiDungThu.Properties.ReadOnly = false;
            txt_HinhThucThu.Properties.ReadOnly = false;
            date_NgayPhieu.Properties.ReadOnly = false;


            cbo_DoanKhach.Enabled = true;
            cbo_Catruc.Enabled = true;

        }
        private void bttLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdded)
                {
                    isAdded = false;

                    phieuThuDoanKhachBUS.Insert(GetPhieuThuDoanKhachVO());
                }
                if (isModified)
                {
                    isModified = false;
                    phieuThuDoanKhachBUS.Update(GetPhieuThuDoanKhachVO());
                }

                LoadInit();
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
                if (MessageBox.Show(this, "Bạn có muốn xóa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    phieuThuDoanKhachBUS.Delete(GetPhieuThuDoanKhachVO().SO_PHIEU);
                    LoadInit();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

    }
}
