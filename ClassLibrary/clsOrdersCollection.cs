using System;
using System.Collections.Generic;
using System.Net;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        List<clsOrders> mOrdersList = new List<clsOrders>();

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

        public clsOrders ThisOrder { get; set; }
    }
}