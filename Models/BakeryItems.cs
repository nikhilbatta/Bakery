using System;
using System.Collections.Generic;
 
namespace Bakery
{
    public class BakeryItem
    {
        public int Amount{get;set;}
        public double Price{get;set;}
        private static List<BakeryItem> _instances = new List<BakeryItem>{};
    
    public static List<BakeryItem> GetAll()
     {
        return _instances;
    }

    }
    class Pastry : BakeryItem
    {
        public Pastry(int pastryAmount)
        {
            Amount = pastryAmount;
            
            CalculatePastryPrice();
            _instances.Add(this);
        }
        public void CalculatePastryPrice()
        {
            if(Amount <= 2)
        {
            Price = Amount * 2;
        }
            else if(Amount >= 3)
        {
            Price = Amount * 1.67;
        }
        }
    }
    class Bread : BakeryItem
    {
        public Bread(int breadAmount)
        {
            Amount = breadAmount;
            CalculateBreadPrice();
            _instances.Add(this);
        }
        public void CalculateBreadPrice()
        {
            Price = ((Amount / 3) * 10) + ((Amount % 3) * 5);
        }
    }
}