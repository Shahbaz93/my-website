using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Track : System.Web.UI.Page
{
    dal dll = new dal();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    }

    protected void btnsherch_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        
        dt = dll.Alloredrdetails(txtemail.Text.ToString().Trim().ToLower());
        gvorder.DataSource = dt;
        gvorder.DataBind();
    }

    protected void btnopen_Click(object sender, EventArgs e)
    {
       
        LinkButton repeat = (LinkButton)sender;
        GridView ChildRPT = (GridView)repeat.FindControl("childRpt");
        Label OrderID = (Label)repeat.FindControl("lblOrderID");
        DataTable dt = new DataTable();
        dt = dll.Itemdetails(OrderID.Text.ToString());
        ChildRPT.DataSource = dt;
        ChildRPT.DataBind();
        ChildRPT.Visible = true;
    }

    protected void btnclose_Click(object sender, EventArgs e)
    {
        LinkButton repeat = (LinkButton)sender;
        Label OrderID = (Label)repeat.FindControl("lblOrderID");
        GridView ChildRPT = (GridView)repeat.FindControl("childRpt");

        ChildRPT.Visible = false;
        OrderID.Focus();
    }
}