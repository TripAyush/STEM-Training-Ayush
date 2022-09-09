using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // PersonInfo martin = new PersonInfo();
            // martin.GetData();
            // martin.ShowData();

            // PersonInfo blake = new PersonInfo();
            // blake.ShowData();

            // PersonInfo clark = new PersonInfo("Clark",'M',34);
            // clark.ShowData();

            // PersonInfo scott = new PersonInfo("Scott",78);
            // scott.ShowData();

            EmployeeInfo emp = new EmployeeInfo();
            emp.GetData();
            emp.ShowData();
            Console.WriteLine(emp.ToString());

            StudentInfo stu = new StudentInfo();
            stu.GetData();
            stu.ShowData();
            Console.WriteLine(stu.ToString());

            EmployeeInfo emp1 = new EmployeeInfo("Ram", 'M', 32, 101, "Sales", "Salesman", 5000);
            emp1.ShowData();
            Console.WriteLine(emp1.ToString());

            StudentInfo stu1 = new StudentInfo("Shyam", 'M', 22, 102, "BE", "Electrical");
            stu1.ShowData();
            Console.WriteLine(stu1.ToString());
        }
    }
}