using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DALLibrary;

namespace FirstWebExample.Pages
{
    public class CustomerModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(ModelCustomer cust)
        {
            cust.CustName = Request.Form["cname"].ToString();
            cust.CustAddress = Request.Form["cadd"].ToString();
            cust.CusMobile = long.Parse(Request.Form["cmob"].ToString());
            cust.CustEmail = Request.Form["cemail"].ToString();
            cust.CustGender = Request.Form["gender"].ToString();
            cust.Password = new Random().Next(1, 99999).ToString();
            ModelState.AddModelError("",cust.CustName + "," + cust.CustAddress +
                "," + cust.CusMobile + "," + cust.CustEmail + "," + cust.CustGender + "," + cust.Password);

            try
            {
                DBConnect db = new DBConnect();
                var res = db.InsertNewCustomer(cust);
                if (res > 0) ModelState.AddModelError("","New Customer ID : "+res.ToString());
            }
            catch (Exception ex){
                ModelState.AddModelError("", ex.Message);
            }
        }
    }
}
