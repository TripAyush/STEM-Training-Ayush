using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSIntro
{
    class EmployeeInfo : PersonInfo,MailingAddress
    {
        int empId;
        string dept;
        string desg;
        double salary;

        public override void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter EmpID");
            empId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter DeptName");
            dept = Console.ReadLine();

            Console.WriteLine("Enter Designation");
            desg = Console.ReadLine();

            Console.WriteLine("Enter Salary");
            salary = double.Parse(Console.ReadLine());
        }

        public override void ShowData()
        {
            base.ShowData();
        }

        public override double calculate()
        {
            double da = salary * 30;
            double hra = salary * 15;
            double conv = salary * 10;
            double pf = salary * .125;

            return ((salary + da + hra + conv) - pf);
        }

        public override string ToString()
        {
            return "$" + calculate().ToString();
        }

        public void GetEmailAddress()
        {
            throw new NotImplementedException();
        }

        public string PrintEmailAddress()
        {
            throw new NotImplementedException();
        }

        public EmployeeInfo() : base()
        {

        }

        public EmployeeInfo(string name, char gen, int age, int empId, string dept, string desg, double sal) : base()
        {
            (name, gen, age){
                this.empId = empId;
                this.dept = dept;
                this.desg = desg;
                this.salary = sal;
            }
        }
    }
}