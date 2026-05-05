using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        public void CustomerIdPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            Int32 TestData = 1;
            AnOrder.CustomerId = TestData;
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            String TestData = "test@email.com";
            AnOrder.Email = TestData;
            Assert.AreEqual(AnOrder.Email, TestData);
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
            decimal TestData = 900.99m;
            AnOrder.Total = TestData;
            Assert.AreEqual(AnOrder.Total, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            string TestData = "Dubai Marina";
            AnOrder.Address = TestData;
            Assert.AreEqual(AnOrder.Address, TestData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            string TestData = "Processing";
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


    }
}
