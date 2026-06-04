using System;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("1StaffLogin.aspx");
    }

    protected void btnInventory_Click(object sender, EventArgs e)
    {
        Response.Redirect("2InventoryLogin.aspx");
    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        Response.Redirect("3OrdersLogin.aspx");
    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("4CustomerLogin.aspx");
    }
}