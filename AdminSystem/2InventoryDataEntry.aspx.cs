using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;



public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create instance of class
        clsInventory AnInventory = new clsInventory();

        
        string ProductName = ProductNameTextBox.Text;
        string StockStatus = StockStatusTextBox.Text;
        string LastUpdated = LastUpdatedTextBox.Text;
        string ProductPrice = ProductPriceTextBox.Text;
        string QuantityInStock = QuantityInStockTextBox.Text;

        //variable for error messages
        string Error = "";

        //call the Valid function
        Error = AnInventory.Valid(ProductName,StockStatus,LastUpdated,ProductPrice,QuantityInStock);

        //if no errors found
        if (Error == "")
        {
            //capture data
            AnInventory.InventoryId = Convert.ToInt32(InventoryIdTextBox.Text);
            AnInventory.ProductId = Convert.ToInt32(ProductIdTextBox.Text);
            AnInventory.ProductName = ProductName;
            AnInventory.ProductPrice = Convert.ToDecimal(ProductPrice);
            AnInventory.QuantityInStock = Convert.ToInt32(QuantityInStock);
            AnInventory.LastUpdated = Convert.ToDateTime(LastUpdated);
            AnInventory.StockStatus = StockStatus;
            AnInventory.Active = chkActive.Checked;

            //store object in session
            Session["AnInventory"] = AnInventory;

            //navigate to viewer page
            Response.Redirect("2InventoryViewer.aspx");
        }
        else
        {
            //display error messages
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
}