namespace QLKS_TiepNhanKhach
{
    partial class Form_CapNhatPhong
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
            this.panelControl_Trial = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_Trial)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl_Trial
            // 
            this.panelControl_Trial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_Trial.Location = new System.Drawing.Point(0, 0);
            this.panelControl_Trial.LookAndFeel.SkinName = "iMaginary";
            this.panelControl_Trial.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl_Trial.Name = "panelControl_Trial";
            this.panelControl_Trial.Size = new System.Drawing.Size(559, 322);
            this.panelControl_Trial.TabIndex = 0;
            // 
            // Form_CapNhatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 322);
            this.Controls.Add(this.panelControl_Trial);
            this.Name = "Form_CapNhatPhong";
            this.Text = "Cập Nhật Phòng";
            this.Load += new System.EventHandler(this.Form_CapNhatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_Trial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl_Trial;


    }
}