using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    //Inheritance การสืบทอด เพื่อ reuse
    public class SpecialProduct : Product
    {
        
        public void SetDiscount(int discount)
        {
            //protected สืบทอดได้ แต่เรียกใช้แบบทางอ้อม
            Discount = discount;   // ได้ เพราะเป็น Class ลูก
        }

        public double GetNetPrice()
        {
            return Price - Discount;
        }

        // เขียนทับ Display() ของ Product
        public override void Display()
        {
            double netPrice = Price - Discount;

            Console.WriteLine(
                $"{Id} {Name} Price:{Price} Discount:{Discount} Net:{netPrice}"
            );
        }


        // เรียก Display ของแม่
        public void DisplayParent()
        {
            base.Display();
        }
    }
}
