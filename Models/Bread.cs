using System;
using System.Collections.Generic;

namespace Bakery
{
    public class Bread
    {
        public int Price{get;set;}
        public int Amount{get;set;}
        private static List<Bread> _Breads = new List<Bread> {};
        
        public Bread()
        {
            Price = 0;
            Amount = 0;
            _Breads.Add(this);
        }
        public static List<Bread> GetAllBread()
        {
        return _Breads;
        }
        public void OrderForBread(int breadNumber)
        {
            AddBread(breadNumber);
            AdjustPrice(breadNumber);
        }
        private void AddBread(int breadNumber)
        {
            Amount = breadNumber;
        }
        private void AdjustPrice(int breadNumber)
        {
            // need to catch 2,5,8,11 for the free ones. 
            Price = ((breadNumber / 3) * 10) + ((breadNumber % 3) * 5);
        }
    }
    
}