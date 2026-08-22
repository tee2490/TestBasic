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
        protected int Discount { get; set; }   // ใช้ได้ใน Product และ Class ลูก
        internal int Stock { get; set; } // ใช้ได้ภายใน Project เดียวกัน

        public void SetCost(int cost)
        {
            Cost = cost;
        }

       
        public double GetProfit()
        {
            return Price - Cost;
        }

        // ใช้สำหรับกำหนด Stock จาก Project อื่น
        public void SetStock(int stock)
        {
            Stock = stock;
        }

        // ใช้สำหรับอ่าน Stock จาก Project อื่น
        public int GetStock()
        {
            return Stock;
        }

        public void Display()
        {
            Console.WriteLine($"{Id} {Name} {Price} Stock:{Stock} Profit:{GetProfit()}");
        }

    }
}
