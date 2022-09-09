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
    public partial class SalaryGeneration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsalary_Click(object sender, EventArgs e)
        {
            try
            {
                DBMethods db = new DBMethods();
                SalaryModels m = new SalaryModels();

                m.EmpId = int.Parse(txtempid.Text);
                m.Salary = decimal.Parse(txtsal.Text);
                foreach (ListItem li in ddldesg.Items){
                   if (li.Selected) m.Desg = li.Text;
                }


                var res = db.GenerateSalary(m);
                if (res > 0) output.Text = "Salary Generated, Salary ID : " + res;
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}