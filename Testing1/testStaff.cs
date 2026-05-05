using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
[TestClass]
public class testStaff
{
    [TestMethod]
    public void InstanceOK()
    {
        clsStaff AStaff = new clsStaff();
        Assert.IsNotNull(AStaff);
    }
}