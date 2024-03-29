using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.Controls
{
    class StyledTextBox: DevExpress.XtraEditors.TextEdit
    {
       #region Constructors

        public StyledTextBox() : base() {

            this.Properties.AutoHeight = false;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.SkinName = "Blue";

            this.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            
            // Set normal appearance
            this.Properties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;

            // Set focused appearance
            this.Properties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;

            // Set read-only appearance
            this.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;

        }//end default constructor

       #endregion //end region Constructors


       #region Methods

       #endregion //end region Methods


       #region Event Handling Methods

       #endregion //end region Event Handling Methods


       #region Attributes

       #endregion //end region Attributes


       #region Instance Fields

       #endregion Instance Fields



    }//end class StyledTextBox
}//end namespace
