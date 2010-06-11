using System;
using System.Collections.Generic;
using System.Text;


namespace QLKS.Controls
{
    class TextBoxCustomer: StyledTextBox
    {
        public TextBoxCustomer()
            : base()
        {
            // Mas Settings
            this.Properties.Mask.EditMask = "KH0000";
            this.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Properties.Mask.SaveLiteral = false;
            this.Properties.Mask.IgnoreMaskBlank = false;

            // Size Settings
            this.Properties.AutoHeight = false;

            // NullText Settings
            this.Properties.NullText = TextBoxCustomer.DefaultNullText;
        }//end default constructor

        public static new String DefaultNullText
        {
            get { return "Mã Khách Hàng sẽ được tạo tự động."; }
        }//end attribute DefaultNullText


    }//end class TextBoxCustomer
}//end namespace 
