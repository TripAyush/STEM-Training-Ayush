using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationForm
{
    public partial class GetSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Name" + Session["name"]);
            Response.Write("<br>");
            Response.Write("Age" + Session["age"]);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write(Session.SessionID);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }
    }
}