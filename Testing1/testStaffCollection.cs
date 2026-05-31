using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestingStaff
{
    [TestClass]
    public class testStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();

            TestItem.StfID = 1;
            TestItem.StfName = "Test Staff";
            TestItem.StfEmail = "teststaff@email.com";
            TestItem.StfRole = "Manager";
            TestItem.StfSalary = 25000;
            TestItem.StfDateJoined = Convert.ToDateTime("01/01/2024");
            TestItem.StfIsActive = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();

            TestStaff.StfID = 1;
            TestStaff.StfName = "Test Staff";
            TestStaff.StfEmail = "teststaff@email.com";
            TestStaff.StfRole = "Manager";
            TestStaff.StfSalary = 25000;
            TestStaff.StfDateJoined = Convert.ToDateTime("01/01/2024");
            TestStaff.StfIsActive = true;

            AllStaff.ThisStaff = TestStaff;

            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();

            TestItem.StfID = 1;
            TestItem.StfName = "Test Staff";
            TestItem.StfEmail = "teststaff@email.com";
            TestItem.StfRole = "Manager";
            TestItem.StfSalary = 25000;
            TestItem.StfDateJoined = Convert.ToDateTime("01/01/2024");
            TestItem.StfIsActive = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
    }
}
