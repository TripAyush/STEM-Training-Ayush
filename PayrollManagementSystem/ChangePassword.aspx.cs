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
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void changeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DBMethods db = new DBMethods();
                UserModels m = new UserModels();

                m.UserId = int.Parse(txtuid.Text);
                m.Password = newpass.Text;
               
                var res = db.ChangePassword(m);
                if (res) output.Text = "Password Changed Successfully";
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}