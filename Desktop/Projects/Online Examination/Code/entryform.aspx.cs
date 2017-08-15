using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class entryform : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = DateTime.Now.Date.ToString();
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        HttpCookie ckmarks = new HttpCookie("MarksObtained");
        ckmarks.Value = "0";
        Response.Cookies.Add(ckmarks);

        HttpCookie ckcorrect = new HttpCookie("CorrectCookie");
        ckcorrect.Value = "0";
        Response.Cookies.Add(ckcorrect);

        HttpCookie cknotcorrect = new HttpCookie("NotCorrectCookie");
        cknotcorrect.Value = "0";
        Response.Cookies.Add(cknotcorrect);

        HttpCookie ckname = new HttpCookie("CandidateName");
        ckname.Value = TextBox1.Text;
        Response.Cookies.Add(ckname);

        HttpCookie cknotattempt = new HttpCookie("NotAttemptCookie");
        cknotattempt.Value = "0";
        Response.Cookies.Add(cknotattempt);

        Response.Redirect("testpage.aspx");
    }
}