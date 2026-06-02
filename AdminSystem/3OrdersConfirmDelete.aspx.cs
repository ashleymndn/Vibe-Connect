using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);

    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the orders collection class
        clsOrdersCollection OrdersBook = new clsOrdersCollection();
        //find the record to delete
        OrdersBook.ThisOrder.Find(OrderId);
        //delet the record
        OrdersBook.Delete();
        //redirect back to the main page
        Response.Redirect("3OrdersList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("3OrdersList.aspx");

    }
}