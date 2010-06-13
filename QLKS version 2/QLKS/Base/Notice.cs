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
        
            MessageBox.Show( error, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error );    
        }//end method ShowError

        public static void ShowWarning(String warning)
        {
            MessageBox.Show(warning, "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
        }//end method ShowWarning

        public static DialogResult ShowConfirm(String question, String title)
        {
            return MessageBox.Show(question, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }//end method ShowConfirm

        #endregion //end region Methods

    }//end class Notice
}//end namespace
