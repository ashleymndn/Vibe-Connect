using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing3
{
    [TestClass]
    public class testOrders
    {
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
            if (AnOrder.Total != 2499.00m)
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







    }
}
