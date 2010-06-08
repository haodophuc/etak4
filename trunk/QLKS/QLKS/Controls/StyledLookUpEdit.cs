using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.Controls
{
    class StyledLookUpEdit : DevExpress.XtraEditors.LookUpEdit
    {
       #region Constructors

        public StyledLookUpEdit() : base() {
            this.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Properties.LookAndFeel.SkinName = "Blue";        
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



    }//end class StyledLookUpEdit
}//end namespace
