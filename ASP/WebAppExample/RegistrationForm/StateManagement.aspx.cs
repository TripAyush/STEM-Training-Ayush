using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationForm{
    public partial class StateManagement : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){
            if (!IsPostBack){
                ViewState["counter"] = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Redirect from one webpage to another -> Routing
            Response.Redirect("GetQueryString.aspx?Name="+TextBox1.Text+"&Age="+TextBox2.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
            Session["age"] = TextBox2.Text;
            Response.Redirect("GetSession.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie cook = new HttpCookie("NameCookie");
            cook.Value = TextBox3.Text;
            cook.Expires = DateTime.Now.AddMinutes(5);
            HttpCookie cook1 = new HttpCookie("AgeCookie");
            cook1.Value = TextBox4.Text;
            cook1.Expires = DateTime.Now.AddMinutes(5);
            Response.Cookies.Add(cook);
            Response.Cookies.Add(cook1);
            Response.Write("Cookies added successfully");
        }

        //int counter;
        protected void Button4_Click(object sender, EventArgs e)
        {
           ViewState["counter"] = (int)ViewState["counter"] + 1;
            Label1.Text = "Counter : " + ViewState["counter"];
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
           ViewState["counter"] = (int)ViewState["counter"] + 1;
            Label1.Text = "Counter : " + ViewState["counter"];
        }
    }
}