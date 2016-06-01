using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace ReportSQL
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetReport_Click(object sender, EventArgs e)
        {
            try
            {
                string sqldb = "SELECT TOP 50 * FROM(SELECT COALESCE(OBJECT_NAME(s2.objectid),'Ad-Hoc') AS ProcName," +
                                "execution_count,s2.objectid," +
                                "(SELECT TOP 1 SUBSTRING(s2.TEXT,statement_start_offset / 2+1 ," +
                                "( (CASE WHEN statement_end_offset = -1" +
                                "THEN (LEN(CONVERT(NVARCHAR(MAX),s2.TEXT)) * 2)" +
                                "ELSE statement_end_offset END)- statement_start_offset) / 2+1)) AS sql_statement," +
                                "last_execution_time" +
                                "FROM sys.dm_exec_query_stats AS s1" +
                                "CROSS APPLY sys.dm_exec_sql_text(sql_handle) AS s2 ) x" +
                                "WHERE sql_statement NOT like 'SELECT TOP 50 * FROM(SELECT %'" +
                                "--and OBJECTPROPERTYEX(x.objectid,'IsProcedure') = 1" +
                                "ORDER BY last_execution_time DESC";

                sqldb = "Select * from dbo.PERIODO_REGISTRO_AUTOPLAN";
                //sqldb = "Select top 10 * from dbo.APROBACION";

                string conn = WebConfigurationManager.ConnectionStrings["3654connect"].ConnectionString.ToString();
                SqlConnection conobj = new SqlConnection(conn);
                conobj.Open();
                SqlCommand cmdobj = new SqlCommand(sqldb, conobj);

                DataSet ds = new DataSet();
                SqlDataAdapter adpobj = new SqlDataAdapter(cmdobj);
                adpobj.Fill(ds);
                conobj.Close();
                Session["dsSession"] = ds.Tables[0];
                //grdv1.DataSource = ds;
                //grdv1.DataBind();
                //grdv1.Visible = true;
                Response.Write("Copy done");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnCopy_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
           
            dt = ((DataTable)Session["dsSession"]);


            string conn = WebConfigurationManager.ConnectionStrings["3656connection"].ConnectionString.ToString();
            SqlConnection conobj = new SqlConnection(conn);
            conobj.Open();
            SqlCommand cmdobj = new SqlCommand("[dbo].[InsertTable]", conobj);
            cmdobj.CommandType = CommandType.StoredProcedure;
            SqlParameter tvparam = cmdobj.Parameters.AddWithValue("@dt", dt);
            tvparam.SqlDbType = SqlDbType.Structured;
            cmdobj.ExecuteNonQuery();
            Response.Write("Paste completed");
        }
    }
}