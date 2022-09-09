using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingProject.Models
{
    public class TransactionModel
    {
        public int TransId { get; set; }
        public DateTime TransDate { get; set; }
        public long AccountNo { get; set; }
        public string TransType { get; set; }
        public decimal TransAmount { get; set; }

    }
}