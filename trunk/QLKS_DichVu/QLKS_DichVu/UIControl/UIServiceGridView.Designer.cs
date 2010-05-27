namespace QLKS_DichVu.UIControl
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).BeginInit();
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
            this.gridControlServices.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlServices.MainView = this.gridViewServices;
            this.gridControlServices.Name = "gridControlServices";
            this.gridControlServices.Size = new System.Drawing.Size(580, 400);
            this.gridControlServices.TabIndex = 0;
            this.gridControlServices.UseEmbeddedNavigator = true;
            this.gridControlServices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewServices});
            this.gridControlServices.Click += new System.EventHandler(this.gridControlServices_Click);
            // 
            // gridViewServices
            // 
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
            this.gridViewServices.OptionsView.ShowFooter = true;
            this.gridViewServices.RowHeight = 25;
            this.gridViewServices.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewServices_FocusedRowChanged);
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
            this.gridColumnServicePrice.AppearanceCell.Options.UseFont = true;
            this.gridColumnServicePrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnServicePrice.AppearanceHeader.Options.UseFont = true;
            this.gridColumnServicePrice.Caption = "Đơn Giá";
            this.gridColumnServicePrice.DisplayFormat.FormatString = "###.#00 VND";
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
            // UIServiceGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlServices);
            this.Name = "UIServiceGridView";
            this.Size = new System.Drawing.Size(580, 400);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlServices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewServices;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServiceName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServicePrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServiceState;
    }
}
