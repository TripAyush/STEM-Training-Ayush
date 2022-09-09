using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                a = 10;
                b = 10;
                c = a / b;

                Console.WriteLine("Div " + c);
                Console.WriteLine("Enter a string");
                string str = Console.ReadLine();

                if (str == "HELLO WORLD") Console.WriteLine("All good");
                else throw new Exception("Wrong String");

                Console.WriteLine("After Error");
                Console.WriteLine("After Error");
                Console.WriteLine("After Error");
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
        }
    }
}
