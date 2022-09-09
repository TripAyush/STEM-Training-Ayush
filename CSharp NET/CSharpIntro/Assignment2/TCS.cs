using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class TCS : EmployeeInfo, GovtRules
    {
        public TCS(long empid, string name, string dept, string desg, double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }
        public double EmployeePF(double basicSalary)
        {
            double pf = basicSalary * 0.12;
            double epf = basicSalary * 0.833;
            double pension = basicSalary * 0.367;
            double finalPF = pf + epf + pension;
           return finalPF;
        }

        public string LeaveDetails()
        {
            return("1 day of Casual Leave per month \n 12 days of Sick Leave per year \n 10 days of Privilege Leave per year");
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            double gratuity = 0;
            if (serviceCompleted > 5) gratuity = basicSalary;
            if (serviceCompleted > 10) gratuity = 2 * basicSalary;
            if (serviceCompleted > 20) gratuity = 3 * basicSalary;
            if (serviceCompleted < 5) gratuity = 0;

            return gratuity;
        }
    }
}
