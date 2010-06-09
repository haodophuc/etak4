namespace QLKS.UIControl
{
    partial class UIServiceGridView
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
            this.gridControlServices = new DevExpress.XtraGrid.GridControl();
            this.gridViewServices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnServiceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnServicePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnServiceState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.radioGroupViewMode = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupViewMode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlServices
            // 
            this.gridControlServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlServices.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gridControlServices.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlServices.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridControlServices.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlServices.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControlServices.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlServices.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridControlServices.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlServices.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gridControlServices.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlServices.Location = new System.Drawing.Point(0, 0);
            this.gridControlServices.LookAndFeel.SkinName = "Money Twins";
            this.gridControlServices.LookAndFeel.UseDefaultLookAndFeel = true;
            this.gridControlServices.MainView = this.gridViewServices;
            this.gridControlServices.Name = "gridControlServices";
            this.gridControlServices.Size = new System.Drawing.Size(580, 440);
            this.gridControlServices.TabIndex = 0;
            this.gridControlServices.UseEmbeddedNavigator = true;
            this.gridControlServices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewServices});
            // 
            // gridViewServices
            // 
            this.gridViewServices.Appearance.OddRow.BackColor = System.Drawing.Color.LightYellow;
            this.gridViewServices.Appearance.OddRow.BackColor2 = System.Drawing.Color.LightYellow;
            this.gridViewServices.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewServices.ColumnPanelRowHeight = 25;
            this.gridViewServices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnServiceName,
            this.gridColumnServicePrice,
            this.gridColumnServiceState});
            this.gridViewServices.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewServices.GridControl = this.gridControlServices;
            this.gridViewServices.GroupPanelText = "Bảng - Dịch Vụ Khách Sạn";
            this.gridViewServices.Name = "gridViewServices";
            this.gridViewServices.OptionsBehavior.Editable = false;
            this.gridViewServices.OptionsSelection.MultiSelect = true;
            this.gridViewServices.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewServices.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewServices.OptionsView.ShowFooter = true;
            this.gridViewServices.RowHeight = 25;
            this.gridViewServices.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewServices_FocusedRowChanged);
            this.gridViewServices.ColumnFilterChanged += new System.EventHandler(this.gridViewServices_ColumnFilterChanged);
            // 
            // gridColumnServiceName
            // 
            this.gridColumnServiceName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumnServiceName.AppearanceCell.Options.UseFont = true;
            this.gridColumnServiceName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnServiceName.AppearanceHeader.Options.UseFont = true;
            this.gridColumnServiceName.Caption = "Tên Dịch Vụ";
            this.gridColumnServiceName.FieldName = "TEN_DICH_VU";
            this.gridColumnServiceName.Name = "gridColumnServiceName";
            this.gridColumnServiceName.Visible = true;
            this.gridColumnServiceName.VisibleIndex = 0;
            this.gridColumnServiceName.Width = 309;
            // 
            // gridColumnServicePrice
            // 
            this.gridColumnServicePrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumnServicePrice.AppearanceCell.Options.UseBackColor = true;
            this.gridColumnServicePrice.AppearanceCell.Options.UseFont = true;
            this.gridColumnServicePrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnServicePrice.AppearanceHeader.Options.UseFont = true;
            this.gridColumnServicePrice.Caption = "Đơn Giá";
            this.gridColumnServicePrice.DisplayFormat.FormatString = " KH ###,### VND";
            this.gridColumnServicePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnServicePrice.FieldName = "DON_GIA";
            this.gridColumnServicePrice.Name = "gridColumnServicePrice";
            this.gridColumnServicePrice.Visible = true;
            this.gridColumnServicePrice.VisibleIndex = 1;
            this.gridColumnServicePrice.Width = 152;
            // 
            // gridColumnServiceState
            // 
            this.gridColumnServiceState.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumnServiceState.AppearanceCell.Options.UseFont = true;
            this.gridColumnServiceState.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnServiceState.AppearanceHeader.Options.UseFont = true;
            this.gridColumnServiceState.Caption = "Hoạt Động";
            this.gridColumnServiceState.FieldName = "HIEU_LUC";
            this.gridColumnServiceState.Name = "gridColumnServiceState";
            this.gridColumnServiceState.Visible = true;
            this.gridColumnServiceState.VisibleIndex = 2;
            this.gridColumnServiceState.Width = 107;
            // 
            // radioGroupViewMode
            // 
            this.radioGroupViewMode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radioGroupViewMode.Location = new System.Drawing.Point(0, 440);
            this.radioGroupViewMode.Name = "radioGroupViewMode";
            this.radioGroupViewMode.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(new decimal(new int[] {
                            0,
                            0,
                            0,
                            0}), "Tất cả các dịch vụ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(new decimal(new int[] {
                            1,
                            0,
                            0,
                            0}), "Các dịch vụ đang hoạt động"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(new decimal(new int[] {
                            2,
                            0,
                            0,
                            0}), "Các dịch vụ ngừng hoạt động")});
            this.radioGroupViewMode.Size = new System.Drawing.Size(580, 50);
            this.radioGroupViewMode.TabIndex = 1;
            this.radioGroupViewMode.SelectedIndexChanged += new System.EventHandler(this.radioGroupViewMode_SelectedIndexChanged);
            // 
            // UIServiceGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlServices);
            this.Controls.Add(this.radioGroupViewMode);
            this.Name = "UIServiceGridView";
            this.Size = new System.Drawing.Size(580, 490);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupViewMode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlServices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewServices;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServiceName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServicePrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServiceState;
        private DevExpress.XtraEditors.RadioGroup radioGroupViewMode;
    }
}
