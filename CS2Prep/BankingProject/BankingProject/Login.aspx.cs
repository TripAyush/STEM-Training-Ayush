﻿using BankingProject.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                BankingDB db = new BankingDB();
                var res = db.Login(int.Parse(txtcid.Text), txtpass.Text);
                output.Text = res;
                if (res == "Login Success")
                {
                    Session["cid"] = long.Parse(txtcid.Text);
                    Response.Redirect("Home.aspx");
                }
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}