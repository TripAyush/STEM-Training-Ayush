using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationForm
{
    public partial class NewActivity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int baseSalary = int.Parse(txtbase.Text);
                int dearnessAllow = int.Parse(dearness.Text);
                int houseRentAllow = int.Parse(hra.Text);
                int conveAllow = int.Parse(convey.Text);
                int enterAllow = int.Parse(entertain.Text);
                int medi = int.Parse(medical.Text);
                int iT = int.Parse(incometax.Text);
                int PF = int.Parse(pf.Text);

                int grossSalary = baseSalary + dearnessAllow + houseRentAllow + conveAllow + enterAllow +
                    medi;

                int netSalary = grossSalary - iT - PF;

                gsalary.Text = grossSalary.ToString();
                nsalary.Text = netSalary.ToString();
            }
            catch(Exception ex)
            {
                gsalary.Text = ex.Message;
            }
        }
    }
}