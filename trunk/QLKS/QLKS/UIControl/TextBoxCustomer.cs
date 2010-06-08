using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.UIControl
{
    class TextBoxCustomer: DevExpress.XtraEditors.TextEdit
    {
        public TextBoxCustomer()
            : base()
        {
            this.Properties.Mask.EditMask = "KH000#";
            this.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
        }//end default constructor


    }//end class TextBoxCustomer
}//end namespace 
