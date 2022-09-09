using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dessert Shop!");
            // Console.WriteLine("Candy Cookie IceCream");
            Console.Write("Please enter your choice: \n Candy \n Cookie \n IceCream");
            string choice = Console.ReadLine();
            
            switch (ch){
                case 'Candy':
                    Console.Write("\nEnter Candy Name: ");
                    string candyName = Console.ReadLine();
                    Console.Write("Enter Candy Weight: ");
                    double weight = double.Parse(Console.ReadLine());
                    Console.Write("Enter Candy Price per Pound: ");
                    double pricePerPound = double.Parse(Console.ReadLine());
                    Candy candy = new Candy(candyName, weight, pricePerPound);
                    Console.WriteLine(candy.ToString());
                    break;
                case 'Cookie':
                    Console.Write("\nEnter Cookie Name: ");
                    string cookieName = Console.ReadLine();
                    Console.Write("Enter Cookie Count: ");
                    int itemCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter Cookie Price per Dozen: ");
                    double pricePerDozen = double.Parse(Console.ReadLine());
                    Cookie cookie = new Cookie(cookieName, itemCount, pricePerDozen);
                    Console.WriteLine(cookie.ToString());
                    break;
                case 'Ice Cream':
                    Console.Write("\nEnter Ice Cream Name: ");
                    string iceCreamName = Console.ReadLine();
                    Console.Write("Enter Ice Cream Scoops: ");
                    int scoops = int.Parse(Console.ReadLine());
                    Console.Write("Enter Ice Cream Price per Sccop: ");
                    double pricePerScoop = double.Parse(Console.ReadLine());
                    Console.Write("Enter Ice Cream Toppings Price: ");
                    double toppingsPrice = double.Parse(Console.ReadLine());
                    IceCream iceCream = new IceCream(iceCreamName, scoops, toppingsPrice, pricePerScoop);
                    Console.WriteLine(iceCream.ToString());
                    break;
                default:
                    Console.WriteLine("Please Enter a valid choice");
                    break;
            }
        }
    }
}

