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

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.StfName = "Add Test Staff";
            TestItem.StfEmail = "addtest@vibeconnect.com";
            TestItem.StfRole = "Assistant";
            TestItem.StfSalary = 4000;
            TestItem.StfDateJoined = DateTime.Now.Date;
            TestItem.StfIsActive = true;

            AllStaff.ThisStaff = TestItem;

            PrimaryKey = AllStaff.Add();

            TestItem.StfID = PrimaryKey;

            AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaff.ThisStaff.StfID, TestItem.StfID);
            Assert.AreEqual(AllStaff.ThisStaff.StfName, TestItem.StfName);
            Assert.AreEqual(AllStaff.ThisStaff.StfEmail, TestItem.StfEmail);
            Assert.AreEqual(AllStaff.ThisStaff.StfRole, TestItem.StfRole);
            Assert.AreEqual(AllStaff.ThisStaff.StfSalary, TestItem.StfSalary);
            Assert.AreEqual(AllStaff.ThisStaff.StfDateJoined.Date, TestItem.StfDateJoined.Date);
            Assert.AreEqual(AllStaff.ThisStaff.StfIsActive, TestItem.StfIsActive);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.StfName = "Update Test Staff";
            TestItem.StfEmail = "updatetest@vibeconnect.com";
            TestItem.StfRole = "Supervisor";
            TestItem.StfSalary = 5000;
            TestItem.StfDateJoined = DateTime.Now.Date;
            TestItem.StfIsActive = true;

            AllStaff.ThisStaff = TestItem;

            PrimaryKey = AllStaff.Add();

            TestItem.StfID = PrimaryKey;
            TestItem.StfName = "Updated Staff";
            TestItem.StfEmail = "updatedstaff@vibeconnect.com";
            TestItem.StfRole = "Manager";
            TestItem.StfSalary = 6000;
            TestItem.StfDateJoined = DateTime.Now.Date;
            TestItem.StfIsActive = false;

            AllStaff.ThisStaff = TestItem;

            AllStaff.Update();

            AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaff.ThisStaff.StfID, TestItem.StfID);
            Assert.AreEqual(AllStaff.ThisStaff.StfName, TestItem.StfName);
            Assert.AreEqual(AllStaff.ThisStaff.StfEmail, TestItem.StfEmail);
            Assert.AreEqual(AllStaff.ThisStaff.StfRole, TestItem.StfRole);
            Assert.AreEqual(AllStaff.ThisStaff.StfSalary, TestItem.StfSalary);
            Assert.AreEqual(AllStaff.ThisStaff.StfDateJoined.Date, TestItem.StfDateJoined.Date);
            Assert.AreEqual(AllStaff.ThisStaff.StfIsActive, TestItem.StfIsActive);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.StfName = "Delete Test";
            TestItem.StfEmail = "delete@test.com";
            TestItem.StfRole = "Tester";
            TestItem.StfSalary = 3000;
            TestItem.StfDateJoined = DateTime.Now.Date;
            TestItem.StfIsActive = true;

            AllStaff.ThisStaff = TestItem;

            PrimaryKey = AllStaff.Add();

            TestItem.StfID = PrimaryKey;

            AllStaff.ThisStaff.Find(PrimaryKey);

            AllStaff.Delete();

            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }
    }
}