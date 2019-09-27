using System;
using System.Collections.Generic;

namespace Bakery
{
    class Program
    {
        public static void Main()
        {
            
            StartBakery();

            
        }
        public static void StartBakery()
        {
            Console.WriteLine("Welcome to my Bakery please enter in how many pastries you would like to purchase today?");
            int aNumber = int.Parse(Console.ReadLine());
            Pastry pastry1 = new Pastry(aNumber);
            pastry1.CalculatePastryPrice();
            Console.WriteLine(pastry1.Price);


            Console.WriteLine("Enter in how many loafs of bread");
            int anotherNumber = int.Parse(Console.ReadLine());
            Bread bread = new Bread(anotherNumber);
            bread.CalculateBreadPrice();
            Console.WriteLine(bread.Price);
            
            
            Console.WriteLine("Would you like to add to your order?");
            string answer = Console.ReadLine();
            if(answer == "y")
            {
                // recursive function
                StartBakery();
            }
            else {
            //     // show total price 
                Program.GetList();
            }
        }
        public static void GetList()
        {
            List<BakeryItem> bakeryResult = BakeryItem.GetAll();
            
            foreach(BakeryItem item in bakeryResult)
            {
               Console.WriteLine(item);
            }
        }
    }
}