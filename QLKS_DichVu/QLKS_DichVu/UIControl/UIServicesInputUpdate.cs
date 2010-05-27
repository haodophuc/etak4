using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QLKS_DichVu.VO;

namespace QLKS_DichVu.UIControl
{
    public partial class UIServicesInputUpdate : UserControl
    {
       #region Constructors

        public UIServicesInputUpdate()
        {
            InitializeComponent();
        }//end default constructor

        public UIServicesInputUpdate(UIServicesManagement parent): this()
        {
            ParentUI = parent;
        }//end constructor
       #endregion //end region Constructors


       #region Methods

        public void Reset()
        {
            SetData(data);
        }//end method Reset

        private void VerifyTextBox()
        {
            if (!(textBoxServiceName.Text == "" || textBoxServicePrice.Text == ""))
            {
                buttonUpdate.Enabled = true;
            }//end if both textboxes empty
            else
            {
                buttonUpdate.Enabled = false;
            }//end else
        }//end method VerifyTextBox

        private bool GetCheckedState()
        {
            if (radioButtonDisable.Checked == true)
                return false;
            else
                return true;
        }//end method CheckedState

        private void SetCheckedState(bool value) {
            if (value == true)
                radioButtonEnable.Checked = true;
            else
                radioButtonDisable.Checked = true;
        }//end method SetCheckedState

        public void SetData(ServiceVO service)
        {
            textBoxServiceName.Text = service.Name;
            textBoxServicePrice.Text = service.Price.ToString();
            SetCheckedState(service.State);

            // Enable buttons
            if (data == null)
            {
                buttonDelete.Enabled = true;
                buttonReset.Enabled = true;
            }//end if 

            data = service;
        }//end method SetData

        public ServiceVO GetData()
        {
            try
            {
                String id = data.ID;
                String name = textBoxServiceName.Text;
                Double price = Double.Parse(textBoxServicePrice.Text);
                bool state = GetCheckedState();
                data = new ServiceVO(id, name, price, state);
                return data;
            }//end try
            catch (Exception e)
            {
                throw e;
            }//end catch
        }//end method GetData

       #endregion //end region Methods


       #region Event Handling Methods

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }//end method buttonReset_Click

        private void textBox_Changed(object sender, EventArgs e) {
            VerifyTextBox();
        }//end method textBox_Changed

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ParentUI.UpdateService();
        }//end method buttonUpdate_Click

       #endregion //end region Event Handling Methods


       #region Attributes
        public UIServicesManagement ParentUI
        {
            get { return parentUI; }
            set { this.parentUI = value; }
        }//end attribute ParentUI
       #endregion //end region Attributes


       #region Instance Fields
        private ServiceVO data;
        private UIServicesManagement parentUI;
       #endregion Instance Fields       



    }//end class UIServicesInputUpdate
}//end namespace QLKS_DichVu.UIControl
