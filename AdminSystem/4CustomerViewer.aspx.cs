using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VibeConnect;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    
    {
        // Retrieve customer object from Session
    Customer ACustomer = (Customer)Session["ACustomer"];

    // Display customer information
    lblCustomerInfo.Text =
        "Name: " + ACustomer.CustomerName + "<br />" +
        "Email: " + ACustomer.CustomerEmail + "<br />" +
        "Phone: " + ACustomer.CustomerPhone + "<br />" +
        "Address: " + ACustomer.CustomerAddress + "<br />" +
        "Active: " + ACustomer.CustomerIsActive;

    }
}