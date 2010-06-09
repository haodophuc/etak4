using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.Base.Interfaces;
using QLKS.UIControl;

namespace QLKS.UIControl
{
    public partial class UIRegData : DevExpress.XtraEditors.XtraUserControl
    {
       #region Constructors

        public UIRegData()
        {
            InitializeComponent();

            // Set default submitmode is Checking
            submitMode = new Base.SubmitChecking();

            // Contruct register data
            RegDataSource = new Base.RegData();

        }//end default constructor

       #endregion //end region Constructors


       #region Methods

        public void SubmitData()
        {
            SubmitMode.Submit( new DataSet() );
        }//end method SubmitData

        public void SwitchPanel(PaneInfo panel)
        {
            switch (panel) { 
                case PaneInfo.CustomerPanel:
                    LoadPanelCustomer();
                    break;

                case PaneInfo.RoomPanel:
                    LoadPanelRoom();
                    break;            
            }//end switch
        }//end method SwitchPanel

        private void LoadPanelCustomer()
        {
            gridControl.DataSource = RegDataSource.Customers;
        }//end method LoadPanelCustomer

        private void LoadPanelRoom()
        {
            gridControl.DataSource = RegDataSource.Rooms;
        }//end method LoadPanelRoom

       #endregion //end region Methods


       #region Event Handling Methods

       #endregion //end region Event Handling Methods


       #region Attributes

        public enum PaneInfo { CustomerPanel, RoomPanel };


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

        public Base.RegData RegDataSource
        {
            get { return regDataSource; }
            set { this.regDataSource = value; }
        }//end attribute DataSource

       #endregion //end region Attributes


       #region Instance Fields
        private IDataSubmit submitMode;

        private Base.RegData regDataSource;

        private UIGroupInfoPanel panelGroup;
        private UICustomerInfoPanel panelCustomer;
        private UIRoomInfoPanel panelRoom;
       #endregion Instance Fields

    }//end class UIRegData
}//end namespace
