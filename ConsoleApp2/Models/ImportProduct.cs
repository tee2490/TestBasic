using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    public class ImportProduct : Product
    {
        public override double GetNetPrice()
        {
            return Price * 1.07;
        }
    }
}
