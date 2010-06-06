using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS_TiepNhanKhach.Controls
{
    class NumberTextBox : StyledTextBox
    {
       #region Constructors

        public NumberTextBox() : base() {
            this.AllowSpace = false;
            this.Length = 1;
        }//end default constructor

        public NumberTextBox(int length, bool allowSpace) : base() {
            this.Length = length;
            this.AllowSpace = allowSpace;
            this.Properties.Mask.EditMask = GetMask();
            this.Properties.Mask.MaskType = GetMaskType();
        }//end constructor

       #endregion //end region Constructors


       #region Methods

        private void SetMask( String editMask, DevExpress.XtraEditors.Mask.MaskType maskType )
        {
            this.Properties.Mask.EditMask = editMask;
            this.Properties.Mask.MaskType = maskType;
        }//end method SetMask

        private string GetMask()
        {
            if (AllowSpace == true) {
                string mask = "9";

                // Create a "####" string base on the Length
                for (int i = 1; i < length; i++)
                {
                    mask += "9";
                }//end for

                return mask;
            }//end allowing space
            else {
                return "\\d{1," + Length.ToString() + "}";    
            }//end else
        }//end method GetMask

        private DevExpress.XtraEditors.Mask.MaskType GetMaskType()
        {
            if (AllowSpace == true)
                return DevExpress.XtraEditors.Mask.MaskType.Simple;
            else
                return DevExpress.XtraEditors.Mask.MaskType.RegEx;
        }//end method GetMaskType

       #endregion //end region Methods


       #region Event Handling Methods
 
       #endregion //end region Event Handling Methods


       #region Attributes

        // The length of the numberic string
        public int Length { 
            get { return length; }
            set { 
                length = ( value > 0 ) ? value : 1;
                SetMask(GetMask(), GetMaskType());
            }//end method set
        }//end attribute Length

        // Indicate the string can contain spaces or not
        public bool AllowSpace {
            get { return allowSpace; }
            set { allowSpace = value;
            SetMask(GetMask(), GetMaskType());
            }//end method set        
        }//end attribute AllowSpace

       #endregion //end region Attributes


       #region Instance Fields
        private int length;
        private bool allowSpace;
       #endregion Instance Fields

    }//end class NumberTextbox
}//end namespace
