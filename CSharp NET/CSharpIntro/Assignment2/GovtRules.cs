using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    interface GovtRules
    {
        double EmployeePF(double basicSalary);
        string LeaveDetails();
        double gratuityAmount(float serviceCompleted, double basicSalary);
    }
}
