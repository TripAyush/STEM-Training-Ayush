using System;
using System.Collections.Generic;
using System.Text;

namespace DIExample
{
    class Bike:IDrive
    {
        public void Drive()
        {
            Console.Write("Bike Driving\n");
        }
    }
}
