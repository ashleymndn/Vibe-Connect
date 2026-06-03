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
    protected void btnFind_Click(object sender, EventArgs e)
{
    // Create an instance of the customer class
    Customer ACustomer = new Customer();

    // Variable to store the primary key
    Int32 CustomerID;

    // Get the ID entered by the user
    CustomerID = Convert.ToInt32(txtCustomerID.Text);

    // Find the record
    Boolean Found = ACustomer.Find(CustomerID);

    // If found
    if (Found == true)
    {
        txtCustomerName.Text = ACustomer.CustomerName;
        txtCustomerEmail.Text = ACustomer.CustomerEmail;
        txtCustomerPhone.Text = ACustomer.CustomerPhone;
        txtCustomerAddress.Text = ACustomer.CustomerAddress;
        txtCustomerPassword.Text = ACustomer.CustomerPassword;
        chkCustomerIsActive.Checked = ACustomer.CustomerIsActive;
    }
}
}