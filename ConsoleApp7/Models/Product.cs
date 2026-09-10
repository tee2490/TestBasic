using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int M1 { get; set; }
        public int M2 { get; set; }
        public int M3 { get; set; }
        public int M4 { get; set; }

        public int TotalQuantity() => M1 + M2 + M3 + M4;
        public double Amount() => Price * TotalQuantity();
    }
}
