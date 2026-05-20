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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();

            clsOrders TestItem = new clsOrders();

            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.IsDelivered = false;
            TestItem.OrderId = 5;
            TestItem.CustomerId = 8;
            TestItem.Total = 95.00m;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Address = "8233 Westwood Avenue";
            TestItem.OrderStatus = "Pending";

            //set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem;

            //add the record
            PrimaryKey = AllOrders.Add();

            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;

            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;

            TestItem.IsDelivered = false;
            TestItem.OrderId = 5;
            TestItem.CustomerId = 8;
            TestItem.Total = 95.00m;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Address = "8233 Westwood Avenue";
            TestItem.OrderStatus = "Pending";

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.OrderId = PrimaryKey;

            TestItem.IsDelivered = false;
            TestItem.OrderId = 11;
            TestItem.CustomerId = 14;
            TestItem.Total = 275.00m;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Address = "89 Elmore Lane";
            TestItem.OrderStatus = "Pending";

            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.IsDelivered = false;
            TestItem.OrderId = 5;
            TestItem.CustomerId = 8;
            TestItem.Total = 95.00m;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Address = "8233 Westwood Avenue";
            TestItem.OrderStatus = "Pending";

            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the reccord
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByOrderStatusMethodOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            FilteredOrders.ReportByOrderStatus("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderStatusNoneFound()
        {
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            FilteredOrders.ReportByOrderStatus("xxxxxx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderStatusDataFound()
        {
            //create an instance of filtered data
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply the order status that doesn't exist
            FilteredOrders.ReportByOrderStatus("Pending");
            //check that the corrct number of records are foumd
            if (FilteredOrders.Count == 2)
            {
                //check to see that the first record is 24
                if (FilteredOrders.OrdersList[0].OrderId != 26)
                {
                    OK = false;
                }
                //check to see that the first record is 26
                if (FilteredOrders.OrdersList[0].OrderId != 36)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}
