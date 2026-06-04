using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VibeConnect;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
{
    CustomerID = Convert.ToInt32(Session["CustomerID"]);

    if (IsPostBack == false)
    {
        if (CustomerID != -1)
        {
            DisplayCustomer();
        }
    }
}
private void DisplayCustomer()
{
    Customer ACustomer = new Customer();

    ACustomer.Find(CustomerID);

    txtCustomerID.Text = ACustomer.CustomerID.ToString();
    txtCustomerName.Text = ACustomer.CustomerName;
    txtCustomerEmail.Text = ACustomer.CustomerEmail;
    txtCustomerPhone.Text = ACustomer.CustomerPhone;
    txtCustomerAddress.Text = ACustomer.CustomerAddress;
    txtCustomerPassword.Text = ACustomer.CustomerPassword;
    chkCustomerIsActive.Checked = ACustomer.CustomerIsActive;
}
    protected void btnOK_Click(object sender, EventArgs e)
{
    // Create an instance of the Customer class
    Customer ACustomer = new Customer();

    // Variables for validation
    string CustomerName;
    string CustomerEmail;
    string CustomerPhone;
    string CustomerAddress;
    string CustomerPassword;
    string CustomerDateCreated;

    string Error;

    // Capture data from the form
    CustomerName = txtCustomerName.Text;
    CustomerEmail = txtCustomerEmail.Text;
    CustomerPhone = txtCustomerPhone.Text;
    CustomerAddress = txtCustomerAddress.Text;
    CustomerPassword = txtCustomerPassword.Text;

    // We don't currently have a date textbox, so use today's date
    CustomerDateCreated = DateTime.Now.Date.ToString();

    // Validate the data
    Error = ACustomer.Valid(
        CustomerName,
        CustomerEmail,
        CustomerPhone,
        CustomerAddress,
        CustomerPassword,
        CustomerDateCreated);

    // If there are no errors
    if (Error == "")
    {
        ACustomer.CustomerName = CustomerName;
ACustomer.CustomerEmail = CustomerEmail;
ACustomer.CustomerPhone = CustomerPhone;
ACustomer.CustomerAddress = CustomerAddress;
ACustomer.CustomerPassword = CustomerPassword;
ACustomer.CustomerIsActive = chkCustomerIsActive.Checked;
ACustomer.CustomerDateCreated = Convert.ToDateTime(CustomerDateCreated);

// Create the collection
CustomerCollection CustomerBook = new CustomerCollection();

// Assign the customer to ThisCustomer
CustomerBook.ThisCustomer = ACustomer;

// Decide whether to Add or Update
if (CustomerID == -1)
{
    CustomerBook.Add();
}
else
{
    ACustomer.CustomerID = CustomerID;
    CustomerBook.Update();
}

// Return to the list page
Response.Redirect("4CustomerList.aspx");
    }
    else
    {
        // Display the error message
        lblError.Text = Error;
    }
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
protected void btnMainMenu_Click(object sender, EventArgs e)
{
    Response.Redirect("TeamMainMenu.aspx");
}
}