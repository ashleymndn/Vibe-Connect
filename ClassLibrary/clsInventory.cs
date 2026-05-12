using System;

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
        private DateTime mLastUpdate;
        private bool mActive;

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
                return mLastUpdate; 
            }
            set { 
                mLastUpdate = value;
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
                mLastUpdate = Convert.ToDateTime(DB.DataTable.Rows[0]["LastUpdated"]);
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

       


 
                


 