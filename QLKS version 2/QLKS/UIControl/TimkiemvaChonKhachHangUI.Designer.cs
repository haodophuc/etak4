namespace QLKS.UIControl
{
    partial class TimkiemvaChonKhachHangUI
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
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.bt_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btt_Select = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grdCtrlKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView_KhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.bt_Cancel);
            this.panelControl3.Controls.Add(this.btt_Select);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 491);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(829, 44);
            this.panelControl3.TabIndex = 51;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(429, 14);
            this.bt_Cancel.LookAndFeel.SkinName = "Money Twins";
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.TabIndex = 21;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // btt_Select
            // 
            this.btt_Select.Location = new System.Drawing.Point(312, 14);
            this.btt_Select.LookAndFeel.SkinName = "Money Twins";
            this.btt_Select.Name = "btt_Select";
            this.btt_Select.Size = new System.Drawing.Size(75, 23);
            this.btt_Select.TabIndex = 20;
            this.btt_Select.Text = "Select";
            this.btt_Select.Click += new System.EventHandler(this.btt_Select_Click);
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
            this.panelControl1.Size = new System.Drawing.Size(829, 491);
            this.panelControl1.TabIndex = 52;
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
            this.grdCtrlKhachHang.MainView = this.gridView_KhachHang;
            this.grdCtrlKhachHang.MinimumSize = new System.Drawing.Size(749, 185);
            this.grdCtrlKhachHang.Name = "grdCtrlKhachHang";
            this.grdCtrlKhachHang.Size = new System.Drawing.Size(829, 491);
            this.grdCtrlKhachHang.TabIndex = 18;
            this.grdCtrlKhachHang.UseEmbeddedNavigator = true;
            this.grdCtrlKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_KhachHang,
            this.gridView1});
            // 
            // gridView_KhachHang
            // 
            this.gridView_KhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CustomerID,
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
            this.gridView_KhachHang.OptionsBehavior.Editable = false;
            this.gridView_KhachHang.OptionsBehavior.ReadOnly = true;
            this.gridView_KhachHang.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView_KhachHang.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView_KhachHang.OptionsSelection.MultiSelect = true;
            this.gridView_KhachHang.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView_KhachHang.OptionsView.EnableAppearanceOddRow = true;
            this.gridView_KhachHang.OptionsView.ShowAutoFilterRow = true;
            // 
            // CustomerID
            // 
            this.CustomerID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.AppearanceHeader.Options.UseFont = true;
            this.CustomerID.Caption = "Mã Khách Hàng";
            this.CustomerID.DisplayFormat.FormatString = "KH0000";
            this.CustomerID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CustomerID.FieldName = "MA_KHACH_HANG";
            this.CustomerID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Visible = true;
            this.CustomerID.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Quốc Gia";
            this.gridColumn2.FieldName = "TEN_QUOC_GIA";
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
            // TimkiemvaChonKhachHangUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.Name = "TimkiemvaChonKhachHangUI";
            this.Size = new System.Drawing.Size(829, 535);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btt_Select;
        private DevExpress.XtraEditors.SimpleButton bt_Cancel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grdCtrlKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_KhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;

    }
}
