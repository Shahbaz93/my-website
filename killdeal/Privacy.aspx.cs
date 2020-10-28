using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Privacy : System.Web.UI.Page
{
    string prevPage = null;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void back_Click(object sender, EventArgs e)
    {
        if (Session["back"] != null)
        {
            string prpage = (string)Session["back"];
            Session["back"] = null;
            Response.Redirect(prpage);
        }
        else
        {
            Session["back"] = null;
            Response.Redirect("Home.aspx");
        }
    }
}