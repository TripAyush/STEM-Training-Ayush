using PayrollManagement.DataAccessLayer;
using PayrollManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollManagement
{
    public partial class NewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                DBMethods db = new DBMethods();
                UserModels m = new UserModels();

                m.UserName = txtuname.Text;
                m.Password = txtpwd.Text;
                if (rbadmin.Checked) m.UserRole = rbadmin.Text;
                if (rbemployee.Checked) m.UserRole = rbemployee.Text;

                var res = db.InsertUser(m);
                if (res > 0) output.Text = "New UserID is : " + res;
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}