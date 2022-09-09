using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSIntro
{
    class StudentInfo : PersonInfo,MailingAddress
    {
        int rollno;
        string branch;
        string course;
        double aggr;

        public override void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter RollNo");
            rollno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Branch");
            branch = Console.ReadLine();

            Console.WriteLine("Enter Course");
            course = Console.ReadLine();
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine("RollNo" + rollno);
            Console.WriteLine("Branch" + branch);
            Console.WriteLine("Course" + course);
        }

        public override double calculate()
        {
            int[] marks = new int[5];
            Console.WriteLine("Enter marks");
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
                aggr += marks[i];
            }
            aggr /= 5;
            return aggr;
        }

        public override string ToString()
        {
            return (calculate().ToString());
        }

        public void GetEmailAddress()
        {
            throw new NotImplementedException();
        }

        public string PrintEmailAddress()
        {
            throw new NotImplementedException();
        }

        public StudentInfo() : base()
        {

        }

        public StudentInfo(string name, char gender, int age, int rollno, string course, string branch) : base()
        {
            (name, gender, age){
                this.rollno = rollno;
                this.course = course;
                this.branch = branch;
            }
        }
    }
}