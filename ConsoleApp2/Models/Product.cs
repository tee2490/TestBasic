using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    public class Product  //แม่แบบ นำไปใช้ตรงๆ ไม่ได้
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private double Cost { get; set; } //ราคาต้นทุน

        public void SetCost(int cost)
        {
            Cost = cost;
        }

        public double GetProfit()
        {
            return Price - Cost;
        }

        public void Display()
        {
            Console.WriteLine($"{Id} {Name} {Price} Profit:{GetProfit()}");
        }

    }
}
