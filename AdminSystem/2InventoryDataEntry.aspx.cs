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
        clsInventory AnInventory = new clsInventory();
        AnInventory.InventoryId=Convert.ToInt32(InventoryIdTextBox.Text);
        AnInventory.ProductId=Convert.ToInt32(ProductIdTextBox.Text);
        AnInventory.ProductName= ProductNameTextBox.Text;
        AnInventory.ProductPrice = Convert.ToDecimal(ProductPriceTextBox.Text);
        AnInventory.QuantityInStock = Convert.ToInt32(QuantityInStockTextBox.Text);
        AnInventory.LastUpdated = Convert.ToDateTime(LastUpdatedTextBox.Text);
        AnInventory.StockStatus = StockStatusTextBox.Text;
        AnInventory.Active = chkActive.Checked;

        Session["AnInventory"] = AnInventory;

        Response.Redirect("2InventoryViewer.aspx");
    }


}