using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models
{
    internal class SpecialProduct : Product,IShipping
    {
        public double Weight { get; set; }
        public override double GetNetPrice()
        {
            return Price-Discount;
        }

        public double GetShippingCost()
        {
            return Weight * 10;
        }

        public void Test()
        { 
        }
    }
}
