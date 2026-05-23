using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            if (OrderId != -1)
            {
                DisplayOrders();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();

        //capture the Customer Id
        string CustomerId = txtCustomerId.Text;

        //capture the Order Date
        string OrderDate = txtOrderDate.Text;

        //capture the Total
        string Total = txtTotal.Text;

        //capture the Address
        string Address = txtAddress.Text;

        //capture the Order Status
        string OrderStatus = txtOrderStatus.Text;

        //capture the Is Delivered check box
        string IsDelivered = chkIsDelivered.Text;



        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AnOrder.Valid(CustomerId, OrderDate, Total, Address, OrderStatus);

        if (Error == "")
        {
            //capture the order id
            AnOrder.OrderId = OrderId;

            //capture the Customer Id
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);

            //capture the Order Date
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);

            //capture the Total
            AnOrder.Total = Convert.ToDecimal(Total);

            //capture the Address
            AnOrder.Address = Address;

            //capture the Order Status
            AnOrder.OrderStatus = OrderStatus;

            //capture the Is Delivered check box
            AnOrder.IsDelivered = chkIsDelivered.Checked;

            //create a new instance fo the orders collection
            clsOrdersCollection OrdersList = new clsOrdersCollection();

            //if this is a new record i.e. OrderId = -1 the add the data
            if (OrderId == -1)
            {
                //set the ThisOrder property
                OrdersList.ThisOrder = AnOrder;
                //update the record
                OrdersList.Add();

            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrdersList.ThisOrder.Find(OrderId);
                //set the ThisOrder property
                OrdersList.ThisOrder = AnOrder;
                // update the record
                OrdersList.Update();

            }
        
            //redirect back to the list page
            Response.Redirect("3OrdersList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("3OrdersList.aspx");
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();
        Int32 OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(txtOrderId.Text);
        Found = AnOrder.Find(OrderId);
        if (Found == true)
        {
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtTotal.Text = AnOrder.Total.ToString();
            txtAddress.Text = AnOrder.Address.ToString();
            txtOrderStatus.Text = AnOrder.OrderStatus.ToString();
            chkIsDelivered.Checked = AnOrder.IsDelivered;

        }
    }

    void DisplayOrders()
    {
        //create an instance of the address book
        clsOrdersCollection OrdersBook = new clsOrdersCollection();
        //find the record to update
        OrdersBook.ThisOrder.Find(OrderId);
        //display the dat for the record
        txtOrderId.Text = OrdersBook.ThisOrder.OrderId.ToString();
        txtCustomerId.Text = OrdersBook.ThisOrder.CustomerId.ToString();
        txtOrderDate.Text = OrdersBook.ThisOrder.OrderDate.ToString();
        txtTotal.Text = OrdersBook.ThisOrder.Total.ToString();
        txtAddress.Text = OrdersBook.ThisOrder.Address;
        txtOrderStatus.Text = OrdersBook.ThisOrder.OrderStatus;
        chkIsDelivered.Checked = OrdersBook.ThisOrder.IsDelivered;
    }
}