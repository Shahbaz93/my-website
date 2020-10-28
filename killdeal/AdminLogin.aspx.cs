using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminLogin : System.Web.UI.Page
{
    dal dll = new dal();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt = dll.UserAuth(txbuserid.Text.Trim().ToString().ToLower(), txbpassword.Text.Trim().ToString().ToLower());
        if(dt.Rows.Count>0)
        {
            Session["userid"] = txbuserid.Text.Trim().ToString().ToLower();
            string role = dt.Rows[0]["TUA_ROLE"] == DBNull.Value ? string.Empty : Convert.ToString(dt.Rows[0]["TUA_ROLE"]); 
            if(role=="A")
            {
                Session["Role"] = "ADMIN";

            }
            else if(role=="D")
            {
                Session["Role"] = "BOY";
            }
            Session["UserName"] = dt.Rows[0]["TUA_USER_NAME"] == DBNull.Value ? string.Empty : Convert.ToString(dt.Rows[0]["TUA_USER_NAME"]); ;

            Response.Redirect("AdminDashbord.aspx");
        }
        else
        {

        }
    }
}