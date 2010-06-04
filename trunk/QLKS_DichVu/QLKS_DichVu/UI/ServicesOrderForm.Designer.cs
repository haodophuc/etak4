namespace QLKS_DichVu.UI
{
    partial class ServicesOrderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceGridControl = new DevExpress.XtraGrid.GridControl();
            this.serviceOrderBillView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.serviceDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.quantitySpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.serviceLookupEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.roomGridControl = new DevExpress.XtraGrid.GridControl();
            this.roomBillView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.checkingInOutDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.controlNavigator2 = new DevExpress.XtraEditors.ControlNavigator();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.serviceGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceOrderBillView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDateEdit.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceLookupEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBillView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkingInOutDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkingInOutDateEdit.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceGridControl
            // 
            this.serviceGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceGridControl.Location = new System.Drawing.Point(3, 0);
            this.serviceGridControl.MainView = this.serviceOrderBillView;
            this.serviceGridControl.Name = "serviceGridControl";
            this.serviceGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.serviceDateEdit,
            this.quantitySpinEdit,
            this.serviceLookupEdit});
            this.serviceGridControl.Size = new System.Drawing.Size(691, 140);
            this.serviceGridControl.TabIndex = 2;
            this.serviceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.serviceOrderBillView});
            // 
            // serviceOrderBillView
            // 
            this.serviceOrderBillView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.serviceOrderBillView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.serviceOrderBillView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.serviceOrderBillView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.serviceOrderBillView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(57)))));
            this.serviceOrderBillView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(57)))));
            this.serviceOrderBillView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White;
            this.serviceOrderBillView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.serviceOrderBillView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.serviceOrderBillView.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.serviceOrderBillView.Appearance.Empty.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.serviceOrderBillView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.serviceOrderBillView.Appearance.EvenRow.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.EvenRow.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.serviceOrderBillView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.serviceOrderBillView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.serviceOrderBillView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.serviceOrderBillView.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.serviceOrderBillView.Appearance.FilterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.serviceOrderBillView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.serviceOrderBillView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.FilterPanel.Options.UseBorderColor = true;
            this.serviceOrderBillView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(37)))));
            this.serviceOrderBillView.Appearance.FixedLine.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.serviceOrderBillView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.serviceOrderBillView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(114)))), ((int)(((byte)(50)))));
            this.serviceOrderBillView.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(114)))), ((int)(((byte)(50)))));
            this.serviceOrderBillView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.serviceOrderBillView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.serviceOrderBillView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.serviceOrderBillView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.serviceOrderBillView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White;
            this.serviceOrderBillView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.serviceOrderBillView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.serviceOrderBillView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.serviceOrderBillView.Appearance.GroupButton.ForeColor = System.Drawing.Color.White;
            this.serviceOrderBillView.Appearance.GroupButton.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.serviceOrderBillView.Appearance.GroupButton.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(193)))), ((int)(((byte)(55)))));
            this.serviceOrderBillView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(193)))), ((int)(((byte)(55)))));
            this.serviceOrderBillView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.serviceOrderBillView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.serviceOrderBillView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.serviceOrderBillView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.serviceOrderBillView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(193)))), ((int)(((byte)(55)))));
            this.serviceOrderBillView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(193)))), ((int)(((byte)(55)))));
            this.serviceOrderBillView.Appearance.GroupRow.ForeColor = System.Drawing.Color.White;
            this.serviceOrderBillView.Appearance.GroupRow.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.GroupRow.Options.UseBorderColor = true;
            this.serviceOrderBillView.Appearance.GroupRow.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(57)))));
            this.serviceOrderBillView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(57)))));
            this.serviceOrderBillView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Red;
            this.serviceOrderBillView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.serviceOrderBillView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(158)))), ((int)(((byte)(64)))));
            this.serviceOrderBillView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.serviceOrderBillView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(37)))));
            this.serviceOrderBillView.Appearance.HorzLine.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.serviceOrderBillView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.serviceOrderBillView.Appearance.OddRow.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.OddRow.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.serviceOrderBillView.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.serviceOrderBillView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(114)))), ((int)(((byte)(50)))));
            this.serviceOrderBillView.Appearance.Preview.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.Preview.Options.UseFont = true;
            this.serviceOrderBillView.Appearance.Preview.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.serviceOrderBillView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.serviceOrderBillView.Appearance.Row.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.Row.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.serviceOrderBillView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.serviceOrderBillView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.serviceOrderBillView.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.serviceOrderBillView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.serviceOrderBillView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.serviceOrderBillView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.serviceOrderBillView.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.serviceOrderBillView.Appearance.TopNewRow.Options.UseBackColor = true;
            this.serviceOrderBillView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(37)))));
            this.serviceOrderBillView.Appearance.VertLine.Options.UseBackColor = true;
            this.serviceOrderBillView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.serviceOrderBillView.GridControl = this.serviceGridControl;
            this.serviceOrderBillView.GroupPanelText = "Kéo và thả tên cột để gom nhóm";
            this.serviceOrderBillView.Name = "serviceOrderBillView";
            this.serviceOrderBillView.OptionsDetail.EnableMasterViewMode = false;
            this.serviceOrderBillView.OptionsNavigation.AutoFocusNewRow = true;
            this.serviceOrderBillView.OptionsView.AllowHtmlDrawHeaders = true;
            this.serviceOrderBillView.OptionsView.EnableAppearanceEvenRow = true;
            this.serviceOrderBillView.OptionsView.EnableAppearanceOddRow = true;
            this.serviceOrderBillView.OptionsView.ShowAutoFilterRow = true;
            this.serviceOrderBillView.ViewCaption = "Phiếu đăng ký dịch vụ";
            this.serviceOrderBillView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.serviceOrderBillView_InitNewRow);
            this.serviceOrderBillView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.serviceOrderBillView_InvalidRowException);
            this.serviceOrderBillView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.serviceOrderBillView_ValidateRow);
            this.serviceOrderBillView.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.serviceOrderBillView_CustomDrawColumnHeader);
            // 
            // serviceDateEdit
            // 
            this.serviceDateEdit.AutoHeight = false;
            this.serviceDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.serviceDateEdit.DisplayFormat.FormatString = "g";
            this.serviceDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.serviceDateEdit.EditFormat.FormatString = "g";
            this.serviceDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.serviceDateEdit.Mask.EditMask = "g";
            this.serviceDateEdit.Name = "serviceDateEdit";
            this.serviceDateEdit.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // quantitySpinEdit
            // 
            this.quantitySpinEdit.AutoHeight = false;
            this.quantitySpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.quantitySpinEdit.IsFloatValue = false;
            this.quantitySpinEdit.Mask.BeepOnError = true;
            this.quantitySpinEdit.Mask.EditMask = "\\d+";
            this.quantitySpinEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.quantitySpinEdit.MaxLength = 10;
            this.quantitySpinEdit.MaxValue = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.quantitySpinEdit.Name = "quantitySpinEdit";
            this.quantitySpinEdit.NullValuePrompt = "Invalid value";
            this.quantitySpinEdit.NullValuePromptShowForEmptyValue = true;
            // 
            // serviceLookupEdit
            // 
            this.serviceLookupEdit.AutoHeight = false;
            this.serviceLookupEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.serviceLookupEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.serviceLookupEdit.Name = "serviceLookupEdit";
            this.serviceLookupEdit.NullText = "Làm ơn chọn dịch vụ";
            this.serviceLookupEdit.NullValuePrompt = "Giá trị không hợp lệ";
            this.serviceLookupEdit.NullValuePromptShowForEmptyValue = true;
            this.serviceLookupEdit.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D;
            this.serviceLookupEdit.ValidateOnEnterKey = true;
            // 
            // roomGridControl
            // 
            this.roomGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.roomGridControl.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomGridControl.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.roomGridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.roomGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.roomGridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.roomGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.roomGridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.roomGridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.roomGridControl.Location = new System.Drawing.Point(0, 0);
            this.roomGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.roomGridControl.MainView = this.roomBillView;
            this.roomGridControl.Name = "roomGridControl";
            this.roomGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkingInOutDateEdit});
            this.roomGridControl.Size = new System.Drawing.Size(697, 149);
            this.roomGridControl.TabIndex = 2;
            this.roomGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.roomBillView});
            // 
            // roomBillView
            // 
            this.roomBillView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.roomBillView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.roomBillView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.roomBillView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.roomBillView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.roomBillView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.roomBillView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(57)))));
            this.roomBillView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(57)))));
            this.roomBillView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White;
            this.roomBillView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.roomBillView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.roomBillView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.roomBillView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.roomBillView.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.roomBillView.Appearance.Empty.Options.UseBackColor = true;
            this.roomBillView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.roomBillView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.roomBillView.Appearance.EvenRow.Options.UseBackColor = true;
            this.roomBillView.Appearance.EvenRow.Options.UseForeColor = true;
            this.roomBillView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.roomBillView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.roomBillView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.roomBillView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.roomBillView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.roomBillView.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.roomBillView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.roomBillView.Appearance.FilterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.roomBillView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.roomBillView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.roomBillView.Appearance.FilterPanel.Options.UseBorderColor = true;
            this.roomBillView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.roomBillView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(37)))));
            this.roomBillView.Appearance.FixedLine.Options.UseBackColor = true;
            this.roomBillView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.roomBillView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.roomBillView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.roomBillView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.roomBillView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(114)))), ((int)(((byte)(50)))));
            this.roomBillView.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(114)))), ((int)(((byte)(50)))));
            this.roomBillView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.roomBillView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.roomBillView.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.roomBillView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.roomBillView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.roomBillView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.roomBillView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White;
            this.roomBillView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.roomBillView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.roomBillView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.roomBillView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.roomBillView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.roomBillView.Appearance.GroupButton.ForeColor = System.Drawing.Color.White;
            this.roomBillView.Appearance.GroupButton.Options.UseBackColor = true;
            this.roomBillView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.roomBillView.Appearance.GroupButton.Options.UseForeColor = true;
            this.roomBillView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(193)))), ((int)(((byte)(55)))));
            this.roomBillView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(193)))), ((int)(((byte)(55)))));
            this.roomBillView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.roomBillView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.roomBillView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.roomBillView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.roomBillView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.roomBillView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.roomBillView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.roomBillView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(193)))), ((int)(((byte)(55)))));
            this.roomBillView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(193)))), ((int)(((byte)(55)))));
            this.roomBillView.Appearance.GroupRow.ForeColor = System.Drawing.Color.White;
            this.roomBillView.Appearance.GroupRow.Options.UseBackColor = true;
            this.roomBillView.Appearance.GroupRow.Options.UseBorderColor = true;
            this.roomBillView.Appearance.GroupRow.Options.UseForeColor = true;
            this.roomBillView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(57)))));
            this.roomBillView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(57)))));
            this.roomBillView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Red;
            this.roomBillView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.roomBillView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.roomBillView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.roomBillView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(158)))), ((int)(((byte)(64)))));
            this.roomBillView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.roomBillView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.roomBillView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.roomBillView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(37)))));
            this.roomBillView.Appearance.HorzLine.Options.UseBackColor = true;
            this.roomBillView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.roomBillView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.roomBillView.Appearance.OddRow.Options.UseBackColor = true;
            this.roomBillView.Appearance.OddRow.Options.UseForeColor = true;
            this.roomBillView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.roomBillView.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.roomBillView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(114)))), ((int)(((byte)(50)))));
            this.roomBillView.Appearance.Preview.Options.UseBackColor = true;
            this.roomBillView.Appearance.Preview.Options.UseFont = true;
            this.roomBillView.Appearance.Preview.Options.UseForeColor = true;
            this.roomBillView.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.roomBillView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.roomBillView.Appearance.Row.Options.UseBackColor = true;
            this.roomBillView.Appearance.Row.Options.UseForeColor = true;
            this.roomBillView.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.roomBillView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.roomBillView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.roomBillView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.roomBillView.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.roomBillView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.roomBillView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.roomBillView.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.roomBillView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.roomBillView.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.roomBillView.Appearance.TopNewRow.Options.UseBackColor = true;
            this.roomBillView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(37)))));
            this.roomBillView.Appearance.VertLine.Options.UseBackColor = true;
            this.roomBillView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.roomBillView.GridControl = this.roomGridControl;
            this.roomBillView.GroupPanelText = "Kéo và thả tên cột để gom nhóm";
            this.roomBillView.Name = "roomBillView";
            this.roomBillView.OptionsBehavior.ReadOnly = true;
            this.roomBillView.OptionsDetail.EnableMasterViewMode = false;
            this.roomBillView.OptionsView.EnableAppearanceEvenRow = true;
            this.roomBillView.OptionsView.EnableAppearanceOddRow = true;
            this.roomBillView.OptionsView.ShowAutoFilterRow = true;
            this.roomBillView.ViewCaption = "Phiếu thuê phòng";
            this.roomBillView.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.roomBillView_CustomDrawColumnHeader);
            // 
            // checkingInOutDateEdit
            // 
            this.checkingInOutDateEdit.AutoHeight = false;
            this.checkingInOutDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkingInOutDateEdit.Name = "checkingInOutDateEdit";
            this.checkingInOutDateEdit.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.controlNavigator2);
            this.splitContainerControl1.Panel1.Controls.Add(this.roomGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.controlNavigator1);
            this.splitContainerControl1.Panel2.Controls.Add(this.serviceGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(697, 366);
            this.splitContainerControl1.SplitterPosition = 181;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // controlNavigator2
            // 
            this.controlNavigator2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlNavigator2.Appearance.Options.UseFont = true;
            this.controlNavigator2.Buttons.Append.Visible = false;
            this.controlNavigator2.Buttons.CancelEdit.Visible = false;
            this.controlNavigator2.Buttons.Edit.Visible = false;
            this.controlNavigator2.Buttons.EndEdit.Visible = false;
            this.controlNavigator2.Buttons.Remove.Visible = false;
            this.controlNavigator2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.controlNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator2.Location = new System.Drawing.Point(0, 144);
            this.controlNavigator2.Name = "controlNavigator2";
            this.controlNavigator2.NavigatableControl = this.roomGridControl;
            this.controlNavigator2.Size = new System.Drawing.Size(697, 37);
            this.controlNavigator2.TabIndex = 3;
            this.controlNavigator2.Text = "controlNavigator2";
            this.controlNavigator2.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlNavigator1.Appearance.Options.UseFont = true;
            this.controlNavigator1.Buttons.Edit.Visible = false;
            this.controlNavigator1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator1.Location = new System.Drawing.Point(0, 138);
            this.controlNavigator1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.NavigatableControl = this.serviceGridControl;
            this.controlNavigator1.Size = new System.Drawing.Size(697, 41);
            this.controlNavigator1.TabIndex = 3;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.controlNavigator1.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.controlNavigator1_ButtonClick);
            // 
            // ServicesOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 366);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ServicesOrderForm";
            this.Text = "ServicesOrderForm Cộng đồng C Việt";
            this.Load += new System.EventHandler(this.ServicesOrderForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServicesOrderForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.serviceGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceOrderBillView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDateEdit.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceLookupEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBillView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkingInOutDateEdit.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkingInOutDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl serviceGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView serviceOrderBillView;
        private DevExpress.XtraGrid.GridControl roomGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView roomBillView;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit serviceDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit quantitySpinEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit serviceLookupEdit;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit checkingInOutDateEdit;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator2;
    }
}