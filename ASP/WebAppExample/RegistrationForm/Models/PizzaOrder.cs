using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationForm.Models
{
    public class PizzaOrder
    {
        public string CustomerName { get; set; }
        public string PhoneNum { get; set; }
        public int Amount { get; set; }
    }
}