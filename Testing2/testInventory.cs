using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing2
{
    [TestClass]
    public class testInventory

    {
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
            Int32 InventoryId = 6;
            Found = AnInventory.Find(InventoryId);
            Assert.IsTrue(Found);

            if (AnInventory.InventoryId != 6)
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


            Int32 InventoryId = 6;

            Found = AnInventory.Find(InventoryId);


            if (AnInventory.InventoryId != 6)
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


            Int32 InventoryId = 5;

            Found = AnInventory.Find(InventoryId);


            if (AnInventory.ProductId != 4)
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
            Int32 InventoryId = 5;
            Found = AnInventory.Find(InventoryId);

            if (AnInventory.ProductName != "Vphone2ProMax")
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
            Int32 InventoryId = 5;
            Found = AnInventory.Find(InventoryId);
            if (AnInventory.ProductPrice != 265.00m)
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
            Int32 InventoryId = 6;
            Found = AnInventory.Find(InventoryId);
            if (AnInventory.QuantityInStock != 0)
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
            Int32 InventoryId = 6;
            Found = AnInventory.Find(InventoryId);
            if (AnInventory.LastUpdated != Convert.ToDateTime("01/04/2025"))
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
            Int32 InventoryId = 5;
            Found = AnInventory.Find(InventoryId);
            if (AnInventory.StockStatus != "Out Of Stock")
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
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated,ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductName = "";

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductName = "V";

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductName = "VV";

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductName = "VVVVV"; // 5 chars

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductName = "VVVVVV"; // 6 chars

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductName = "VVVVVVV"; // 7 chars

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductName = "VVV"; // middle value

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(100, 'V');

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

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

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

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

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

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

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

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

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

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

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastUpdatedInvalidData()
        {
            clsInventory AnInventory = new clsInventory();
            String Error = "";

            String LastUpdated = "This is not a date!";

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockStatusMinLessOne()
        {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string StockStatus = "";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockStatusMin()
        {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string StockStatus = "I";

            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockStatusMinPlusOne()
        {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string StockStatus = "In";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StockStatusMaxLessOne() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string StockStatus = "In";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StockStatusMax() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string StockStatus = "In Stock";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockStatusMaxPlusOne() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string StockStatus = "In Stock!";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StockStatusMaxPlus() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string StockStatus = "";
            StockStatus = StockStatus.PadRight(100, 'I');
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockStatusMid() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string StockStatus = "In St";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductPriceMinLessOne() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductPrice = "-0.01";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductPriceMin() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductPrice = "0.00";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductPriceMinPlusOne() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductPrice = "0.01";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductPriceMaxLessOne() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductPrice = "999999.99";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductPriceMax() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductPrice = "1000000.00";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");
        } 
        [TestMethod]
        public void ProductPriceMaxPlusOne() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductPrice = "1000000.01";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductPriceMid() {  
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string ProductPrice = "500000.00";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityInStockMinLessOne() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string QuantityInStock = "-1";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInStockMin() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string QuantityInStock = "0";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityInStockMinPlusOne() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string QuantityInStock = "1";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityInStockMaxLessOne() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string QuantityInStock = "9999";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityInStockMax() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string QuantityInStock = "10000";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");
        } 
        [TestMethod]
        public void QuantityInStockMaxPlusOne() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string QuantityInStock = "10001";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityInStockMid() {
            clsInventory AnInventory = new clsInventory();
            String Error = "";
            string QuantityInStock = "5000";
            Error = AnInventory.Valid(ProductName, StockStatus, LastUpdated, ProductPrice, QuantityInStock);
            Assert.AreEqual(Error, "");
        }
    }
}