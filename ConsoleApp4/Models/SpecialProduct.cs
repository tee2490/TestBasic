using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models
{
    internal class SpecialProduct : Product
    {
        public override double GetNetPrice()
        {
            return Price-Discount;
        }


        public void Test()
        { 
        }
    }
}
