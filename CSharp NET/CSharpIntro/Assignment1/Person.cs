using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Person
    {
        string firstName, lastName, email;
        DateTime dateOfBirth;
        public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
        }
        public Person(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }
        public void Adult()
        {
            if (DateTime.Now.Year - this.dateOfBirth.Year >= 18)
            {
                Console.WriteLine("You are over 18 years of age.");
            }
            else
            {
                Console.WriteLine("You are under 18 years of age.");
            }
        }
        public void Birthday()
        {
            if (dateOfBirth.Date == DateTime.Now.Date && dateOfBirth.Month == DateTime.Now.Month)
            {
                Console.WriteLine("Happy" + (DateTime.Now.Year - dateOfBirth.Year) + "th Birthday");
            }
            else
            {
                Console.WriteLine("You were born on " + dateOfBirth);
            }
        }
    }
}

