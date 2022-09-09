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
    public partial class PizzaForm : System.Web.UI.Page
    {
        PizzaOrder model = new PizzaOrder();
        PizzaFormDB db = new PizzaFormDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderPizza_Click(object sender, EventArgs e)
        {
            model.CustomerName = txtname.Text;
            model.PhoneNum = txtnumber.Text;
            model.Amount = 0;

            if(p1Type.Checked)
            {

                p1Final.Text = (int.Parse(p1Qty.Text) * int.Parse(p1Price.Text)).ToString();
                model.Amount += int.Parse(p1Final.Text);
                
            }

            if (p2Type.Checked)
            {

                p2Final.Text = (int.Parse(p2Qty.Text) * int.Parse(p2Price.Text)).ToString();
                model.Amount += int.Parse(p2Final.Text);
            }
            if (p3Type.Checked)
            {

                p3Final.Text = (int.Parse(p3Qty.Text) * int.Parse(p3Price.Text)).ToString();
                model.Amount += int.Parse(p3Final.Text);
            }

            totalPrice.Text = model.Amount.ToString();

            try
            {
                int res = db.insertPizzaTable(model);
                if (res > 0) output.Text = "Data Inserted Successfully";
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }
        }
    }
}