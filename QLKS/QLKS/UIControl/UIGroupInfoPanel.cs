using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.Base;
using QLKS.Controls;

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
            StyledTextBox[] textboxes = new StyledTextBox[11];
           
            for (int i = 0, j = 0; j < 11; i++)
            {
                if (groupControl.Controls[i] is StyledTextBox)
                {
                    textboxes[j++] = (StyledTextBox)groupControl.Controls[i];
                }
            }//end for

            return textboxes;
        }//end method GetAllTextBox

       #endregion //end region Methods


       #region Event Handling Methods

        private void buttonLoadGroup_Click(object sender, EventArgs e)
        {

        }//end method buttonLoadGroup_Click

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

       #endregion Instance Fields

        private void styledButton1_Click(object sender, EventArgs e)
        {
            if (SubmitMode == Mode.SubmitMode.Booking)
                SubmitMode = Mode.SubmitMode.CheckIn;
            else
                SubmitMode = Mode.SubmitMode.Booking;
        }




    }//end class UIGroupInfoPanel
}//end namespace
