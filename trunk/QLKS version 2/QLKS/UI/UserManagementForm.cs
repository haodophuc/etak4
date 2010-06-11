using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using QLKS.BUS;
using QLKS.VO;
using System.Security.Cryptography;

namespace QLKS.UI
{
    public partial class UserManagementForm : DevExpress.XtraEditors.XtraForm
    {
        #region Data members
        private UserBUS userBUS;
        private ImageList sortingGlyphsImageList;
        #endregion

        #region constructors
        public UserManagementForm()
        {
            InitializeComponent();
            userBUS = new UserBUS();

            // prepare image list for sorting glyph
            createImageList();
        }
        #endregion

        #region Helpers
        private void sizeAndPosition()
        {
            this.Size = new Size(1000, 680);
            this.Location = new Point((this.MdiParent.ClientSize.Width - this.Width) / 2,
                                      (this.MdiParent.ClientSize.Height - this.Height) / 2);
        }

        private void loadGrid()
        {
            UserVO userVO = userBUS.getVO();

            userGridControl.DataSource = userVO.DataSet;
            userGridControl.DataMember = "USERS";
            userGridControl.ForceInitialize();

            userGridControl.LevelTree.Nodes.Add("USERS__USER2ROLE", user2roleGridView);
            user2roleGridView.PopulateColumns(userVO.UserRoleDataTable);

            // set readonly for column "USERID" because it is identity
            userGridView.Columns["USERID"].OptionsColumn.ReadOnly = true;
            user2roleGridView.Columns["USERID"].OptionsColumn.ReadOnly = true;
        }

        private void drawColumnHeaders()
        {
            userGridView.Columns["USERID"].Caption = "ID";
            //userGridView.Columns["USERID"].VisibleIndex = -1;
            userGridView.Columns["USER_NAME"].Caption = "Tên đăng nhập";
            userGridView.Columns["LAST_NAME"].Caption = "Họ";
            userGridView.Columns["FIRST_NAME"].Caption = "Tên";
            userGridView.Columns["IS_ADMIN"].Caption = "Là admin";
            userGridView.Columns["ADDRESS_STREET"].Caption = "Địa chỉ";
            userGridView.Columns["PHONE"].Caption = "Điện thoại";
            userGridView.Columns["EMAIL"].Caption = "Email";
            userGridView.Columns["DETAILS"].Caption = "Mô tả thêm";

            user2roleGridView.Columns["USERID"].Caption = "Tên đăng nhập";
            user2roleGridView.Columns["ROLEID"].Caption = "Vai trò";

            // best fit columns of grid views
            userGridView.BestFitColumns();
            user2roleGridView.BestFitColumns();
        }

        private void createImageList()
        {
            sortingGlyphsImageList = new ImageList();
            sortingGlyphsImageList.Images.Add(Properties.Resources.up2);
            sortingGlyphsImageList.Images.Add(Properties.Resources.down2);
        }

        private void updateInnerElements(ColumnHeaderCustomDrawEventArgs e, bool restore, ref Rectangle sortBounds)
        {
            //Locate an element corresponding to the sort glyph
            foreach (DevExpress.Utils.Drawing.DrawElementInfo item in e.Info.InnerElements)
            {
                if (item.ElementPainter is DevExpress.Utils.Drawing.SortedShapeObjectPainter)
                {
                    if (restore)
                    {
                        //Restore the rectangle for the sort glyph
                        item.ElementInfo.Bounds = sortBounds;
                    }
                    else
                    {
                        //Store the rectangle for the sort glyph in sortBounds and
                        //then clear this region in the e.Info object
                        sortBounds = item.ElementInfo.Bounds;
                        item.ElementInfo.Bounds = Rectangle.Empty;
                    }
                }
            }
        }

        private void drawCustomSortedShape(Graphics g, Rectangle r, ColumnSortOrder so, ImageList iml)
        {
            //Draw a custom image for the sort glyph
            if (so == ColumnSortOrder.None) return;
            int i = 0;
            if (so == ColumnSortOrder.Descending) i = 1;
            g.DrawImageUnscaled(iml.Images[i], r.X + (r.Width - iml.ImageSize.Width) / 2, r.Y +
              (r.Height - iml.ImageSize.Height) / 2);
        }

        private void drawSortGlyph(DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == null) return;
            //A rectangle for the sort glyph
            Rectangle sortBounds = Rectangle.Empty;
            try
            {
                //Store the rectangle for the sort glyph in sortBounds and
                //then clear this region in the e.Info object
                updateInnerElements(e, false, ref sortBounds);
                //Draw the column header without the sort glyph
                e.Painter.DrawObject(e.Info);
            }
            finally
            {
                //Restore the rectangle for the sort glyph
                updateInnerElements(e, true, ref sortBounds);
            }

            if (!sortBounds.IsEmpty)
            {
                //Perform custom painting of the sort glyph
                drawCustomSortedShape(e.Graphics, sortBounds, e.Column.SortOrder, sortingGlyphsImageList);
            }
            e.Handled = true;
        }

        private void sortIt()
        {
            userGridView.Columns["USERID"].SortOrder = ColumnSortOrder.Ascending;
            user2roleGridView.Columns["ROLEID"].SortOrder = ColumnSortOrder.Ascending;          
        }

        private void initNewRowForMasterView(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.FocusedColumn = view.Columns["USER_NAME"];
            view.SetRowCellValue(e.RowHandle, "USER_NAME", "Unknown");
            view.SetRowCellValue(e.RowHandle, "FIRST_NAME", "Unknown");
            view.SetRowCellValue(e.RowHandle, "LAST_NAME", "Unknown");
            view.SetRowCellValue(e.RowHandle, "IS_ADMIN", false);
        }

        private void validateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.ClearColumnErrors();

            //// validate user ID HOW??????????
            //GridColumn userIDColumn = view.Columns["USERID"];
            //String userID = view.GetRowCellDisplayText(e.Row, userIDColumn);
            //if (userID == "")
            //{
            //    e.Valid = false;
            //    view.SetColumnError(view.Columns["USERID"], "Làm ơn cập nhật lưới trước khi thêm dòng này");
            //}

            // validate user name
            GridColumn userNameColumn = view.Columns["USER_NAME"];
            String userName = view.GetRowCellDisplayText(e.RowHandle, userNameColumn);
            if (userName == "")
            {
                e.Valid = false;
                view.SetColumnError(userNameColumn, "Làm ơn nhập tên đăng nhập");
            }

            // guarantee unique name
            userName = view.GetRowCellDisplayText(GridControl.NewItemRowHandle, userNameColumn);
            if (userBUS.didThisUserExist(userName))
            {
                e.Valid = false;
                view.SetColumnError(userNameColumn, "Tên đăng nhập đã tồn tại");
            }

            // validate first name
            GridColumn firstNameColumn = view.Columns["FIRST_NAME"];
            String firstName = view.GetRowCellDisplayText(e.RowHandle, firstNameColumn);
            if (firstName == "")
            {
                e.Valid = false;
                view.SetColumnError(firstNameColumn, "Làm ơn nhập tên");
            }

            // validate last name
            GridColumn lastNameColumn = view.Columns["LAST_NAME"];
            String lastName = view.GetRowCellDisplayText(e.RowHandle, lastNameColumn);
            if (lastName == "")
            {
                e.Valid = false;
                view.SetColumnError(lastNameColumn, "Làm ơn nhập họ");
            }
        }

        private void f()
        {
            //GridColumn userNameColumn = userGridView.Columns["USER_NAME"];
            //String userName = userGridView.GetRowCellDisplayText(e.RowHandle, userNameColumn);
            //if (userBUS.didThisUserExist(userName))
            //{
            //    e.Valid = false;
            //    view.SetColumnError(userNameColumn, "Tên đăng nhập đã tồn tại");
            //}
        }
        #endregion

        #region Cell Editors
        private void assignCellEditors()
        {
            assignCellEditorForAddressStreet();
            assignCellEditorForPhone();
            assignCellEditorForEmail();
            assignCellEditorForRoleUserNote();
            assignCellEditorForUserID();
            assignCellEditorForRoleID();
        }

        private void assignCellEditorForPhone()
        {
            userGridView.Columns["PHONE"].ColumnEdit = phoneMemoExEdit;
        }

        private void assignCellEditorForEmail()
        {
            userGridView.Columns["EMAIL"].ColumnEdit = emailMemoExEdit;
        }

        private void assignCellEditorForAddressStreet()
        {
            userGridView.Columns["ADDRESS_STREET"].ColumnEdit = addressMemoExEdit;
        }

        private void assignCellEditorForRoleUserNote()
        {
            userGridView.Columns["DETAILS"].ColumnEdit = userNoteMemoExEdit;
        }

        private void assignCellEditorForRoleID()
        {
            UserVO userVO = userBUS.getVO();

            roleNameLookupEdit.DataSource = userVO.RoleDataTable;
            roleNameLookupEdit.PopulateColumns();
            roleNameLookupEdit.DisplayMember = "ROLE_NAME";
            roleNameLookupEdit.ValueMember = "ROLEID";
            roleNameLookupEdit.Columns["ROLEID"].Caption = "Mã vai trò";
            roleNameLookupEdit.Columns["ROLEID"].Visible = false;
            roleNameLookupEdit.Columns["ROLE_NAME"].Caption = "Tên vai trò";
            roleNameLookupEdit.Columns["ROLE_NAME"].SortOrder = ColumnSortOrder.Ascending;
            roleNameLookupEdit.Columns["DETAILS"].Caption = "Mô tả";

            user2roleGridView.Columns["ROLEID"].ColumnEdit = roleNameLookupEdit;
        }

        private void assignCellEditorForUserID()
        {
            UserVO userVO = userBUS.getVO();

            userNameLookupEdit.DataSource = userVO.UserDataTable;
            userNameLookupEdit.PopulateColumns();
            for (int i = 0; i < userNameLookupEdit.Columns.Count; ++i)
                userNameLookupEdit.Columns[i].Visible = false;

            userNameLookupEdit.Columns["USER_NAME"].Visible = true;
            userNameLookupEdit.DisplayMember = "USER_NAME";
            userNameLookupEdit.ValueMember = "USERID";

            user2roleGridView.Columns["USERID"].ColumnEdit = userNameLookupEdit;
        }
        #endregion

        #region Form's Event Handlers
        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            sizeAndPosition();

            loadGrid();
            drawColumnHeaders();
            sortIt();
            assignCellEditors();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            userBUS.setInitialPassword(initialPasswordTextBox.Text);
            initialPasswordTextBox.Clear();
        }

        private void userControlNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            GridView view = userGridControl.FocusedView as GridView;
            switch (e.Button.ButtonType)
            {
                case NavigatorButtonType.EndEdit:
                    updateRows(view, e);
                    f();
                    break;

                case NavigatorButtonType.Append:
                    break;
            }
        }
        #endregion

        #region DataSource manipulations
        private void updateRows(GridView view, NavigatorButtonClickEventArgs e)
        {
            view.FocusedRowHandle = Int32.MinValue;
            if (view.Name == "userGridView")
            {
                userBUS.updateUsers();
            }
            else
            {
                userBUS.updateUserRoles();
            }            
        }
        #endregion

        #region MasterView's Event Handlers
        private void userGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            initNewRowForMasterView(sender, e);
        }

        private void userGridView_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            drawSortGlyph(e);
        }

        private void userGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            validateRow(sender, e);
        }

        private void userGridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void userGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            Object obj = userGridView.GetRowCellValue(userGridView.FocusedRowHandle, userGridView.Columns["USER_NAME"]);
            if (obj is DBNull)
                return;
            String userName = (String)obj;

            if (userName == "admin")
                e.Cancel = true;
        }

        private void userGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Object obj = userGridView.GetRowCellValue(e.FocusedRowHandle, userGridView.Columns["USER_NAME"]);
            if (obj is DBNull)
                return;
            String userName = (String)obj;
            
            if (userName == "admin" || e.PrevFocusedRowHandle == Int32.MinValue)
                userControlNavigator.Buttons.Remove.Enabled = false;
            else
                userControlNavigator.Buttons.Remove.Enabled = true;
        }
        #endregion

        #region DetailView's Event Handlers
        private void user2roleGridView_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            drawSortGlyph(e);
        }

        private void user2roleGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "USERID")
                e.Cancel = true;
        }

        private void user2roleGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn roleNameColumn = view.Columns["ROLEID"];
            String roleName = view.GetRowCellDisplayText(e.RowHandle, roleNameColumn);
            if (roleName == roleNameColumn.ColumnEdit.NullText)
            {
                e.Valid = false;
                view.SetColumnError(roleNameColumn, "Làm ơn chọn vai trò");
            }
        }

        private void user2roleGridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
        #endregion
    }


}