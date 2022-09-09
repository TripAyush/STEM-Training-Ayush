using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Item
    {
        int code;
        string desc;
        int qty;
        double price;
        double total;
        public Item(int code, string desc, int qty, double price)
        {
            this.code = code;
            this.desc = desc;
            this.qty = qty;
            this.price = price;
        }
        public double Calculate()
        {
            return this.qty * this.price;
        }
    }
}

