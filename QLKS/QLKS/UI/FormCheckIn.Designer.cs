namespace QLKS.UI
{
    partial class FormCheckIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMainContainer = new QLKS.Controls.StyledPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelMainContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMainContainer.LookAndFeel.SkinName = "Blue";
            this.panelMainContainer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(375, 268);
            this.panelMainContainer.TabIndex = 0;
            // 
            // FormCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 268);
            this.Controls.Add(this.panelMainContainer);
            this.Name = "FormCheckIn";
            this.Text = "Quản Lý Khách Sạn - Đăng Ký Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.panelMainContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLKS.Controls.StyledPanel panelMainContainer;
    }
}