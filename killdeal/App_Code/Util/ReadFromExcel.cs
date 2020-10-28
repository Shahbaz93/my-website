using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// Summary description for ReadFromExcel
/// </summary>

    public class ReadFromExcel
    {
        public ReadFromExcel()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public DataTable Import_To_Grid(string FilePath, string Extension, string isHDR, string SheetName)

        {

            string conStr = "";

            switch (Extension)

            {

                case ".xls": //Excel 97-03

                    conStr = ConfigurationManager.ConnectionStrings["Excel03ConString"]

                             .ConnectionString;

                    break;

                case ".xlsx": //Excel 07

                    conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"]

                              .ConnectionString;

                    break;

            }

            conStr = String.Format(conStr, FilePath, isHDR);

            OleDbConnection connExcel = new OleDbConnection(conStr);

            OleDbCommand cmdExcel = new OleDbCommand();

            OleDbDataAdapter oda = new OleDbDataAdapter();

            DataTable dt = new DataTable();

            cmdExcel.Connection = connExcel;



            //Get the name of First Sheet

            connExcel.Open();

            DataTable dtExcelSchema;

            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            //SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();



            connExcel.Close();



            //Read Data from First Sheet

            connExcel.Open();

            cmdExcel.CommandText = "SELECT * From [" + SheetName + "]";
        //cmdExcel.CommandText = "SELECT * From [T_ENQUIRY_DETAILS]";

        oda.SelectCommand = cmdExcel;

            oda.Fill(dt);

            connExcel.Close();

            return dt;

        }
        public int Insert_TO_Excel(string FilePath, string Extension, string isHDR, string SheetName, string query)

        {
            int res = 0;
            string conStr = "";

            switch (Extension)

            {

                case ".xls": //Excel 97-03

                    conStr = ConfigurationManager.ConnectionStrings["Excel03ConString"]

                             .ConnectionString;

                    break;

                case ".xlsx": //Excel 07

                    conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"]

                              .ConnectionString;

                    break;

            }

            conStr = String.Format(conStr, FilePath, isHDR);

            OleDbConnection connExcel = new OleDbConnection(conStr);

            OleDbCommand cmdExcel = new OleDbCommand();

            OleDbDataAdapter oda = new OleDbDataAdapter();

            DataTable dt = new DataTable();

            cmdExcel.Connection = connExcel;



            //Get the name of First Sheet

            connExcel.Open();

            DataTable dtExcelSchema;

            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            //SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();



            connExcel.Close();



            //Read Data from First Sheet

            connExcel.Open();

            cmdExcel.CommandText = query;



            //checking that connection state is closed or not if closed the     
            //open the connection    
            if (connExcel.State == ConnectionState.Closed)
            {
                connExcel.Open();
            }
            //create command object    
            OleDbCommand cmd = new OleDbCommand(query, connExcel);
            res = cmd.ExecuteNonQuery();




            //oda.SelectCommand = cmdExcel;

            //oda.Fill(dt);

            connExcel.Close();

            return res;

        }
    }
