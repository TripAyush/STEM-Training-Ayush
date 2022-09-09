using PayrollManagement.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollManagement
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                DBMethods db = new DBMethods();
                string userRole = "";
                if (rbAdmin.Checked) userRole = rbAdmin.Text;
                if (rbEmp.Checked) userRole = rbEmp.Text;

                var res = db.Login(int.Parse(txtUid.Text), txtPass.Text,userRole);
                output.Text = res;
                if (res == "Login Success")
                {
                    Session["uid"] = int.Parse(txtUid.Text);
                    // FormsAuthentication.RedirectFromLoginPage(txtcid.Text,false);
                    if(userRole=="Admin") Response.Redirect("AdminHome.aspx");
                    if (userRole == "Employee") Response.Redirect("EmployeeHome.aspx");
                }
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}