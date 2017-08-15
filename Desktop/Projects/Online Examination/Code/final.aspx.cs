using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class final : System.Web.UI.Page
{
    SqlConnection sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["con"]);
    SqlCommand sqlcmd = new SqlCommand();
    int m1, c1, nc1, na1;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Label4.Text = Request.Cookies["CandidateName"].Value;
            Label6.Text = Request.Cookies["MarksObtained"].Value;
            Label8.Text = Request.Cookies["CorrectCookie"].Value;
            Label9.Text = Request.Cookies["NotCorrectCookie"].Value;
            Label7.Text = Request.Cookies["NotAttemptCookie"].Value;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        sqlcon.Open();
        sqlcmd.Connection= sqlcon;
        m1 = Convert.ToInt32(Label6.Text);
        c1 = Convert.ToInt32(Label8.Text);
        nc1 = Convert.ToInt32(Label9.Text);
        na1 = Convert.ToInt32(Label7.Text);
        sqlcmd.CommandText = "insert into Score_Table values('" + Label4.Text +"'," + m1 + "," +c1+ "," + nc1 + "," + na1+ ")";
        int a = sqlcmd.ExecuteNonQuery();
        
        sqlcon.Close();
        Response.Redirect("entryform.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       
    }
}