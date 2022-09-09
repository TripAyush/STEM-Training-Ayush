using System;
using System.Collections.Generic;
using System.Text;

namespace DIExample
{
    class Car:IDrive
    {
        public void Drive()
        {
            Console.Write("Car Driving\n");
        }
    }
}
