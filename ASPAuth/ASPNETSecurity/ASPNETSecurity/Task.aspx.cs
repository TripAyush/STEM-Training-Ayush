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
    public partial class Task : System.Web.UI.Page
    {
        TaskModel model = new TaskModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalc_Click(object sender, EventArgs e)
        {
            model.Name = txtname.Text;
            model.accounts = int.Parse(txtacc.Text);
            model.marketing = int.Parse(txtmar.Text);
            model.computing = int.Parse(txtcom.Text);

            int total = int.Parse(txtacc.Text) + int.Parse(txtmar.Text) + int.Parse(txtcom.Text);
            totalMarks.Text = total.ToString();
            model.totalMarks = total;

            int aggr = total / 3;
            aggregate.Text = aggr.ToString();
            model.aggMarks = aggr;
            

            char grade = ' ';
            if (aggr >= 80) model.totalGrade = 'A';
            else if (aggr < 80 && aggr >= 60) model.totalGrade = 'B';
            else if (aggr < 60) model.totalGrade = 'C';

            grades.Text = model.totalGrade.ToString();

            try
            {
                DBMethods db = new DBMethods();
                var res = db.InsertStudent(model);
                if (res > 0) output.Text = "Thanks for the response Your Roll No. is " + res;
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}