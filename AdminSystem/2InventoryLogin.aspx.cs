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
        if (IsPostBack == false)
        {
            //clear error message
            DisplayAddress();
        }
        clsInventoryUser AnInventory = new clsInventoryUser();
        clsInventoryUser AnUser = (clsInventoryUser)Session["AnUser"];
        Response.Write("Logged in as " + AnUser.UserName);
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create instance of the user class
        clsInventoryUser AnUser = new clsInventoryUser();

        //variables for username and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;

        Boolean Found = false;
        UserName=Convert.ToString(txtUserName.Text);
        Password=Convert.ToString(txtPassword.Text);

        Found = AnUser.FindUser(UserName,Password);
        Session["UserName"] = UserName;

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
        Response.Redirect("TeamMainMenu.aspx");
    }
}