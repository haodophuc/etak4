namespace QLKS_TiepNhanKhach.UI
{
    partial class TraCuuKhachHangUI
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
            this.grdCtrlKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView_KhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCtrlKhachHang
            // 
            this.grdCtrlKhachHang.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.grdCtrlKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlKhachHang.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdCtrlKhachHang.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.grdCtrlKhachHang.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdCtrlKhachHang.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.grdCtrlKhachHang.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdCtrlKhachHang.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.grdCtrlKhachHang.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdCtrlKhachHang.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.grdCtrlKhachHang.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdCtrlKhachHang.Location = new System.Drawing.Point(0, 0);
            this.grdCtrlKhachHang.LookAndFeel.SkinName = "Money Twins";
            this.grdCtrlKhachHang.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdCtrlKhachHang.MainView = this.gridView_KhachHang;
            this.grdCtrlKhachHang.MinimumSize = new System.Drawing.Size(749, 185);
            this.grdCtrlKhachHang.Name = "grdCtrlKhachHang";
            this.grdCtrlKhachHang.Size = new System.Drawing.Size(774, 290);
            this.grdCtrlKhachHang.TabIndex = 18;
            this.grdCtrlKhachHang.UseEmbeddedNavigator = true;
            this.grdCtrlKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_KhachHang,
            this.gridView1});
            // 
            // gridView_KhachHang
            // 
            this.gridView_KhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView_KhachHang.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView_KhachHang.GridControl = this.grdCtrlKhachHang;
            this.gridView_KhachHang.GroupPanelText = "Kéo và thả tên cột để gom nhóm";
            this.gridView_KhachHang.Name = "gridView_KhachHang";
            this.gridView_KhachHang.OptionsBehavior.ReadOnly = true;
            this.gridView_KhachHang.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView_KhachHang.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView_KhachHang.OptionsSelection.MultiSelect = true;
            this.gridView_KhachHang.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView_KhachHang.OptionsView.EnableAppearanceOddRow = true;
            this.gridView_KhachHang.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Mã Khách Hàng";
            this.gridColumn1.FieldName = "MaKH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Mã Quốc Gia";
            this.gridColumn2.FieldName = "MaQG";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Họ Khách Hàng";
            this.gridColumn3.FieldName = "HO_KHACH_HANG";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Tên Khách Hàng";
            this.gridColumn4.FieldName = "TEN_KHACH_HANG";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "CMND";
            this.gridColumn5.FieldName = "CMND";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.Caption = "Hộ Chiếu";
            this.gridColumn6.FieldName = "HO_CHIEU";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.Caption = "Điện Thoại";
            this.gridColumn7.FieldName = "DIEN_THOAI";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCtrlKhachHang;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.grdCtrlKhachHang);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(774, 290);
            this.panelControl1.TabIndex = 46;
            // 
            // TraCuuKhachHangUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelControl1);
            this.Name = "TraCuuKhachHangUI";
            this.Size = new System.Drawing.Size(774, 290);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrlKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_KhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}
