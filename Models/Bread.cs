using System;
using System.Collections.Generic;

namespace Bakery
{
    public class Bread
    {
        public double Price{get;set;}
        public int Amount{get;set;}
        

        public Bread()
        {
            Price = 0;
            Amount = 0;
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
            
            // if(breadNumber == 1)
            // {
            //     Price = breadNumber * 5;
            // }
            // else if(breadNumber >= 2)
            // {
            //     Price = ((((breadNumber + 1) * 2) / 3) * 5);
            // }
        }
    }
    
}