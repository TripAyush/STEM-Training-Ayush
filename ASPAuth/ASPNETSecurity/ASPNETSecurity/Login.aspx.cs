using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNETSecurity.DataAccessLayer;

namespace ASPNETSecurity
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try
            {
                DBMethods db = new DBMethods();
                var res = db.Login(Login1.UserName, Login1.Password);

                if (res == true)
                {
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true);
                }
                else
                {
                    Login1.FailureText = "Invalid Credentials";
                }
            }
            catch (Exception ex)
            {
                Login1.FailureText = ex.Message;
            }

        }
    }
}