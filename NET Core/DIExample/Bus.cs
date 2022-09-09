using System;
using System.Collections.Generic;
using System.Text;

namespace DIExample
{
    class Bus:IDrive
    {
        public void Drive()
        {
            Console.Write("Bus Driving\n");
        }
    }
}
