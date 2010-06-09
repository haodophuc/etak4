namespace QLKS.UIControl
{
    partial class UITellerManagement
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
            this.tellerGridControl = new DevExpress.XtraGrid.GridControl();
            this.tellerGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tellerRoleLookupEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tellerControlNavigator = new DevExpress.XtraEditors.ControlNavigator();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.tellerGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tellerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tellerRoleLookupEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tellerGridControl
            // 
            this.tellerGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tellerGridControl.Location = new System.Drawing.Point(0, 0);
            this.tellerGridControl.MainView = this.tellerGridView;
            this.tellerGridControl.Name = "tellerGridControl";
            this.tellerGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.tellerRoleLookupEdit});
            this.tellerGridControl.Size = new System.Drawing.Size(653, 200);
            this.tellerGridControl.TabIndex = 3;
            this.tellerGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tellerGridView});
            // 
            // tellerGridView
            // 
            this.tellerGridView.GridControl = this.tellerGridControl;
            this.tellerGridView.Name = "tellerGridView";
            this.tellerGridView.OptionsDetail.EnableMasterViewMode = false;
            this.tellerGridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // tellerRoleLookupEdit
            // 
            this.tellerRoleLookupEdit.AutoHeight = false;
            this.tellerRoleLookupEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tellerRoleLookupEdit.Name = "tellerRoleLookupEdit";
            // 
            // tellerControlNavigator
            // 
            this.tellerControlNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tellerControlNavigator.Location = new System.Drawing.Point(0, 197);
            this.tellerControlNavigator.Name = "tellerControlNavigator";
            this.tellerControlNavigator.NavigatableControl = this.tellerGridControl;
            this.tellerControlNavigator.Size = new System.Drawing.Size(653, 34);
            this.tellerControlNavigator.TabIndex = 2;
            this.tellerControlNavigator.Text = "controlNavigator2";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tellerControlNavigator);
            this.splitContainerControl1.Panel1.Controls.Add(this.tellerGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(653, 440);
            this.splitContainerControl1.SplitterPosition = 231;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // TellerManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "TellerManagementUI";
            this.Size = new System.Drawing.Size(653, 440);
            ((System.ComponentModel.ISupportInitialize)(this.tellerGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tellerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tellerRoleLookupEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl tellerGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView tellerGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit tellerRoleLookupEdit;
        private DevExpress.XtraEditors.ControlNavigator tellerControlNavigator;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}
