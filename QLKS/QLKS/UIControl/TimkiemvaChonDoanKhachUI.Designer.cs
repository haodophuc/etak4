namespace QLKS.UIControl
{
    partial class TimkiemvaChonDoanKhachUI
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
            this.GroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Company = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckInDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btt_Select = new DevExpress.XtraEditors.SimpleButton();
            this.btt_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlDoanKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DoanKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
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
            this.panelControl1.Size = new System.Drawing.Size(771, 423);
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
            this.grdCtrlDoanKhach.Size = new System.Drawing.Size(771, 423);
            this.grdCtrlDoanKhach.TabIndex = 18;
            this.grdCtrlDoanKhach.UseEmbeddedNavigator = true;
            this.grdCtrlDoanKhach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DoanKhach});
            // 
            // gridView_DoanKhach
            // 
            this.gridView_DoanKhach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GroupID,
            this.Company,
            this.CheckInDay});
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
            // GroupID
            // 
            this.GroupID.Caption = "Mã Đoàn Khách";
            this.GroupID.DisplayFormat.FormatString = "DK0000";
            this.GroupID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GroupID.FieldName = "MA_DOAN_KHACH";
            this.GroupID.Name = "GroupID";
            this.GroupID.Visible = true;
            this.GroupID.VisibleIndex = 0;
            // 
            // Company
            // 
            this.Company.Caption = "Công Ty";
            this.Company.FieldName = "TEN_CONG_TY";
            this.Company.Name = "Company";
            this.Company.Visible = true;
            this.Company.VisibleIndex = 1;
            // 
            // CheckInDay
            // 
            this.CheckInDay.Caption = "Ngày Đến";
            this.CheckInDay.FieldName = "NGAY_DEN";
            this.CheckInDay.Name = "CheckInDay";
            this.CheckInDay.Visible = true;
            this.CheckInDay.VisibleIndex = 2;
            // 
            // btt_Select
            // 
            this.btt_Select.Location = new System.Drawing.Point(295, 21);
            this.btt_Select.LookAndFeel.SkinName = "Money Twins";
            this.btt_Select.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btt_Select.Name = "btt_Select";
            this.btt_Select.Size = new System.Drawing.Size(75, 23);
            this.btt_Select.TabIndex = 21;
            this.btt_Select.Text = "Select";
            this.btt_Select.Click += new System.EventHandler(this.btt_Select_Click);
            // 
            // btt_Cancel
            // 
            this.btt_Cancel.Location = new System.Drawing.Point(401, 21);
            this.btt_Cancel.LookAndFeel.SkinName = "Money Twins";
            this.btt_Cancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btt_Cancel.Name = "btt_Cancel";
            this.btt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btt_Cancel.TabIndex = 20;
            this.btt_Cancel.Text = "Cancel";
            this.btt_Cancel.Click += new System.EventHandler(this.btt_Cancel_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.btt_Cancel);
            this.panelControl4.Controls.Add(this.btt_Select);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(0, 423);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(771, 64);
            this.panelControl4.TabIndex = 52;
            // 
            // TimkiemvaChonDoanKhachUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl4);
            this.Name = "TimkiemvaChonDoanKhachUI";
            this.Size = new System.Drawing.Size(771, 487);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlDoanKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DoanKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grdCtrlDoanKhach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DoanKhach;
        private DevExpress.XtraEditors.SimpleButton btt_Cancel;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btt_Select;
        private DevExpress.XtraGrid.Columns.GridColumn GroupID;
        private DevExpress.XtraGrid.Columns.GridColumn Company;
        private DevExpress.XtraGrid.Columns.GridColumn CheckInDay;
    }
}
