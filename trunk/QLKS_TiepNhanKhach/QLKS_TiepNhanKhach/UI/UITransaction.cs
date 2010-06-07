using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS_TiepNhanKhach.Base;

namespace QLKS_TiepNhanKhach.UI
{
    public partial class UITransaction : UserControl
    {
       #region Constructors
        
        public UITransaction()
        {
            InitializeComponent();

            LoadControls();
        }//end default constructor

       #endregion //end region Constructors


       #region Methods

        private void LoadControls()
        {
            UIRoomInfoPanel roomInfo = new UIRoomInfoPanel( Mode.SubmitMode.CheckIn);
            roomInfo.Dock = DockStyle.Fill;
            tabPageRoom.Controls.Add( roomInfo );

            UIGroupInfoPanel groupInfo = new UIGroupInfoPanel(Mode.SubmitMode.CheckIn);
            groupInfo.Dock = DockStyle.Fill;
            tabPageGroup.Controls.Add(groupInfo);

        }//end method LoadControls


       #endregion //end region Methods


       #region Event Handling Methods

       #endregion //end region Event Handling Methods


       #region Attributes

       #endregion //end region Attributes


       #region Instance Fields

       #endregion Instance Fields


    }//end class UITransaction
}//end namespace
