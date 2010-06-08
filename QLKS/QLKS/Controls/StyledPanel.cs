using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.Controls
{
    class StyledPanel : DevExpress.XtraEditors.PanelControl
    {
       #region Constructors

        public StyledPanel() : base() {
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.SkinName = "Blue";
            this.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
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



    }//end class StyledPanel
}//end namespace
