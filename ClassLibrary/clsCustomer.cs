using System;

namespace VibeConnect
{
    public class Customer
    {
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

        public Customer(int id, string name, string email,
                        string phone, string address)
        {
            CustomerID = id;
            CustomerName = name;
            CustomerEmail = email;
            CustomerPhone = phone;
            CustomerAddress = address;
        }

        public void Register()
        {
            Console.WriteLine("Customer account created successfully.");
        }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine("Customer ID: " + CustomerID);
            Console.WriteLine("Name: " + CustomerName);
            Console.WriteLine("Email: " + CustomerEmail);
            Console.WriteLine("Phone: " + CustomerPhone);
            Console.WriteLine("Address: " + CustomerAddress);
        }

        public void Login()
        {
            Console.WriteLine(CustomerName + " logged into the system.");
        }

        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");

            if (DB.Count == 1)
            {
                this.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                this.CustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                this.CustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                this.CustomerPhone = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhone"]);
                this.CustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                this.CustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
                this.CustomerDateCreated = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomeDateCreated"]);
                this.CustomerIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerIsActive"]);

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

            if (customerName.Length == 0)
            {
                Error += "The customer name may not be blank : ";
            }

            if (customerName.Length > 50)
            {
                Error += "The customer name must be less than 50 characters : ";
            }

            DateTime DateTemp;
            try
            {
                DateTemp = Convert.ToDateTime(customerDateCreated);

                if (DateTemp < DateTime.Now.Date.AddYears(-10))
                {
                    Error += "The date is too far in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error += "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error += "The date was not a valid date : ";
            }

            if (customerEmail.Length == 0)
            {
                Error += "The customer email may not be blank : ";
            }

            if (customerEmail.Length > 200)
            {
                Error += "The customer email must be less than 200 characters : ";
            }

            if (customerPhone.Length == 0)
            {
                Error += "The customer phone may not be blank : ";
            }

            if (customerPhone.Length > 40)
            {
                Error += "The customer phone must be less than 40 characters : ";
            }

            if (customerAddress.Length == 0)
            {
                Error += "The customer address may not be blank : ";
            }

            if (customerAddress.Length > 300)
            {
                Error += "The customer address must be less than 300 characters : ";
            }

            if (customerPassword.Length == 0)
            {
                Error += "The customer password may not be blank : ";
            }

            if (customerPassword.Length > 255)
            {
                Error += "The customer password must be less than 255 characters : ";
            }

            return Error;
        }
    }
}