using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKS.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using QLKS.VO;
using QLKS.BUS;
using System.Data.Sql;

namespace QLKS.UI
{
    public partial class FormTest : DevExpress.XtraEditors.XtraForm
    {
        public FormTest()
        {
            InitializeComponent();

            //regdata = new RegData();       
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            
            //gridControl1.DataSource = regdata.Customers;
            //gridView1.Columns[0].Visible = false;
            ////gridControl2.DataSource = regdata.Groups;
            //gridControl3.DataSource = regdata.Rooms;

            //RepositoryItemLookUpEdit lookupRoom = new RepositoryItemLookUpEdit();
            //lookupRoom.DataSource = regdata.Rooms;
            //lookupRoom.DisplayMember = "RoomNumber";
            //lookupRoom.ValueMember = "RoomID";

            //LookUpColumnInfoCollection cols = lookupRoom.Columns;
            //cols.Add( new LookUpColumnInfo("RoomNumber", "Số Phòng", 0));
            //cols.Add(new LookUpColumnInfo("RoomType", "Loại Phòng", 0));
            //cols.Add(new LookUpColumnInfo("Beds", "Số Giường", 0));
            //lookupRoom.BestFitMode = BestFitMode.BestFitResizePopup;
            //lookupRoom.NullText = "Chưa chọn phòng";
            //gridView1.Columns["RoomNumber"].ColumnEdit = lookupRoom;

            //gridControl2.DataSource = regdata.Companies;
            //gridView2.Columns[0].Visible = false;

        }
        
       private RegData regdata;

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //regdata.Update();
            
            gridControl1.DataSource = regdata.Rooms;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //String[] values = new String[9];
            //values[0] = textBox1.Text;
            //values[1] = textBox2.Text;
            //values[2] = textBox3.Text;
            //values[3] = textBox4.Text;
            //String value = textBox5.Text;
            //values[5] = textBox6.Text;
            //values[6] = textBox7.Text;
            //values[7] = textBox8.Text;
            //values[8] = textBox9.Text;
            //AddRow(value);

            //regdata.Update();

            //PhieuThuePhongBUS bus = new PhieuThuePhongBUS();
            //PhieuThuePhongVO pack = new PhieuThuePhongVO();

            //DataRow row = gridView1.GetFocusedDataRow();

            //MessageBox.Show(row["CustomerID"].ToString());
            int int32 = Int32.Parse(textBoxCustomer1.EditValue.ToString());
            
            MessageBox.Show(int32.ToString());


        }

        public void AddRow(String value) {
            DataRow row = gridView1.GetFocusedDataRow();
            row["RoomNumber"] = "Click để chọn phòng";
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            //tabContainer.SelectedTabPage.Controls.Add(gridControl1);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //DataRow row = gridView1.GetFocusedDataRow();

            //textBox1.Text = row[0].ToString();
            //textBox2.Text = row[1].ToString();
            //textBox3.Text = row[2].ToString();
            //textBox4.Text = row[3].ToString();
            //textBox5.Text = row[4].ToString();
            //textBox6.Text = row[5].ToString();
            //textBox7.Text = row[6].ToString();
            //textBox8.Text = row[7].ToString();
            //textBox9.Text = row[8].ToString();
            //textBox10.Text = row[9].ToString();
        }//end method AddRow


    }//end class

}//end namespace