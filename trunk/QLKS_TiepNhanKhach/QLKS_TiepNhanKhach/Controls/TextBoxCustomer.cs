using System;
using System.Collections.Generic;
using System.Text;


namespace QLKS_TiepNhanKhach.Controls
{
    class TextBoxCustomer: StyledTextBox
    {
        public TextBoxCustomer()
            : base()
        {
            this.Properties.Mask.EditMask = "KH0000";
            this.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.Properties.AutoHeight = false;
        }//end default constructor


    }//end class TextBoxCustomer
}//end namespace 
