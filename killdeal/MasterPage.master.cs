﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected string ArrayStore = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        this.ArrayStore = Request.Form["ArrayStore"];
        if (this.ArrayStore != null)
        {
            Order(this.ArrayStore);
        }

        DataTable dt = new DataTable();
        dt = (DataTable)Session["dtSelectedItem"];
        if (dt != null)
        {
            body.Visible = true;
            body2.Visible = false;
            gvcart.DataSource = dt;
            gvcart.DataBind();
        }
        else
        {
            body.Visible = false;
            body2.Visible = true;
        }
        int sum = 0;
        DataTable check = new DataTable();
        check = (DataTable)Session["dtSelectedItem"];
        if (check != null)
        {
            if (check.Rows.Count > 0)
            {
              //  count.Text = check.Rows.Count.ToString();
                count1.Text = check.Rows.Count.ToString();
                foreach (DataRow row2 in check.Rows)
                {
                    sum = sum + Convert.ToInt32(row2["ITM_TOTAL_PRICE"].ToString());
                   

                }
                //cartamount.Text = sum.ToString();
                cartamount1.Text = sum.ToString();
            }
           
        }
        else
        {
            cartamount1.Text = "0";
            count1.Text = "0";
        }
    }

    protected void btnprivasy_Click(object sender, EventArgs e)
    {
        Session["back"] = Request.UrlReferrer.ToString();

        Response.Redirect("Privacy.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Session["back"] = Request.UrlReferrer.ToString();

        Response.Redirect("ReturnPoly.aspx");
    }
    protected void btncart_Click(object sender, EventArgs e)
    {
        //GPNO.Text = "Order Delivered";
       // modelSuss.InnerText = "Order Delivered";
        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showModalCart();", true);
    }
    protected void btncontinue_Click(object sender, EventArgs e)
    {

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
        if (dtSelectedItem.Rows.Count != 0)
        {
           // Response.Redirect("Home.aspx");
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
