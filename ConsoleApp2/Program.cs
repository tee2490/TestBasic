
using ConsoleApp2.Models;

var p = new Product();

//p.Cost เข้าโดยตรง
p.SetCost(1000); //โดยอ้อม ผ่าน method
p.Price = 1500;
p.Display();
