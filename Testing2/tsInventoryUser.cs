using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstInventoryUser
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsInventoryUser AnUser = new clsInventoryUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOk()
        {
            clsInventoryUser AnUser = new clsInventoryUser();
            Int32 TestData = 2;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOk()
        {
            clsInventoryUser AnUser = new clsInventoryUser();
            string TestData = "Nabiha";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOk()
        {
            clsInventoryUser AnUser = new clsInventoryUser();
            string TestData = "inventory#";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOk()
        {
            clsInventoryUser AnUser = new clsInventoryUser();
            string TestData = "Inventory";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOk()
        {
            clsInventoryUser AnUser = new clsInventoryUser();

            Boolean Found = false;

            string UserName = "Nabiha";
            string Password = "inventory#";

            Found = AnUser.FindUser(UserName, Password);

            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound() { 
            clsInventoryUser AnUser = new clsInventoryUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Nabiha";
            string Password = "inventory#";
            Found = AnUser.FindUser(UserName, Password);
            if(AnUser.UserName!=UserName && AnUser.Password != Password){
                OK = false;
            }

            Assert.IsTrue(Found);
        }
    }
}