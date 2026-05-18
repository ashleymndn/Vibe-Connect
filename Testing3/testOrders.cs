using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing3
{
    [TestClass]
    public class testOrders
    {
        string CustomerId = "105";
        string OrderDate = DateTime.Now.ToShortDateString();
        string Total = "1799.00";
        string Address = "566 Grenville St.";
        string OrderStatus = "Pending";

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsOrders AnOrder = new clsOrders();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean TestData = true;
            AnOrder.Active = TestData;
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            Int32 TestData = 1;
            AnOrder.OrderId = TestData;
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            Int32 TestData = 101;
            AnOrder.CustomerId = TestData;
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }


        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void TotalPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            decimal TestData = 2499.00m;
            AnOrder.Total = TestData;
            Assert.AreEqual(AnOrder.Total, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            string TestData = "123 Sycamore Lane";
            AnOrder.Address = TestData;
            Assert.AreEqual(AnOrder.Address, TestData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            string TestData = "Delivered";
            AnOrder.OrderStatus = TestData;
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }

        [TestMethod]
        public void IsDeliveredPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            bool TestData = true;
            AnOrder.IsDelivered = TestData;
            Assert.AreEqual(AnOrder.IsDelivered, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);

        }

        /******************PROPERTY DATA TESTS******************/

        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.CustomerId != 101)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderDate != Convert.ToDateTime("07/02/2025"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Total != 95.00m)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Address != "123 Sycamore Lane")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderStatus != "Delivered")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsDeliveredFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.IsDelivered != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }




        /******************PARAMETER TESTS******************/

        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string CustomerId = "";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string CustomerId = "a";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string CustomerId = "aa";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string CustomerId = "aaaaa";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string CustomerId = "aaaaaa";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string CustomerId = "aaa";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string CustomerId = "aaaaaaa";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerIdExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string CustomerId = "";
            CustomerId = CustomerId.PadRight(500, 'a');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string OrderDate = "this is not a valid date !";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Total = "";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Total = "0";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Total = "00";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotaldMaxLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Total = "";
            Total = Total.PadRight(99, '0');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Total = "";
            Total = Total.PadRight(100, '0');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Total = "";
            Total = Total.PadRight(50, '0');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalMaxPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Total = "";
            Total = Total.PadRight(101, '0');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Total = "";
            Total = Total.PadRight(300, '0');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AddressMinInLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Address = "";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Address = "w";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Address = "ww";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(299, 'w');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(300, 'w');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(301, 'w');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(250, 'w');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(500, 'w');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinInLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string OrderStatus = "w";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string OrderStatus = "ww";
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(31, 'w');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(32, 'w');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(33, 'w');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(16, 'w');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(100, 'w');
            Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
    }
}
