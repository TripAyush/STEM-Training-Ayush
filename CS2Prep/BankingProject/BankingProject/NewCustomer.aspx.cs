using BankingProject.DataAccessLayer;
using BankingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingProject
{
    public partial class NewCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                BankingDB db = new BankingDB();
                CustomerModel m = new CustomerModel();

                m.CustName = cname.Text;
                m.CustAddress = caddr.Text;
                m.MobNo = long.Parse(cmob.Text);
                m.EmailId = cemail.Text;
                m.Password = cpass.Text;
                if (rmale.Checked) m.Gender = rmale.Text;
                if (rfemale.Checked) m.Gender = rfemale.Text;
                if (rother.Checked) m.Gender = rother.Text;

                var res = db.InsertCustomer(m);
                if (res > 0) output.Text = "New CustomerID is : " + res;
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}