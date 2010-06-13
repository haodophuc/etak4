using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.Base;

namespace QLKS.UIControl
{
    public partial class UITransaction : DevExpress.XtraEditors.XtraUserControl
    {
       #region Constructors
        
        public UITransaction()
        {
            InitializeComponent();

            // Prepare all data;
            RegData = new RegData();
            
        }//end default constructor

        public UITransaction(Mode.SubmitMode mode) : this()
        {
            SubmitMode = mode;
            LoadControls();
        }//end constructor

       #endregion //end region Constructors


       #region Methods

        private void LoadControls()
        {
            generalInfo = new UIGeneralInfo( this, this.SubmitMode);
            generalInfo.Dock = DockStyle.Fill;
            tabPageGeneral.Controls.Add(generalInfo);
            // bring back to z-order 0;
            generalInfo.BringToFront();
          

            roomInfo = new UIRoomInfoPanel( this, this.SubmitMode );
            roomInfo.Dock = DockStyle.Fill;
            tabPageRoom.Controls.Add( roomInfo );

            groupInfo = new UIGroupInfoPanel(this, this.SubmitMode);
            groupInfo.Dock = DockStyle.Fill;
            tabPageGroup.Controls.Add(groupInfo);

            customerInfo = new UICustomerInfoPanel(this);
            customerInfo.Dock = DockStyle.Fill;
            tabPageCustomer.Controls.Add(customerInfo);

            if (SubmitMode == Mode.SubmitMode.Booking)
                LoadBookingControls();
            else
                LoadCheckInControls();
            
        }//end method LoadControls

        private void LoadCheckInControls()
        {
            buttonBooking.Enabled = false;
        }//end method LoadCheckInControls

        private void LoadBookingControls()
        {
            buttonCheckIn.Enabled = false;
        }//end method LoadBookingControls

        public void Submit()
        {

            if (SubmitMode == Mode.SubmitMode.CheckIn)
                SubmitCheckIn();
            else
                SubmitBooking();

        }//end method Submit

        private void SubmitCheckIn()
        {
            try {
                RegData.SubmitCheckIn();
                DialogResult result = Notice.ShowConfirm("Đăng ký phòng thành công. Tiếp tục đăng ký?", "Đăng Ký Thành Công");
                if (result == DialogResult.Yes)
                    Reset();
                else
                    ParentForm.Close();
            }//end try
            catch(Exception ex) {
                Notice.ShowError(ex.Message);
                return;
            }//end catch
        }//end method SubmitCheckIn

        private void SubmitBooking()
        {
            try
            {
                RegData.SubmitBooking();
                DialogResult result = Notice.ShowConfirm("Đăng ký đặt phòng thành công. Tiếp tục đăng ký?", "Đăng Ký Thành Công");
                if (result == DialogResult.Yes)
                    Reset();
                else
                    ParentForm.Close();
            }//end try
            catch (Exception ex)
            {
                Notice.ShowError(ex.Message);
                return;
            }//end catch
        }//end method SubmitBooking

        private void Reset() 
        {
            this.RegData.Reset();

            generalInfo.Reset();
            groupInfo.Reset();
            customerInfo.Reset();
            roomInfo.Reset();
        }//end method Reset

       #endregion //end region Methods


       #region Event Handling Methods

        private void tabContainer_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == tabPageGeneral)
                generalInfo.LoadData();
        }//end method tabContainer_SelectedPageChanged

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                RegData.VerifyData();
                SubmitCheckIn();
            }//end try
            catch (Exception ex)
            {
                Notice.ShowError(ex.Message);
            }//end catch
        }//end method buttonCheckIn_Click

       #endregion //end region Event Handling Methods


       #region Attributes

        public RegData RegData
        {
            get { return regData; }
            set { this.regData = value; }
        }//end attribute RegData

        public Mode.SubmitMode SubmitMode
        {
            get { return this.submitMode; }
            set { this.submitMode = value; }
        }//end attribute SubmitMode

       #endregion //end region Attributes


       #region Instance Fields

        private Mode.SubmitMode submitMode;

        private UIGroupInfoPanel groupInfo;
        private UIRoomInfoPanel roomInfo;
        private UICustomerInfoPanel customerInfo;
        private UIGeneralInfo generalInfo;

        private RegData regData;
       #endregion Instance Fields

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }//end method buttonCancel_Click


    }//end class UITransaction
}//end namespace
