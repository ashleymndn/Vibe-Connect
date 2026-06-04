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
            clsOrdersCollection Orders = new clsOrdersCollection();
            DisplayOrders(Orders);
        }

        //create an instance of clsOrdersUser
        clsOrdersUser AUser = new clsOrdersUser();
        //get data from the session object
        AUser = (clsOrdersUser)Session["AUser"];
        //display the user name
        Response.Write("Logged in as: " + AUser.UserName);
    }

    void DisplayOrders(clsOrdersCollection Orders)
    {
        lstOrdersList.Items.Clear();

        foreach (clsOrders AnOrder in Orders.OrdersList)
        { 
            ListItem Item = new ListItem();

            Item.Value = AnOrder.OrderId.ToString();

            Item.Text =
                AnOrder.OrderId + " | " +
                AnOrder.CustomerId + " | " +
                AnOrder.OrderDate.ToShortDateString() + " | " +
                AnOrder.Total + " | " +
                AnOrder.Address + " | " +
                AnOrder.OrderStatus + " | " +
                AnOrder.IsDelivered;

            lstOrdersList.Items.Add(Item);
        }
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("3OrdersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderId;

        if (lstOrdersList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrdersList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("3OrdersDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrdersList.SelectedIndex != -1) 
        {
            //get primary key value of the record to delete
            OrderId = Convert.ToInt32(lstOrdersList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the delete page
            Response.Redirect("3OrdersConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the orders object
        clsOrdersCollection AnOrder = new clsOrdersCollection();
        //retrieve the value of the order status from the presentaion layer
        AnOrder.ReportByOrderStatus(txtFilter.Text);
        //set the data source to the list of orders in the collecttion
        lstOrdersList.DataSource = AnOrder.OrdersList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderId";
        //display fields
        DisplayOrders(AnOrder);
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the orders object
        clsOrdersCollection AnOrder = new clsOrdersCollection();
        //set an empty string 
        AnOrder.ReportByOrderStatus("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //display fields
        DisplayOrders(AnOrder);

    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect user to the orders login page
        Response.Redirect("TeamMainMenu.aspx");
    }
}