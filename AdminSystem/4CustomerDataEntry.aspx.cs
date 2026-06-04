using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VibeConnect;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
         // Create a new customer object
    Customer ACustomer = new Customer();

    // Capture values from the form
    ACustomer.CustomerName = txtCustomerName.Text;
    ACustomer.CustomerEmail = txtCustomerEmail.Text;
    ACustomer.CustomerPhone = txtCustomerPhone.Text;
    ACustomer.CustomerAddress = txtCustomerAddress.Text;
    ACustomer.CustomerPassword = txtCustomerPassword.Text;
    ACustomer.CustomerIsActive = chkCustomerIsActive.Checked;

    // Store customer object in Session
    Session["ACustomer"] = ACustomer;

    // Navigate to the viewer page
    Response.Redirect("4CustomerViewer.aspx");
    }
}