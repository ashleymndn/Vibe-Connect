using System;
using ClassLibrary;

namespace Testing4
{
    public class CustomerTests
    {
        public void RunTest()
        {
            Customer customer1 = new Customer(
                1,
                "Hajra",
                "hajra@email.com",
                "03001234567",
                "Faisalabad"
            );

            customer1.Register();
            customer1.Login();
            customer1.DisplayCustomerInfo();
        }
    }
}