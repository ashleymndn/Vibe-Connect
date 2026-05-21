using System;
using System.Data;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsInventoryCollection
    {
        List<clsInventory> mInventoryList = new List<clsInventory>();
        clsInventory mThisInventory = new clsInventory();
        public List<clsInventory> InventoryList
        {
            get
            {
                return mInventoryList;
            }
            set
            {
                mInventoryList = value;
            }
        }

        public int Count { 
            get { 
                return mInventoryList.Count;
            }
            set {
               
            } 
        }
        public clsInventory ThisInventory { 
            get {  
                return mThisInventory;

            } 
            set { 
                mThisInventory = value;
            }
           
        }
        

        public clsInventoryCollection()
        {
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount = 0;

            //object for the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_InventoryTable_SelectAll");

            //get the count of records
            RecordCount = DB.Count;

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank inventory object
                clsInventory AnInventory = new clsInventory();

                //read in the fields for the current record
                AnInventory.InventoryId = Convert.ToInt32(DB.DataTable.Rows[Index]["InventoryId"]);
                AnInventory.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                AnInventory.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AnInventory.ProductPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ProductPrice"]);
                AnInventory.QuantityInStock = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityInStock"]);
                AnInventory.StockStatus = Convert.ToString(DB.DataTable.Rows[Index]["StockStatus"]);
                AnInventory.LastUpdated = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastUpdated"]);

                //add the record to the private data member
                mInventoryList.Add(AnInventory);

                //point at the next record
                Index++;
            }
        }
        public int Add() {  
           
            clsDataConnection DB= new clsDataConnection();
            DB.AddParameter("@ProductId", mThisInventory.ProductId);
            DB.AddParameter("@ProductName", mThisInventory.ProductName);
            DB.AddParameter("@ProductPrice", mThisInventory.ProductPrice);
            DB.AddParameter("@QuantityInStock", mThisInventory.QuantityInStock);
            DB.AddParameter("@StockStatus", mThisInventory.StockStatus);
            DB.AddParameter("@LastUpdated", mThisInventory.LastUpdated);

            return DB.Execute("sproc_InventoryTable_Insert");
        }
    }
}