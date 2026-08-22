using ConsoleApp2.Models;

var p1 = new Product();
p1.Name = "Mouse";
p1.Price = 500;

var p2 = new SpecialProduct();
p2.Name = "Keyboard";
p2.Price = 1000;

var p3 = new MemberProduct();
p3.Name = "Monitor";
p3.Price = 5000;

var p4 = new ImportProduct();
p4.Name = "Notebook";
p4.Price = 30000;

// เรียก Method เดียวกัน
Console.WriteLine(p1.GetNetPrice());
Console.WriteLine(p2.GetNetPrice());
Console.WriteLine(p3.GetNetPrice());
Console.WriteLine(p4.GetNetPrice());