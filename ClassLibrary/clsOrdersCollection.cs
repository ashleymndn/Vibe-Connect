using System;
using System.Collections.Generic;
using System.Net;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        List<clsOrders> mOrdersList = new List<clsOrders>();
        clsOrders mThisOrder = new clsOrders();

        public clsOrdersCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrders_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrders AnOrder = new clsOrders();
                AnOrder.IsDelivered = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsDelivered"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.Total = Convert.ToDecimal(DB.DataTable.Rows[Index]["Total"]);
                AnOrder.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                
                mOrdersList.Add(AnOrder);
                Index++;
            }
        }

        public List<clsOrders> OrdersList
        {
            get
            {
                return mOrdersList;
            }
            set
            {
                mOrdersList = value;
            }
        }

        public int Count
        {
            get
            {
                return OrdersList.Count;
            }
            set
            {

            }
        }

        public clsOrders ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Total", mThisOrder.Total);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@IsDelivered", mThisOrder.IsDelivered);

            return DB.Execute("sproc_tblOrders_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //execure te stored procedure
            DB.Execute("sproc_tblOrders_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Total", mThisOrder.Total);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@IsDelivered", mThisOrder.IsDelivered);

            DB.Execute("sproc_tblOrders_Update");
        }
    }
}