using System;
using System.Collections.Generic;

namespace VibeConnect
{
    public class CustomerCollection
    {
        private List<Customer> mCustomerList = new List<Customer>();
        private Customer mThisCustomer = new Customer();

        public CustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }

        public List<Customer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
        }

        public Customer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }
        private void PopulateArray(clsDataConnection DB)
{
    Int32 Index = 0;
    Int32 RecordCount;

    RecordCount = DB.Count;

    mCustomerList = new List<Customer>();

    while (Index < RecordCount)
    {
        Customer ACustomer = new Customer();

        ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
        ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
        ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
        ACustomer.CustomerPhone = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhone"]);
        ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
        ACustomer.CustomerPassword = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPassword"]);
        ACustomer.CustomerDateCreated = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomeDateCreated"]);
        ACustomer.CustomerIsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerIsActive"]);

        mCustomerList.Add(ACustomer);

        Index++;
    }
}
    }
}