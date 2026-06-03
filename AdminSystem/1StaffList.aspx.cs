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

        if (IsPostBack == false)
        {
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();

        lstStaffList.Items.Clear();

        for (int i = 0; i < Staff.Count; i++)
        {
            string DisplayText =
                Staff.StaffList[i].StfID + " - " +
                Staff.StaffList[i].StfName + " - " +
                Staff.StaffList[i].StfRole;

            lstStaffList.Items.Add(new System.Web.UI.WebControls.ListItem(
                DisplayText,
                Staff.StaffList[i].StfID.ToString()
            ));
        }
    }

    void DisplayFilteredStaff(string Role)
    {
        clsStaffCollection Staff = new clsStaffCollection();

        Staff.ReportByRole(Role);

        lstStaffList.Items.Clear();

        for (int i = 0; i < Staff.Count; i++)
        {
            string DisplayText =
                Staff.StaffList[i].StfID + " - " +
                Staff.StaffList[i].StfName + " - " +
                Staff.StaffList[i].StfRole;

            lstStaffList.Items.Add(new System.Web.UI.WebControls.ListItem(
                DisplayText,
                Staff.StaffList[i].StfID.ToString()
            ));
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StfID"] = -1;
        Response.Redirect("1StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (lstStaffList.SelectedIndex != -1)
        {
            Session["StfID"] = Convert.ToInt32(lstStaffList.SelectedValue);
            Response.Redirect("1StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a staff record to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (lstStaffList.SelectedIndex != -1)
        {
            Session["StfID"] = Convert.ToInt32(lstStaffList.SelectedValue);
            Response.Redirect("1StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a staff record to delete.";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        DisplayFilteredStaff(txtFilter.Text);
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        txtFilter.Text = "";
        DisplayStaff();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}