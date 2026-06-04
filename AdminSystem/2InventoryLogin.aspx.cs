using ClassLibrary;
using System;
using System.Web.UI;

public partial class _2InventoryLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblError.Text = "";
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsInventoryUser AnUser = new clsInventoryUser();

        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;

        if (UserName == "" || Password == "")
        {
            lblError.Text = "Please enter a username and password";
        }
        else
        {
            bool Found = AnUser.FindUser(UserName, Password);

            if (Found)
            {
                Session["AnUser"] = AnUser;
                Session["UserName"] = UserName;

                Response.Redirect("2InventoryList.aspx");
            }
            else
            {
                lblError.Text = "Login details are incorrect.";
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}