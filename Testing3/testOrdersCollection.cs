using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class testOrdersCollection
    {
       

        [TestMethod]
        public void InstanceOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrdersListOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();

            List<clsOrders> TestList = new List<clsOrders>();
            clsOrders TestItem = new clsOrders();

            TestItem.IsDelivered = false;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 8;
            TestItem.Total = 95.00m;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Address = "8233 Westwood Avenue";
            TestItem.OrderStatus = "Pending";

            TestList.Add(TestItem);
            AllOrders.OrdersList = TestList;
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            clsOrders TestOrders = new clsOrders();

            TestOrders.IsDelivered = false;
            TestOrders.OrderId = 1;
            TestOrders.CustomerId = 8;
            TestOrders.Total = 95.00m;
            TestOrders.OrderDate = DateTime.Now;
            TestOrders.Address = "8233 Westwood Avenue";
            TestOrders.OrderStatus = "Pending";


            AllOrders.ThisOrder = TestOrders;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrders);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            List<clsOrders> TestList = new List<clsOrders>();
            clsOrders TestItem = new clsOrders();

            TestItem.IsDelivered = false;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 8;
            TestItem.Total = 95.00m;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Address = "8233 Westwood Avenue";
            TestItem.OrderStatus = "Pending";

            TestList.Add(TestItem);
            AllOrders.OrdersList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

    }
}
