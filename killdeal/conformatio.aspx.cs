using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class conformatio : System.Web.UI.Page
{
    dal dll = new dal();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["dtSelectedItem"] = null;
        string id = (string)Session["order"];
        DataTable dt = new DataTable();
        dt = dll.oredrdetails(id);
        Session["order"] = null;
        if (dt!=null)
        {
           if(dt.Rows.Count>0)
            {
                lblOrderID.Text = Convert.ToString(dt.Rows[0]["TOT_ID"]);
                lblTrackId.Text= Convert.ToString(dt.Rows[0]["TOT_CORER_ID"]);
                contry.Text = Convert.ToString(dt.Rows[0]["TOT_CONTRY"]);
                txtcontact.Text = Convert.ToString(dt.Rows[0]["TOT_PHONE"]);
                billing_first_name.Text = Convert.ToString(dt.Rows[0]["TOT_F_NAME"]);
                billing_last_name.Text = Convert.ToString(dt.Rows[0]["TOT_L_NAME"]);
                billing_address_1.Text = Convert.ToString(dt.Rows[0]["TOT_ADDRESS"]);
                billing_address_2.Text = Convert.ToString(dt.Rows[0]["TOT_APPARTMENT"]);
                billing_city.Text = Convert.ToString(dt.Rows[0]["TOT_CITY"]);
                billing_postcode.Text = Convert.ToString(dt.Rows[0]["TOT_PIN"]);
                billing_email.Text = Convert.ToString(dt.Rows[0]["TOT_EMAIL"]);
                billing_phone.Text = Convert.ToString(dt.Rows[0]["TOT_PHONE2"]);
                TOTAL.Text  = Convert.ToString(dt.Rows[0]["TOT_AMOUNT"]);
            }
        }
        gvorder.DataSource = dt;
        gvorder.DataBind();
    }
}