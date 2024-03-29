namespace QLKS.UIControl
{
    partial class TimKiemVaChonPhongTrong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdCtrl_CapNhatPhong = new DevExpress.XtraGrid.GridControl();
            this.grdView_Phong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrl_CapNhatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView_Phong)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCtrl_CapNhatPhong
            // 
            this.grdCtrl_CapNhatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrl_CapNhatPhong.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.grdCtrl_CapNhatPhong.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdCtrl_CapNhatPhong.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.grdCtrl_CapNhatPhong.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdCtrl_CapNhatPhong.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.grdCtrl_CapNhatPhong.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdCtrl_CapNhatPhong.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.grdCtrl_CapNhatPhong.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdCtrl_CapNhatPhong.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.grdCtrl_CapNhatPhong.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdCtrl_CapNhatPhong.Location = new System.Drawing.Point(0, 0);
            this.grdCtrl_CapNhatPhong.LookAndFeel.SkinName = "Money Twins";
            this.grdCtrl_CapNhatPhong.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdCtrl_CapNhatPhong.MainView = this.grdView_Phong;
            this.grdCtrl_CapNhatPhong.Name = "grdCtrl_CapNhatPhong";
            this.grdCtrl_CapNhatPhong.Size = new System.Drawing.Size(586, 440);
            this.grdCtrl_CapNhatPhong.TabIndex = 17;
            this.grdCtrl_CapNhatPhong.UseEmbeddedNavigator = true;
            this.grdCtrl_CapNhatPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdView_Phong});
            // 
            // grdView_Phong
            // 
            this.grdView_Phong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.grdView_Phong.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdView_Phong.GridControl = this.grdCtrl_CapNhatPhong;
            this.grdView_Phong.GroupPanelText = "Kéo và thả tên cột để gom nhóm";
            this.grdView_Phong.Name = "grdView_Phong";
            this.grdView_Phong.OptionsSelection.MultiSelect = true;
            this.grdView_Phong.OptionsView.EnableAppearanceEvenRow = true;
            this.grdView_Phong.OptionsView.EnableAppearanceOddRow = true;
            this.grdView_Phong.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Số Phòng";
            this.gridColumn1.FieldName = "SO_PHONG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Mã Loại Phòng";
            this.gridColumn2.FieldName = "MA_LOAI_PHONG";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // TimKiemVaChonPhongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdCtrl_CapNhatPhong);
            this.Name = "TimKiemVaChonPhongTrong";
            this.Size = new System.Drawing.Size(586, 440);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrl_CapNhatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView_Phong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrl_CapNhatPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView grdView_Phong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}
