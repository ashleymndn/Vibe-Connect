using System;
using System.Configuration;

namespace ClassLibrary
{
    public class clsInventory
    {


        private Int32 mInventoryId;
        private Int32 mProductId;
        private string mProductName;
        private decimal mProductPrice;
        private Int32 mQuantityInStock;
        private string mStockStatus;
        private DateTime mLastUpdated;
        private bool mActive;
         




        public string Valid(string ProductId,string ProductName, string StockStatus, string LastUpdated, string ProductPrice, string QuantityInStock)
        {
            //create a string variable to store the error
            String Error = "";

            //create temporary variables
            DateTime DateTemp;
            decimal PriceTemp;
            int QuantityTemp;
            int ProductIdTemp;

            //PRODUCT NAME VALIDATION

            //if the product name is blank
            if (ProductName.Length == 0)
            {
                Error = Error + "The product name may not be blank. ";
            }

            //if the product name is too long
            if (ProductName.Length > 15)
            {
                Error = Error + "The product name must not exceed 15 characters. ";
            }

            //STOCK STATUS VALIDATION

            //if the stock status is blank
            if (StockStatus.Length == 0)
            {
                Error = Error + "The stock status may not be blank. ";
            }

            //if the stock status is too long
            if (StockStatus.Length > 15)
            {
                Error = Error + "The stock status must not exceed 15 characters. ";
            }

            //LAST UPDATED DATE VALIDATION

            try
            {
                //copy the LastUpdated value to the DateTemp variable
                DateTemp = Convert.ToDateTime(LastUpdated);

                //check if the date is in the past
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The last updated date cannot be in the past. ";
                }

                //check if the date is in the future
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The last updated date cannot be in the future. ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The last updated date is not a valid date. ";
            }

            //PRODUCT PRICE VALIDATION

            try
            {
                //convert the ProductPrice value
                PriceTemp = Convert.ToDecimal(ProductPrice);

                //check if the price is less than or equal to zero
                if (PriceTemp <= 0)
                {
                    Error = Error + "The product price must be greater than zero. ";
                }

                //check if the price is too high
                if (PriceTemp > 300)
                {
                    Error = Error + "The product price must not exceed 300. ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The product price is not valid. ";
            }

            //QUANTITY IN STOCK VALIDATION

            try
            {
                //convert the QuantityInStock value
                QuantityTemp = Convert.ToInt32(QuantityInStock);

                //check if quantity is negative
                if (QuantityTemp < 0)
                {
                    Error = Error + "The quantity in stock cannot be negative. ";
                }

                //check if quantity is too high
                if (QuantityTemp > 100)
                {
                    Error = Error + "The quantity in stock must not exceed 100. ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The quantity in stock is not valid. ";
            }
            try
            {
                //convert ProductId
                ProductIdTemp = Convert.ToInt32(ProductId);

                //cannot be less than 1
                if (ProductIdTemp < 1)
                {
                    Error = Error + "The product ID must be greater than 0. ";
                }

                //cannot exceed 100
                if (ProductIdTemp > 100)
                {
                    Error = Error + "The product ID must not exceed 100. ";
                }
            }
            catch
            {
                Error = Error + "The product ID is not valid. ";
            }
            //return any error messages
            return Error;

        }



        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        public Int32 InventoryId {
            get
            {
                return mInventoryId;
            }
            set
            { 
                mInventoryId= value;
            }
        }
        public int ProductId {
            get 
            { 
                return mProductId; 
            }
            set { 
                mProductId = value; 
            }
        }
        public string ProductName {
            get { 
                return mProductName;
            }
            set { 
                mProductName = value;
            }
        }
        public decimal ProductPrice {
            get { 
                return mProductPrice; 
            }
            set { 
                mProductPrice = value;
            }
        }
        public int QuantityInStock {
            get 
            { 
                return mQuantityInStock;
            }
            set { 
                mQuantityInStock = value;
            }
        }
        public DateTime LastUpdated {
            get { 
                return mLastUpdated; 
            }
            set { 
                mLastUpdated = value;
            }
        }
        public string StockStatus {
            get { 
                return mStockStatus; 
            }
            set { 
                mStockStatus = value;
            }
        }







        public bool Find(int inventoryId)
        {
            // create instance of data connection
            clsDataConnection DB = new clsDataConnection();

            // add parameter
            DB.AddParameter("@InventoryId", inventoryId);

            // execute stored procedure
            DB.Execute("sproc_InventoryTable_FilterByInventoryId");

            // if one record found
            if (DB.Count == 1)
            {
                // copy data from database to private members
                mInventoryId = Convert.ToInt32(DB.DataTable.Rows[0]["InventoryId"]);
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mProductPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ProductPrice"]);
                mQuantityInStock = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityInStock"]);
                mLastUpdated = Convert.ToDateTime(DB.DataTable.Rows[0]["LastUpdated"]);
                mStockStatus = Convert.ToString(DB.DataTable.Rows[0]["StockStatus"]);
                

                return true;
            }
            else
            {
                return false;
            }

       
        }

        
    }   
}

       


 
                


 

