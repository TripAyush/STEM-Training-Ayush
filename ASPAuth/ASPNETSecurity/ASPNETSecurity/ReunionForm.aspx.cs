using ASPNETSecurity.DataAccessLayer;
using ASPNETSecurity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETSecurity
{
    public partial class ReunionForm : System.Web.UI.Page
    {
        ReunionModel model = new ReunionModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (yesradio.Checked) model.Attendance = yesradio.Text;
            if (noradio.Checked) model.Attendance = yesradio.Text;

            model.FName = fntxt.Text;
            model.LName = lntxt.Text;
            model.PhNo = long.Parse(phonetxt.Text);

            if (vegradio.Checked) model.Meals = vegradio.Text;
            if (nonvegradio.Checked) model.Meals = nonvegradio.Text;

            foreach (ListItem li in gamecbl.Items)
            {
                if (li.Selected) model.Games += li.Text + ",";
            }

            model.Questions = quesTxt.Text;

            output.Text = model.Attendance + "," + model.FName + "," + model.LName + "," + model.PhNo + "," + model.Meals + "," + model.Games + "," + model.Questions;


            try
            {
                DBMethods db = new DBMethods();
                var res = db.InsertReunion(model);
                if (res > 0) output.Text = "Thanks for the response Membership Id is " + res;
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }

        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                DBMethods db = new DBMethods();
                var res = db.SelectReunion();
                GridView1.DataSource = res;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {

                output.Text = ex.Message;
            }
        }
    }
}