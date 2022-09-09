using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingProject.Models
{
    public class CustomerModel
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public long MobNo { get; set; }
        public string EmailId { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }

    }
}