using Microsoft.VisualStudio.TestTools.UnitTesting;
using VibeConnect;
using System;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class CustomerUserTests
    {
        [TestMethod]
        public void InstanceOK()
        {
            CustomerUser AnUser = new CustomerUser();

            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            CustomerUser AnUser = new CustomerUser();

            Int32 TestData = 1;

            AnUser.UserID = TestData;

            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            CustomerUser AnUser = new CustomerUser();

            string TestData = "Hajra";

            AnUser.UserName = TestData;

            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            CustomerUser AnUser = new CustomerUser();

            string TestData = "password123";

            AnUser.Password = TestData;

            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            CustomerUser AnUser = new CustomerUser();

            string TestData = "Customers";

            AnUser.Department = TestData;

            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            CustomerUser AnUser = new CustomerUser();

            Boolean Found = false;

            string UserName = "";
            string Password = "";

            Found = AnUser.FindUser(UserName, Password);

            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void FindUserOK()
        {
            CustomerUser AnUser = new CustomerUser();

            Boolean Found = false;

            string UserName = "Hajra";
            string Password = "apassworD";

            Found = AnUser.FindUser(UserName, Password);

            Assert.IsTrue(Found);
        }
    }

}