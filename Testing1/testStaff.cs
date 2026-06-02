using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingStaff
{
    [TestClass]
    public class testStaff
    {
        private string StfName = "Saarah Shaikh";
        private string StfEmail = "saarah@vibeconnect.com";
        private string StfRole = "Sales Assistant";
        private string StfSalary = "3500";
        private string StfDateJoined = DateTime.Now.Date.ToString();

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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfNameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfName = "";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfNameMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfName = "A";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfNameMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfName = "";
            StfName = StfName.PadRight(100, 'A');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfNameMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfName = "";
            StfName = StfName.PadRight(101, 'A');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfEmailMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfEmail = "";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfEmailMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfEmail = "a@b.com";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfEmailMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfEmail = "a@";
            StfEmail = StfEmail.PadRight(100, 'a');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfEmailMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfEmail = "a@";
            StfEmail = StfEmail.PadRight(101, 'a');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfEmailInvalid()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfEmail = "invalidemail.com";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfRoleMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfRole = "";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfRoleMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfRole = "A";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfRoleMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfRole = "";
            StfRole = StfRole.PadRight(50, 'A');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfRoleMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfRole = "";
            StfRole = StfRole.PadRight(51, 'A');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfSalaryValid()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfSalary = "3500";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfSalaryNegative()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfSalary = "-1";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfSalaryExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfSalary = "1000001";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfSalaryInvalidData()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfSalary = "ABC";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfDateJoinedToday()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfDateJoined = DateTime.Now.Date.ToString();

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfDateJoinedPast()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfDateJoined = DateTime.Now.Date.AddDays(-1).ToString();

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfDateJoinedFuture()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfDateJoined = DateTime.Now.Date.AddDays(1).ToString();

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfDateJoinedExtremePast()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfDateJoined = DateTime.Now.Date.AddYears(-51).ToString();

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfDateJoinedInvalidData()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfDateJoined = "not a date";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StfNameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfName = "AA";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfNameMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfName = "";
            StfName = StfName.PadRight(99, 'A');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfNameMid()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfName = "";
            StfName = StfName.PadRight(50, 'A');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfNameExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfName = "";
            StfName = StfName.PadRight(500, 'A');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfEmailMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfEmail = "ab@b.com";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfEmailMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfEmail = "a@";
            StfEmail = StfEmail.PadRight(99, 'a');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfEmailMid()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfEmail = "staff";
            StfEmail = StfEmail.PadRight(45, 'a') + "@email.com";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfEmailExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfEmail = "a@";
            StfEmail = StfEmail.PadRight(500, 'a');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfRoleMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfRole = "AA";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfRoleMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfRole = "";
            StfRole = StfRole.PadRight(49, 'A');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfRoleMid()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfRole = "";
            StfRole = StfRole.PadRight(25, 'A');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfRoleExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfRole = "";
            StfRole = StfRole.PadRight(500, 'A');

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfSalaryMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfSalary = "0";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfSalaryMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfSalary = "1000000";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfSalaryMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfSalary = "1000001";

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfDateJoinedMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfDateJoined = DateTime.Now.Date.AddYears(-51).ToString();

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StfDateJoinedMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfDateJoined = DateTime.Now.Date.AddYears(-50).ToString();

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StfDateJoinedMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StfDateJoined = DateTime.Now.Date.AddYears(-49).ToString();

            Error = AStaff.Valid(StfName, StfEmail, StfRole, StfSalary, StfDateJoined);

            Assert.AreEqual(Error, "");
        }
    }
}