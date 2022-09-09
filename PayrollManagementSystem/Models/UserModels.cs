using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayrollManagement.Models
{
    public class UserModels
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserRole { get; set; }  

        public string Password { get; set; }
    }
}