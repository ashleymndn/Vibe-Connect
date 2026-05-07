using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsInventory AnInventory= new clsInventory();
        AnInventory = (clsInventory)Session["AnInventory"];
        Response.Write(AnInventory.InventoryId);
        Response.Write(AnInventory.ProductId);
        Response.Write(AnInventory.ProductName);
        Response.Write(AnInventory.ProductPrice);
        Response.Write(AnInventory.QuantityInStock);
        Response.Write(AnInventory.LastUpdated);
        Response.Write(AnInventory.StockStatus);
        Response.Write(AnInventory.Active);
    }
}