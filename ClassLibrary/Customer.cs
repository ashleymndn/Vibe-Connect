using System;

namespace VibeConnect
{
    public class Customer
    {
        // Properties
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }

        // Constructor
        public Customer(int id, string name, string email,
                        string phone, string address)
        {
            CustomerID = id;
            CustomerName = name;
            CustomerEmail = email;
            CustomerPhone = phone;
            CustomerAddress = address;
        }

        // Register Method
        public void Register()
        {
            Console.WriteLine("Customer account created successfully.");
        }

        // Display Method
        public void DisplayCustomerInfo()
        {
            Console.WriteLine("Customer ID: " + CustomerID);
            Console.WriteLine("Name: " + CustomerName);
            Console.WriteLine("Email: " + CustomerEmail);
            Console.WriteLine("Phone: " + CustomerPhone);
            Console.WriteLine("Address: " + CustomerAddress);
        }

        // Login Method
        public void Login()
        {
            Console.WriteLine(CustomerName + " logged into the system.");
        }
    }
}