using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models
{
    //ข้อกำหนดว่าให้ทำอะไร What ไม่มีโค้ด เน้นที่ Method
    internal interface IShipping
    {
        double GetShippingCost();
    }
}
