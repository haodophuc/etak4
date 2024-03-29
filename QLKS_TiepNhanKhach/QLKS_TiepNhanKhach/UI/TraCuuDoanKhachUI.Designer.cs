namespace QLKS_TiepNhanKhach.UI
{
    partial class TraCuuDoanKhachUI
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grdCtrlDoanKhach = new DevExpress.XtraGrid.GridControl();
            this.gridView_DoanKhach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlDoanKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DoanKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.grdCtrlDoanKhach);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(771, 242);
            this.panelControl1.TabIndex = 49;
            // 
            // grdCtrlDoanKhach
            // 
            this.grdCtrlDoanKhach.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.grdCtrlDoanKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlDoanKhach.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdCtrlDoanKhach.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.grdCtrlDoanKhach.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdCtrlDoanKhach.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.grdCtrlDoanKhach.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdCtrlDoanKhach.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.grdCtrlDoanKhach.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdCtrlDoanKhach.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.grdCtrlDoanKhach.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdCtrlDoanKhach.Location = new System.Drawing.Point(0, 0);
            this.grdCtrlDoanKhach.LookAndFeel.SkinName = "Money Twins";
            this.grdCtrlDoanKhach.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdCtrlDoanKhach.MainView = this.gridView_DoanKhach;
            this.grdCtrlDoanKhach.MinimumSize = new System.Drawing.Size(749, 185);
            this.grdCtrlDoanKhach.Name = "grdCtrlDoanKhach";
            this.grdCtrlDoanKhach.Size = new System.Drawing.Size(771, 242);
            this.grdCtrlDoanKhach.TabIndex = 18;
            this.grdCtrlDoanKhach.UseEmbeddedNavigator = true;
            this.grdCtrlDoanKhach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DoanKhach});
            // 
            // gridView_DoanKhach
            // 
            this.gridView_DoanKhach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView_DoanKhach.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView_DoanKhach.GridControl = this.grdCtrlDoanKhach;
            this.gridView_DoanKhach.GroupPanelText = "Kéo và thả tên cột để gom nhóm";
            this.gridView_DoanKhach.Name = "gridView_DoanKhach";
            this.gridView_DoanKhach.OptionsBehavior.ReadOnly = true;
            this.gridView_DoanKhach.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView_DoanKhach.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView_DoanKhach.OptionsSelection.MultiSelect = true;
            this.gridView_DoanKhach.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView_DoanKhach.OptionsView.EnableAppearanceOddRow = true;
            this.gridView_DoanKhach.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Đoàn Khách";
            this.gridColumn1.FieldName = "MaDK";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã Công Ty";
            this.gridColumn2.FieldName = "MaCT";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày Đến";
            this.gridColumn3.FieldName = "NGAY_DEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // TraCuuDoanKhachUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelControl1);
            this.Name = "TraCuuDoanKhachUI";
            this.Size = new System.Drawing.Size(771, 242);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlDoanKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DoanKhach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grdCtrlDoanKhach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DoanKhach;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
