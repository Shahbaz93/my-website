using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Product : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
       

        if(Session["dtdetailsItem"]!=null)
        {
            dt = (DataTable)Session["dtdetailsItem"];
        }
        else
        {
            Response.Redirect("Home.aspx");
        }
        if(dt.Rows.Count>0)
        {
            string[] desc = Convert.ToString(dt.Rows[0]["ITM_DETAILS"]).Split('#');
            int srtlength = desc.Length;
            lblprice.Text = Convert.ToString(dt.Rows[0]["ITM_PRICE"]);
            lblname.Text= Convert.ToString(dt.Rows[0]["ITM_NAME"]);
            lbldeff.Text = "&#x2022;&nbsp;" + desc[5];
            Image1.ImageUrl = desc[0];
            Image2.ImageUrl = desc[1];
            Image3.ImageUrl = desc[2];
            Image4.ImageUrl = desc[3];
            Image5.ImageUrl = desc[4];
            if(srtlength>5)
            {
                p1.Text = "&#x2022;&nbsp;" + desc[5];
                p1.Visible = true;
            }
            if (srtlength > 6)
            {
                p2.Text = "&#x2022;&nbsp;" + desc[6];
                p2.Visible = true;
            }
            if (srtlength > 7)
            {
                p3.Text = "&#x2022;&nbsp;" + desc[7];
                p3.Visible = true;
            }
            if (srtlength > 8)
            {
                p4.Text = "&#x2022;&nbsp;" + desc[8];
                p4.Visible = true;
            }
            if (srtlength > 9)
            {
                p5.Text = "&#x2022;&nbsp;" + desc[9];
                p5.Visible = true;
            }
            if (srtlength > 10)
            {
                p6.Text = "&#x2022;&nbsp;" + desc[10];
                p6.Visible = true;
            }
            if (srtlength > 11)
            {
                p7.Text = "&#x2022;&nbsp;" + desc[11];
                p7.Visible = true;
            }
            if (srtlength > 12)
            {
                p8.Text = "&#x2022;&nbsp;" + desc[12];
                p8.Visible = true;
            }
            if (srtlength > 13)
            {
                p9.Text = "&#x2022;&nbsp;" + desc[13];
                p9.Visible = true;
            }
            if (srtlength > 14)
            {
                p10.Text = "&#x2022;&nbsp;" + desc[14];
                p10.Visible = true;
            }
            if (srtlength > 15)
            {
                p11.Text = "&#x2022;&nbsp;" + desc[15];
                p11.Visible = true;
            }
            if (srtlength > 16)
            {
                p12.Text = "&#x2022;&nbsp;" + desc[16];
                p12.Visible = true;
            }
            if (srtlength > 17)
            {
                p13.Text = "&#x2022;&nbsp;" + desc[17];
                p13.Visible = true;
            }
            if (srtlength > 18)
            {
                p14.Text = "&#x2022;&nbsp;" + desc[18];
                p14.Visible = true;
            }
            if (srtlength > 19)
            {
                p15.Text = "&#x2022;&nbsp;" + desc[19];
                p15.Visible = true;
            }
            if (srtlength > 20)
            {
                p16.Text = desc[20];
                p16.Visible = true;
            }
            if (srtlength > 21)
            {
                p17.Text = "&#x2022;&nbsp;" + desc[21];
                p17.Visible = true;
            }
            if (srtlength > 22)
            {
                p18.Text = "&#x2022;&nbsp;" + desc[22];
                p18.Visible = true;
            }
            if (srtlength > 23)
            {
                p19.Text = "&#x2022;&nbsp;" + desc[23];
                p19.Visible = true;
            }
            if (srtlength > 24)
            {
                p20.Text = "&#x2022;&nbsp;" + desc[24];
                p20.Visible = true;
            }
            if (srtlength > 25)
            {
                p21.Text = "&#x2022;&nbsp;" + desc[25];
                p21.Visible = true;
            }

          
        }
        else
        {
            Response.Redirect("Home.aspx");
        }
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