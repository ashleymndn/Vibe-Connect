using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public bool Active { get; set; }      
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public decimal Total { get; set; }
        public string Address { get; set; }
        public string OrderStatus { get; set; }
        public bool IsDelivered { get; set; }

    }
}