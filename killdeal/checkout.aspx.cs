using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class checkout : System.Web.UI.Page
{
    int sum = 0;
    string name = null;
    dal ddl = new dal();
    protected void Page_Load(object sender, EventArgs e)
    {
     
        DataTable check = new DataTable();
        check = (DataTable)Session["dtSelectedItem"];
        if (check != null)
        {
            if (check.Rows.Count > 0)
            {
                
                foreach (DataRow row2 in check.Rows)
                {
                    name = name + "," + "  "+row2["ITM_NAME"].ToString() + " x " + row2["Quantity"].ToString();
                   
                    sum = sum + Convert.ToInt32(row2["ITM_TOTAL_PRICE"].ToString());
                    

                }
                name = name.Trim(',');
                Name.Text = name.ToString();
                amount.Text = sum.ToString();
                subtotal.Text = sum.ToString();
                GrandTotal.Text = sum.ToString();
            }

        }
        else
        {
            body.Visible = false;
            body2.Visible = true;
        }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        Page page = HttpContext.Current.CurrentHandler as Page;
        Session["order"] = null;
        string script = null;
        string result = "";
        Ecommerce.T_ECO_ORDER_TRANS tran = new Ecommerce.T_ECO_ORDER_TRANS();
        tran.TOT_CONTRY = contry.Text.ToString();
        tran.TOT_PHONE = txtcontact.Text.ToString();
        tran.TOT_F_NAME = billing_first_name.Text.ToString();
        tran.TOT_L_NAME = billing_last_name.Text.ToString();
        tran.TOT_ADDRESS = billing_address_1.Text.ToString();
        tran.TOT_APPARTMENT = billing_address_2.Text.ToString();
        tran.TOT_CITY = billing_city.Text.ToString();
        tran.TOT_PIN = billing_postcode.Text.ToString();
        tran.TOT_EMAIL = billing_email.Text.ToString();
        tran.TOT_PHONE2 = billing_phone.Text.ToString();
        tran.TOT_ACT_FLG = "Y";
        tran.TOT_AMOUNT = GrandTotal.Text.ToString();
        tran.TOT_CONTACT_PERSON = "898162170";
        DataTable check = new DataTable();
        check = (DataTable)Session["dtSelectedItem"];
        if(check!=null)
        {
           result= ddl.submit(tran, check);
            if(result!= "alert('An error occur please try again !')")
            {
                Session["order"] = result;
                Response.Redirect("conformatio.aspx");
                
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertMessage", result, true);
            }
        }
        else
        {
            string scriptText = "alert('An error occur while inserting data,Please try again. !')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alertMessage", scriptText, true);
        }
    }
}