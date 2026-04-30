using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class testInventory
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsInventory AnInventory = new clsInventory();
            Assert.IsNotNull( AnInventory );
        }
    }
}
