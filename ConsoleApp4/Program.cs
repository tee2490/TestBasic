

using ConsoleApp4.Models;

//abstract ไม่สามารถสร้างเป็น object
//Product p = new Product();   // Error

Product p1 = new SpecialProduct();
p1.Name = "Keyboard";
p1.Price = 1000;

Product p2 = new ImportProduct();
p2.Name = "Notebook";
p2.Price = 30000;


SpecialProduct p3 = new SpecialProduct();

p3.Name = "Monitor";
p3.Price = 5000;
p3.Weight = 5;

Console.WriteLine(p1.GetNetPrice());
Console.WriteLine(p2.GetNetPrice());
Console.WriteLine($"Shipping = {p3.GetShippingCost()}");

