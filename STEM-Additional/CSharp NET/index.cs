//Project File
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSIntro{
    class Program{
        static void Main(string[] args){
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

            EmployeeInfo emp1 = new EmployeeInfo("Ram",'M',32,101,"Sales","Salesman",5000);
            emp1.ShowData();
            emp1.GetEmailAddress();
            Console.WriteLine(emp1.ToString());

            StudentInfo stu1 = new StudentInfo("Shyam",'M',22,102,"BE","Electrical");
            stu1.ShowData();
            stu1.GetEmailAddress();
            Console.WriteLine(stu1.ToString());
        }
    }
}



// Person Info
//Sealed classes can't be inherited
//New Functions can't be overrided
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSIntro{
    abstract class PersonInfo{
        string name;
        char gender;
        int age;

        public virtual void GetData(){
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Gender(M/F)");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Age");
            age = int.Parse(Console.ReadLine());
        }

        public virtual void ShowData(){
            Console.WriteLine("Name" + name);
            Console.WriteLine("Age" + age);
            Console.WriteLine("Gender" + gender);
        }

        public PersonInfo(string name, int age, char gender){
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public PersonInfo(){
            name = "default";
            gender = 'D';
            age = 9999;
        }

        public PersonInfo(string name, int age){
            this.name = name;
            this.age = age;
        }

        public abstract double calculate();
    }
}



// Employee Info
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSIntro{
    class EmployeeInfo:PersonInfo{
        int empId;
        string dept;
        string desg;
        double salary;

         public override void GetData(){
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

        public override void ShowData(){
            base.ShowData();
        }

        public override double calculate(){
            double da = salary*30;
            double hra = salary*15;
            double conv = salary*10;
            double pf = salary*.125;

            return ((salary + da + hra + conv) - pf);
        }

        public override string ToString(){
            return "$" + calculate().ToString(); + "\nEmail ID for offer letter" : email;
        }

        string email = "";
        public void GetEmailAddress(){
            Console.WriteLine("Enter email address");
            email = Console.ReadLine();
        }

        public string PrintEmailAddress(){
            return email;
        }

        public EmployeeInfo() : base(){

        }

        public EmployeeInfo(string name, char gen,int age,int empId,string dept,string desg,double sal):base(){
            (name,gen,age){
                this.empId = empId;
                this.dept = dept;
                this.desg = desg;
                this.salary = sal;
            }
        }
    }
}



//Student Info
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSIntro{
    sealed class StudentInfo:PersonInfo,MailingAddress{
        int rollno;
        string branch;
        string course;
        double aggr;

        public override void GetData(){
            base.GetData();
            Console.WriteLine("Enter RollNo");
            rollno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Branch");
            branch = Console.ReadLine();

            Console.WriteLine("Enter Course");
            course = Console.ReadLine();
        }

        public override void ShowData(){
            base.ShowData();
            Console.WriteLine("RollNo"+rollno);
            Console.WriteLine("Branch"+branch);
            Console.WriteLine("Course"+course);
        }

        public override double calculate(){
            int[] marks = new int[5];
            Console.WriteLine("Enter marks");
            for(int i=0; i<marks.Length; i++){
                marks[i] = int.Parse(Console.ReadLine());
                aggr += marks[i];
            }
            aggr /= 5;
            return aggr;
        }

         public override string ToString(){
            return calculate().ToString(); + "\nEmail ID for Admission" + email;
        }

        string email = "";
        public void GetEmailAddress(){
        Console.WriteLine("Enter email address");
        email = Console.ReadLine();
        }

        public string PrintEmailAddress(){
            return email;
        }


        public StudentInfo() : base(){

        }

        public StudentInfo(string name, char gender,int age,int rollno,string course,string branch):base(){
            (name,gender,age){
                this.rollno = rollno;
                this.course = course;
                this.branch = branch;
            }
        }
    }
}


//Interface 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSIntro{
    interface MailingAddress{
        void GetEmailAddress();
        string PrintEmailAddress();
    }
}
