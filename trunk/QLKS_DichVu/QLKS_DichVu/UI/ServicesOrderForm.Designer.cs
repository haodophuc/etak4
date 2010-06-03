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
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
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
            this.serviceGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceGridControl.Location = new System.Drawing.Point(0, 0);
            this.serviceGridControl.MainView = this.serviceOrderBillView;
            this.serviceGridControl.Name = "serviceGridControl";
            this.serviceGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.serviceDateEdit,
            this.quantitySpinEdit,
            this.serviceLookupEdit});
            this.serviceGridControl.Size = new System.Drawing.Size(543, 167);
            this.serviceGridControl.TabIndex = 2;
            this.serviceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.serviceOrderBillView});
            // 
            // serviceOrderBillView
            // 
            this.serviceOrderBillView.GridControl = this.serviceGridControl;
            this.serviceOrderBillView.Name = "serviceOrderBillView";
            this.serviceOrderBillView.OptionsView.ShowAutoFilterRow = true;
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
            this.serviceLookupEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.serviceLookupEdit.Name = "serviceLookupEdit";
            // 
            // roomGridControl
            // 
            this.roomGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomGridControl.Location = new System.Drawing.Point(0, 0);
            this.roomGridControl.MainView = this.roomBillView;
            this.roomGridControl.Name = "roomGridControl";
            this.roomGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkingInOutDateEdit});
            this.roomGridControl.Size = new System.Drawing.Size(543, 213);
            this.roomGridControl.TabIndex = 2;
            this.roomGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.roomBillView});
            // 
            // roomBillView
            // 
            this.roomBillView.GridControl = this.roomGridControl;
            this.roomBillView.Name = "roomBillView";
            this.roomBillView.OptionsBehavior.ReadOnly = true;
            this.roomBillView.OptionsDetail.EnableMasterViewMode = false;
            this.roomBillView.OptionsView.ShowAutoFilterRow = true;
            this.roomBillView.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.roomBillView_CustomDrawColumnHeader);
            // 
            // checkingInOutDateEdit
            // 
            this.checkingInOutDateEdit.AutoHeight = false;
            this.checkingInOutDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkingInOutDateEdit.DisplayFormat.FormatString = "g";
            this.checkingInOutDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.checkingInOutDateEdit.EditFormat.FormatString = "g";
            this.checkingInOutDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.checkingInOutDateEdit.Mask.EditMask = "g";
            this.checkingInOutDateEdit.Name = "checkingInOutDateEdit";
            this.checkingInOutDateEdit.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataNavigator1.Location = new System.Drawing.Point(0, 386);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(543, 43);
            this.dataNavigator1.TabIndex = 3;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dataNavigator1_ButtonClick);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.roomGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.serviceGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(543, 386);
            this.splitContainerControl1.SplitterPosition = 213;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ServicesOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 429);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "ServicesOrderForm";
            this.Text = "ServicesOrderForm";
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
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit serviceDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit quantitySpinEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit serviceLookupEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit checkingInOutDateEdit;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}