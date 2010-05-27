namespace QLKS_DichVu.UI
{
    partial class ServicesManagementForm
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
            this.SuspendLayout();
            // 
            // ServicesManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(572, 607);
            this.MinimumSize = new System.Drawing.Size(580, 639);
            this.Name = "ServicesManagementForm";
            this.Text = "Quản Lý Dịch Vụ";
            this.Load += new System.EventHandler(this.ServicesManagementForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServicesManagementForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

    }
}