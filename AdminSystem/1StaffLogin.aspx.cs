using System;
using ClassLibrary;

public partial class _1StaffLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsStaffUser AnUser = new clsStaffUser();

        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;

        Boolean Found = false;

        Found = AnUser.FindUser(UserName, Password);

        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a username";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a password";
        }
        else if (Found == true)
        {
            Session["AnUser"] = AnUser;
            Response.Redirect("1StaffList.aspx");
        }
        else
        {
            lblError.Text = "Login details are incorrect. Please try again.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}