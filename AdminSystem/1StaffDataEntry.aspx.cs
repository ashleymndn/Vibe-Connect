using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();

        string StfName = txtStfName.Text;
        string StfEmail = txtStfEmail.Text;
        string StfRole = txtStfRole.Text;
        string StfSalary = txtStfSalary.Text;
        string StfDateJoined = txtStfDateJoined.Text;

        string Error = "";

        Error = AStaff.Valid(
                    StfName,
                    StfEmail,
                    StfRole,
                    StfSalary,
                    StfDateJoined);

        if (Error == "")
        {
            AStaff.StfName = StfName;
            AStaff.StfEmail = StfEmail;
            AStaff.StfRole = StfRole;
            AStaff.StfSalary = Convert.ToInt32(StfSalary);
            AStaff.StfDateJoined = Convert.ToDateTime(StfDateJoined);
            AStaff.StfIsActive = chkStfIsActive.Checked;

            lblError.Text = "Data entered successfully.";
        }
        else
        {
            lblError.Text = Error;
        }
    }
}