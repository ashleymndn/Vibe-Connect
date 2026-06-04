using Microsoft.VisualStudio.TestTools.UnitTesting;
using VibeConnect;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class CustomerCollectionTests
    {
        [TestMethod]
        public void InstanceOK()
        {
            CustomerCollection AllCustomers = new CustomerCollection();

            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
public void CustomerListOK()
{
    CustomerCollection AllCustomers = new CustomerCollection();

    List<Customer> TestList = new List<Customer>();

    AllCustomers.CustomerList = TestList;

    Assert.AreEqual(AllCustomers.CustomerList, TestList);
}
[TestMethod]
public void CountPropertyOK()
{
    CustomerCollection AllCustomers = new CustomerCollection();

    Int32 SomeCount = 0;

    Assert.AreEqual(AllCustomers.Count, SomeCount);
}
[TestMethod]
public void ThisCustomerPropertyOK()
{
    CustomerCollection AllCustomers = new CustomerCollection();

    Customer TestCustomer = new Customer();

    AllCustomers.ThisCustomer = TestCustomer;

    Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
}
[TestMethod]
public void AddMethodOK()
{
    CustomerCollection AllCustomers = new CustomerCollection();

    Customer TestItem = new Customer();

    Int32 PrimaryKey = 0;

    TestItem.CustomerName = "Test Customer";
    TestItem.CustomerEmail = "test@email.com";
    TestItem.CustomerPhone = "03001234567";
    TestItem.CustomerAddress = "Test Address";
    TestItem.CustomerPassword = "Password123!";
    TestItem.CustomerDateCreated = DateTime.Now.Date;
    TestItem.CustomerIsActive = true;

    AllCustomers.ThisCustomer = TestItem;

    PrimaryKey = AllCustomers.Add();

    TestItem.CustomerID = PrimaryKey;

    AllCustomers.ThisCustomer.Find(PrimaryKey);

    Assert.AreEqual(AllCustomers.ThisCustomer.CustomerID, TestItem.CustomerID);
}
    }
}