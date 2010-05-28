using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QLKS_DichVu.UIControl
{
    class NumberTextBox : System.Windows.Forms.TextBox
    {
       #region Constructors

        public NumberTextBox()
            : base()
        {
            ShortcutsEnabled = false;
        }//default constructor

       #endregion //end region Constructors


       #region Methods

       #endregion //end region Methods


       #region Event Handling Methods

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            nonNumbericKey = false;
            // Determine whether the keystroke is a number from the top of the keyboard
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumbericKey = true;
                    }//end if key is backspace
                }//end if key is on numpad
            }//end if normal number key

            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumbericKey = true;
            }//end if Shift is pressed
        }//end overriden method OnKeyDown

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = nonNumbericKey;
        }//end overriden method OnKeyPressed

       #endregion //end region Event Handling Methods


       #region Attributes

       #endregion //end region Attributes


       #region Instance Fields
        private bool nonNumbericKey = false;
       #endregion //end region Instance Fields

    }//end class NumberTextBox
}//end method
