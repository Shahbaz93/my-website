using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Ecommerce
/// </summary>
public class Ecommerce
{
    public Ecommerce()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public class T_ECO_ITEM
    {
        public double ITM_ID { get; set; }
        public string ITM_NAME { get; set; }
        public string ITM_DETAILS { get; set; }
        public string ITM_PRICE { get; set; }
        public string ITM_IMAGE { get; set; }

    }

    public class T_ECO_ORDER_TRANS
    {
        public double TOT_ID { get; set; }
        public string TOT_CONTRY { get; set; }
        public string TOT_PHONE { get; set; }
        public string TOT_PHONE2 { get; set; }
        public string TOT_F_NAME { get; set; }

        public string TOT_L_NAME { get; set; }

        public string TOT_ADDRESS { get; set; }

        public string TOT_APPARTMENT { get; set; }

        public string TOT_CITY { get; set; }
        public string TOT_PIN { get; set; }

        public string TOT_EMAIL { get; set; }

        public string TOT_CORER_ID { get; set; }

        public string TOT_STATUS { get; set; }
        public string TOT_AMOUNT { get; set; }
        public string TOT_ACT_FLG { get; set; }
        public string TOT_CONTACT_PERSON { get; set; }

    }

    public class T_ECO_ORDER_DETAILS
    {
        public double TOD_ORDER_ID { get; set; }
        public double TOD_ITEM_ID { get; set; }
        public string TOD_NAME { get; set; }
        public string TOD_DETAILS { get; set; }
        public string TOD_PRICE { get; set; }
        public string TOD_QTY { get; set; }
        public string TOD_TOTAL_PRICE { get; set; }
        public string TOD_IMAGE { get; set; }
        public string TOD_ACT_FLG { get; set; }

    }
}