using System;
using System.Collections.Generic;

namespace Bakery
{
    public class Pastry
    {
        public int Price;
        public int Amount;
    
    public Pastry()
    {
        Price = 0;
        Amount = 0;
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
        Price = aNumber * 2;
    }
    }
}