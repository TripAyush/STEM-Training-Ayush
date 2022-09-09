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
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DBMethods db = new DBMethods();
                EmployeeModels m = new EmployeeModels();

                m.Empname = txtename.Text;

                foreach (ListItem li in ddDept.Items)
                {
                    if (li.Selected) m.Dept = li.Text;
                }

                m.EmailId = txtmail.Text;
                m.MobNo = long.Parse(txtphone.Text);
                m.Location = txtloc.Text;

                foreach (ListItem li in ddDesg.Items)
                {
                    if (li.Selected) m.Desg = li.Text;
                }


                var res = db.InsertEmployee(m);
                if (res > 0) output.Text = "New Employee Added, Employee ID : " + res;
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}