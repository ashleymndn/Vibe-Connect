using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VibeConnect;

namespace Testing4
{
    [TestClass]
    public class CustomerTests
    {
        // good test data
    string CustomerName = "Hajra";
    string CustomerEmail = "hajra@email.com";
    string CustomerPhone = "03001234567";
    string CustomerAddress = "Faisalabad";
    string CustomerPassword = "Password123!";
    string CustomerDateCreated = DateTime.Now.Date.ToString();

    [TestMethod]
public void CustomerNameMinLessOne()
{
    Customer ACustomer = new Customer();

    string Error = "";

    string CustomerName = "";

    Error = ACustomer.Valid(
        CustomerName,
        CustomerEmail,
        CustomerPhone,
        CustomerAddress,
        CustomerPassword,
        CustomerDateCreated);

    Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void CustomerNameMin()
{
    Customer ACustomer = new Customer();

    string Error = "";

    string CustomerName = "A";

    Error = ACustomer.Valid(
        CustomerName,
        CustomerEmail,
        CustomerPhone,
        CustomerAddress,
        CustomerPassword,
        CustomerDateCreated);

    Assert.AreEqual(Error, "");
}
[TestMethod]
public void CustomerNameMaxPlusOne()
{
    Customer ACustomer = new Customer();

    string Error = "";

    string CustomerName = "";
    CustomerName = CustomerName.PadRight(51, 'A');

    Error = ACustomer.Valid(
        CustomerName,
        CustomerEmail,
        CustomerPhone,
        CustomerAddress,
        CustomerPassword,
        CustomerDateCreated);

    Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void CustomerNameMax()
{
    Customer ACustomer = new Customer();

    string Error = "";

    string CustomerName = "";
    CustomerName = CustomerName.PadRight(50, 'A');

    Error = ACustomer.Valid(
        CustomerName,
        CustomerEmail,
        CustomerPhone,
        CustomerAddress,
        CustomerPassword,
        CustomerDateCreated);

    Assert.AreEqual(Error, "");
}
[TestMethod]
public void CustomerNameMinPlusOne()
{
    Customer ACustomer = new Customer();

    string Error = "";

    string CustomerName = "AA";

    Error = ACustomer.Valid(
        CustomerName,
        CustomerEmail,
        CustomerPhone,
        CustomerAddress,
        CustomerPassword,
        CustomerDateCreated);

    Assert.AreEqual(Error, "");
}
[TestMethod]
public void CustomerNameMaxLessOne()
{
    Customer ACustomer = new Customer();

    string Error = "";

    string CustomerName = "";
    CustomerName = CustomerName.PadRight(49, 'A');

    Error = ACustomer.Valid(
        CustomerName,
        CustomerEmail,
        CustomerPhone,
        CustomerAddress,
        CustomerPassword,
        CustomerDateCreated);

    Assert.AreEqual(Error, "");
}
[TestMethod]
public void CustomerNameMid()
{
    Customer ACustomer = new Customer();

    string Error = "";

    string CustomerName = "";
    CustomerName = CustomerName.PadRight(25, 'A');

    Error = ACustomer.Valid(
        CustomerName,
        CustomerEmail,
        CustomerPhone,
        CustomerAddress,
        CustomerPassword,
        CustomerDateCreated);

    Assert.AreEqual(Error, "");
}
[TestMethod]
public void CustomerDateCreatedExtremeMin()
{
    Customer ACustomer = new Customer();

    string Error = "";

    DateTime TestDate;
    TestDate = DateTime.Now.Date;
    TestDate = TestDate.AddYears(-100);

    string CustomerDateCreated = TestDate.ToString();

    Error = ACustomer.Valid(
        CustomerName,
        CustomerEmail,
        CustomerPhone,
        CustomerAddress,
        CustomerPassword,
        CustomerDateCreated);

    Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void CustomerDateCreatedMin()
{
    Customer ACustomer = new Customer();

    string Error = "";

    DateTime TestDate;
    TestDate = DateTime.Now.Date;

    string CustomerDateCreated = TestDate.ToString();

    Error = ACustomer.Valid(
        CustomerName,
        CustomerEmail,
        CustomerPhone,
        CustomerAddress,
        CustomerPassword,
        CustomerDateCreated);

    Assert.AreEqual(Error, "");
}
[TestMethod]
public void CustomerDateCreatedInvalidData()
{
    Customer ACustomer = new Customer();

    string Error = "";

    string CustomerDateCreated = "This is not a date";

    Error = ACustomer.Valid(
        CustomerName,
        CustomerEmail,
        CustomerPhone,
        CustomerAddress,
        CustomerPassword,
        CustomerDateCreated);

    Assert.AreNotEqual(Error, "");
}


    [TestMethod]
public void ValidMethodOK()
{
    Customer ACustomer = new Customer();

    string Error = "";

    Error = ACustomer.Valid(
        CustomerName,
        CustomerEmail,
        CustomerPhone,
        CustomerAddress,
        CustomerPassword,
        CustomerDateCreated);

    Assert.AreEqual(Error, "");
}

        [TestMethod]
public void InstanceOK()

{
    Customer ACustomer = new Customer(
        1,
        "Hajra",
        "hajra@email.com",
        "03001234567",
        "Faisalabad"
    );

    Assert.IsNotNull(ACustomer);
}
[TestMethod]
public void CustomerNamePropertyOK()
{
    Customer ACustomer = new Customer(
        1,
        "Hajra",
        "hajra@email.com",
        "03001234567",
        "Faisalabad"
    );

    string TestData = "Hajra";

    ACustomer.CustomerName = TestData;

    Assert.AreEqual(ACustomer.CustomerName, TestData);
}
[TestMethod]
public void CustomerEmailPropertyOK()
{
    Customer ACustomer = new Customer(
        1,
        "Hajra",
        "hajra@email.com",
        "03001234567",
        "Faisalabad"
    );

    string TestData = "hajra@email.com";

    ACustomer.CustomerEmail = TestData;

    Assert.AreEqual(ACustomer.CustomerEmail, TestData);
}
[TestMethod]
public void CustomerPhonePropertyOK()
{
    Customer ACustomer = new Customer(
        1,
        "Hajra",
        "hajra@email.com",
        "03001234567",
        "Faisalabad"
    );

    string TestData = "03001234567";

    ACustomer.CustomerPhone = TestData;

    Assert.AreEqual(ACustomer.CustomerPhone, TestData);
}
[TestMethod]
public void CustomerAddressPropertyOK()
{
    Customer ACustomer = new Customer(
        1,
        "Hajra",
        "hajra@email.com",
        "03001234567",
        "Faisalabad"
    );

    string TestData = "Faisalabad";

    ACustomer.CustomerAddress = TestData;

    Assert.AreEqual(ACustomer.CustomerAddress, TestData);
}
[TestMethod]
public void CustomerPasswordPropertyOK()
{
    Customer ACustomer = new Customer(
        1,
        "Hajra",
        "hajra@email.com",
        "03001234567",
        "Faisalabad"
    );

    string TestData = "Password123!";

    ACustomer.CustomerPassword = TestData;

    Assert.AreEqual(ACustomer.CustomerPassword, TestData);
}
[TestMethod]
public void CustomerDateCreatedPropertyOK()
{
    Customer ACustomer = new Customer(
        1,
        "Hajra",
        "hajra@email.com",
        "03001234567",
        "Faisalabad"
    );

    DateTime TestData = DateTime.Now.Date;

    ACustomer.CustomerDateCreated = TestData;

    Assert.AreEqual(ACustomer.CustomerDateCreated, TestData);
}
[TestMethod]
public void CustomerIsActivePropertyOK()
{
    Customer ACustomer = new Customer(
        1,
        "Hajra",
        "hajra@email.com",
        "03001234567",
        "Faisalabad"
    );

    Boolean TestData = true;

    ACustomer.CustomerIsActive = TestData;

    Assert.AreEqual(ACustomer.CustomerIsActive, TestData);
}
[TestMethod]
public void CustomerIDPropertyOK()
{
    Customer ACustomer = new Customer(
        1,
        "Hajra",
        "hajra@email.com",
        "03001234567",
        "Faisalabad"
    );

    Int32 TestData = 1;

    ACustomer.CustomerID = TestData;

    Assert.AreEqual(ACustomer.CustomerID, TestData);
}
[TestMethod]
public void FindMethodOK()
{
    // Create an instance of the class
    Customer ACustomer = new Customer();

    // Create a Boolean variable to store the result
    Boolean Found = false;

    // Create some test data
    Int32 CustomerID = 1;

    // Invoke the method
    Found = ACustomer.Find(CustomerID);

    // Test to see if the result is true
    Assert.IsTrue(Found);
}

[TestMethod]
public void TestCustomerIDFound()
{
    // Create an instance of the class
    Customer ACustomer = new Customer();

    // Create Boolean variables
    Boolean Found = false;
    Boolean OK = true;

    // Test data
    Int32 CustomerID = 1;

    // Invoke method
    Found = ACustomer.Find(CustomerID);

    // Check CustomerID property
    if (ACustomer.CustomerID != 1)
    {
        OK = false;
    }

    // Test result
    Assert.IsTrue(OK);
}
[TestMethod]
public void TestCustomerNameFound()
{
    // Create an instance of the class
    Customer ACustomer = new Customer();

    // Create Boolean variables
    Boolean Found = false;
    Boolean OK = true;

    // Test data
    Int32 CustomerID = 1;

    // Invoke method
    Found = ACustomer.Find(CustomerID);

    // Check CustomerName property
    if (ACustomer.CustomerName != "Hajra")
    {
        OK = false;
    }

    // Test result
    Assert.IsTrue(OK);
}
[TestMethod]
public void TestCustomerEmailFound()
{
    // Create an instance of the class
    Customer ACustomer = new Customer();

    // Create Boolean variables
    Boolean Found = false;
    Boolean OK = true;

    // Test data
    Int32 CustomerID = 1;

    // Invoke method
    Found = ACustomer.Find(CustomerID);

    // Check CustomerEmail property
    if (ACustomer.CustomerEmail != "hajra@email.com")
    {
        OK = false;
    }

    // Test result
    Assert.IsTrue(OK);
}
[TestMethod]
public void TestCustomerPhoneFound()
{
    // Create an instance of the class
    Customer ACustomer = new Customer();

    // Create Boolean variables
    Boolean Found = false;
    Boolean OK = true;

    // Test data
    Int32 CustomerID = 1;

    // Invoke method
    Found = ACustomer.Find(CustomerID);

    // Check CustomerPhone property
    if (ACustomer.CustomerPhone != "03001234567")
    {
        OK = false;
    }

    // Test result
    Assert.IsTrue(OK);
}
[TestMethod]
public void TestCustomerAddressFound()
{
    // Create an instance of the class
    Customer ACustomer = new Customer();

    // Create Boolean variables
    Boolean Found = false;
    Boolean OK = true;

    // Test data
    Int32 CustomerID = 1;

    // Invoke method
    Found = ACustomer.Find(CustomerID);

    // Check CustomerAddress property
    if (ACustomer.CustomerAddress != "Faisalabad")
    {
        OK = false;
    }

    // Test result
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

    if (ACustomer.CustomerPassword != "Password123!")
    {
        OK = false;
    }

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

    if (ACustomer.CustomerDateCreated != Convert.ToDateTime("2026-05-26 22:01:54.960"))
    {
        OK = false;
    }

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

    if (ACustomer.CustomerIsActive != true)
    {
        OK = false;
    }

    Assert.IsTrue(OK);
}

    }
}
