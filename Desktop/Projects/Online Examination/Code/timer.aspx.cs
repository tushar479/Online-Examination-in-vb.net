using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class timer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!ScriptManager1.IsInAsyncPostBack)
        {
            Session["sc"] = 60;
            Session["ct"] = 2;

        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        int sec = Convert.ToInt32(Session["sc"]);
        int min = Convert.ToInt32(Session["ct"]);
        sec=sec--;
        Label2.Text = sec.ToString();
        Label1.Text = min.ToString();
        //if (sec == 0)
        //{
        //    ViewState["sc"] = 60;
        //    min = min - 1;
        //    ViewState["ct"] = min;
        //}
    }
}