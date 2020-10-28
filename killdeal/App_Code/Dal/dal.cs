using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for dal
/// </summary>
public class dal
{
    string CONNECTION_STRING_SQL = ConfigurationManager.ConnectionStrings["mdfconnection"].ConnectionString;
    public dal()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DataTable Item()
    {
        DataTable Loc = new DataTable();
        SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
        SqlTransaction transaction;
        con.Open();
        transaction = con.BeginTransaction("LocationDLL");
        DataTable dtResult = new DataTable();
        try
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = transaction;
            cmd.CommandText = @"select * from T_ECO_ITEM where ITM_ACT_FLG='Y'";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtResult);
            Loc = dtResult;
            transaction.Commit();
            con.Close();
            con.Dispose();
        }
        catch (Exception ex)
        {

            transaction.Rollback();
            con.Close();
            con.Dispose();
            throw ex;
        }
        finally
        {
            // transaction.Commit();
            con.Close();
            con.Dispose();
        }

        return Loc;

    }

    public string submit(Ecommerce.T_ECO_ORDER_TRANS tran,DataTable item)
    {
        string result = null;
        int result1 = 0;
        int result2 = 0;
        int id = ID();
        SqlTransaction trans;
        SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
        con.Open();
        trans = con.BeginTransaction();
        try
        {
            string Trans = @"insert into T_ECO_ORDER_TRANS(TOT_ID,TOT_CONTRY,TOT_PHONE,TOT_PHONE2,TOT_F_NAME,TOT_L_NAME,TOT_ADDRESS,TOT_APPARTMENT,TOT_CITY,TOT_PIN,
                                                          TOT_EMAIL,TOT_STATUS,TOT_CONTACT_PERSON,TOT_AMOUNT,TOT_ACT_FLG,TOT_CRT_DATE,TOT_CRT_BY)
                              values (@TOT_ID,@TOT_CONTRY,@TOT_PHONE,@TOT_PHONE2,@TOT_F_NAME,@TOT_L_NAME,@TOT_ADDRESS,@TOT_APPARTMENT,@TOT_CITY,@TOT_PIN,
                                         @TOT_EMAIL,@TOT_STATUS,@TOT_CONTACT_PERSON,@TOT_AMOUNT,@TOT_ACT_FLG,@TOT_CRT_DATE,@TOT_CRT_BY)";
            SqlCommand cmdDltCart = new SqlCommand(Trans, con);
            cmdDltCart.Transaction = trans;
            cmdDltCart.Parameters.AddWithValue("TOT_ID",id);
            cmdDltCart.Parameters.AddWithValue("TOT_CONTRY", tran.TOT_CONTRY);
            cmdDltCart.Parameters.AddWithValue("TOT_PHONE", tran.TOT_PHONE);
            cmdDltCart.Parameters.AddWithValue("TOT_PHONE2", tran.TOT_PHONE2);
            cmdDltCart.Parameters.AddWithValue("TOT_F_NAME", tran.TOT_F_NAME);
            cmdDltCart.Parameters.AddWithValue("TOT_L_NAME", tran.TOT_L_NAME);
            cmdDltCart.Parameters.AddWithValue("TOT_ADDRESS", tran.TOT_ADDRESS);
            cmdDltCart.Parameters.AddWithValue("TOT_APPARTMENT", tran.TOT_APPARTMENT);
            cmdDltCart.Parameters.AddWithValue("TOT_CITY", tran.TOT_CITY);
            cmdDltCart.Parameters.AddWithValue("TOT_PIN", tran.TOT_PIN);
            cmdDltCart.Parameters.AddWithValue("TOT_EMAIL", tran.TOT_EMAIL);
            cmdDltCart.Parameters.AddWithValue("TOT_STATUS", "Order Place");
            cmdDltCart.Parameters.AddWithValue("TOT_CONTACT_PERSON", tran.TOT_CONTACT_PERSON);
            cmdDltCart.Parameters.AddWithValue("TOT_AMOUNT", tran.TOT_AMOUNT);
            cmdDltCart.Parameters.AddWithValue("TOT_ACT_FLG", tran.TOT_ACT_FLG);
            cmdDltCart.Parameters.AddWithValue("TOT_CRT_DATE",DateTime.Now);
            cmdDltCart.Parameters.AddWithValue("TOT_CRT_BY", tran.TOT_EMAIL);
            result1 = cmdDltCart.ExecuteNonQuery();
            foreach (DataRow row in item.Rows)
            {
                string ITEMTrans = @"insert into T_ECO_ORDER_ITEM_DETAILS(TOD_SL,TOD_ORDER_ID,TOD_ITEM_ID,TOD_NAME,TOD_PRICE,TOD_QTY,TOD_TOTAL_PRICE,TOD_IMAGE,TOD_ACT_FLG,TOD_CRT_DT,TOD_CRT_BY)
                                      values((SELECT ISNULL(MAX(TOD_SL), 0)+1  FROM  T_ECO_ORDER_ITEM_DETAILS),@Id,@itmId,@name,@price,@qty,@TOTPRICE,@Img,@flg,@TOD_CRT_DT,@TOD_CRT_BY)";
                SqlCommand cmdItem = new SqlCommand(ITEMTrans, con);
                cmdItem.Transaction = trans;
                cmdItem.Parameters.AddWithValue("Id", id);
                cmdItem.Parameters.AddWithValue("itmId", Convert.ToInt32(row["ITM_ID"].ToString()));
                cmdItem.Parameters.AddWithValue("name", row["ITM_NAME"].ToString());
                cmdItem.Parameters.AddWithValue("price", row["ITM_PRICE"].ToString());
                cmdItem.Parameters.AddWithValue("qty", row["Quantity"].ToString());
                cmdItem.Parameters.AddWithValue("TOTPRICE", row["ITM_TOTAL_PRICE"].ToString());
                cmdItem.Parameters.AddWithValue("Img", row["ITM_IMAGE"].ToString());
                cmdItem.Parameters.AddWithValue("flg", "Y");
                cmdItem.Parameters.AddWithValue("TOD_CRT_DT", DateTime.Now);
                cmdItem.Parameters.AddWithValue("TOD_CRT_BY", tran.TOT_EMAIL);
                result2 =result2+ cmdItem.ExecuteNonQuery();
            }
            if (result1 > 0 && result2>0)
            {
                trans.Commit();
                con.Close();
                con.Dispose();
                result = id.ToString();
            }
            else
            {
                trans.Rollback();
                con.Close();
                con.Dispose();
                result = "alert('An error occur please try again !')";
            }
        }
        catch(Exception ex)
        {
            trans.Rollback();
            con.Close();
            con.Dispose();
            result = "alert('An error occur please try again !')";
        }
        finally
        {

        }

            return result;
    }
    public int ID()
    {
        int RID = 0;
        string rid = null;
        DataTable id = new DataTable();
        SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
        // con.Open();
        string qurey = @"select ISNULL(MAX(TOT_ID),20200)+1 as MAXID from T_ECO_ORDER_TRANS";
        SqlCommand command = new SqlCommand(qurey, con);
        SqlDataAdapter sa = new SqlDataAdapter(command);
        sa.Fill(id);
        rid = id.Rows[0]["MAXID"] == DBNull.Value ? string.Empty : Convert.ToString(id.Rows[0]["MAXID"]);
        RID = Convert.ToInt32(rid);
        return RID;
    }
    public DataTable oredrdetails(string id)
    {
        DataTable Loc = new DataTable();
        if (id != null)
        {
           
            SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
            SqlTransaction transaction;
            con.Open();
            transaction = con.BeginTransaction("LocationDLL");
            DataTable dtResult = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Transaction = transaction;
                cmd.CommandText = @"select * from T_ECO_ORDER_TRANS a
join T_ECO_ORDER_ITEM_DETAILS b on b.TOD_ORDER_ID=a.TOT_ID
where a.TOT_ID=@ID";
                cmd.Parameters.AddWithValue("ID", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtResult);
                Loc = dtResult;
                transaction.Commit();
                con.Close();
                con.Dispose();

            }
            catch (Exception ex)
            {

                transaction.Rollback();
                con.Close();
                con.Dispose();
                throw ex;
            }
            finally
            {
                // transaction.Commit();
                con.Close();
                con.Dispose();
            }
        }
        return Loc;

    }

    public DataTable Alloredrdetails(string email)
    {
        DataTable Loc = new DataTable();
       

            SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
            SqlTransaction transaction;
            con.Open();
            transaction = con.BeginTransaction("LocationDLL");
            DataTable dtResult = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Transaction = transaction;
                cmd.CommandText = @"select * from T_ECO_ORDER_TRANS a where TOT_EMAIL=@email order by TOT_ID desc";
                cmd.Parameters.AddWithValue("email", email);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtResult);
                Loc = dtResult;
                transaction.Commit();
                con.Close();
                con.Dispose();

            }
            catch (Exception ex)
            {

                transaction.Rollback();
                con.Close();
                con.Dispose();
                throw ex;
            }
            finally
            {
                // transaction.Commit();
                con.Close();
                con.Dispose();
            }
        
        return Loc;

    }

    public DataTable Itemdetails(string id)
    {
        DataTable Loc = new DataTable();
        if (id != null)
        {

            SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
            SqlTransaction transaction;
            con.Open();
            transaction = con.BeginTransaction("LocationDLL");
            DataTable dtResult = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Transaction = transaction;
                cmd.CommandText = @"select * from T_ECO_ORDER_ITEM_DETAILS a Where a.TOD_ORDER_ID=@ID";
                cmd.Parameters.AddWithValue("ID", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtResult);
                Loc = dtResult;
                transaction.Commit();
                con.Close();
                con.Dispose();

            }
            catch (Exception ex)
            {

                transaction.Rollback();
                con.Close();
                con.Dispose();
                throw ex;
            }
            finally
            {
                // transaction.Commit();
                con.Close();
                con.Dispose();
            }
        }
        return Loc;

    }

    //----------Admin--------------//

    public DataTable Alloredrdetails()
    {
        DataTable Loc = new DataTable();


        SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
        SqlTransaction transaction;
        con.Open();
        transaction = con.BeginTransaction("LocationDLL");
        DataTable dtResult = new DataTable();
        try
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = transaction;
            cmd.CommandText = @"select * from T_ECO_ORDER_TRANS a where TOT_ACT_FLG='Y' order by TOT_ID desc";    
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtResult);
            Loc = dtResult;
            transaction.Commit();
            con.Close();
            con.Dispose();

        }
        catch (Exception ex)
        {

            transaction.Rollback();
            con.Close();
            con.Dispose();
            throw ex;
        }
        finally
        {
            // transaction.Commit();
            con.Close();
            con.Dispose();
        }

        return Loc;

    }
    public DataTable Alloredrdetails2(string email)
    {
        DataTable Loc = new DataTable();


        SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
        SqlTransaction transaction;
        con.Open();
        transaction = con.BeginTransaction("LocationDLL");
        DataTable dtResult = new DataTable();
        try
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = transaction;
            cmd.CommandText = @"select * from T_ECO_ORDER_TRANS a where TOT_ID=@email order by TOT_ID desc";
            cmd.Parameters.AddWithValue("email",Convert.ToInt32( email));
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtResult);
            Loc = dtResult;
            transaction.Commit();
            con.Close();
            con.Dispose();

        }
        catch (Exception ex)
        {

            transaction.Rollback();
            con.Close();
            con.Dispose();
            throw ex;
        }
        finally
        {
            // transaction.Commit();
            con.Close();
            con.Dispose();
        }

        return Loc;

    }
    public DataTable Neworedrdetails()
    {
        DataTable Loc = new DataTable();


        SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
        SqlTransaction transaction;
        con.Open();
        transaction = con.BeginTransaction("LocationDLL");
        DataTable dtResult = new DataTable();
        try
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = transaction;
            cmd.CommandText = @"select * from T_ECO_ORDER_TRANS a where TOT_STATUS='Order Place' and TOT_ACT_FLG='Y' order by TOT_ID desc";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtResult);
            Loc = dtResult;
            transaction.Commit();
            con.Close();
            con.Dispose();

        }
        catch (Exception ex)
        {

            transaction.Rollback();
            con.Close();
            con.Dispose();
            throw ex;
        }
        finally
        {
            // transaction.Commit();
            con.Close();
            con.Dispose();
        }

        return Loc;

    }
    public DataTable Neworedrdetails2(string email)
    {
        DataTable Loc = new DataTable();


        SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
        SqlTransaction transaction;
        con.Open();
        transaction = con.BeginTransaction("LocationDLL");
        DataTable dtResult = new DataTable();
        try
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = transaction;
            cmd.CommandText = @"select * from T_ECO_ORDER_TRANS a where TOT_ID=@email and TOT_STATUS='Order Place' and TOT_ACT_FLG='Y' order by TOT_ID desc";
            cmd.Parameters.AddWithValue("email", Convert.ToInt32(email));
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtResult);
            Loc = dtResult;
            transaction.Commit();
            con.Close();
            con.Dispose();

        }
        catch (Exception ex)
        {

            transaction.Rollback();
            con.Close();
            con.Dispose();
            throw ex;
        }
        finally
        {
            // transaction.Commit();
            con.Close();
            con.Dispose();
        }

        return Loc;

    }
    public DataTable Boyoredrdetails()
    {
        DataTable Loc = new DataTable();


        SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
        SqlTransaction transaction;
        con.Open();
        transaction = con.BeginTransaction("LocationDLL");
        DataTable dtResult = new DataTable();
        try
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = transaction;
            cmd.CommandText = @"select * from T_ECO_ORDER_TRANS a where TOT_STATUS not in('Order Place','Delivered','Cancel') and TOT_ACT_FLG='Y' and TOT_CORER_ID='N/A' order by TOT_ID desc";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtResult);
            Loc = dtResult;
            transaction.Commit();
            con.Close();
            con.Dispose();

        }
        catch (Exception ex)
        {

            transaction.Rollback();
            con.Close();
            con.Dispose();
            throw ex;
        }
        finally
        {
            // transaction.Commit();
            con.Close();
            con.Dispose();
        }

        return Loc;

    }
    public DataTable Boyoredrdetails2(string email)
    {
        DataTable Loc = new DataTable();


        SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
        SqlTransaction transaction;
        con.Open();
        transaction = con.BeginTransaction("LocationDLL");
        DataTable dtResult = new DataTable();
        try
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = transaction;
            cmd.CommandText = @"select * from T_ECO_ORDER_TRANS a where TOT_ID=@email and TOT_STATUS not in('Order Place','Delivered','Cancel') and TOT_ACT_FLG='Y' and TOT_CORER_ID='N/A' order by TOT_ID desc";
            cmd.Parameters.AddWithValue("email", Convert.ToInt32( email));
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtResult);
            Loc = dtResult;
            transaction.Commit();
            con.Close();
            con.Dispose();

        }
        catch (Exception ex)
        {

            transaction.Rollback();
            con.Close();
            con.Dispose();
            throw ex;
        }
        finally
        {
            // transaction.Commit();
            con.Close();
            con.Dispose();
        }

        return Loc;

    }
    //----------Admin--------------//
    public int update(string trackid, string status, string boy, string boycontact, string id)
    {
        int result = 0;
        SqlTransaction trans;
        SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
        con.Open();
        trans = con.BeginTransaction();
        try
        {
            string userid = (string)HttpContext.Current.Session["userid"];
            string Trans = @"update T_ECO_ORDER_TRANS set TOT_CORER_ID=@trackID,TOT_STATUS=@status,TOT_D_BOY=@boy,TOT_D_BOY_CONTACT=@boycontact,TOT_UP_BY=@TOT_UP_BY,TOT_UP_DATE=@TOT_UP_DATE where TOT_ID=@id ";
            SqlCommand cmdDltCart = new SqlCommand(Trans, con);
            cmdDltCart.Transaction = trans;
            cmdDltCart.Parameters.AddWithValue("id", Convert.ToInt32(id));
            cmdDltCart.Parameters.AddWithValue("trackID", trackid);
            cmdDltCart.Parameters.AddWithValue("status", status);
            cmdDltCart.Parameters.AddWithValue("boy", boy);
            cmdDltCart.Parameters.AddWithValue("boycontact", boycontact);
            cmdDltCart.Parameters.AddWithValue("TOT_UP_BY", userid);
            cmdDltCart.Parameters.AddWithValue("TOT_UP_DATE", DateTime.Now);
            int result1 = cmdDltCart.ExecuteNonQuery();
            if (result1 > 0)
            {
                trans.Commit();
                con.Close();
                con.Dispose();
                result = result1;
            }
            else
            {
                trans.Rollback();
                con.Close();
                con.Dispose();
                result = 0;
            }
        }
        catch (Exception ex)
        {
            trans.Rollback();
            con.Close();
            con.Dispose();
            result = 0;
        }
        finally
        {

        }
        return result;
    }

    public int update2( string status,string id)
    {
        int result = 0;
        SqlTransaction trans;
        SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
        con.Open();
        trans = con.BeginTransaction();
        try
        {
            string userid = (string)HttpContext.Current.Session["userid"];
            string Trans = @"update T_ECO_ORDER_TRANS set TOT_STATUS=@status,TOT_UP_BY=@TOT_UP_BY,TOT_UP_DATE=@TOT_UP_DATE where TOT_ID=@id ";
            SqlCommand cmdDltCart = new SqlCommand(Trans, con);
            cmdDltCart.Transaction = trans;
            cmdDltCart.Parameters.AddWithValue("id", Convert.ToInt32(id));
            cmdDltCart.Parameters.AddWithValue("status", status);
            cmdDltCart.Parameters.AddWithValue("TOT_UP_BY", userid);
            cmdDltCart.Parameters.AddWithValue("TOT_UP_DATE", DateTime.Now);
            int result1 = cmdDltCart.ExecuteNonQuery();
            if (result1 > 0)
            {
                trans.Commit();
                con.Close();
                con.Dispose();
                result = result1;
            }
            else
            {
                trans.Rollback();
                con.Close();
                con.Dispose();
                result = 0;
            }
        }
        catch (Exception ex)
        {
            trans.Rollback();
            con.Close();
            con.Dispose();
            result = 0;
        }
        finally
        {

        }
        return result;
    }

    public DataTable UserAuth(string id,string pass)
    {
        DataTable Loc = new DataTable();
        if (id != null)
        {

            SqlConnection con = new SqlConnection(CONNECTION_STRING_SQL);
            SqlTransaction transaction;
            con.Open();
            transaction = con.BeginTransaction("LocationDLL");
            DataTable dtResult = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Transaction = transaction;
                cmd.CommandText = @"select TUA_USER_NAME,TUA_ROLE from T_USER_AUTH a Where a.TUA_USER_ID=@ID and a.TUA_USER_PASS=@pass and TUA_ACT_FLG='Y'";
                cmd.Parameters.AddWithValue("ID", id);
                cmd.Parameters.AddWithValue("pass", pass);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtResult);
                Loc = dtResult;
                transaction.Commit();
                con.Close();
                con.Dispose();

            }
            catch (Exception ex)
            {

                transaction.Rollback();
                con.Close();
                con.Dispose();
                throw ex;
            }
            finally
            {
                // transaction.Commit();
                con.Close();
                con.Dispose();
            }
        }
        return Loc;

    }
}