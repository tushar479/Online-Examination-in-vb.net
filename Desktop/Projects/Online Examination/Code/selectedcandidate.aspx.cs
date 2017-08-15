using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class selectedcandidate : System.Web.UI.Page
{
    SqlConnection sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["con"]);
    SqlCommand sqlcmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "select * from Score_Table where Score >=30";
            SqlDataReader sdr = sqlcmd.ExecuteReader();
            
            DataTable dt = new DataTable();
            dt.Load(sdr);
            Response.Write(dt.Rows.Count.ToString());
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
            sqlcon.Close();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}