using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingStaff
{
    [TestClass]
    public class testStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StfIDPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 1;
            AStaff.StfID = TestData;
            Assert.AreEqual(AStaff.StfID, TestData);
        }

        [TestMethod]
        public void StfNamePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "Saarah Shaikh";
            AStaff.StfName = TestData;
            Assert.AreEqual(AStaff.StfName, TestData);
        }

        [TestMethod]
        public void StfEmailPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "saarah@vibeconnect.com";
            AStaff.StfEmail = TestData;
            Assert.AreEqual(AStaff.StfEmail, TestData);
        }

        [TestMethod]
        public void StfRolePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "Sales Assistant";
            AStaff.StfRole = TestData;
            Assert.AreEqual(AStaff.StfRole, TestData);
        }

        [TestMethod]
        public void StfSalaryPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 3500;
            AStaff.StfSalary = TestData;
            Assert.AreEqual(AStaff.StfSalary, TestData);
        }

        [TestMethod]
        public void StfDateJoinedPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.StfDateJoined = TestData;
            Assert.AreEqual(AStaff.StfDateJoined, TestData);
        }

        [TestMethod]
        public void StfIsActivePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = true;
            AStaff.StfIsActive = TestData;
            Assert.AreEqual(AStaff.StfIsActive, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 StfID = 1;
            Found = AStaff.Find(StfID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStfIDFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StfID = 1;

            Found = AStaff.Find(StfID);

            if (AStaff.StfID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStfNameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StfID = 1;

            Found = AStaff.Find(StfID);

            if (AStaff.StfName != "Test Staff")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStfEmailFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StfID = 1;

            Found = AStaff.Find(StfID);

            if (AStaff.StfEmail != "teststaff@email.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStfRoleFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StfID = 1;

            Found = AStaff.Find(StfID);

            if (AStaff.StfRole != "Manager")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStfSalaryFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StfID = 1;

            Found = AStaff.Find(StfID);

            if (AStaff.StfSalary != 25000)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStfDateJoinedFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StfID = 1;

            Found = AStaff.Find(StfID);

            if (AStaff.StfDateJoined != Convert.ToDateTime("01/01/2024"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStfIsActiveFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StfID = 1;

            Found = AStaff.Find(StfID);

            if (AStaff.StfIsActive != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
    
    }