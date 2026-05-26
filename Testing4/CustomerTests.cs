using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VibeConnect;

namespace Testing4
{
    [TestClass]
    public class CustomerTests
    {
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

    }
}