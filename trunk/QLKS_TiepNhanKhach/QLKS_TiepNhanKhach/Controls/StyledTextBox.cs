using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS_TiepNhanKhach.Controls
{
    class StyledTextBox: DevExpress.XtraEditors.TextEdit
    {
       #region Constructors

        public StyledTextBox() : base() {
            this.Properties.AutoHeight = false;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.SkinName = "Blue";
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
