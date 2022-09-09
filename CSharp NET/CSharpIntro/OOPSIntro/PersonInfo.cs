using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSIntro
{
    abstract class PersonInfo
    {
        string name;
        char gender;
        int age;

        public virtual void GetData()
        {
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Gender(M/F)");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Age");
            age = int.Parse(Console.ReadLine());
        }

        public virtual void ShowData()
        {
            Console.WriteLine("Name" + name);
            Console.WriteLine("Age" + age);
            Console.WriteLine("Gender" + gender);
        }

        public PersonInfo(string name, int age, char gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public PersonInfo()
        {
            name = "default";
            gender = 'D';
            age = 9999;
        }

        public PersonInfo(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract double calculate();
    }
}