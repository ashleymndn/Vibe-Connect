using System;
using VibeConnect;

public partial class _4CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        CustomerUser AnUser = new CustomerUser();

        Boolean Found = false;

        string UserName;
        string Password;

        UserName = txtUserName.Text;
        Password = txtPassword.Text;

        Found = AnUser.FindUser(UserName, Password);

        if (Found == true)
        {
            Session["UserID"] = AnUser.UserID;
            Session["UserName"] = AnUser.UserName;
            Session["Department"] = AnUser.Department;

            Response.Redirect("4CustomerList.aspx");
        }
        else
        {
            lblError.Text = "Login details are incorrect.";
        }
    }
}