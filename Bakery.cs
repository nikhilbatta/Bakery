using System;
using System.Collections.Generic;

namespace Bakery
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to my Bakery please enter in how many pastries you would like to purchase today?");
            int aNumber = int.Parse(Console.ReadLine());
            Pastry pastry = new Pastry();
            pastry.OrderForPastry(aNumber);
            Console.WriteLine(pastry.Price);
        }

    }
}