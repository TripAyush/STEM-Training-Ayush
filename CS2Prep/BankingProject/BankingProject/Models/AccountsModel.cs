using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingProject.Models
{
    public class AccountsModel
    {
        public long AccountNo { get; set; }

        public int CustId { get; set; }

        public string AccountType { get; set; }

        public decimal Balance { get; set; }

        public string Status { get; set; }

    }
}