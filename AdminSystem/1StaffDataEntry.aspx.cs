using System;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StfID;

    protected void Page_Load(object sender, EventArgs e)
    {
        StfID = Convert.ToInt32(Session["StfID"]);

        if (IsPostBack == false)
        {
            if (StfID != -1)
            {
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();

        Staff.ThisStaff.Find(StfID);

        txtStfName.Text = Staff.ThisStaff.StfName;
        txtStfEmail.Text = Staff.ThisStaff.StfEmail;
        txtStfRole.Text = Staff.ThisStaff.StfRole;
        txtStfSalary.Text = Staff.ThisStaff.StfSalary.ToString();
        txtStfDateJoined.Text = Staff.ThisStaff.StfDateJoined.ToShortDateString();
        chkStfIsActive.Checked = Staff.ThisStaff.StfIsActive;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();

        string StfName = txtStfName.Text;
        string StfEmail = txtStfEmail.Text;
        string StfRole = txtStfRole.Text;
        string StfSalary = txtStfSalary.Text;
        string StfDateJoined = txtStfDateJoined.Text;

        string Error = AStaff.Valid(
            StfName,
            StfEmail,
            StfRole,
            StfSalary,
            StfDateJoined
        );

        if (Error == "")
        {
            clsStaffCollection Staff = new clsStaffCollection();

            AStaff.StfName = StfName;
            AStaff.StfEmail = StfEmail;
            AStaff.StfRole = StfRole;
            AStaff.StfSalary = Convert.ToInt32(StfSalary);
            AStaff.StfDateJoined = Convert.ToDateTime(StfDateJoined);
            AStaff.StfIsActive = chkStfIsActive.Checked;

            Staff.ThisStaff = AStaff;

            if (StfID == -1)
            {
                Staff.Add();
            }
            else
            {
                AStaff.StfID = StfID;
                Staff.ThisStaff = AStaff;
                Staff.Update();
            }

            Response.Redirect("1StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 StfID;
        Boolean Found = false;
        StfID = Convert.ToInt32(txtStfID.Text);
        Found = AStaff.Find(StfID);
        if (Found == true)
        {
            txtStfName.Text = AStaff.StfName.ToString();
            txtStfEmail.Text = AStaff.StfEmail.ToString();
            txtStfRole.Text = AStaff.StfRole.ToString();
            txtStfSalary.Text = AStaff.StfSalary.ToString();
            txtStfDateJoined.Text = AStaff.StfDateJoined.ToString();
            chkStfIsActive.Checked = AStaff.StfIsActive;

        }
    }
}