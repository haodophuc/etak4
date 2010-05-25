using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace QLKS_TiepNhanKhach
{
  public  class MyUtilities
    {
      public MyUtilities()
        {
        }
      public void VisibleSimpleButton(SimpleButton bttThem, SimpleButton bttXoa, SimpleButton bttSua, SimpleButton bttLuu, SimpleButton bttHuy, bool value)
        {
            bttThem.Enabled = value;
            bttXoa.Enabled = value;
            bttSua.Enabled = value;
            bttLuu.Enabled = !value;
            bttHuy.Enabled = !value;
        
        }
    }
}
