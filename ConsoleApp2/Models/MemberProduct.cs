using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    public class MemberProduct : Product
    {
        public override double GetNetPrice()
        {
            return Price * 0.90;
        }
    }
}
