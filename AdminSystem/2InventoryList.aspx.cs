using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayInventory();
        }
    }
    void DisplayInventory()
    {
        //create instance of collection class
        clsInventoryCollection Inventory = new clsInventoryCollection();

        //set the data source to the list of inventory in the collection
        lstInventoryList.DataSource = Inventory.InventoryList;

        //set the name of the primary key
        lstInventoryList.DataValueField = "InventoryId";

        //set the data field to display
        lstInventoryList.DataTextField = "ProductName";

        //bind the data to the list
        lstInventoryList.DataBind();
    }

    protected void lstInventoryList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["InventoryId"] = -1;
        Response.Redirect("2InventoryDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 InventoryId;

        if (lstInventoryList.SelectedIndex != -1)
        {
            InventoryId = Convert.ToInt32(lstInventoryList.SelectedValue);

            Session["InventoryId"] = InventoryId;

            Response.Redirect("2InventoryDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit.";
        }
    }
    
}
