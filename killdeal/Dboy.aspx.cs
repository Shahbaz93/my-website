using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dboy : System.Web.UI.Page
{
    dal dll = new dal();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            dt = dll.Boyoredrdetails();
            gvorder.DataSource = dt;
            gvorder.DataBind();
        }
    }
    protected void btnsherch_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();

        dt = dll.Boyoredrdetails2(txtOrderID.Text.ToString().Trim());
        gvorder.DataSource = dt;
        gvorder.DataBind();
    }

    protected void btnopen_Click(object sender, EventArgs e)
    {

        LinkButton repeat = (LinkButton)sender;
        GridView ChildRPT = (GridView)repeat.FindControl("childRpt");
        Label OrderID = (Label)repeat.FindControl("lblOrderID");
        Button B1 = (Button)repeat.FindControl("btnOrderUpd");
        Button B2 = (Button)repeat.FindControl("btnCancle");
        DataTable dt = new DataTable();
        dt = dll.Itemdetails(OrderID.Text.ToString());
        ChildRPT.DataSource = dt;
        ChildRPT.DataBind();
        ChildRPT.Visible = true;
        B1.Visible = true;
        B2.Visible = true;
    }

    protected void btnclose_Click(object sender, EventArgs e)
    {
        LinkButton repeat = (LinkButton)sender;
        Label OrderID = (Label)repeat.FindControl("lblOrderID");
        GridView ChildRPT = (GridView)repeat.FindControl("childRpt");
        Button B1 = (Button)repeat.FindControl("btnOrderUpd");
        Button B2 = (Button)repeat.FindControl("btnCancle");
        ChildRPT.Visible = false;
        B1.Visible = false;
        B2.Visible = false;
        OrderID.Focus();
    }

    protected void btnOrderUpd_Click(object sender, EventArgs e)
    {
        Button repeat = (Button)sender;
        Label OrderID = (Label)repeat.FindControl("lblOrderID");
        Label trackID = (Label)repeat.FindControl("lblTrackId");
        TextBox T1 = (TextBox)repeat.FindControl("trackID");
        DropDownList T2 = (DropDownList)repeat.FindControl("DDl");
        TextBox T3 = (TextBox)repeat.FindControl("TextBox2");
        TextBox T4 = (TextBox)repeat.FindControl("TextBox3");
        int result = dll.update2("Delivered", OrderID.Text.ToString());
        if (Convert.ToUInt32(result) > 0)
        {
            GPNO.Text = "Order Delivered";
            modelSuss.InnerText = "Order Delivered";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showModalSuccess();", true);
        }
        else
        {
            lblWarnMessage.Text = "Error ";
            lblWarnMessage.ForeColor = System.Drawing.Color.White;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showModalWarn();", true);
        }
    }

    protected void btnCancle_Click(object sender, EventArgs e)
    {
        Button repeat = (Button)sender;
        Label OrderID = (Label)repeat.FindControl("lblOrderID");
        TextBox T1 = (TextBox)repeat.FindControl("trackID");
        DropDownList T2 = (DropDownList)repeat.FindControl("DDl");
        TextBox T3 = (TextBox)repeat.FindControl("TextBox2");
        TextBox T4 = (TextBox)repeat.FindControl("TextBox3");
        int result = dll.update2( "Cancel", OrderID.Text.ToString());
        if (Convert.ToUInt32(result) > 0)
        {
            GPNO.Text = "Order cancelled";
            modelSuss.InnerText = "Order cancelled";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showModalSuccess();", true);
        }
        else
        {
            lblWarnMessage.Text = "Error ";
            lblWarnMessage.ForeColor = System.Drawing.Color.White;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showModalWarn();", true);
        }
    }
    protected void btncontinue_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dboy.aspx");
    }
}