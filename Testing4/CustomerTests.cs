using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VibeConnect;

namespace Testing4
{
    [TestClass]
    public class clsCustomerTests
    {
        string CustomerName = "Hajra";
        string CustomerEmail = "hajra@email.com";
        string CustomerPhone = "03001234567";
        string CustomerAddress = "Faisalabad";
        string CustomerPassword = "Password123!";
        string CustomeDateCreated = DateTime.Now.Date.ToString();

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerName = "";

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerName = "A";

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerName = "".PadRight(51, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerName = "".PadRight(50, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerName = "AA";

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerName = "".PadRight(49, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerName = "".PadRight(25, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateCreatedExtremeMin()
        {
            Customer ACustomer = new Customer();
            string Error = "";

            DateTime TestDate = DateTime.Now.Date.AddYears(-100);
            string CustomeDateCreated = TestDate.ToString();

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateCreatedMin()
        {
            Customer ACustomer = new Customer();
            string Error = "";

            DateTime TestDate = DateTime.Now.Date;
            string CustomerDateCreated = TestDate.ToString();

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomerDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateCreatedInvalidData()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerDateCreated = "This is not a date";

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomerDateCreated);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerEmail = "";

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerEmail = "A";

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerEmail = "".PadRight(100, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerEmail = "".PadRight(200, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerEmail = "".PadRight(201, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMinLessOne()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerPhone = "";

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMin()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerPhone = "A";

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMid()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerPhone = "".PadRight(20, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMax()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerPhone = "".PadRight(40, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMaxPlusOne()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerPhone = "".PadRight(41, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerAddress = "";

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerAddress = "A";

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerAddress = "".PadRight(150, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerAddress = "".PadRight(300, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerAddress = "".PadRight(301, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMinLessOne()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerPassword = "";

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMin()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerPassword = "A";

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMid()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerPassword = "".PadRight(127, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMax()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerPassword = "".PadRight(255, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMaxPlusOne()
        {
            Customer ACustomer = new Customer();
            string Error = "";
            string CustomerPassword = "".PadRight(256, 'A');

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            Customer ACustomer = new Customer();
            string Error = "";

            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhone,
                CustomerAddress, CustomerPassword, CustomeDateCreated);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InstanceOK()
        {
            Customer ACustomer = new Customer(1, "Hajra", "hajra@email.com", "03001234567", "Faisalabad");
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            Customer ACustomer = new Customer(1, "Hajra", "hajra@email.com", "03001234567", "Faisalabad");
            string TestData = "Hajra";
            ACustomer.CustomerName = TestData;
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            Customer ACustomer = new Customer(1, "Hajra", "hajra@email.com", "03001234567", "Faisalabad");
            string TestData = "hajra@email.com";
            ACustomer.CustomerEmail = TestData;
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerPhonePropertyOK()
        {
            Customer ACustomer = new Customer(1, "Hajra", "hajra@email.com", "03001234567", "Faisalabad");
            string TestData = "03001234567";
            ACustomer.CustomerPhone = TestData;
            Assert.AreEqual(ACustomer.CustomerPhone, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            Customer ACustomer = new Customer(1, "Hajra", "hajra@email.com", "03001234567", "Faisalabad");
            string TestData = "Faisalabad";
            ACustomer.CustomerAddress = TestData;
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerPasswordPropertyOK()
        {
            Customer ACustomer = new Customer(1, "Hajra", "hajra@email.com", "03001234567", "Faisalabad");
            string TestData = "Password123!";
            ACustomer.CustomerPassword = TestData;
            Assert.AreEqual(ACustomer.CustomerPassword, TestData);
        }

        [TestMethod]
        public void CustomerDateCreatedPropertyOK()
        {
            Customer ACustomer = new Customer(1, "Hajra", "hajra@email.com", "03001234567", "Faisalabad");
            DateTime TestData = DateTime.Now.Date;
            ACustomer.CustomerDateCreated = TestData;
            Assert.AreEqual(ACustomer.CustomerDateCreated, TestData);
        }

        [TestMethod]
        public void CustomerIsActivePropertyOK()
        {
            Customer ACustomer = new Customer(1, "Hajra", "hajra@email.com", "03001234567", "Faisalabad");
            Boolean TestData = true;
            ACustomer.CustomerIsActive = TestData;
            Assert.AreEqual(ACustomer.CustomerIsActive, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            Customer ACustomer = new Customer(1, "Hajra", "hajra@email.com", "03001234567", "Faisalabad");
            Int32 TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            Customer ACustomer = new Customer();
            Boolean Found = false;

            Found = ACustomer.Find(1);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            Customer ACustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.CustomerID != 1) OK = false;

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            Customer ACustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.CustomerName != "Hajra") OK = false;

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            Customer ACustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.CustomerEmail != "hajra@email.com") OK = false;

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPhoneFound()
        {
            Customer ACustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.CustomerPhone != "03001234567") OK = false;

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            Customer ACustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.CustomerAddress != "Faisalabad") OK = false;

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPasswordFound()
        {
            Customer ACustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.CustomerPassword != "Password123!") OK = false;

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDateCreatedFound()
        {
            Customer ACustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.CustomerDateCreated == DateTime.MinValue) OK = false;

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIsActiveFound()
        {
            Customer ACustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.CustomerIsActive != true) OK = false;

            Assert.IsTrue(OK);
        }
    }
}