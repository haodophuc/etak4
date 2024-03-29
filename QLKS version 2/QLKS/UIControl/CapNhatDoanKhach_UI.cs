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
    public partial class CapNhatDoanKhach_UI : DevExpress.XtraEditors.XtraUserControl
    {
        #region Properties
        private CongtyBus congtyBUS;
        private DoanKhachBUS doankhachBUS;
        private MyUtilities myUtilities = new MyUtilities();
        private bool isAdded = false;
        private bool isModified = false;

        public CapNhatDoanKhach_UI()
        {
            InitializeComponent();
            congtyBUS = new CongtyBus();
            doankhachBUS = new DoanKhachBUS();

        }
        #endregion

        #region methods

        private void CapNhatDoanKhach_Load(object sender, EventArgs e)
        {
            LoadCongTyInFo();
            LoadInit();
          
        }
        private void LoadInit()
        {
            isAdded = false;
            isModified = false;
            UnabledTextbox();

            LoadGrid();
            myUtilities.EnableSimpleButton(bttThem, bttXoa, bttSua, bttLuu, bttHuy, true);
            grdCtrlDoanKhach.Enabled = true;
        }
        private void UnabledTextbox()
        {
            txt_MaDoanKhach.Properties.ReadOnly = true;
            date_NgayDen.Properties.ReadOnly = true;
         
            cbo_MaCongTy.Enabled = false;
          

        }


        private void LoadCongTyInFo()
        {
            DataTable dtTableCongty = new DataTable();
            dtTableCongty = congtyBUS.GetAll();


            cbo_MaCongTy.DataSource = dtTableCongty;
            cbo_MaCongTy.ValueMember = "MaCT";
            cbo_MaCongTy.DisplayMember = "MaCT";

            txt_TenCongTy.DataBindings.Add("Text", dtTableCongty, "TEN_CONG_TY");
            txt_SoTaiKhoan.DataBindings.Add("Text", dtTableCongty, "SO_TAI_KHOAN");
            txt_MaSoThue.DataBindings.Add("Text", dtTableCongty, "MA_SO_THUE");
            
        }

        private void LoadGrid()
        {
            try
            {
                DataTable dtTableDK = new DataTable();
                dtTableDK = doankhachBUS.GetAll();

                grdCtrlDoanKhach.DataSource = dtTableDK;
              
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


        }

   

        private DoanKhachVO GetDoanKhachVO()
        {
            DoanKhachVO doankhachVO = new DoanKhachVO();
            doankhachVO.MA_DOAN_KHACH= int.Parse(txt_MaDoanKhach.Text.Substring(2));
            doankhachVO.MA_CONG_TY = int.Parse(cbo_MaCongTy.SelectedValue.ToString().Substring(2));
          
            doankhachVO.NGAY_DEN = DateTime.ParseExact(date_NgayDen.Text, "dd/MM/yyyy hh:mm:ss tt",null);
     
            doankhachVO.HIEU_LUC = true;
            return doankhachVO;
        }

#endregion

        #region EventHandler
        private void gridView_DoanKhach_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataRow dtrow;
            dtrow = gridView_DoanKhach.GetFocusedDataRow();

            txt_MaDoanKhach.Text = dtrow[0].ToString();
            date_NgayDen.Text = dtrow[2].ToString();

            cbo_MaCongTy.SelectedValue = dtrow[1].ToString();

        }
        private void bttThem_Click(object sender, EventArgs e)
        {
            try
            {
                isAdded = true;

                myUtilities.EnableSimpleButton(bttThem, bttXoa, bttSua, bttLuu, bttHuy, false);

                date_NgayDen.Properties.ReadOnly = false;

                cbo_MaCongTy.Enabled = true;

                date_NgayDen.Text = System.DateTime.Now.ToString();

                date_NgayDen.Focus();
                txt_MaDoanKhach.Text = myUtilities.FormatID(doankhachBUS.GetNewIndentity().ToString(), "DK");

                grdCtrlDoanKhach.Enabled = false;
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
                    doankhachBUS.Delete(GetDoanKhachVO().MA_DOAN_KHACH);
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
            date_NgayDen.Properties.ReadOnly = false;


            cbo_MaCongTy.Enabled = true;

        }
  
        private void bttLuu_Click(object sender, EventArgs e)
        {

            try
            {
                if (isAdded)
                {
                    isAdded = false;

                    doankhachBUS.Insert(GetDoanKhachVO());
                }
                if (isModified)
                {
                    isModified = false;
                    doankhachBUS.Update(GetDoanKhachVO());
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
