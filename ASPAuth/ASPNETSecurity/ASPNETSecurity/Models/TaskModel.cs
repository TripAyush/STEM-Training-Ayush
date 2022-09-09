using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETSecurity.Models
{
    public class TaskModel
    {
        public int rollNo { get; set; }
        public string Name { get; set; }
        public int accounts { get; set; }
        public int marketing { get; set; }
        public int computing { get; set; }

        public int totalMarks { get; set; }
        public int aggMarks { get; set; }
        public char totalGrade { get; set; }


    }
}