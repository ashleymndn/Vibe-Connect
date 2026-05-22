using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;

namespace Testing2

{
    [TestClass]
    public class tstInventoryCollection
    {
        [TestMethod]
        public void InventoryListOK()
        {
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            List<clsInventory> TestList = new List<clsInventory>();
            clsInventory TestItem = new clsInventory();
            TestItem.InventoryId = 1;
            TestItem.ProductId = 1;
            TestItem.ProductName = "Vphone1";
            TestItem.ProductPrice = 95.00m;
            TestItem.QuantityInStock = 5;
            TestItem.LastUpdated = DateTime.Now.Date;
            TestItem.StockStatus = "In Stock";
            TestItem.Active = true;
            TestList.Add(TestItem);
            AllInventories.InventoryList = TestList;
            Assert.AreEqual(AllInventories.InventoryList, TestList);
        }
        
        [TestMethod]
        public void ThisInventoryPropertyOK()
        {
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            clsInventory TestInventory = new clsInventory();
            TestInventory.InventoryId = 1;
            TestInventory.ProductId = 1;
            TestInventory.ProductName = "Vphone1";
            TestInventory.ProductPrice = 95.00m;
            TestInventory.QuantityInStock = 5;
            TestInventory.LastUpdated = DateTime.Now.Date;
            TestInventory.StockStatus = "In Stock";
            TestInventory.Active = true;
            AllInventories.ThisInventory = TestInventory;
            Assert.AreEqual(AllInventories.ThisInventory, TestInventory);
        }
        [TestMethod]
        public void ListandCountOK()
        {
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            List<clsInventory> TestList = new List<clsInventory>();
            clsInventory TestItem = new clsInventory();
            TestItem.InventoryId = 1;
            TestItem.ProductId = 1;
            TestItem.ProductName = "Vphone1";
            TestItem.ProductPrice = 95.00m;
            TestItem.QuantityInStock = 5;
            TestItem.LastUpdated = DateTime.Now.Date;
            TestItem.StockStatus = "In Stock";
            TestItem.Active = true;
            TestList.Add(TestItem);
            AllInventories.InventoryList = TestList;
            Assert.AreEqual(AllInventories.Count, TestList.Count);
        }

        [TestClass]
        public class testInventory

        {
            string ProductId = "1";
            string ProductName = "Vphone2";
            string StockStatus = "In Stock";
            string LastUpdated = DateTime.Now.Date.ToShortDateString();
            string ProductPrice = "95.00";
            string QuantityInStock = "5";



            [TestMethod]

            public void InstanceOK()
            {
                clsInventory AnInventory = new clsInventory();
                Assert.IsNotNull(AnInventory);
            }

            [TestMethod]
            public void ActivePropertyOK()
            {
                clsInventory AnInventory = new clsInventory();
                Boolean TestData = true;
                AnInventory.Active = TestData;
                Assert.AreEqual(AnInventory.Active, TestData);
            }

            [TestMethod]
            public void InventoryIdPropertyOK()
            {
                clsInventory AnInventory = new clsInventory();
                int TestData = 1;
                AnInventory.InventoryId = TestData;
                Assert.AreEqual(AnInventory.InventoryId, TestData);
            }

            [TestMethod]
            public void ProductIdPropertyOK()
            {
                clsInventory AnInventory = new clsInventory();
                int TestData = 1;
                AnInventory.ProductId = TestData;
                Assert.AreEqual(AnInventory.ProductId, TestData);
            }

            [TestMethod]
            public void QuantityInStockPropertyOK()
            {
                clsInventory AnInventory = new clsInventory();
                int TestData = 5;
                AnInventory.QuantityInStock = TestData;
                Assert.AreEqual(AnInventory.QuantityInStock, TestData);
            }

            [TestMethod]
            public void LastUpdatedPropertyOK()
            {

                clsInventory AnInventory = new clsInventory();
                DateTime TestData = DateTime.Now.Date;
                AnInventory.LastUpdated = TestData;
                Assert.AreEqual(AnInventory.LastUpdated, TestData);

            }
            [TestMethod]
            public void ProductNamePropertyOK()
            {
                clsInventory AnInventory = new clsInventory();
                string TestData = "Vphone1";
                AnInventory.ProductName = TestData;
                Assert.AreEqual(AnInventory.ProductName, TestData);
            }

            [TestMethod]

            public void ProductPricePropertyOK()
            {
                clsInventory AnInventory = new clsInventory();
                decimal TestData = 95.0m;
                AnInventory.ProductPrice = TestData;
                Assert.AreEqual(AnInventory.ProductPrice, TestData);
            }

            [TestMethod]
            public void StockStatusPropertyOK()
            {
                clsInventory AnInventory = new clsInventory();
                string TestData = "In Stock";
                AnInventory.StockStatus = TestData;
                Assert.AreEqual(AnInventory.StockStatus, TestData);
            }

            [TestMethod]
            public void FindMethodOK()
            {

                clsInventory AnInventory = new clsInventory();
                Boolean Found = false;
                Boolean OK = true;
                Int32 InventoryId = 2;
                Found = AnInventory.Find(InventoryId);
                Assert.IsTrue(Found);

                if (AnInventory.InventoryId != 2)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }


            [TestMethod]
            public void TestInventoryIdFound()
            {
                clsInventory AnInventory = new clsInventory();


                Boolean Found = false;


                Boolean OK = true;


                Int32 InventoryId = 2;

                Found = AnInventory.Find(InventoryId);


                if (AnInventory.InventoryId != 2)
                {
                    OK = false;
                }


                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestProductIdFound()
            {
                clsInventory AnInventory = new clsInventory();


                Boolean Found = false;


                Boolean OK = true;


                Int32 InventoryId = 2;

                Found = AnInventory.Find(InventoryId);


                if (AnInventory.ProductId != 7)
                {
                    OK = false;
                }


                Assert.IsTrue(OK);

            }
            [TestMethod]
            public void TestProductNameFound()
            {
                clsInventory AnInventory = new clsInventory();
                Boolean Found = false;
                Boolean OK = true;
                Int32 InventoryId = 2;
                Found = AnInventory.Find(InventoryId);

                if (AnInventory.ProductName != "Vphone2")
                {
                    OK = false;
                }

                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestProductPriceFound()
            {
                clsInventory AnInventory = new clsInventory();
                Boolean Found = false;
                Boolean OK = true;
                Int32 InventoryId = 2;
                Found = AnInventory.Find(InventoryId);
                if (AnInventory.ProductPrice != 104.00m)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestQuantityInStockFound()
            {
                clsInventory AnInventory = new clsInventory();
                Boolean Found = false;
                Boolean OK = true;
                Int32 InventoryId = 2;
                Found = AnInventory.Find(InventoryId);
                if (AnInventory.QuantityInStock != 9)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestLastUpdatedFound()
            {
                clsInventory AnInventory = new clsInventory();
                Boolean Found = false;
                Boolean OK = true;
                Int32 InventoryId = 2;
                Found = AnInventory.Find(InventoryId);
                if (AnInventory.LastUpdated != Convert.ToDateTime("03/05/2025 "))
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestStockStatusFound()
            {
                clsInventory AnInventory = new clsInventory();
                Boolean Found = false;
                Boolean OK = true;
                Int32 InventoryId = 2;
                Found = AnInventory.Find(InventoryId);
                if (AnInventory.StockStatus != "In Stock")
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void ValidMethodOk()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductNameMinLessOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductName = "";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void ProductNameMin()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductName = "V";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductNameMinPlusOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductName = "VV";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductNameMaxLessOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";

                string ProductName = "";
                ProductName = ProductName.PadRight(14, 'V');

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductNameMax()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";

                string ProductName = "";
                ProductName = ProductName.PadRight(15, 'V');

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductNameMaxPlusOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";

                string ProductName = "";
                ProductName = ProductName.PadRight(16, 'V');

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void ProductNameMid()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductName = "Vphone2";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductNameExtremeMax()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";

                string ProductName = "";
                ProductName = ProductName.PadRight(100, 'V');

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void LastUpdatedExtremeMin()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";

                DateTime TestDate;
                TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddYears(-100);

                String LastUpdated = TestDate.ToShortDateString();

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void LastUpdatedMinLessOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";

                DateTime TestDate;
                TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddDays(-1);

                String LastUpdated = TestDate.ToShortDateString();

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void LastUpdatedMin()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";

                DateTime TestDate;
                TestDate = DateTime.Now.Date;

                String LastUpdated = TestDate.ToShortDateString();

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void LastUpdatedMinPlusOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";

                DateTime TestDate;
                TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddDays(1);

                String LastUpdated = TestDate.ToShortDateString();

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void LastUpdatedExtremeMax()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";

                DateTime TestDate;
                TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddYears(100);

                String LastUpdated = TestDate.ToShortDateString();

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void LastUpdatedInvalidData()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";

                String LastUpdated = "This is not a date!";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StockStatusMinLessOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string StockStatus = "";
                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void StockStatusMin()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string StockStatus = "I";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void StockStatusMinPlusOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string StockStatus = "In";
                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
                Assert.AreEqual(Error, "");

            }
            [TestMethod]
            public void StockStatusMaxLessOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string StockStatus = "In";
                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
                Assert.AreEqual(Error, "");

            }
            [TestMethod]
            public void StockStatusMax()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string StockStatus = "In Stock";
                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void StockStatusMaxPlusOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";

                string StockStatus = "";
                StockStatus = StockStatus.PadRight(16, 'I');

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void StockStatusMaxPlus()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string StockStatus = "";
                StockStatus = StockStatus.PadRight(100, 'I');
                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void StockStatusMid()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string StockStatus = "In St";
                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void ProductPriceMinLessOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductPrice = "-0.01";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void ProductPriceMin()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductPrice = "0.01";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductPriceMinPlusOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductPrice = "1.00";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductPriceMaxLessOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductPrice = "299.99";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductPriceMax()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductPrice = "300.00";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductPriceMaxPlusOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductPrice = "300.01";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void ProductPriceMid()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductPrice = "150.00";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductPriceExtremeMax()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductPrice = "999999.99";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void QuantityInStockMinLessOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string QuantityInStock = "-1";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void QuantityInStockMin()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string QuantityInStock = "0";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void QuantityInStockMinPlusOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string QuantityInStock = "1";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void QuantityInStockMaxLessOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string QuantityInStock = "99";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void QuantityInStockMax()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string QuantityInStock = "100";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void QuantityInStockMaxPlusOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string QuantityInStock = "101";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void QuantityInStockMid()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string QuantityInStock = "50";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void QuantityInStockExtremeMax()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string QuantityInStock = "9999";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void QuantityInStockInvalidData()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string QuantityInStock = "abc";

                Error = AnInventory.Valid(ProductId,ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void ProductIdMinLessOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductId = "0";

                Error = AnInventory.Valid(ProductId, ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void ProductIdMin()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductId = "1";

                Error = AnInventory.Valid(ProductId, ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductIdMinPlusOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductId = "2";

                Error = AnInventory.Valid(ProductId, ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductIdMaxLessOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductId = "99";

                Error = AnInventory.Valid(ProductId, ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductIdMax()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductId = "100";

                Error = AnInventory.Valid(ProductId, ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductIdMaxPlusOne()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductId = "101";

                Error = AnInventory.Valid(ProductId, ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void ProductIdExtremeMax()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductId = "999999";

                Error = AnInventory.Valid(ProductId, ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void ProductIdMid()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductId = "50";

                Error = AnInventory.Valid(ProductId, ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductIdInvalidData()
            {
                clsInventory AnInventory = new clsInventory();
                String Error = "";
                string ProductId = "abc";

                Error = AnInventory.Valid(ProductId, ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

                Assert.AreNotEqual(Error, "");
            }

        }
         

        [TestMethod]
        public void AddMethodOk()
        {
            // create an instance of the class we want to create
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            // create an instance of the class we want to test
            clsInventory AnInventory = new clsInventory();
            // set the properties of the object
            AnInventory.InventoryId = 1;
            AnInventory.ProductId = 1;
            AnInventory.ProductName = "Vphone2";
            AnInventory.ProductPrice = 9.99m;
            AnInventory.QuantityInStock = 10;
            AnInventory.LastUpdated = DateTime.Now.Date;
            AnInventory.StockStatus = "In Stock";
            AnInventory.Active = true;
            // set ThisInventory to the test object
            AllInventories.ThisInventory = AnInventory;
            // add the record
            AllInventories.Add();
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance of collection class
            clsInventoryCollection AllInventory = new clsInventoryCollection();

            //create item for testing
            clsInventory TestItem = new clsInventory();

            //variable to store primary key
            Int32 PrimaryKey = 0;

            //set properties
            TestItem.ProductName = "Vphone2";
            TestItem.ProductPrice = 9.99m;
            TestItem.StockStatus = "In Stock";
            TestItem.QuantityInStock = 10;
            TestItem.ProductId = 1;
            TestItem.LastUpdated = DateTime.Now.Date;

            //set ThisInventory
            AllInventory.ThisInventory = TestItem;

            //add record
            PrimaryKey = AllInventory.Add();

            //set primary key of test data
            TestItem.InventoryId = PrimaryKey;

            //modify test record
            TestItem.ProductName = "Updated Phone";
            TestItem.ProductPrice = 19.99m;
            TestItem.StockStatus = "Out of Stock";
            TestItem.QuantityInStock = 5;

            //set updated record
            AllInventory.ThisInventory = TestItem;

            //perform update
            AllInventory.Update();

            //find updated record
            AllInventory.ThisInventory.Find(PrimaryKey);

            //test if updated record matches
            Assert.AreEqual(AllInventory.ThisInventory.ProductName, TestItem.ProductName);
        }
    }
}