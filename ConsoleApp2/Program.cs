using ConsoleApp2.Models;

var sp = new SpecialProduct();

sp.SetCost(100); //mothor method 
sp.Price = 150;
sp.SetDiscount(5); //child
Console.WriteLine(sp.GetNetPrice());
sp.Display();

// ต้องการเรียก Display ของแม่
sp.DisplayParent();