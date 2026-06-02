using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for the order id property
        private Int32 mOrderId;
        //orderId public property
        public int OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }

        private Int32 mCustomerId;
        public int CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

        private decimal mTotal;

        public decimal Total
        {
            get
            {
                return mTotal;
            }
            set
            {
                mTotal = value;
            }
        }


        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }

        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        private string mOrderStatus;
        public string OrderStatus
        {
            get
            {
                return mOrderStatus;
            }
            set
            {
                mOrderStatus = value;
            }
        }

        private bool mIsDelivered;
        public bool IsDelivered
        {
            get
            {
                return mIsDelivered;
            }
            set
            {
                mIsDelivered = value;
            }
        }


        public bool Active { get; set; }

        public bool Find(int OrderId)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the address id to search for
            DB.AddParameter("@OrderId", OrderId);

            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderId");

            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {

                //set the private data members to the test data value
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotal = Convert.ToDecimal(DB.DataTable.Rows[0]["Total"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                mIsDelivered = Convert.ToBoolean(DB.DataTable.Rows[0]["IsDelivered"]);
                //always return true
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string customerId, string orderDate, string total, string address, string orderStatus)
        {
            String Error = "";
            DateTime DateTemp;
            if (customerId.Length == 0)
            {
                Error = Error + "The customer id may not be blank : ";
            }

            if (customerId.Length > 6)
            {
                Error = Error + "The customer id may not be greater than 6 characters  : ";
            }

            DateTime DateComp = DateTime.Now.Date;

            try
            {
                DateTemp = Convert.ToDateTime(orderDate);

                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannnot be in the past : ";
                }
                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannnot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            if (total.Length == 0)
            {
                Error = Error + "The total may not be blank : ";
            }

            if (total.Length > 100)
            {
                Error = Error + "The total must be less than 100 characters : ";
            }

            if (address.Length == 0)
            {
                Error = Error + "The address may not be blank : ";
            }

            if (address.Length > 300)
            {
                Error = Error + "The address must be less than 300 characters : ";
            }

            if (orderStatus.Length == 0)
            {
                Error = Error + "The order status may not be blank : ";
            }

            if (orderStatus.Length > 32)
            {
                Error = Error + "The order status must be less than 50 characters : ";
            }


            return Error;

        }
    }
}

