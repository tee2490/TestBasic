using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models
{
    internal class ImportProduct : Product
    {
        public override double GetNetPrice()
        {
            return Price * 1.07;
        }
    }
}
