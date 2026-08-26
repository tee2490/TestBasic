using ConsoleApp5.Models;

List<Product> products = new List<Product>();

for (int i = 0; i < 10; i++)
{
    var temp = new Product()
    {
        Id = i,
        Name = "Coffee" + i,
        Price = 100
    };

    products.Add(temp);

}

products.ForEach(p => p.Display());