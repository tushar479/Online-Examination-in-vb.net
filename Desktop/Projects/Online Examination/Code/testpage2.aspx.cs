using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class testpage2 : System.Web.UI.Page
{
    SqlConnection sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["con"]);
    SqlCommand sqlcmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            try
            {
                sqlcmd.Connection = sqlcon;
                sqlcon.Open();
                sqlcmd.CommandText = "select * from Question_Table where Question_Id=3";
                SqlDataReader sdr = sqlcmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Label3.Text = sdr[1].ToString();
                        RadioButtonList1.Items.Add(sdr[2].ToString());
                        RadioButtonList1.Items.Add(sdr[3].ToString());
                        RadioButtonList1.Items.Add(sdr[4].ToString());
                        RadioButtonList1.Items.Add(sdr[5].ToString());

                    }

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

    }
    int flag;
    int f1;
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            flag = 0;
            sqlcmd.Connection = sqlcon;
            sqlcon.Open();


            sqlcmd.CommandText = "select Correct_Answer from Question_Table where Question_Id=3";
            SqlDataReader sdr1 = sqlcmd.ExecuteReader();
            string s1 = "";
            while (sdr1.Read())
            {
                s1 = sdr1["Correct_Answer"].ToString();
            }

            sqlcon.Close();

            for (int i = 0; i < RadioButtonList1.Items.Count; i++)
            {
                if (RadioButtonList1.Items[i].Selected == true)
                {
                    if (RadioButtonList1.Items[i].Text == s1)
                    {
                        int m1 = Convert.ToInt32(Request.Cookies["MarksObtained"].Value);
                        m1 = m1 + 10;
                        HttpCookie ckmarks = new HttpCookie("MarksObtained");
                        ckmarks.Value = m1.ToString(); ;
                        Response.Cookies.Add(ckmarks);


                        int c1 = Convert.ToInt32(Request.Cookies["CorrectCookie"].Value);
                        c1 = c1 + 1;
                        HttpCookie ckcorrect = new HttpCookie("CorrectCookie");
                        ckcorrect.Value = c1.ToString();
                        Response.Cookies.Add(ckcorrect);
                        flag = 1;
                        //Response.Redirect("testpage1.aspx");
                        break;
                    }
                    else
                    {
                        if (Request.Cookies["NotCorrectCookie"].Value != null)
                        {
                            int nc1 = Convert.ToInt32(Request.Cookies["NotCorrectCookie"].Value);
                            nc1 = nc1 + 1;

                            HttpCookie cknotcorrect = new HttpCookie("NotCorrectCookie");
                            cknotcorrect.Value = nc1.ToString();
                            Response.Cookies.Add(cknotcorrect);
                            flag = 1;
                        }

                        //Response.Redirect("testpage1.aspx");
                        break;
                    }


                }

            }
            //if (flag == 0)
            //{
            //    int na1=Convert.ToInt32(Request.Cookies["NotAttemptCookie"].Value);
            //    na1=na1+1;
            //    HttpCookie cknotattempt = new HttpCookie("NotAttemptCookie");
            //    cknotattempt.Value = na1.ToString();
            //    Response.Cookies.Add(cknotattempt);
            //    //Response.Redirect("testpage1.aspx");
            //}

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            //sqlcon.Close();
        }
        for (int i = 0; i < RadioButtonList1.Items.Count; i++)
        {
            if (RadioButtonList1.Items[i].Selected == true)
            {
                f1 = 1;
                break;
            }
        }
        if (f1 == 0)
        {
            int na1 = Convert.ToInt32(Request.Cookies["NotAttemptCookie"].Value);
            na1 = na1 + 1;
            HttpCookie cknotattempt = new HttpCookie("NotAttemptCookie");
            cknotattempt.Value = na1.ToString();
            Response.Cookies.Add(cknotattempt);
        }
        Response.Redirect("testpage3.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("testpage1.aspx");
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    }
