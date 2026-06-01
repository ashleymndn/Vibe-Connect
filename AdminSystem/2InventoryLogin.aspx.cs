using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create instance of the user class
        clsInventoryUser AnUser = new clsInventoryUser();

        //variables for username and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;

        //check blank fields
        if (UserName == "" || Password == "")
        {
            lblError.Text = "Please enter a username and password";
        }
        else
        {
            //find the user
            Boolean Found = AnUser.FindUser(UserName, Password);

            //if found
            if (Found == true)
            {
                //redirect to list page
                Response.Redirect("InventoryList.aspx");
            }
            else
            {
                //show error
                lblError.Text = "Login details are incorrect. Please try again.";
            }

        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}