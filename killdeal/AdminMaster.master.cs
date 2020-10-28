using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null && Session["Role"] != null)
        {
            string Role = (string)Session["Role"];
            if(Role!= "ADMIN")
            {
                neword.Visible = false;
                allorder.Visible = false;
            }
            else
            {

            }
        }
   }
    protected void Page_Init(object sender, EventArgs e)
    {
        //Load the session variables if the session is not set.
        if (validateSessionVariabes() == false)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        if (validateSessionVariabes() == true)
        {

        }
    }

    public bool validateSessionVariabes()
    {
        //TODO: METHOD TO VALIDATE THE SESSION VARIABLES.

        //Bool type flag to indicate whether the Session is valid or not.
        bool isSessionValid = false;

        //Check that the Session values are not null
        if (Session["userid"] != null)
        {
            string userid = (string)Session["userid"];
            if (userid != null)
            {
                isSessionValid = true;
            }
        }
        //return the bool flag.
        return isSessionValid;
    }

    protected void sinout_Click(object sender, EventArgs e)
    {
        Session["userid"] = null;
        Session["Role"] = null;
        Session["UserName"] = null;
        Response.Redirect("Home.aspx");

    }
}
