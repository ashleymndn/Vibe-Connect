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
    }
}