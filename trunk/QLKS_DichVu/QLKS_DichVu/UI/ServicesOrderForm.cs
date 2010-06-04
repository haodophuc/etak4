using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKS_DichVu.UIControl;
using QLKS_DichVu.BUS;
using QLKS_DichVu.VO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;

namespace QLKS_DichVu.UI
{
    public partial class ServicesOrderForm : Form
    {
        #region Data members
        private ImageList sortingGlyphsImageList;
        private ServiceOrderBUS serviceOrderBUS;
        private ServiceOrderVO serviceOrderVO;
        private BindingSource masterBindingSource = new BindingSource();
        private BindingSource detailBindingSource = new BindingSource();
        private int lastID = 0;
        private int numOfRowsAppended = 0;
        #endregion

        #region constructors
        public ServicesOrderForm()
        {
            InitializeComponent();
            serviceOrderBUS = new ServiceOrderBUS(Program.DBConnection);

            // prepare image list for sorting glyph
            createImageList();
        }
       
        #endregion

        #region Helpers
        private void loadGrid()
        {
            serviceOrderVO = serviceOrderBUS.getVO();

            masterBindingSource.DataSource = serviceOrderVO.DataSet;
            masterBindingSource.DataMember = "PHIEU_THUE_PHONG";
            detailBindingSource.DataSource = masterBindingSource;
            detailBindingSource.DataMember = "PHIEU_THUE_PHONG__PHIEU_DANG_KY_DICH_VU";

            roomGridControl.DataSource = masterBindingSource;
            serviceGridControl.DataSource = detailBindingSource;
            dataNavigator1.DataSource = detailBindingSource;

            // set readonly for column "SO_PHIEU" because it is identity
            //serviceOrderBillView.Columns["SO_PHIEU"].OptionsColumn.ReadOnly = true;
        }

        private void createImageList()
        {
            sortingGlyphsImageList = new ImageList();
            sortingGlyphsImageList.Images.Add(Properties.Resources.up2);
            sortingGlyphsImageList.Images.Add(Properties.Resources.down2);
        }

        private void drawColumnHeaders()
        {
            roomBillView.Columns["MA_PHIEU"].Caption = "Mã phiếu";
            roomBillView.Columns["MA_PHIEU"].VisibleIndex = -1;
            roomBillView.Columns["SO_PHONG"].Caption = "Số phòng";
            roomBillView.Columns["NGAY_NHAN_PHONG"].Caption = "Ngày nhận phòng";
            roomBillView.Columns["NGAY_TRA_PHONG"].Caption = "Ngày trả phòng";

            serviceOrderBillView.Columns["SO_PHIEU"].Caption = "Số phiếu";
            serviceOrderBillView.Columns["MA_PHIEU"].Caption = "Mã phiếu";
            serviceOrderBillView.Columns["MA_PHIEU"].VisibleIndex = -1;
            serviceOrderBillView.Columns["MA_DICH_VU"].Caption = "Tên dịch vụ";
            serviceOrderBillView.Columns["NGAY_PHUC_VU"].Caption = "Ngày phục vụ";
            serviceOrderBillView.Columns["SO_LUONG"].Caption = "Số lượng";

            // fit columns
            roomBillView.BestFitColumns();
            serviceOrderBillView.BestFitColumns();
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
            roomBillView.Columns["SO_PHONG"].SortOrder = ColumnSortOrder.Ascending;
            serviceOrderBillView.Columns["SO_PHIEU"].SortOrder = ColumnSortOrder.Ascending;
        }

        private void groupSomeFirst()
        {

        }

        private void assignCellEditors()
        {
            assignCellEditorForCheckingInOutDate();
            assignCellEditorForServiceName();
            assignCellEditorForServiceQuantity();
            assignCellEditorForServiceDate();
        }

        private void assignCellEditorForCheckingInOutDate()
        {
            roomBillView.Columns["NGAY_NHAN_PHONG"].ColumnEdit = checkingInOutDateEdit;
            roomBillView.Columns["NGAY_TRA_PHONG"].ColumnEdit = checkingInOutDateEdit;
        }

        private void assignCellEditorForServiceName()
        {
            serviceLookupEdit.DataSource = serviceOrderVO.DichVuDataTable;
            serviceLookupEdit.PopulateColumns();
            serviceLookupEdit.DisplayMember = "TEN_DICH_VU";
            serviceLookupEdit.ValueMember = "MA_DICH_VU";
            serviceLookupEdit.Columns["MA_DICH_VU"].Caption = "Mã dịch vụ";
            serviceLookupEdit.Columns["MA_DICH_VU"].Visible = false;
            serviceLookupEdit.Columns["TEN_DICH_VU"].Caption = "Tên dịch vụ";
            serviceLookupEdit.Columns["TEN_DICH_VU"].SortOrder = ColumnSortOrder.Ascending;
            serviceLookupEdit.Columns["DON_GIA"].Caption = "Đơn giá";
            serviceLookupEdit.Columns["HIEU_LUC"].Caption = "Hiệu lực";         
            serviceLookupEdit.BestFit();

            serviceOrderBillView.Columns["MA_DICH_VU"].ColumnEdit = serviceLookupEdit;
        }

        private void assignCellEditorForServiceQuantity()
        {
            serviceOrderBillView.Columns["SO_LUONG"].ColumnEdit = quantitySpinEdit;
        }

        private void assignCellEditorForServiceDate()
        {
            serviceOrderBillView.Columns["NGAY_PHUC_VU"].ColumnEdit = serviceDateEdit;
        }
        
        private void sizeAndPosition()
        {
            Size = new Size(1000, 600);
            CenterToScreen();
        }
        #endregion

        #region Event handlers
        private void ServicesOrderForm_Load(object sender, EventArgs e)
        {
            splitContainerControl1.SplitterPosition = 300;
            sizeAndPosition();
            initLastID();
            loadGrid();
            drawColumnHeaders();
            groupSomeFirst();
            sortIt();
            assignCellEditors();
        }

        private void initLastID()
        {
            lastID = serviceOrderBUS.getLastIdentity();
        }
        
        private void roomBillView_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            drawSortGlyph(e);
        }

        private void serviceOrderBillView_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            drawSortGlyph(e);
        }

        private void ServicesOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void dataNavigator1_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            switch (e.Button.ButtonType)
            {
                case NavigatorButtonType.EndEdit:
                    updateRows(sender);                   
                    break;
                case NavigatorButtonType.Append:
                    //appendRow();
                    break;
                case NavigatorButtonType.CancelEdit:
                    //cancel();
                    break;
                case NavigatorButtonType.Remove:
                    //removeRow();
                    break;
                default:
                    break;
            }
        }

        private void serviceOrderBillView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            initNewRow(sender, e);
        }
        #endregion       

        #region DataSource manipulations
        private void updateRows(object sender)
        {   
            ////////////////// WORKING HERE ////////// NEED REFRESH GRID /////////
            serviceOrderBUS.update();
            serviceOrderBillView.RefreshData();
            serviceOrderBillView.RefreshEditor(true);
            serviceOrderBillView.Columns["SO_PHIEU"].SortOrder = ColumnSortOrder.Ascending;
            
            //lastID += numOfRowsAppended;
            //numOfRowsAppended = 0;            
        }

        private void removeRow()
        {
            //--numOfRowsAppended;
        }

        private void cancel()
        {
            --numOfRowsAppended;
        }

        private void appendRow()
        {
            ++numOfRowsAppended;
        }

        private void initNewRow(object sender, InitNewRowEventArgs e)
        {            
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, "NGAY_PHUC_VU", DateTime.Today);
            view.SetRowCellValue(e.RowHandle, "SO_LUONG", 1);
            //view.SetRowCellValue(e.RowHandle, "SO_PHIEU", lastID + numOfRowsAppended);
        }
        #endregion

        private void serviceOrderBillView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn serviceNameColumn = view.Columns["MA_DICH_VU"];
            String serviceName = view.GetRowCellDisplayText(e.RowHandle, serviceNameColumn);
            if (serviceName == serviceLookupEdit.NullText)
            {
                e.Valid = false;
                view.SetColumnError(serviceNameColumn, "Làm ơn chọn dịch vụ");
            }
        }

        private void serviceLookupEdit_BeforeShowMenu(object sender, DevExpress.XtraEditors.Controls.BeforeShowMenuEventArgs e)
        {
            //RepositoryItemLookUpEdit edit = sender as RepositoryItemLookUpEdit;
        }

        private void serviceOrderBillView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
    }
}