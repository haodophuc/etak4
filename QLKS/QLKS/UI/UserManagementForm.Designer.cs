namespace QLKS.UI
{
    partial class UserManagementForm
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
            this.userManagementTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.adminTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.tellerTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementTabControl)).BeginInit();
            this.userManagementTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // userManagementTabControl
            // 
            this.userManagementTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userManagementTabControl.Location = new System.Drawing.Point(0, 0);
            this.userManagementTabControl.Name = "userManagementTabControl";
            this.userManagementTabControl.SelectedTabPage = this.adminTabPage;
            this.userManagementTabControl.Size = new System.Drawing.Size(553, 230);
            this.userManagementTabControl.TabIndex = 0;
            this.userManagementTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.adminTabPage,
            this.tellerTabPage});
            // 
            // adminTabPage
            // 
            this.adminTabPage.Name = "adminTabPage";
            this.adminTabPage.Size = new System.Drawing.Size(546, 201);
            this.adminTabPage.Text = "Quản lý admin";
            // 
            // tellerTabPage
            // 
            this.tellerTabPage.Name = "tellerTabPage";
            this.tellerTabPage.Size = new System.Drawing.Size(546, 201);
            this.tellerTabPage.Text = "Quản lý thu ngân";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 230);
            this.Controls.Add(this.userManagementTabControl);
            this.Name = "UserManagementForm";
            this.Text = "UserManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.userManagementTabControl)).EndInit();
            this.userManagementTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl userManagementTabControl;
        private DevExpress.XtraTab.XtraTabPage adminTabPage;
        private DevExpress.XtraTab.XtraTabPage tellerTabPage;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;

    }
}