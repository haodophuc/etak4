using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QLKS.UIControl
{
    public partial class UIGeneralInfo : UserControl
    {
       #region Constructors

        public UIGeneralInfo()
        {
            InitializeComponent();

        }//end default constructor

        public UIGeneralInfo( UITransaction parent, Base.Mode.SubmitMode mode) : this()
        {
            ParentUI = parent;
            SubmitMode = mode;
            LoadControls();
        }//end method UIGeneralInfo

       #endregion //end region Constructors


       #region Methods

        private void LoadControls()
        {
            if (SubmitMode == QLKS.Base.Mode.SubmitMode.Booking)
                LoadBookingControls();
            else
                LoadCheckingControls();
        }//end method LoadControls

        private void LoadBookingControls()
        {
            dateCheckIn.DateTime = DateTime.Today;
        }//end method LoadBookingControls()

        private void LoadCheckingControls()
        {
            dateCheckIn.DateTime = DateTime.Today;
            dateCheckIn.Enabled = false;
        }//end method LoadCheckingControls

        public void LoadData()
        {
            if (ParentUI.RegData.Groups.Rows.Count == 0)
                LoadNoGroup();
            else
                LoadGroup();
            //LoadCustomers();
            LoadTime();
        }//end method LoadData


        private void LoadNoGroup()
        {
            string nullText = "Không có dữ liệu";

            labelGroupIDText.Text = nullText;
            labelBookedDayText.Text = nullText;            
            labelDepositText.Text = nullText;

            labelCompanyNameText.Text = nullText;
            labelCompanyAddressText.Text = nullText;
            labelCompanyPhoneText.Text = nullText;            

        }//end method LoadNoGroup

        private void LoadGroup()
        {
            DataRow value = ParentUI.RegData.Groups.Rows[0];

            labelGroupIDText.Text = value["GroupName"].ToString();
            labelBookedDayText.Text = value["CheckInDay"].ToString();
            labelDepositText.Text = String.Empty;

            labelCompanyNameText.Text = value["CompanyName"].ToString();
            labelCompanyAddressText.Text = value["Address"].ToString();
            labelCompanyPhoneText.Text = value["Phone"].ToString();  
        }//end method LoadGroup

        private void LoadTime()
        {

        }//end method LoadTime

       #endregion //end region Methods


       #region Event Handling Methods

       #endregion //end region Event Handling Methods


       #region Attributes

        public UITransaction ParentUI
        {
            get { return parentUI; }
            set { this.parentUI = value; }
        }//end attribute ParentUI

        public Base.Mode.SubmitMode SubmitMode
        {
            get { return submitMode; }
            set { this.submitMode = value; }
        }//end attribute SubmitMode
    
       #endregion //end region Attributes


       #region Instance Fields

        private Base.Mode.SubmitMode submitMode;
        private UITransaction parentUI;

       #endregion Instance Fields


    }//end class UIGeneralInfo
}//end namespace
