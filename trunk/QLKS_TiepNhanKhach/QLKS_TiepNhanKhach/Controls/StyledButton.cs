using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS_TiepNhanKhach.Controls
{
    class StyledButton : DevExpress.XtraEditors.SimpleButton
    {
       #region Constructors

        public StyledButton()
            : base()
        {
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = true;
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

    }//end class StyledButton
}//end namespace
