using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models
{
    internal class SpecialProduct : Product,IShipping,IPrintable
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

        public void Print()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Shippin Cost: {GetShippingCost()}");
        }

        public void Test()
        { 
        }
    }
}
