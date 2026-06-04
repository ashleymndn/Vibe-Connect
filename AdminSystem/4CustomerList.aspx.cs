using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VibeConnect;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        CustomerCollection Customers = new CustomerCollection();

        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "CustomerName";
        lstCustomerList.DataBind();
    }

    
}
protected void btnAdd_Click(object sender, EventArgs e)
{
    Session["CustomerID"] = -1;
    Response.Redirect("4CustomerDataEntry.aspx");
}
protected void btnEdit_Click(object sender, EventArgs e)
{
    Int32 CustomerID;

    if (lstCustomerList.SelectedIndex != -1)
    {
        CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);

        Session["CustomerID"] = CustomerID;

        Response.Redirect("4CustomerDataEntry.aspx");
    }
    else
    {
        lblError.Text = "Please select a customer from the list.";
    }
}
protected void btnDelete_Click(object sender, EventArgs e)
{
    Int32 CustomerID;

    if (lstCustomerList.SelectedIndex != -1)
    {
        CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);

        Session["CustomerID"] = CustomerID;

        Response.Redirect("4CustomerConfirmDelete.aspx");
    }
    else
    {
        lblError.Text = "Please select a customer from the list to delete.";
    }
}
}