using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETSecurity.Models
{
    public class ReunionModel
    {
        public int MemId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public long PhNo { get; set; }
        public string Attendance { get; set; }
        public string Meals { get; set; }
        public string Games { get; set; }
        public string Questions { get; set; }
    }
}