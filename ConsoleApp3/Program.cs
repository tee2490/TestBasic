using ConsoleApp2.Models;

var tp = new Product();

tp.Id = 1;
tp.Name = "test";
tp.Price = 500;
//tp.Stock Internal
tp.SetStock(55); 

tp.Display();
