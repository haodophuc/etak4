using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QLKS.Base
{
    public static class Notice
    {
        #region Methods

        public static void ShowError( String error ) {
        
            MessageBox.Show( error, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning );    
        }//end method ShowError

        #endregion //end region Methods

    }//end class Notice
}//end namespace
