using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cart : System.Web.UI.Page
{
    protected string ArrayStore = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton Cart = (LinkButton)Master.FindControl("btncart");
        Cart.Enabled = false;
        this.ArrayStore = Request.Form["ArrayStore"];
        if (this.ArrayStore!=null)
        {
            Order(this.ArrayStore);
        }
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["dtSelectedItem"];
            if (dt != null)
            {
                gvcart.DataSource = dt;
                gvcart.DataBind();
            }
            else
            {
                body.Visible = false;
                body2.Visible = true;
            }
        }

    }


    public void Order(string x)

    {
        if (x != "" && x != null && x!=",")
        {
            jsonToDt jsondata = new jsonToDt();

            DataTable dt = jsondata.JsonStringToDataTable(x);


            DataTable dtSelectedItem = (DataTable)Session["dtSelectedItem"];
            foreach (DataRow row in dtSelectedItem.Rows)
            {
                foreach (DataRow row2 in dt.Rows)
                {
                    if (row["ITM_ID"].ToString() == row2["ID"].ToString())
                    {
                        row["ITM_TOTAL_PRICE"] = row2["TOTAL"].ToString();
                        row["Quantity"] = Convert.ToInt32(row2["QTY"].ToString());
                    }
                }
            }
            Session["dtSelectedItem"] = dtSelectedItem;
            gvcart.DataSource = dtSelectedItem;
            gvcart.DataBind();
        }
    }



    protected void btncheckout_Click(object sender, EventArgs e)
    {
        Response.Redirect("checkout.aspx");
    }

    protected void btnremove_Click(object sender, EventArgs e)
    {
        LinkButton eventBtn = (LinkButton)(sender);
        string[] commandArgs = eventBtn.CommandArgument.ToString().Split(new char[] { ',' });
        string ItemID = commandArgs[0];
        DataTable dtSelectedItem = (DataTable)Session["dtSelectedItem"];
        foreach (DataRow row in dtSelectedItem.Rows)
        {
           
                if (ItemID == row["ITM_ID"].ToString())
                {
                row.Delete();
                break;
                }
            }
        
        Session["dtSelectedItem"] = dtSelectedItem;
        gvcart.DataSource = dtSelectedItem;
        gvcart.DataBind();
        if(dtSelectedItem.Rows.Count!=0)
        {
            Response.Redirect("Cart.aspx");
        }
        else
        {
            Session["dtSelectedItem"] = null;
            Response.Redirect("Home.aspx");
        }
        
    }
    protected void btnContinue_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}