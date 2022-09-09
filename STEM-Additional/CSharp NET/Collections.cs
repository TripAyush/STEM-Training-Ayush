using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExample{
    class Program{
        static void Main(string[] args){
            List<PizzaInfo> plist = new List<PizzaInfo>();
            plist.Add(new PizzaInfo{PizzaName="Cheese Pizza",PizzaSize='S',PizzaType="Veg",Toppings="Cheese",Price=120});

            plist.Add(new PizzaInfo{PizzaName="Chicken Pizza",PizzaSize='M',PizzaType="NonVeg",Toppings="Bacon",Price=250});

            plist.Add(new PizzaInfo{PizzaName="Fresh Farm Pizza",PizzaSize='L',PizzaType="Veg",Toppings="Cheese",Price=170});

            foreach (PizzaInfo p in plist){
                Console.WriteLine(p.PizzaName + "." + p.PizzaSize + "." + p.PizzaType + "." + p.Toppings + "." + p.Price);

            }

            Dictionary<int,PizzaInfo> pizzas = new Dictionary<int,PizzaInfo>();
            pizzas.Add(1,new PizzaInfo{PizzaName="Cheese Pizza",PizzaSize='S',PizzaType="Veg",Toppings="Cheese",Price=120});
            pizzas.Add(2,new PizzaInfo{PizzaName="Chicken Pizza",PizzaSize='M',PizzaType="NonVeg",Toppings="Bacon",Price=250});
            pizzas.Add(3,new PizzaInfo{PizzaName="Corn Pizza",PizzaSize='M',PizzaType="NonVeg",Toppings="Bacon",Price=150});
            pizzas.Add(4,new PizzaInfo{PizzaName="Farmhouse Pizza",PizzaSize='M',PizzaType="Veg",Toppings="Cheese",Price=270});

            foreach (var p in pizzas){
                Console.WriteLine(p.Key + " " + p.Value.PizzaName + " " + p.Value.PizzaType + " " + p.Value.PizzaSize + " " + p.Value.Price + " " + p.Value.Toppings);
            }
        }
    }
}



// Pizza Info
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExample{
    class PizzaInfo{
        public string PizzaName { get; set; }
        public char PizzaSize { get; set; }
        public string PizzaType { get; set; }
        public string Toppings { get; set; }
        public double Price { get; set; }
    }
}
