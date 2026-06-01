using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingStaff
{
    [TestClass]
    public class testStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Int32 TestData = 1;

            AnUser.UserID = TestData;

            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            string TestData = "Saarah";

            AnUser.UserName = TestData;

            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            string TestData = "staff123";

            AnUser.Password = TestData;

            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            string TestData = "Staff";

            AnUser.Department = TestData;

            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Boolean Found = false;

            string UserName = "Saarah";
            string Password = "staff123";

            Found = AnUser.FindUser(UserName, Password);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Boolean Found = false;
            Boolean OK = true;

            string UserName = "Saarah";
            string Password = "staff123";

            Found = AnUser.FindUser(UserName, Password);

            if (AnUser.UserName != UserName || AnUser.Password != Password)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
