using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class EmployeeInfo
    {
        public long empid;
        public string name;
        public string dept;
        public string desg;
        public double basicSalary;

        public EmployeeInfo(long empid, string name, string dept, string desg, double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }
    }
}
