using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayrollManagement.Models
{
    public class SalaryModels
    {
        public int SalaryId { get; set; }
        public int EmpId { get; set; }

        public decimal Salary { get; set; }
        public string Desg { get; set; }

    }
}