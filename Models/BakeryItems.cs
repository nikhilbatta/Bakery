using System;
using System.Collections.Generic;
 
namespace Bakery
{
    public class BakeryItem
    {
        public int Amount;
        public int Price;
    
    public void Print()
    {
        Console.WriteLine(Amount);
    }
    }
    class Pastry : BakeryItem
    {
        public Pastry(int pastryAmount)
        {
            Amount = pastryAmount;
            CalculatePastryPrice();
        }
        public void CalculatePastryPrice()
        {
            if(Amount <= 2)
        {
            Price = aNumber * 2;
        }
            else if(Amount >= 3)
        {
            Price = aNumber * 1.67;
        }
        }
    }
    class Bread : BakeryItem
    {
        public Bread(int breadAmount)
        {
            Amount = breadAmount;
            CalculateBreadPrice();
        }
        public void CalculateBreadPrice()
        {
            Price = ((breadNumber / 3) * 10) + ((breadNumber % 3) * 5);
        }
    }
}