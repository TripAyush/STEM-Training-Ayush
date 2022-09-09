using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationForm.Models
{
    public class RegTableModel
    {
        //Poco class - Plain old CLR objects
        public string Name{get; set;}
            public string Address { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }
        public string City { get; set; }
        public string SkillSets { get; set; }
        public int Age { get; set; }
            public string Email { get; set; }



    }
}