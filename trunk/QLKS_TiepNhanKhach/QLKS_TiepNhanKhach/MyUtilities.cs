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
      public void EnableSimpleButton(SimpleButton bttThem, SimpleButton bttXoa, SimpleButton bttSua, SimpleButton bttLuu, SimpleButton bttHuy, bool value)
        {
            bttThem.Enabled = value;
            bttXoa.Enabled = value;
            bttSua.Enabled = value;
            bttLuu.Enabled = !value;
            bttHuy.Enabled = !value;
        
        }

      public string FormatID(string id, string type)
      {
          string result = "";
          int num = Int32.Parse(id);
          if (num < 10)
          {
              result = "000";
          }
          else if (num < 100)
          {
              result = "00";
          }
          else if (num < 1000)
          {
              result = "0";
          }
          return result = type + result + id;
      }
    }
}
