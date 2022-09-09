using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ans;
            double totalAmt = 0;
            do
            {
                Console.WriteLine("Enter item code");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter item desc");
                string desc = Console.ReadLine();
                Console.WriteLine("Enter item qty");
                int qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter item price");
                double price = double.Parse(Console.ReadLine());
                Item item = new Item(code, desc, qty, price);
                totalAmt += item.Calculate();
                Console.WriteLine("Continue?(y/n)");
                ans = char.Parse(Console.ReadLine());
            }
            while (ans == 'y');
            if (totalAmt > 10000)
            {
                totalAmt -= totalAmt * 0.1;
            }
            else if (totalAmt < 1000)
            {
                Console.WriteLine("Do you want to pay with card?(y/n)");
                if (char.Parse(Console.ReadLine()) == 'y')
                {
                    totalAmt += totalAmt * 0.025;
                }

            }
            Console.WriteLine("Total amount to be paid: " + totalAmt);

            //2nd Ques

            Console.WriteLine("\nEnter First Name");
            string first = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string last = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth");
            DateTime DOB = DateTime.Parse(Console.ReadLine());
            Person person = new Person(first, last, email, DOB);
            // Person person = new Person(first, last, email);
            // Person person = new Person(first, last, DOB);
            person.Adult();
            person.Birthday();
        }
    }
}

