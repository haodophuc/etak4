using System;
using System.Collections.Generic;
using System.Text;


namespace QLKS.Controls
{
    class TextBoxCustomer: StyledTextBox
    {
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit fProperties;
    
        public TextBoxCustomer()
            : base()
        {
            this.Properties.Mask.EditMask = "KH0000";
            this.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.Properties.AutoHeight = false;
        }

        private void InitializeComponent()
        {
            this.fProperties = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // fProperties
            // 
            this.fProperties.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.fProperties.Appearance.Options.UseBorderColor = true;
            this.fProperties.AppearanceFocused.BackColor = System.Drawing.Color.NavajoWhite;
            this.fProperties.AppearanceFocused.Options.UseBackColor = true;
            this.fProperties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.fProperties.AppearanceReadOnly.BorderColor = System.Drawing.Color.DarkGray;
            this.fProperties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Gray;
            this.fProperties.AppearanceReadOnly.Options.UseBackColor = true;
            this.fProperties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.fProperties.AppearanceReadOnly.Options.UseForeColor = true;
            this.fProperties.AutoHeight = false;
            this.fProperties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fProperties.LookAndFeel.SkinName = "Blue";
            this.fProperties.Name = "fProperties";
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).EndInit();
            this.ResumeLayout(false);

        }//end default constructor


    }//end class TextBoxCustomer
}//end namespace 
