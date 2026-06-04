using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_InventoryList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayInventory();
        }
    }

    private void DisplayInventory()
    {
        clsInventoryCollection inventory = new clsInventoryCollection();

        lstInventoryList.DataSource = inventory.InventoryList;
        lstInventoryList.DataValueField = "InventoryId";
        lstInventoryList.DataTextField = "ProductName";
        lstInventoryList.DataBind();
    }

    protected void lstInventoryList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
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