namespace QLKS.UIControl
{
    partial class UIAdminManagement
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.adminGridControl = new DevExpress.XtraGrid.GridControl();
            this.adminGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.adminRoleLookupEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.adminRoleGridControl = new DevExpress.XtraGrid.GridControl();
            this.adminRoleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.controlNavigator2 = new DevExpress.XtraEditors.ControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminRoleLookupEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminRoleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminRoleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.controlNavigator1);
            this.splitContainerControl1.Panel1.Controls.Add(this.adminGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.adminRoleGridControl);
            this.splitContainerControl1.Panel2.Controls.Add(this.controlNavigator2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(694, 456);
            this.splitContainerControl1.SplitterPosition = 231;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator1.Location = new System.Drawing.Point(0, 192);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.NavigatableControl = this.adminGridControl;
            this.controlNavigator1.Size = new System.Drawing.Size(694, 39);
            this.controlNavigator1.TabIndex = 3;
            this.controlNavigator1.Text = "controlNavigator1";
            // 
            // adminGridControl
            // 
            this.adminGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.adminGridControl.Location = new System.Drawing.Point(-2, 3);
            this.adminGridControl.MainView = this.adminGridView;
            this.adminGridControl.Name = "adminGridControl";
            this.adminGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.adminRoleLookupEdit});
            this.adminGridControl.Size = new System.Drawing.Size(696, 188);
            this.adminGridControl.TabIndex = 2;
            this.adminGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.adminGridView});
            // 
            // adminGridView
            // 
            this.adminGridView.GridControl = this.adminGridControl;
            this.adminGridView.Name = "adminGridView";
            this.adminGridView.OptionsDetail.EnableMasterViewMode = false;
            this.adminGridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // adminRoleLookupEdit
            // 
            this.adminRoleLookupEdit.AutoHeight = false;
            this.adminRoleLookupEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.adminRoleLookupEdit.Name = "adminRoleLookupEdit";
            // 
            // adminRoleGridControl
            // 
            this.adminRoleGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.adminRoleGridControl.Location = new System.Drawing.Point(-2, -2);
            this.adminRoleGridControl.MainView = this.adminRoleGridView;
            this.adminRoleGridControl.Name = "adminRoleGridControl";
            this.adminRoleGridControl.Size = new System.Drawing.Size(696, 184);
            this.adminRoleGridControl.TabIndex = 4;
            this.adminRoleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.adminRoleGridView});
            // 
            // adminRoleGridView
            // 
            this.adminRoleGridView.GridControl = this.adminRoleGridControl;
            this.adminRoleGridView.Name = "adminRoleGridView";
            // 
            // controlNavigator2
            // 
            this.controlNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator2.Location = new System.Drawing.Point(0, 180);
            this.controlNavigator2.Name = "controlNavigator2";
            this.controlNavigator2.NavigatableControl = this.adminRoleGridControl;
            this.controlNavigator2.Size = new System.Drawing.Size(694, 39);
            this.controlNavigator2.TabIndex = 3;
            this.controlNavigator2.Text = "controlNavigator1";
            // 
            // UIAdminManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "UIAdminManagement";
            this.Size = new System.Drawing.Size(694, 456);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminRoleLookupEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminRoleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminRoleGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraGrid.GridControl adminGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView adminGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit adminRoleLookupEdit;
        private DevExpress.XtraGrid.GridControl adminRoleGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView adminRoleGridView;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator2;
    }
}
