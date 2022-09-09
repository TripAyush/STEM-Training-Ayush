using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GithubDemo
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnayush_Click(object sender, EventArgs e)
        {
            Response.Write("Ayush Button Clicked");
        }
      
        protected void btnvish_Click1(object sender, EventArgs e)
        {
            Response.Write("Vishwak Button Clicked");
        }
        

        protected void BtnNechiketh_Click(object sender, EventArgs e)
        {
            Response.Write("Nechiketh Button Clicked");
        }
    }
}