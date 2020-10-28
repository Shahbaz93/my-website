using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDashbord : System.Web.UI.Page
{
    dal ddl = new dal();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["userid"] != null && Session["Role"] != null)
        {
            string Role = (string)Session["Role"];
            if (Role != "ADMIN")
            {
                neword.Visible = false;
                allord.Visible = false;
            }
            else
            {

            }
        }
        DataTable neworder = new DataTable();
        DataTable allorder = new DataTable();
        DataTable boy = new DataTable();
        allorder = ddl.Alloredrdetails();
        neworder = ddl.Neworedrdetails();
        boy = ddl.Boyoredrdetails();
        if(allorder.Rows.Count>0)
        {
            lblAllOrder.Text = allorder.Rows.Count.ToString();
        }
        else
        {
            lblAllOrder.Text = "0";
        }
        if (neworder.Rows.Count > 0)
        {
            lblneworder.Text = neworder.Rows.Count.ToString();
        }
        else
        {
            lblneworder.Text = "0";
        }
        if (boy.Rows.Count > 0)
        {
            lblBoy.Text = boy.Rows.Count.ToString();
        }
        else
        {
            lblBoy.Text = "o";
        }
    }
}