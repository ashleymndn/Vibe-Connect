using System;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {

    }

    protected void btnInventory_Click(object sender, EventArgs e)
    {

    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        //redirect user to the orders login page
        Response.Redirect("3OrdersLogin.aspx");
    }

    protected void btnCustomers_Click(object sender, EventArgs e)
    {

    }
}