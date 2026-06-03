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
        public string CustomerPassword { get; set; }
        public DateTime CustomerDateCreated { get; set; }
        public bool CustomerIsActive { get; set; }

        public Customer()
{
}

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
        public bool Find(int CustomerID)
{
   // Create an instance of the data connection
    clsDataConnection DB = new clsDataConnection();

    // Add the parameter for the primary key
    DB.AddParameter("@CustomerId", CustomerID);

    // Execute the stored procedure
    DB.Execute("sproc_tblCustomer_FilterByCustomerID");

    // If one record is found
    if (DB.Count == 1)
    {
        // Copy the data from the database
        this.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
        this.CustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
        this.CustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
        this.CustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
        this.CustomerDateCreated = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomeDateCreated"]);
        this.CustomerIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerIsActive"]);
        this.CustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
        this.CustomerPhone = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhone"]);

        return true;
    }
    else
    {
        return false;
    }
}
    }
}