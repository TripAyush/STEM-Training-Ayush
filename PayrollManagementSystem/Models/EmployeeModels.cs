using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayrollManagement.Models
{
    public class EmployeeModels
    {
        public int EmpId { get; set; }
        public string Empname { get; set; }
        public string Dept { get; set; }
        public string EmailId { get; set; }
        public long MobNo { get; set; }
        public string Location { get; set; }
        public string Desg { get; set; }
    }
}