namespace QLKS_TiepNhanKhach.UI
{
    partial class CapNhatPhong_UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapNhatPhong_UI));
            this.txt_SoPhong = new DevExpress.XtraEditors.TextEdit();
            this.lbl_SoPhong = new DevExpress.XtraEditors.LabelControl();
            this.lbl_TinhTrang = new DevExpress.XtraEditors.LabelControl();
            this.lbl_LoaiPhong = new DevExpress.XtraEditors.LabelControl();
            this.grdCtrl_CapNhatPhong = new DevExpress.XtraGrid.GridControl();
            this.grdView_Phong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSource_Phong = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbo_TinhTrang = new System.Windows.Forms.ComboBox();
            this.panelControl_CapNhatPhong = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl_DataInput = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrl_CapNhatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView_Phong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Phong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_CapNhatPhong)).BeginInit();
            this.panelControl_CapNhatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_DataInput)).BeginInit();
            this.panelControl_DataInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SoPhong
            // 
            this.txt_SoPhong.Location = new System.Drawing.Point(242, 13);
            this.txt_SoPhong.Name = "txt_SoPhong";
            this.txt_SoPhong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoPhong.Properties.Appearance.Options.UseFont = true;
            this.txt_SoPhong.Size = new System.Drawing.Size(207, 28);
            this.txt_SoPhong.TabIndex = 7;
            // 
            // lbl_SoPhong
            // 
            this.lbl_SoPhong.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoPhong.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_SoPhong.Appearance.Options.UseFont = true;
            this.lbl_SoPhong.Appearance.Options.UseForeColor = true;
            this.lbl_SoPhong.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbl_SoPhong.Location = new System.Drawing.Point(120, 15);
            this.lbl_SoPhong.LookAndFeel.SkinName = "iMaginary";
            this.lbl_SoPhong.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lbl_SoPhong.Name = "lbl_SoPhong";
            this.lbl_SoPhong.Size = new System.Drawing.Size(80, 23);
            this.lbl_SoPhong.TabIndex = 10;
            this.lbl_SoPhong.Text = "Số Phòng";
            // 
            // lbl_TinhTrang
            // 
            this.lbl_TinhTrang.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TinhTrang.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_TinhTrang.Appearance.Options.UseFont = true;
            this.lbl_TinhTrang.Appearance.Options.UseForeColor = true;
            this.lbl_TinhTrang.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbl_TinhTrang.Location = new System.Drawing.Point(109, 106);
            this.lbl_TinhTrang.LookAndFeel.SkinName = "iMaginary";
            this.lbl_TinhTrang.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lbl_TinhTrang.Name = "lbl_TinhTrang";
            this.lbl_TinhTrang.Size = new System.Drawing.Size(91, 23);
            this.lbl_TinhTrang.TabIndex = 12;
            this.lbl_TinhTrang.Text = "Tình Trạng";
            // 
            // lbl_LoaiPhong
            // 
            this.lbl_LoaiPhong.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoaiPhong.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_LoaiPhong.Appearance.Options.UseFont = true;
            this.lbl_LoaiPhong.Appearance.Options.UseForeColor = true;
            this.lbl_LoaiPhong.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbl_LoaiPhong.Location = new System.Drawing.Point(104, 61);
            this.lbl_LoaiPhong.LookAndFeel.SkinName = "iMaginary";
            this.lbl_LoaiPhong.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lbl_LoaiPhong.Name = "lbl_LoaiPhong";
            this.lbl_LoaiPhong.Size = new System.Drawing.Size(96, 23);
            this.lbl_LoaiPhong.TabIndex = 11;
            this.lbl_LoaiPhong.Text = "Loại Phòng";
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
            this.grdCtrl_CapNhatPhong.Location = new System.Drawing.Point(3, 3);
            this.grdCtrl_CapNhatPhong.LookAndFeel.SkinName = "Money Twins";
            this.grdCtrl_CapNhatPhong.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdCtrl_CapNhatPhong.MainView = this.grdView_Phong;
            this.grdCtrl_CapNhatPhong.Name = "grdCtrl_CapNhatPhong";
            this.grdCtrl_CapNhatPhong.Size = new System.Drawing.Size(550, 193);
            this.grdCtrl_CapNhatPhong.TabIndex = 16;
            this.grdCtrl_CapNhatPhong.UseEmbeddedNavigator = true;
            this.grdCtrl_CapNhatPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdView_Phong});
            // 
            // grdView_Phong
            // 
            this.grdView_Phong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grdView_Phong.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdView_Phong.GridControl = this.grdCtrl_CapNhatPhong;
            this.grdView_Phong.GroupPanelText = "Kéo và thả tên cột để gom nhóm";
            this.grdView_Phong.Name = "grdView_Phong";
            this.grdView_Phong.OptionsSelection.MultiSelect = true;
            this.grdView_Phong.OptionsView.EnableAppearanceEvenRow = true;
            this.grdView_Phong.OptionsView.EnableAppearanceOddRow = true;
            this.grdView_Phong.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grdView_Phong_SelectionChanged);
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
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Mã Tình Trạng";
            this.gridColumn3.FieldName = "MA_TINH_TRANG";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // cbo_LoaiPhong
            // 
            this.cbo_LoaiPhong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiPhong.FormattingEnabled = true;
            this.cbo_LoaiPhong.Location = new System.Drawing.Point(242, 61);
            this.cbo_LoaiPhong.Name = "cbo_LoaiPhong";
            this.cbo_LoaiPhong.Size = new System.Drawing.Size(207, 29);
            this.cbo_LoaiPhong.TabIndex = 17;
            // 
            // cbo_TinhTrang
            // 
            this.cbo_TinhTrang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TinhTrang.FormattingEnabled = true;
            this.cbo_TinhTrang.Location = new System.Drawing.Point(242, 106);
            this.cbo_TinhTrang.Name = "cbo_TinhTrang";
            this.cbo_TinhTrang.Size = new System.Drawing.Size(207, 29);
            this.cbo_TinhTrang.TabIndex = 18;
            // 
            // panelControl_CapNhatPhong
            // 
            this.panelControl_CapNhatPhong.Controls.Add(this.grdCtrl_CapNhatPhong);
            this.panelControl_CapNhatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_CapNhatPhong.Location = new System.Drawing.Point(0, 200);
            this.panelControl_CapNhatPhong.LookAndFeel.SkinName = "Money Twins";
            this.panelControl_CapNhatPhong.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl_CapNhatPhong.Name = "panelControl_CapNhatPhong";
            this.panelControl_CapNhatPhong.Size = new System.Drawing.Size(556, 199);
            this.panelControl_CapNhatPhong.TabIndex = 19;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.btn_Them);
            this.groupControl2.Controls.Add(this.btn_Huy);
            this.groupControl2.Controls.Add(this.btn_Xoa);
            this.groupControl2.Controls.Add(this.btn_Luu);
            this.groupControl2.Controls.Add(this.btn_Sua);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 150);
            this.groupControl2.LookAndFeel.SkinName = "iMaginary";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(552, 48);
            this.groupControl2.TabIndex = 30;
            this.groupControl2.Text = "groupControl2";
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.Location = new System.Drawing.Point(56, 10);
            this.btn_Them.LookAndFeel.SkinName = "iMaginary";
            this.btn_Them.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(69, 29);
            this.btn_Them.TabIndex = 23;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Appearance.Options.UseFont = true;
            this.btn_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.Image")));
            this.btn_Huy.Location = new System.Drawing.Point(427, 10);
            this.btn_Huy.LookAndFeel.SkinName = "iMaginary";
            this.btn_Huy.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(69, 29);
            this.btn_Huy.TabIndex = 27;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(153, 10);
            this.btn_Xoa.LookAndFeel.SkinName = "iMaginary";
            this.btn_Xoa.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(69, 29);
            this.btn_Xoa.TabIndex = 24;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Appearance.Options.UseFont = true;
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.Location = new System.Drawing.Point(332, 10);
            this.btn_Luu.LookAndFeel.SkinName = "iMaginary";
            this.btn_Luu.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(69, 29);
            this.btn_Luu.TabIndex = 26;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Appearance.Options.UseFont = true;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(240, 10);
            this.btn_Sua.LookAndFeel.SkinName = "iMaginary";
            this.btn_Sua.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(69, 29);
            this.btn_Sua.TabIndex = 25;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // panelControl_DataInput
            // 
            this.panelControl_DataInput.Controls.Add(this.groupControl2);
            this.panelControl_DataInput.Controls.Add(this.groupControl1);
            this.panelControl_DataInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl_DataInput.Location = new System.Drawing.Point(0, 0);
            this.panelControl_DataInput.Name = "panelControl_DataInput";
            this.panelControl_DataInput.Size = new System.Drawing.Size(556, 200);
            this.panelControl_DataInput.TabIndex = 31;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.lbl_SoPhong);
            this.groupControl1.Controls.Add(this.cbo_LoaiPhong);
            this.groupControl1.Controls.Add(this.lbl_TinhTrang);
            this.groupControl1.Controls.Add(this.txt_SoPhong);
            this.groupControl1.Controls.Add(this.cbo_TinhTrang);
            this.groupControl1.Controls.Add(this.lbl_LoaiPhong);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.LookAndFeel.SkinName = "iMaginary";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(552, 148);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "groupControl1";
            // 
            // CapNhatPhong_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl_CapNhatPhong);
            this.Controls.Add(this.panelControl_DataInput);
            this.MinimumSize = new System.Drawing.Size(556, 399);
            this.Name = "CapNhatPhong_UI";
            this.Size = new System.Drawing.Size(556, 399);
            this.Load += new System.EventHandler(this.CapNhatPhong_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrl_CapNhatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView_Phong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Phong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_CapNhatPhong)).EndInit();
            this.panelControl_CapNhatPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_DataInput)).EndInit();
            this.panelControl_DataInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_SoPhong;
        private DevExpress.XtraEditors.LabelControl lbl_SoPhong;
        private DevExpress.XtraEditors.LabelControl lbl_TinhTrang;
        private DevExpress.XtraEditors.LabelControl lbl_LoaiPhong;
        private DevExpress.XtraGrid.GridControl grdCtrl_CapNhatPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView grdView_Phong;
        private System.Windows.Forms.BindingSource bindingSource_Phong;
        private System.Windows.Forms.ComboBox cbo_LoaiPhong;
        private System.Windows.Forms.ComboBox cbo_TinhTrang;
        private DevExpress.XtraEditors.PanelControl panelControl_CapNhatPhong;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.SimpleButton btn_Huy;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton btn_Sua;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.PanelControl panelControl_DataInput;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
