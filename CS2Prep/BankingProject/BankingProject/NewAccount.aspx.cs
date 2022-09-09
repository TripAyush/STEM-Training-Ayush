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
    public partial class NewAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cid"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            else
            {
                txtcid.Text = Session["cid"].ToString();
            }
        }

        protected void btnNewAcc_Click(object sender, EventArgs e)
        {
            try
            {
                AccountsModel am = new AccountsModel();
                am.CustId = int.Parse(txtcid.Text);
                am.AccountType = DropDownList1.SelectedItem.Text;
                if (ractive.Checked) am.Status = ractive.Text;
                if (rinactive.Checked) am.Status = rinactive.Text;

                BankingDB db = new BankingDB();
                var res = db.InsertAccounts(am);
                if (res > 0) output.Text = "New AccountID is : " + res;
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}