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
    TestItem.CustomeDateCreated = DateTime.Now.Date;
    TestItem.CustomerIsActive = true;

    AllCustomers.ThisCustomer = TestItem;

    PrimaryKey = AllCustomers.Add();

    TestItem.CustomerID = PrimaryKey;

    AllCustomers.ThisCustomer.Find(PrimaryKey);

    Assert.AreEqual(AllCustomers.ThisCustomer.CustomerID, TestItem.CustomerID);
}
[TestMethod]
public void UpdateMethodOK()
{
    CustomerCollection AllCustomers = new CustomerCollection();

    Customer TestItem = new Customer();

    Int32 PrimaryKey = 0;

    // Original data
    TestItem.CustomerName = "Test Customer";
    TestItem.CustomerEmail = "test@email.com";
    TestItem.CustomerPhone = "03001234567";
    TestItem.CustomerAddress = "Test Address";
    TestItem.CustomerPassword = "Password123!";
    TestItem.CustomeDateCreated = DateTime.Now.Date;
    TestItem.CustomerIsActive = true;

    AllCustomers.ThisCustomer = TestItem;

    PrimaryKey = AllCustomers.Add();

    TestItem.CustomerID = PrimaryKey;

    // Updated data
    TestItem.CustomerName = "Updated Customer";
    TestItem.CustomerEmail = "updated@email.com";
    TestItem.CustomerPhone = "03111234567";
    TestItem.CustomerAddress = "Updated Address";
    TestItem.CustomerPassword = "UpdatedPassword";
    TestItem.CustomeDateCreated = DateTime.Now.Date;
    TestItem.CustomerIsActive = false;

    AllCustomers.ThisCustomer = TestItem;

    AllCustomers.Update();

    AllCustomers.ThisCustomer.Find(PrimaryKey);

    Assert.AreEqual(AllCustomers.ThisCustomer.CustomerName, TestItem.CustomerName);
}
[TestMethod]
public void DeleteMethodOK()
{
    CustomerCollection AllCustomers = new CustomerCollection();

    Customer TestItem = new Customer();

    Int32 PrimaryKey = 0;

    TestItem.CustomerName = "Delete Test";
    TestItem.CustomerEmail = "delete@test.com";
    TestItem.CustomerPhone = "03001234567";
    TestItem.CustomerAddress = "Delete Address";
    TestItem.CustomerPassword = "Delete123";
    TestItem.CustomerDateCreated = DateTime.Now.Date;
    TestItem.CustomerIsActive = true;

    AllCustomers.ThisCustomer = TestItem;

    PrimaryKey = AllCustomers.Add();

    TestItem.CustomerID = PrimaryKey;

    AllCustomers.ThisCustomer.Find(PrimaryKey);

    AllCustomers.Delete();

    Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);

    Assert.IsFalse(Found);
}
[TestMethod]
public void ReportByCustomerNameMethodOK()
{
    CustomerCollection AllCustomers = new CustomerCollection();

    CustomerCollection FilteredCustomers = new CustomerCollection();

    FilteredCustomers.ReportByCustomerName("");

    Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
}
    }
}