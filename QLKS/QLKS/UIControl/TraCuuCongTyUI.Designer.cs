namespace QLKS.UIControl
{
    partial class TraCuuCongTyUI
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
            this.grdCtrlCongTy = new DevExpress.XtraGrid.GridControl();
            this.gridView_CongTy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlCongTy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CongTy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCtrlCongTy
            // 
            this.grdCtrlCongTy.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.grdCtrlCongTy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlCongTy.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdCtrlCongTy.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.grdCtrlCongTy.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdCtrlCongTy.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.grdCtrlCongTy.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdCtrlCongTy.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.grdCtrlCongTy.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdCtrlCongTy.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.grdCtrlCongTy.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdCtrlCongTy.Location = new System.Drawing.Point(0, 0);
            this.grdCtrlCongTy.LookAndFeel.SkinName = "Money Twins";
            this.grdCtrlCongTy.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdCtrlCongTy.MainView = this.gridView_CongTy;
            this.grdCtrlCongTy.MinimumSize = new System.Drawing.Size(749, 185);
            this.grdCtrlCongTy.Name = "grdCtrlCongTy";
            this.grdCtrlCongTy.Size = new System.Drawing.Size(797, 257);
            this.grdCtrlCongTy.TabIndex = 18;
            this.grdCtrlCongTy.UseEmbeddedNavigator = true;
            this.grdCtrlCongTy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_CongTy});
            // 
            // gridView_CongTy
            // 
            this.gridView_CongTy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridView_CongTy.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView_CongTy.GridControl = this.grdCtrlCongTy;
            this.gridView_CongTy.GroupPanelText = "Kéo và thả tên cột để gom nhóm";
            this.gridView_CongTy.Name = "gridView_CongTy";
            this.gridView_CongTy.OptionsBehavior.ReadOnly = true;
            this.gridView_CongTy.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView_CongTy.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView_CongTy.OptionsSelection.MultiSelect = true;
            this.gridView_CongTy.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView_CongTy.OptionsView.EnableAppearanceOddRow = true;
            this.gridView_CongTy.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Công Ty";
            this.gridColumn1.FieldName = "MaCT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã Quốc Gia";
            this.gridColumn2.FieldName = "MaQG";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã Người Đại Diện";
            this.gridColumn3.FieldName = "MaKH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tên Công Ty";
            this.gridColumn4.FieldName = "TEN_CONG_TY";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Địa Chỉ";
            this.gridColumn5.FieldName = "DIA_CHI";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Điện Thoại";
            this.gridColumn6.FieldName = "DIEN_THOAI";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Email";
            this.gridColumn7.FieldName = "EMAIL";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Fax";
            this.gridColumn8.FieldName = "FAX";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Số Tài khoản";
            this.gridColumn9.FieldName = "SO_TAI_KHOAN";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Mã Số Thuế";
            this.gridColumn10.FieldName = "MA_SO_THUE";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.grdCtrlCongTy);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(797, 257);
            this.panelControl1.TabIndex = 49;
            // 
            // TraCuuCongTyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "TraCuuCongTyUI";
            this.Size = new System.Drawing.Size(797, 257);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlCongTy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CongTy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrlCongTy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_CongTy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}
