﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

namespace QLKS.Base
{
    public class TableRooms : DataTable
    {
        public TableRooms()
            : base("Rooms")
        {
            AddColumns();
        }//end default constructor

        private void AddColumns()
        {

            DataColumnCollection cols = this.Columns;

            // Idenfity column
            DataColumn roomid = cols.Add("RoomID", typeof(Int32));
            roomid.AllowDBNull = false;
            roomid.AutoIncrement = true;
            roomid.AutoIncrementSeed = -1;
            roomid.AutoIncrementStep = -1;

            // Add other column
            cols.Add("RoomTypeID", typeof(Int32));
            cols.Add("RoomType", typeof(String)).Caption = "Loại Phòng";
            cols.Add("TicketID", typeof(Int32));
            cols.Add("OwnerID", typeof(Int32));
            cols.Add("Owner", typeof(String)).Caption = "Người Đứng Tên Thuê";
            cols.Add("RoomNumber", typeof(String)).Caption = "Số Phòng";
            cols.Add("Beds", typeof(Int32)).Caption = "Số Giường";
            cols.Add("Price", typeof(Decimal)).Caption = "Đơn Giá";
            cols.Add("Quantity", typeof(Int32)).Caption = "Số Lượng Phòng Đã Đăng Ký";

            // Add primary colummn
            this.PrimaryKey = new DataColumn[] { cols["RoomID"] };

        }//end method IniColumns

        public DataTableMapping GetTableMapping()
        {
            // Return an empty DataTableMapping object at the time being.
            return new DataTableMapping();
        }//end method GetTableMapping

        public String SelectCommand
        {
            get { return "SELECT * FROM PHONG"; }
        }//end attribute SelectCommand

        public enum RoomState : int { Ready = 1, Busy, Cleaning };

    }//end clas RoomTable
}//end namespace
