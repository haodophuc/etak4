namespace QLKS.UIControl
{
    partial class TimKiemVaChonPhongTrongUI
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
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.bt_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btt_Select = new DevExpress.XtraEditors.SimpleButton();
            this.RoomNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Beds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrl_CapNhatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView_Phong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
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
            this.grdCtrl_CapNhatPhong.LookAndFeel.UseDefaultLookAndFeel = true;
            this.grdCtrl_CapNhatPhong.MainView = this.grdView_Phong;
            this.grdCtrl_CapNhatPhong.Name = "grdCtrl_CapNhatPhong";
            this.grdCtrl_CapNhatPhong.Size = new System.Drawing.Size(767, 452);
            this.grdCtrl_CapNhatPhong.TabIndex = 17;
            this.grdCtrl_CapNhatPhong.UseEmbeddedNavigator = true;
            this.grdCtrl_CapNhatPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdView_Phong});
            // 
            // grdView_Phong
            // 
            this.grdView_Phong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RoomNumber,
            this.RoomType,
            this.Beds,
            this.Price});
            this.grdView_Phong.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdView_Phong.GridControl = this.grdCtrl_CapNhatPhong;
            this.grdView_Phong.GroupPanelText = "Kéo và thả tên cột để gom nhóm";
            this.grdView_Phong.Name = "grdView_Phong";
            this.grdView_Phong.OptionsSelection.MultiSelect = true;
            this.grdView_Phong.OptionsView.EnableAppearanceEvenRow = true;
            this.grdView_Phong.OptionsView.EnableAppearanceOddRow = true;
            this.grdView_Phong.OptionsView.ShowAutoFilterRow = true;
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.bt_Cancel);
            this.panelControl3.Controls.Add(this.btt_Select);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 408);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(767, 44);
            this.panelControl3.TabIndex = 52;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(429, 14);
            this.bt_Cancel.LookAndFeel.SkinName = "Money Twins";
            this.bt_Cancel.LookAndFeel.UseDefaultLookAndFeel = true;
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.TabIndex = 21;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click_1);
            // 
            // btt_Select
            // 
            this.btt_Select.Location = new System.Drawing.Point(312, 14);
            this.btt_Select.LookAndFeel.SkinName = "Money Twins";
            this.btt_Select.LookAndFeel.UseDefaultLookAndFeel = true;
            this.btt_Select.Name = "btt_Select";
            this.btt_Select.Size = new System.Drawing.Size(75, 23);
            this.btt_Select.TabIndex = 20;
            this.btt_Select.Text = "Select";
            this.btt_Select.Click += new System.EventHandler(this.btt_Select_Click);
            // 
            // RoomNumber
            // 
            this.RoomNumber.Caption = "Số Phòng";
            this.RoomNumber.FieldName = "SO_PHONG";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Visible = true;
            this.RoomNumber.VisibleIndex = 0;
            // 
            // RoomType
            // 
            this.RoomType.Caption = "Loại Phòng";
            this.RoomType.FieldName = "TEN_LOAI_PHONG";
            this.RoomType.Name = "RoomType";
            this.RoomType.Visible = true;
            this.RoomType.VisibleIndex = 1;
            // 
            // Beds
            // 
            this.Beds.Caption = "Số Giường";
            this.Beds.FieldName = "SO_GIUONG";
            this.Beds.Name = "Beds";
            this.Beds.Visible = true;
            this.Beds.VisibleIndex = 2;
            // 
            // Price
            // 
            this.Price.Caption = "Giá";
            this.Price.FieldName = "GIA_THAM_KHAO";
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 3;
            // 
            // TimKiemVaChonPhongTrongUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.grdCtrl_CapNhatPhong);
            this.Name = "TimKiemVaChonPhongTrongUI";
            this.Size = new System.Drawing.Size(767, 452);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrl_CapNhatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView_Phong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrl_CapNhatPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView grdView_Phong;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton bt_Cancel;
        private DevExpress.XtraEditors.SimpleButton btt_Select;
        private DevExpress.XtraGrid.Columns.GridColumn RoomNumber;
        private DevExpress.XtraGrid.Columns.GridColumn RoomType;
        private DevExpress.XtraGrid.Columns.GridColumn Beds;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
    }
}
