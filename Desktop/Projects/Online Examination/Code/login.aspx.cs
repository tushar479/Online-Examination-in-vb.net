using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;


public partial class login : System.Web.UI.Page
{

    SqlConnection sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["con"]);
    SqlCommand sqlcmd = new SqlCommand();
    

    protected void Page_Load(object sender, EventArgs e)
    {
        sqlcmd.Connection = sqlcon;
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            sqlcmd.CommandText = "select count(*) from Login_Table where User_Id ='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "' ";
            sqlcon.Open();
            int cnt = Convert.ToInt32(sqlcmd.ExecuteScalar());
            if (cnt > 0)
            {
                //HttpCookie ckusername=
                Response.Redirect("entryform.aspx");
            }
            if (cnt == 0)
            {
                Response.Write("Incorrect UserName and Password");
                TextBox1.Text = "";
                TextBox2.Text = "";

            }
            sqlcon.Close();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}