using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;

namespace QLKS
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


      public static String encrypt(String str)
      {
          ////////////// encrypt password //////////////////////////
          Byte[] rawBytes = Encoding.UTF8.GetBytes(str);
          MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
          Byte[] hashedBytes = md5.ComputeHash(rawBytes);

          StringBuilder sb = new StringBuilder();
          for (int i = 0; i < hashedBytes.Length; ++i)
              sb.Append(hashedBytes[i]);

          return sb.ToString();
      }
    }
}
