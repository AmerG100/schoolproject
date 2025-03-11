using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class MasterPage1 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["mutar"] == "ok")
            Label1.Visible = true;
        else
            Label1.Visible = false;
        //טיפול במקרה של שני תפריטים
        if (Page.Session["mutar"] != "ok")
        {
            MainMenu.Visible = true;
            MainMenu2.Visible = false;
        }
        else
        {
            MainMenu.Visible = false;
            MainMenu2.Visible = true;

        }
        if (Session["username1"] !=null)
        {
            Label3.Text = "You are signing in";
            Label3.ForeColor = System.Drawing.Color.Green;
            Button1.Visible = true;
        }
        else
        {
            Label3.Text = "You are signing out";
            Label3.ForeColor = System.Drawing.Color.Red;
            Button1.Visible = false;
        }
        
    }

    

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Session["username1"] = null;
        Label3.Text = "You are signing out";
        Label3.ForeColor = System.Drawing.Color.Red;
        Button1.Visible = false;
        Response.Redirect("getin.aspx");
    }
}
