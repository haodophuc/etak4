using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.Base;
using QLKS.Controls;
using QLKS.UI;

namespace QLKS.UIControl
{
    public partial class UIGroupInfoPanel : UserControl
    {

       #region Constructors

        public UIGroupInfoPanel()
        {
            InitializeComponent();
        }//end default constructor

        public UIGroupInfoPanel(UITransaction parent, Mode.SubmitMode mode) : this()
        {
            ParentUI = parent;
            SubmitMode = mode;
            groupMode = false;
        }//end constructor

       #endregion //end region Constructors


       #region Methods

        private void LoadControls() {
            bool enabled = ( SubmitMode == Mode.SubmitMode.CheckIn ) ? true : false;

            // Set all textboxes
            StyledTextBox[] textboxes = GetAllTextBox();
            for (int i = 0; i < textboxes.Length; i++)
            {
                textboxes[i].Text = null;
                textboxes[i].Properties.ReadOnly = enabled;
            }//end for

            // Adjust buttons
            //buttonLoadGroup.Enabled = enabled;
            buttonNewGroup.Enabled = !enabled;            
        }//end method LoadControls

        private void LoadCheckingControls()
        {
            // Set all textboxes to readonly
            StyledTextBox[] textboxes = GetAllTextBox();
            for (int i = 0; i < textboxes.Length; i++)
            {
                textboxes[i].Text = null;
                textboxes[i].Properties.ReadOnly = true;
            }//end for

            // Adjust buttons
            buttonLoadGroup.Enabled = true;
            buttonNewGroup.Enabled = false;

        }//end method CheckingControls

        private void LoadBookingControls()
        {
            // Set all textboxes to normal
            StyledTextBox[] textboxes = GetAllTextBox();
            for (int i = 0; i < textboxes.Length; i++)
            {
                textboxes[i].Properties.ReadOnly = false;
            }//end for

            // Adjust buttons
            buttonLoadGroup.Enabled = false;
            buttonNewGroup.Enabled = true;
        }//end method BookingControls

        private StyledTextBox[] GetAllTextBox()
        {
            StyledTextBox[] textboxes = new StyledTextBox[10];
           
            for (int i = 0, j = 0; j < 10; i++)
            {
                if (panelCenter.Controls[i] is StyledTextBox)
                {
                    textboxes[j++] = (StyledTextBox)panelCenter.Controls[i];
                }
            }//end for

            return textboxes;
        }//end method GetAllTextBox

        private void AddGroup( DataRow group, DataRow companydetail)
        {
            // Get new datarow
            DataRow newRow = ParentUI.RegData.Groups.NewRow();

            // Set values for new row
            newRow["GroupID"] = group["MA_DOAN_KHACH"];
            newRow["GroupName"] = textBoxGroupID.Text;
            newRow["CompanyID"] = group["MA_CONG_TY"];
            newRow["CheckInDay"] = group["NGAY_DEN"];
            newRow["CompanyName"] = group["TEN_CONG_TY"];
            newRow["Country"] = companydetail["TEN_QUOC_GIA"];
            newRow["Address"] = companydetail["DIA_CHI"];
            newRow["Phone"] = companydetail["DIEN_THOAI"];
            newRow["Fax"] = companydetail["FAX"];
            newRow["Email"] = companydetail["EMAIL"];
            newRow["AgentName"] = companydetail["HO_KHACH_HANG"].ToString() + " " + companydetail["TEN_KHACH_HANG"].ToString();
            newRow["AgentPhone"] = companydetail["DIEN_THOAI_KHACH_HANG"];

            // Replace the first row with the new row.
            if (ParentUI.RegData.Groups.Rows.Count > 0)
                ParentUI.RegData.Groups.Rows.RemoveAt(0);
            ParentUI.RegData.Groups.Rows.Add(newRow);
        }//end AddGroup

        private void LoadData( DataRow row )
        {
            groupMode = true;
            DataRow detail = null;
            textBoxGroupID.Text = row["MA_DOAN_KHACH"].ToString();
            textBoxCheckInDay.Text = row["NGAY_DEN"].ToString();
            textBoxCompanyName.Text = row["TEN_CONG_TY"].ToString();

            //BUS.DoanKhachBUS util = new QLKS.BUS.DoanKhachBUS();
            //textBoxDeposit.Text = util.GetDeposit((int)row["MA_DOAN_KHACH"]).ToString();

            try {
                int companyid = int.Parse(row["MA_CONG_TY"].ToString());
                BUS.CongtyBus bus = new QLKS.BUS.CongtyBus();
                detail = bus.LoadDetail(companyid);

                textBoxCountry.Text = detail["TEN_QUOC_GIA"].ToString();
                textBoxAddress.Text = detail["DIA_CHI"].ToString();
                textBoxPhone.Text = detail["DIEN_THOAI"].ToString();
                textBoxFax.Text = detail["FAX"].ToString();
                textBoxEmail.Text = detail["EMAIL"].ToString();

                textBoxAgent.Text = detail["HO_KHACH_HANG"].ToString() + " " + detail["TEN_KHACH_HANG"].ToString();
                textBoxAgentPhone.Text = detail["DIEN_THOAI_KHACH_HANG"].ToString();   
            }//end try
            catch( Exception ex ) {
                Notice.ShowError(ex.Message);
            }//end catch

            AddGroup(row, detail);
        }//end method LoadData

        public bool IsAGroup()
        {
            return groupMode;
        }//end method IsAGroup

        public void Reset()
        {
            LoadControls();
        }//end method Reset 

       #endregion //end region Methods


       #region Event Handling Methods

        private void buttonLoadGroup_Click(object sender, EventArgs e)
        {
            Form_TimKiemVaChonDoanKhach findGroup = new Form_TimKiemVaChonDoanKhach();
            DataRow row = findGroup.ShowModal();
            if (row != null)
            {
                LoadData(row);
            }//end if
        }//end method buttonLoadGroup_Click

        private void buttonNewGroup_Click(object sender, EventArgs e)
        {
            Form_CapNhatDoanKhach groupManagement = new Form_CapNhatDoanKhach();
            groupManagement.ShowInTaskbar = false;
            groupManagement.StartPosition = FormStartPosition.CenterParent;
            groupManagement.ShowDialog();
        }//end method buttonNewGroup_Click

       #endregion //end region Event Handling Methods


       #region Attributes

        public Mode.SubmitMode SubmitMode
        {
            get { return this.submitMode; }
            set { 
                this.submitMode = value;
                LoadControls();
            }//end method set
        }//end attribute Mode

        public UITransaction ParentUI
        {
            get { return this.parentUI; }
            set { this.parentUI = value; }
        }//end attribute ParentUI

       #endregion //end region Attributes


       #region Instance Fields
        private Mode.SubmitMode submitMode;
        private bool groupMode;
        private UITransaction parentUI;
       #endregion Instance Fields



    }//end class UIGroupInfoPanel

}//end namespace
