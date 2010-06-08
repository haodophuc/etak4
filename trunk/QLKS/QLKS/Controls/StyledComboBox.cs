using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.Controls
{
    class StyledComboBox : DevExpress.XtraEditors.ComboBoxEdit
    {
       #region Constructors

        public StyledComboBox() : base() {
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



    }//end class
}//end namespace
