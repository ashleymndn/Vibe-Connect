using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //capture the OrderId
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        //capture the Customer Id
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //capture the Order Date
        AnOrder.OrderDate = Convert.ToDateTime(DateTime.Now);
        //capture the Total
        AnOrder.Total = Convert.ToDecimal(txtTotal.Text);
        //capture the Address
        AnOrder.Address = txtAddress.Text;
        //capture the Order Status
        AnOrder.OrderStatus = txtOrderStatus.Text;
        //capture the Is Delivered check box
        AnOrder.IsDelivered = chkIsDelivered.Checked;
        //store the order in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("3OrdersViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

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
            txtAddress.Text = AnOrder.Address;
            txtOrderStatus.Text = AnOrder.OrderStatus.ToString();
            chkIsDelivered.Checked = AnOrder.IsDelivered;

        }
    }
}