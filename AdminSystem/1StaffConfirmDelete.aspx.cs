using System;
using ClassLibrary;

public partial class _1StaffConfirmDelete : System.Web.UI.Page
{
    Int32 StfID;

    protected void Page_Load(object sender, EventArgs e)
    {
        StfID = Convert.ToInt32(Session["StfID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();

        Staff.ThisStaff.Find(StfID);
        Staff.Delete();

        Response.Redirect("1StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("1StaffList.aspx");
    }
}