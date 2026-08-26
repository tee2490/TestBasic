using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Id} {Name} {Price}");
        }
    }
}
