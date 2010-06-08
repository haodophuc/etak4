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
            SetMode(Mode.Empty);
            AcceptButton = buttonUpdate;
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
            if (service == null) {
                SetMode(Mode.Empty);
            }//end if service is null
            else {
                SetMode(Mode.Active);
                textBoxServiceName.Text = service.Name;
                textBoxServicePrice.Text = service.Price.ToString();
                SetCheckedState(service.State);
            }//end else                

            // Update data
            data = service;
        }//end method SetData

        public ServiceVO GetData()
        {
            Double price;
            try
            {               
                price = Double.Parse(textBoxServicePrice.Text);                
            }//end try
            catch (Exception e)
            {
                if (e is ArgumentNullException || e is FormatException)
                    price = data.Price;
                else
                    throw;
            }//end catch
            String id = data.ID;
            String name = textBoxServiceName.Text;
            bool state = GetCheckedState();
            data = new ServiceVO(id, name, price, state);
            return data;
        }//end method GetData

        private void SetMode( Mode mode )
        {
            // Value to enable/disable controls
            bool enabled = false;

            switch (mode) { 
                case Mode.Empty:
                    enabled = false;
                    textBoxServiceName.Text = "Không có dữ liệu";
                    textBoxServicePrice.Text = "Không có dữ liệu";
                    break;
                case Mode.Active:
                    enabled = true;
                    break;
            }//end switch
            
            textBoxServiceName.Enabled = enabled;
            textBoxServicePrice.Enabled = enabled;

            radioButtonDisable.Enabled = enabled;
            radioButtonEnable.Enabled = enabled;

            buttonUpdate.Enabled = enabled;
            buttonDelete.Enabled = enabled;
            buttonReset.Enabled = enabled;
        }//end method DisableControls

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ParentUI.DeleteService();
        }//end method buttonDelete_Click

       #endregion //end region Event Handling Methods


       #region Attributes
        public UIServicesManagement ParentUI
        {
            get { return parentUI; }
            set { this.parentUI = value; }
        }//end attribute ParentUI

        public Button AcceptButton
        {
            get { return acceptButton; }
            set { this.acceptButton = value; }
        }//end attribute AcceptButton
       #endregion //end region Attributes


       #region Instance Fields
        private ServiceVO data;
        private UIServicesManagement parentUI;
        private Button acceptButton;
        private enum Mode : int { Empty, Active };
       #endregion Instance Fields       

    }//end class UIServicesInputUpdate
}//end namespace QLKS.UIControl
