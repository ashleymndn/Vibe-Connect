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
            //set the private data members to the test data value
            mOrderId = 21;
            mCustomerId = 2001;
            mOrderDate = Convert.ToDateTime("05/04/2025"); ;
            mTotal = 1899.00m;
            mAddress = "12 Sycamore St.";
            mOrderStatus = "Pending";
            mIsDelivered = false;
            //always return true
            return true;
        }
    }
}