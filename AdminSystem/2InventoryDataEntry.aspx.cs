using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;



public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 InventoryId;

    protected void Page_Load(object sender, EventArgs e)
    {
        InventoryId = Convert.ToInt32(Session["InventoryId"]);

        if (IsPostBack == false)
        {
            //if this is not a new record
            if (InventoryId != -1)
            {
                //display current data
                DisplayInventory();
            }
        }
    }

    protected void ProductName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void InventoryId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void ProductId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void ProductPrice_TextChanged(object sender, EventArgs e)
    {

    }

    protected void QuantityInStock_TextChanged(object sender, EventArgs e)
    {

    }


    protected void LastUpdated_TextChanged(object sender, EventArgs e)
    {

      
    }


    protected void StockStatus_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Active_CheckedChanged(object sender, EventArgs e)
    {

    }

    void DisplayInventory()
    {
        //create instance of inventory class
        clsInventory AnInventory = new clsInventory();

        //find the record to update
        AnInventory.Find(InventoryId);

        //display the data in the controls
        ProductIdTextBox.Text = AnInventory.ProductId.ToString();
        ProductNameTextBox.Text = AnInventory.ProductName;
        ProductPriceTextBox.Text = AnInventory.ProductPrice.ToString();
        QuantityInStockTextBox.Text = AnInventory.QuantityInStock.ToString();
        StockStatusTextBox.Text = AnInventory.StockStatus;
        LastUpdatedTextBox.Text = AnInventory.LastUpdated.ToString();
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create instance of class
        clsInventory AnInventory = new clsInventory();

        //capture data
        string ProductId = ProductIdTextBox.Text;
        string ProductName = ProductNameTextBox.Text;
        string StockStatus = StockStatusTextBox.Text;
        string LastUpdated = LastUpdatedTextBox.Text;
        string ProductPrice = ProductPriceTextBox.Text;
        string QuantityInStock = QuantityInStockTextBox.Text;

        //IMPORTANT - capture InventoryId
        int InventoryId = Convert.ToInt32(InventoryIdTextBox.Text);

        //variable for error messages
        string Error = "";

        //validate
        Error = AnInventory.Valid(ProductId, ProductName,
                                  StockStatus, LastUpdated,
                                  ProductPrice, QuantityInStock);

        //if valid
        if (Error == "")
        {
            //assign properties
            AnInventory.InventoryId = InventoryId;
            AnInventory.ProductId = Convert.ToInt32(ProductId);
            AnInventory.ProductName = ProductName;
            AnInventory.ProductPrice = Convert.ToDecimal(ProductPrice);
            AnInventory.QuantityInStock = Convert.ToInt32(QuantityInStock);
            AnInventory.LastUpdated = Convert.ToDateTime(LastUpdated);
            AnInventory.StockStatus = StockStatus;
            AnInventory.Active = chkActive.Checked;

            //create collection object
            clsInventoryCollection InventoryBook = new clsInventoryCollection();

            //new record
            if (InventoryId == -1)
            {
                InventoryBook.ThisInventory = AnInventory;
                InventoryBook.Add();
            }
            else
            {
                //update existing record
                InventoryBook.ThisInventory.Find(InventoryId);
                InventoryBook.ThisInventory = AnInventory;
                InventoryBook.Update();
            }

            //redirect
            Response.Redirect("InventoryList.aspx");
        }
        else
        {
            //display errors
            lblError.Text = Error;
        }

    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsInventory AnInventory = new clsInventory();
        Int32 InventoryId;
        Boolean Found = false;

        InventoryId= Convert.ToInt32(InventoryIdTextBox.Text);
        Found= AnInventory.Find(InventoryId);
        if (Found == true)
        {
            ProductIdTextBox.Text = AnInventory.ProductId.ToString();
            ProductNameTextBox.Text = AnInventory.ProductName;
            ProductPriceTextBox.Text = AnInventory.ProductPrice.ToString();
            QuantityInStockTextBox.Text = AnInventory.QuantityInStock.ToString();
            LastUpdatedTextBox.Text = AnInventory.LastUpdated.ToString();
            StockStatusTextBox.Text = AnInventory.StockStatus;
            chkActive.Checked = AnInventory.Active;
        }


    }


    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}