using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegistrationForm.DataAccessLayer;
using RegistrationForm.Models;

namespace RegistrationForm
{
    public partial class AnotherForm : System.Web.UI.Page
    {
        RegTableModel model = new RegTableModel();
        RegTableDB db = new RegTableDB();
        protected void Page_Load(object sender, EventArgs e) { }

        protected void submit_Click(object sender, EventArgs e)
        {
            //Textbox
            model.Name = txtname.Text;
            model.Address = txtaddr.Text;
            model.Password = txtpass.Text;

            if (txtradio1.Checked) model.Gender = txtradio1.Text;

            if (txtradio2.Checked) model.Gender = txtradio2.Text;


            //Checkbox List
            foreach (ListItem temp in cblist.Items)
            {
                if (temp.Selected) model.Qualification += temp.Text + ",";
            }

            //Dropdown List
            model.City = ddlcity.SelectedItem.Text;

            //List Box
            foreach (ListItem skill in lbskills.Items)
            {
                if (skill.Selected) model.SkillSets += skill.Text + ",";
            }

            model.Age = int.Parse(txtage.Text);
            model.Email = txtemail.Text;

            output.Text = model.Name + "," + model.Address + "," + model.Password + ","
                + model.Gender + "," + model.Qualification + "," + model.City + "," + model.SkillSets + "," + model.Age
                + "," + model.Email;

            try
            {
                int res = db.InsertRegTable(model);
                if (res > 0) output.Text = "Data Inserted Successfully";
                }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }

        //Radio Button
        protected void txtradio1_CheckedChanged(object sender, EventArgs e)
        {
            // gender = txtradio1.Text;
        }

        protected void txtradio2_CheckedChanged(object sender, EventArgs e)
        {
            // gender = txtradio2.Text;
        }

        protected void reset_Click(object sender, EventArgs e)
        {
        }


        protected void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                var result = db.SelectData();
                GridView1.DataSource = result;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }

        protected void selectDS_Click(object sender, EventArgs e)
        {
            try {
                var res = db.SelectDisconnected();
                GridView2.DataSource = res.Tables["RegTable"];
                GridView2.DataBind();
            }
            catch(Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}