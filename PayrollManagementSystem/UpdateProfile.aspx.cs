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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DBMethods db = new DBMethods();
                EmployeeModels m = new EmployeeModels();
                m.EmpId = int.Parse(txtempid.Text);
                m.Empname = txtname.Text;
                m.EmailId = txtmail.Text;
                m.MobNo = long.Parse(txtpn.Text);
                m.Location = txtloc.Text;

                var res = db.UpdateProfile(m);
                if (res) output.Text = "Profile Updated Successfully";
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}