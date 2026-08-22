using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Product  //แม่แบบ นำไปใช้ตรงๆ ไม่ได้
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        //method/function/module โปรแกรมย่อย
        public void Display()
        {
            Console.WriteLine($"{Id} {Name} {Price}");
        }
    }
}
