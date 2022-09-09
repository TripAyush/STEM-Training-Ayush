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
    public partial class DeleteEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DBMethods db = new DBMethods();
                EmployeeModels m = new EmployeeModels();

                m.EmpId = int.Parse(txtempid.Text);

                var res = db.DeleteEmployee(m);
                if (res==true) output.Text = "Employee Deleted Successfully";
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}