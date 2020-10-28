using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewOrder : System.Web.UI.Page
{
    dal dll = new dal();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            dt = dll.Neworedrdetails();
            gvorder.DataSource = dt;
            gvorder.DataBind();
        }
    }
    protected void btnsherch_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();

        dt = dll.Neworedrdetails2(txtOrderID.Text.ToString().Trim());
        gvorder.DataSource = dt;
        gvorder.DataBind();
    }

    protected void btnopen_Click(object sender, EventArgs e)
    {

        LinkButton repeat = (LinkButton)sender;
        GridView ChildRPT = (GridView)repeat.FindControl("childRpt");
        Label OrderID = (Label)repeat.FindControl("lblOrderID");
        Button B1= (Button)repeat.FindControl("btnOrderUpd");
        Button B2 = (Button)repeat.FindControl("btnCancle");
        TextBox T1= (TextBox)repeat.FindControl("trackID");
        DropDownList T2 = (DropDownList)repeat.FindControl("DDl");
        TextBox T3 = (TextBox)repeat.FindControl("TextBox2");
        TextBox T4 = (TextBox)repeat.FindControl("TextBox3");
        DataTable dt = new DataTable();
        dt = dll.Itemdetails(OrderID.Text.ToString());
        ChildRPT.DataSource = dt;
        ChildRPT.DataBind();
        ChildRPT.Visible = true;
        B1.Visible = true;
        B2.Visible = true;
        T1.Visible = true;
        T2.Visible = true;
        T3.Visible = true;
        T4.Visible = true;
    }

    protected void btnclose_Click(object sender, EventArgs e)
    {
        LinkButton repeat = (LinkButton)sender;
        Label OrderID = (Label)repeat.FindControl("lblOrderID");
        GridView ChildRPT = (GridView)repeat.FindControl("childRpt");
        Button B1 = (Button)repeat.FindControl("btnOrderUpd");
        Button B2 = (Button)repeat.FindControl("btnCancle");
        TextBox T1 = (TextBox)repeat.FindControl("trackID");
        DropDownList T2 = (DropDownList)repeat.FindControl("DDl");
        TextBox T3 = (TextBox)repeat.FindControl("TextBox2");
        TextBox T4 = (TextBox)repeat.FindControl("TextBox3");
        ChildRPT.Visible = false;
        B1.Visible = false;
        B2.Visible = false;
        T1.Visible = false;
        T2.Visible = false;
        T3.Visible = false;
        T4.Visible = false;
        OrderID.Focus();
    }

    protected void btnOrderUpd_Click(object sender, EventArgs e)
    {
        Button repeat = (Button)sender;
        Label OrderID = (Label)repeat.FindControl("lblOrderID");
        TextBox T1 = (TextBox)repeat.FindControl("trackID");
        DropDownList T2 = (DropDownList)repeat.FindControl("DDl");
        TextBox T3 = (TextBox)repeat.FindControl("TextBox2");
        TextBox T4 = (TextBox)repeat.FindControl("TextBox3");
        if(T2.SelectedValue=="1")
        {
            if(T1.Text.ToString()!=null && T1.Text.ToString()!="")
            {
                int result = dll.update(T1.Text.ToString(), "Shiped", "N/A", "N/A", OrderID.Text.ToString());
                if(Convert.ToUInt32(result) > 0)
                {
                    GPNO.Text = "Done";
                    modelSuss.InnerText = "Updated";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showModalSuccess();", true);
                }
                else
                {
                    lblWarnMessage.Text = "Please Fill all Fields ";
                    lblWarnMessage.ForeColor = System.Drawing.Color.White;
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showModalWarn();", true);
                }

               
            }
            else
            {
                lblWarnMessage.Text = "Please Fill all Fields ";
                lblWarnMessage.ForeColor = System.Drawing.Color.White;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showModalWarn();", true);
            }

        }
        else if(T2.SelectedValue == "2")
        {
            if (T3.Text.ToString() != null && T3.Text.ToString() != "" && T4.Text.ToString() != null && T4.Text.ToString() != "")
            {


                int result = dll.update("N/A", "Shiped", T3.Text.ToString(), T4.Text.ToString(), OrderID.Text.ToString());
                if (Convert.ToUInt32( result) > 0)
                {
                    GPNO.Text = "Done";
                    modelSuss.InnerText = "Updated";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showModalSuccess();", true);
                }
                else
                {
                    lblWarnMessage.Text = "Error ";
                    lblWarnMessage.ForeColor = System.Drawing.Color.White;
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showModalWarn();", true);
                }
            }
            else
            {
                lblWarnMessage.Text = "Please Fill all Fields ";
                lblWarnMessage.ForeColor = System.Drawing.Color.White;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showModalWarn();", true);
            }
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
        int result = dll.update("N/A", "Cancel", "Cancel", "Cancel", OrderID.Text.ToString());
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
        Response.Redirect("NewOrder.aspx");
    }


}