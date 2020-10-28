using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    ReadFromExcel rfe = new ReadFromExcel();
    dal dll = new dal();
    protected void Page_Load(object sender, EventArgs e)
    {
      //Session["dtSelectedItem"] = null;
        dt = dll.Item();
        Session["Itemdt"] = dt;
        RptItem.DataSource = dt;
        RptItem.DataBind();
        Session["dtdetailsItem"] = null;


    }
    protected void Click_btncart(object sender, EventArgs e)
    {
        LinkButton eventBtn = (LinkButton)(sender);
        string[] commandArgs = eventBtn.CommandArgument.ToString().Split(new char[] { ',' });
        string ItemID = commandArgs[0];
        DataTable dt = new DataTable();
        dt = (DataTable)Session["Itemdt"];
        if (Session["dtSelectedItem"] != null)
        {
            DataTable check = new DataTable();
            check = (DataTable)Session["dtSelectedItem"];
            foreach (DataRow dr in check.Rows)
            {
                if(ItemID== dr["ITM_ID"].ToString())
                {
                    return;
                }
            }
        }
        foreach (DataRow dr in dt.Rows)
        {

            if (dr["ITM_ID"].ToString() == ItemID)
            {
                DataTable dtSelectedItem = new DataTable();

                if (Session["dtSelectedItem"] == null)
                {
                    dtSelectedItem.Columns.Add("ITM_ID", typeof(int));
                    dtSelectedItem.Columns.Add("ITM_NAME", typeof(string));
                    dtSelectedItem.Columns.Add("ITM_DETAILS", typeof(string));
                    dtSelectedItem.Columns.Add("ITM_PRICE", typeof(string));
                    dtSelectedItem.Columns.Add("ITM_TOTAL_PRICE", typeof(string));
                    dtSelectedItem.Columns.Add("ITM_IMAGE", typeof(string));
                    dtSelectedItem.Columns.Add("Quantity", typeof(int));

                }
                else
                {
                    dtSelectedItem = (DataTable)Session["dtSelectedItem"];

                }
                DataRow dtrow = dtSelectedItem.NewRow();
                dtrow["ITM_ID"] = Convert.ToInt32(dr["ITM_ID"].ToString());
                dtrow["ITM_NAME"] = dr["ITM_NAME"].ToString();
                dtrow["ITM_DETAILS"] = dr["ITM_DETAILS"].ToString();
                dtrow["ITM_PRICE"] = dr["ITM_PRICE"].ToString();
                dtrow["ITM_IMAGE"] = dr["ITM_IMAGE"].ToString();
                dtrow["ITM_TOTAL_PRICE"] = dr["ITM_PRICE"].ToString();
                dtrow["Quantity"] = 1;
                dtSelectedItem.Rows.Add(dtrow);
                Session["dtSelectedItem"] = dtSelectedItem;
            }

        }
        Label lblMasterStatus = (Label)Master.FindControl("cartamount1");
        Label count = (Label)Master.FindControl("count1");
        int sum = 0;
        DataTable check2 = new DataTable();
        check2 = (DataTable)Session["dtSelectedItem"];
        if (check2 != null)
        {
            if (check2.Rows.Count > 0)
            {
                //  count.Text = check.Rows.Count.ToString();
                count.Text = check2.Rows.Count.ToString();
                foreach (DataRow row2 in check2.Rows)
                {
                    sum = sum + Convert.ToInt32(row2["ITM_TOTAL_PRICE"].ToString());


                }
                //cartamount.Text = sum.ToString();
                lblMasterStatus.Text = sum.ToString();
            }

        }
    }



    protected void btndetails_Click(object sender, EventArgs e)
    {

        LinkButton eventBtn = (LinkButton)(sender);
        string[] commandArgs = eventBtn.CommandArgument.ToString().Split(new char[] { ',' });
        string ItemID = commandArgs[0];
        DataTable dt = new DataTable();
        dt = (DataTable)Session["Itemdt"];
        
        foreach (DataRow dr in dt.Rows)
        {
            
            if (dr["ITM_ID"].ToString() == ItemID)
            {
                DataTable dtSelectedItem = new DataTable();

                if (Session["dtdetailsItem"] == null)
                {
                    dtSelectedItem.Columns.Add("ITM_ID", typeof(int));
                    dtSelectedItem.Columns.Add("ITM_NAME", typeof(string));
                    dtSelectedItem.Columns.Add("ITM_DETAILS", typeof(string));
                    dtSelectedItem.Columns.Add("ITM_PRICE", typeof(string));
                    dtSelectedItem.Columns.Add("ITM_TOTAL_PRICE", typeof(string));
                    dtSelectedItem.Columns.Add("ITM_IMAGE", typeof(string));
                    dtSelectedItem.Columns.Add("Quantity", typeof(int));

                }
                else
                {
                    dtSelectedItem = (DataTable)Session["dtdetailsItem"];

                }
                DataRow dtrow = dtSelectedItem.NewRow();
                dtrow["ITM_ID"] = Convert.ToInt32(dr["ITM_ID"].ToString());
                dtrow["ITM_NAME"] = dr["ITM_NAME"].ToString();
                dtrow["ITM_DETAILS"] = dr["ITM_DETAILS"].ToString();
                dtrow["ITM_PRICE"] = dr["ITM_PRICE"].ToString();
                dtrow["ITM_IMAGE"] = dr["ITM_IMAGE"].ToString();
                dtrow["ITM_TOTAL_PRICE"] = dr["ITM_PRICE"].ToString();
                dtrow["Quantity"] = 1;
                dtSelectedItem.Rows.Add(dtrow);
                Session["dtdetailsItem"] = dtSelectedItem;
            }

        }





        Session["back"] = Request.UrlReferrer.ToString();

        Response.Redirect("Product.aspx");
    }

    
}