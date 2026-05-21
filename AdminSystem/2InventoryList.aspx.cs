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
            DisplayAddresses();
        }
    }
    void DisplayAddresses()
    {
        clsInventoryCollection Inventory = new clsInventoryCollection();
        lstAddressList.DataSource = Inventory.InventoryList;
        lstAddressList.DataTextField = "ProductName";
        lstAddressList.DataValueField = "InventoryId";
        lstAddressList.DataBind();
    }

    protected void lstAddressList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["InventoryId"] = -1;
        Response.Redirect("2InventoryDataEntry.aspx");
    }
}