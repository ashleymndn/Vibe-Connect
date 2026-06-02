using System;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AnUser"] != null)
        {
            clsStaffUser AnUser = (clsStaffUser)Session["AnUser"];
            lblUserName.Text = "Logged in as: " + AnUser.UserName;
        }
        else
        {
            lblUserName.Text = "No user logged in.";
        }
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StfID"] = -1;
        Response.Redirect("1StaffDataEntry.aspx");
    }
}