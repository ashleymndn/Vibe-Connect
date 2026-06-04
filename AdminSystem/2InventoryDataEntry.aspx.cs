using ClassLibrary;
using System;
using System.Data.SqlClient;
using System.Web.UI;

public partial class _2InventoryDataEntry : System.Web.UI.Page
{
    Int32 InventoryId;

    protected void Page_Load(object sender, EventArgs e)
    {
        // SAFE SESSION HANDLING
        if (Session["InventoryId"] != null)
        {
            InventoryId = Convert.ToInt32(Session["InventoryId"]);
        }
        else
        {
            InventoryId = -1;
        }

        if (IsPostBack == false)
        {
            if (InventoryId != -1)
            {
                DisplayInventory();
            }
        }
    }

    protected void ProductName_TextChanged(object sender, EventArgs e) { }
    protected void InventoryId_TextChanged(object sender, EventArgs e) { }
    protected void ProductId_TextChanged(object sender, EventArgs e) { }
    protected void ProductPrice_TextChanged(object sender, EventArgs e) { }
    protected void QuantityInStock_TextChanged(object sender, EventArgs e) { }
    protected void LastUpdated_TextChanged(object sender, EventArgs e) { }
    protected void StockStatus_TextChanged(object sender, EventArgs e) { }
    protected void Active_CheckedChanged(object sender, EventArgs e) { }

    void DisplayInventory()
    {
        clsInventory AnInventory = new clsInventory();

        bool Found = AnInventory.Find(InventoryId);

        if (Found)
        {
            InventoryIdTextBox.Text = AnInventory.InventoryId.ToString();
            ProductIdTextBox.Text = AnInventory.ProductId.ToString();
            ProductNameTextBox.Text = AnInventory.ProductName;
            ProductPriceTextBox.Text = AnInventory.ProductPrice.ToString();
            QuantityInStockTextBox.Text = AnInventory.QuantityInStock.ToString();
            StockStatusTextBox.Text = AnInventory.StockStatus;
            LastUpdatedTextBox.Text = AnInventory.LastUpdated.ToString();
            chkActive.Checked = AnInventory.Active;
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsInventory AnInventory = new clsInventory();

        string ProductId = ProductIdTextBox.Text;
        string ProductName = ProductNameTextBox.Text;
        string StockStatus = StockStatusTextBox.Text;
        string LastUpdated = LastUpdatedTextBox.Text;
        string ProductPrice = ProductPriceTextBox.Text;
        string QuantityInStock = QuantityInStockTextBox.Text;

        string Error = "";

        Error = AnInventory.Valid(ProductId, ProductName,
                                  StockStatus, LastUpdated,
                                  ProductPrice, QuantityInStock);

        if (Error == "")
        {
            // SAFE + CONSISTENT ID HANDLING
            InventoryId = Convert.ToInt32(InventoryIdTextBox.Text);

            AnInventory.InventoryId = InventoryId;
            AnInventory.ProductId = Convert.ToInt32(ProductId);
            AnInventory.ProductName = ProductName;
            AnInventory.ProductPrice = Convert.ToDecimal(ProductPrice);
            AnInventory.QuantityInStock = Convert.ToInt32(QuantityInStock);
            AnInventory.LastUpdated = Convert.ToDateTime(LastUpdated);
            AnInventory.StockStatus = StockStatus;
            AnInventory.Active = chkActive.Checked;

            clsInventoryCollection InventoryBook = new clsInventoryCollection();

            if (InventoryId == -1)
            {
                InventoryBook.ThisInventory = AnInventory;
                InventoryBook.Add();
            }
            else
            {
                InventoryBook.ThisInventory.Find(InventoryId);
                InventoryBook.ThisInventory = AnInventory;
                InventoryBook.Update();
            }

            Response.Redirect("InventoryList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsInventory AnInventory = new clsInventory();

        int Id = Convert.ToInt32(InventoryIdTextBox.Text);

        bool Found = AnInventory.Find(Id);

        if (Found)
        {
            InventoryIdTextBox.Text = AnInventory.InventoryId.ToString();
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