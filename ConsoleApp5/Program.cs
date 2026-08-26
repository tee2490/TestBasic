using ConsoleApp5.Interfaces;
using ConsoleApp5.Models;
using ConsoleApp5.Services;

ProductService ps = new ProductService();
ps.Mock(5);

Product p = new Product()
{
    Id = 6,
    Name = "Mouse",
    Price = 500
};

ps.Create(p);

ps.Read();

Console.WriteLine();
Product result = ps.Search(3);

if (result != null)
{
    result.Display();
}