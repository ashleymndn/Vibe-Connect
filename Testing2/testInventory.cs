using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class testInventory
    {
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
        public void LastUpdatedPropertyOK() {

            clsInventory AnInventory = new clsInventory();
            DateTime TestData = DateTime.Now.Date;
            AnInventory.LastUpdated = TestData;
            Assert.AreEqual(AnInventory.LastUpdated, TestData);

        }
        [TestMethod]
        public void ProductNamePropertyOK() {
            clsInventory AnInventory = new clsInventory();
            string TestData = "Vphone 1";
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

            if (AnInventory.InventoryId != 2) {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsInventory AnInventory = new clsInventory();

            Boolean Found = false;
            Boolean OK = true;
            Int32 InventoryId = 2;

            Found = AnInventory.Find(InventoryId);

            if (AnInventory.Active != true)
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


            if (AnInventory.ProductId != 1)
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

            if (AnInventory.ProductName != "Vphone 1")
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
            if (AnInventory.ProductPrice != 95.0m)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityInStockFound() { 
            clsInventory AnInventory = new clsInventory();
            Boolean Found = false;
            Boolean OK = true;
            Int32 InventoryId = 2;
            Found = AnInventory.Find(InventoryId);
            if (AnInventory.QuantityInStock != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastUpdatedFound() {
            clsInventory AnInventory = new clsInventory();
            Boolean Found = false;
            Boolean OK = true;
            Int32 InventoryId = 2;
            Found = AnInventory.Find(InventoryId);
            if (AnInventory.LastUpdated != DateTime.Now.Date)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
         [TestMethod]
         public void TestStockStatusFound() {
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
    }   
}