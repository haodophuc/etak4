using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.Base.Interfaces;

namespace QLKS.UIControl
{
    public partial class UIRegData : UserControl
    {
       #region Constructors

        public UIRegData()
        {
            InitializeComponent();

            // default submitmode is Checking
            submitMode = new Base.SubmitChecking();


        }//end default constructor

       #endregion //end region Constructors


       #region Methods

        public void SubmitData()
        {
            SubmitMode.Submit( new DataSet() );
        }//end method SubmitData

       #endregion //end region Methods


       #region Event Handling Methods

       #endregion //end region Event Handling Methods


       #region Attributes

        public IDataSubmit SubmitMode
        {
            get { return submitMode; }
            set { this.submitMode = value; }
        }//end attribute SubmitMode

        public UIGroupInfoPanel PanelGroup
        {
            get { return panelGroup; }
            set { this.panelGroup = value; }
        }//end attribute PanelGroup

        public UICustomerInfoPanel PanelCustomer 
        {
            get { return panelCustomer; }
            set { this.panelCustomer = value; }

        }//end attribute PanelCustomer

        public UIRoomInfoPanel PanelRoom
        {
            get { return panelRoom; }
            set { this.panelRoom = value; }
        }//end attribute PanelRoom

       #endregion //end region Attributes


       #region Instance Fields
        private IDataSubmit submitMode;

        private UIGroupInfoPanel panelGroup;
        private UICustomerInfoPanel panelCustomer;
        private UIRoomInfoPanel panelRoom;
       #endregion Instance Fields

    }//end class UIRegData
}//end namespace
