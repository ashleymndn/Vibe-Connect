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
        public bool Active { get; set; }


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
            mInventoryId = 2;
            mProductId = 1;
            mProductName = "Vphone 1";
            mProductPrice = 95.0m;
            mQuantityInStock = 10;
            mLastUpdate = DateTime.Now.Date;
            mStockStatus = "In Stock";
            return true;
        }

       
    }   
}

       


 
                


 