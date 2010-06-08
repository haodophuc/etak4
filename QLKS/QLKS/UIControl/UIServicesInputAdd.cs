using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS.VO;

namespace QLKS.UIControl
{
    public partial class UIServicesInputAdd : UserControl
    {
       #region Construtors

        public UIServicesInputAdd()
        {
            InitializeComponent();
        }//end default constructor

        public UIServicesInputAdd( UIServicesManagement parent ) : this() {
            ParentUI = parent;
            AcceptButton = buttonAdd;
        }//end constructor

      #endregion //end region Constructor


       #region Methods

        public ServiceVO GetData()
        {
            ServiceVO service = null;
            try
            {
                String name = textBoxName.Text;
                Double price = Double.Parse(textBoxPrice.Text);
                service = new ServiceVO(null, name, price, true);
            }//end try
            catch ( FormatException e )
            {
                throw e;
            }//end catch
            return service;
        }//end method GetData

        public void Reset()
        {
            textBoxName.Text = "";
            textBoxPrice.Text = "";
        }//end method Reset

        private void VerifyTextBox() {
            if (!(textBoxName.Text == "" || textBoxPrice.Text == "")) {
                buttonAdd.Enabled = true;
            }//end if both textboxes empty
            else {
                buttonAdd.Enabled = false;
            }//end else
        }//end method VerifyTextBox

       #endregion //end region Methods


       #region Event Handling Methods

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }//end method buttonReset_Click

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ParentUI.InsertService();
            Reset();
        }//end method buttonAdd_Click

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            VerifyTextBox();
        }//end method textBox_TextChanged

       #endregion //end region Event Handling Methods


       #region Attributes

        public ServiceVO Data
        {
            get {  
                try
                {
                    String name = textBoxName.Text;
                    Double price = Double.Parse(textBoxPrice.Text);
                    data = new ServiceVO(null, name, price, true);
                }//end try
                catch (Exception e)
                {
                    throw e;
                }//end catch
                return data;
            }//end method get

            set {
                this.data = value;
                textBoxName.Text = value.Name;
                textBoxPrice.Text = value.Price.ToString();
            }//end method set
        }//end attribute Data

        public UIServicesManagement ParentUI
        {
            get { return parentUI; }
            set { this.parentUI = value; }
        }//end attribute ParentUI

        public Button AcceptButton
        {
            get { return acceptButton; }
            set { acceptButton = value; }
        }//end attribute AcceptButton

       #endregion //end region Attributes


       #region Instance Fields
        private UIServicesManagement parentUI;
        private ServiceVO data;
        private Button acceptButton;
       #endregion //end region Instance Fields


    }// end class ServicesInput
}// end namespace QLKS.UIControl
