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

        public UIGroupInfoPanel(Mode.SubmitMode mode) : this()
        {
            SubmitMode = mode;
            groupMode = false;
        }//end constructor

       #endregion //end region Constructors


       #region Methods

        private void LoadCheckingControls()
        {
            // Set all textboxes to readonly
            StyledTextBox[] textboxes = GetAllTextBox();
            for (int i = 0; i < textboxes.Length; i++)
            {
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

        public Int32 GetGroupID()
        {
            if (groupMode)
                return groupID;
            else
                return -1;
        }//end method GetData();

        private void LoadData( DataRow row )
        {
            groupID = Int32.Parse(row["MA_DOAN_KHACH"].ToString());
            textBoxGroupID.Text = row["MA_DOAN_KHACH"].ToString();
            textBoxCheckInDay.Text = row["NGAY_DEN"].ToString();
            textBoxCompanyName.Text = row["TEN_CONG_TY"].ToString();
            groupMode = true;
            
        }//end method LoadData

        public bool IsAGroup()
        {
            return groupMode;
        }//end method IsAGroup

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
            MessageBox.Show(GetGroupID().ToString());
        }//end method buttonNewGroup_Click

       #endregion //end region Event Handling Methods


       #region Attributes
        public Mode.SubmitMode SubmitMode
        {
            get { return this.submitMode; }
            set { 
                this.submitMode = value;
                if (SubmitMode == Mode.SubmitMode.CheckIn)
                {
                    LoadCheckingControls();
                }//end if
                else
                {
                    LoadBookingControls();
                }//end else
            }//end method set
        }//end attribute Mode


       #endregion //end region Attributes


       #region Instance Fields
        private Mode.SubmitMode submitMode;
        private Int32 groupID;
        private bool groupMode;
       #endregion Instance Fields



    }//end class UIGroupInfoPanel

}//end namespace
