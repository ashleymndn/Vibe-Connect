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

        public string Valid(string customerName,
                            string customerEmail,
                            string customerPhone,
                            string customerAddress,
                            string customerPassword,
                            string customerDateCreated)
        {
            string Error = "";

            // CustomerName cannot be blank
            if (customerName.Length == 0)
            {
                Error = Error + "The customer name may not be blank : ";
            }
            //CustomerName must be 50 characters or less
            if (customerName.Length > 50)
            {
                Error = Error + "The customer name must be less than 50 characters : ";
            }
            DateTime DateTemp;

try
{
DateTemp = Convert.ToDateTime(customerDateCreated);

    if (DateTemp < DateTime.Now.Date.AddYears(-100))
    {
        Error = Error + "The date is too far in the past : ";
    }
}
catch
{
    Error = Error + "The date was not a valid date : ";

}

// CustomerEmail cannot be blank
if (customerEmail.Length == 0)
{
    Error = Error + "The customer email may not be blank : ";
}

// CustomerEmail max length 200
if (customerEmail.Length > 200)
{
    Error = Error + "The customer email must be less than 200 characters : ";
}

// CustomerPhone cannot be blank
if (customerPhone.Length == 0)
{
    Error = Error + "The customer phone may not be blank : ";
}

// CustomerPhone max length 40
if (customerPhone.Length > 40)
{
    Error = Error + "The customer phone must be less than 40 characters : ";
}

// CustomerAddress cannot be blank
if (customerAddress.Length == 0)
{
    Error = Error + "The customer address may not be blank : ";
}

// CustomerAddress max length 300
if (customerAddress.Length > 300)
{
    Error = Error + "The customer address must be less than 300 characters : ";
}

// CustomerPassword cannot be blank
if (customerPassword.Length == 0)
{
    Error = Error + "The customer password may not be blank : ";
}

// CustomerPassword max length 255
if (customerPassword.Length > 255)
{
    Error = Error + "The customer password must be less than 255 characters : ";
}
            

            return Error;
        }
    }
}