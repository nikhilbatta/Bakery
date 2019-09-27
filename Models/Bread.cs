using System;
using System.Collections.Generic;

namespace Bakery
{
    public class Bread
    {
        public double Price;
        public int Amount;
        

        public Bread()
        {
            Price = 0;
            Amount = 0;
        }
        private void AddBread(int breadNumber)
        {
            Amount = breadNumber;
        }
        private void AdjustPrice(int breadNumber)
        {
            if(breadNumber = 1)
            {
                Price = breadNumber * 5;
            }
            else if(breadNumber >= 2)
            {
                
            }
        }
    }
    
}