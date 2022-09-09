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
    public partial class NewTransaction : System.Web.UI.Page
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

        protected void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            Session["accid"] = row.Cells[0].Text;
            Response.Write("AccountID : " + Session["accid"]);
            accid.Text = Session["accid"].ToString();
        }

        protected void btnTransact_Click(object sender, EventArgs e)
        {
            try
            {
                TransactionModel tm = new TransactionModel();
                tm.AccountNo = long.Parse(accid.Text);

                foreach (ListItem li in rbtt.Items)
                {
                    if (li.Selected) tm.TransType = li.Text;
                }
                tm.TransAmount = decimal.Parse(tamount.Text);

                BankingDB db = new BankingDB();
                var res = db.InsertTransaction(tm);
                output.Text = res;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}