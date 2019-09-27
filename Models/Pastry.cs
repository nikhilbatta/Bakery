using System;
using System.Collections.Generic;

namespace Bakery
{
    public class Pastry
    {
        public double Price{get;set;}
        public int Amount{get;set;}
        private static List<Pastry> _instances = new List<Pastry> {};
    
    public Pastry()
    {
        Price = 0;
        Amount = 0;
        _instances.Add(this);
    }
    public static List<Pastry> GetAll()
    {
        return _instances;
    }
    public void OrderForPastry(int aNumber)
    {
        AddPastry(aNumber);
        AdjustPrice(aNumber);
    }
    private void AddPastry(int aNumber)
    {
        Amount += aNumber;
    }
    private void AdjustPrice(int aNumber)
    {
        
        if(aNumber <= 2){
            Price = aNumber * 2;
        }
        else if(aNumber >= 3)
        {
            Price = aNumber * 1.67;
        }
        
    }
    }
}