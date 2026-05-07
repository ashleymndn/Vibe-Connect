using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //get the data from the session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //display the orderId for this entry
        Response.Write(AnOrder.OrderId + "<br />");
        Response.Write(AnOrder.CustomerId + "<br />");
        Response.Write(AnOrder.OrderDate + "<br />");
        Response.Write(AnOrder.Total + "<br />");
        Response.Write(AnOrder.Address + "<br />");
        Response.Write(AnOrder.OrderStatus + "<br />");
        Response.Write(AnOrder.IsDelivered + "<br />");

    }
}