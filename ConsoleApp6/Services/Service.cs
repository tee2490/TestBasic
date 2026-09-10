using ConsoleApp6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6.Services
{
    public class Service : IService
    {
        List<Product> Products;
        Random rnd;

        public Service()
        {
            Products = new List<Product>();
            rnd = new Random();
        }

        public void Display()
        {
            foreach (var p in Products)
            {
                Console.WriteLine($"{p.Id,5} {p.Name,10} {p.Price,5}" +
                    $"{p.B1,4} {p.B2,4} {p.B3,4}");
            }
        }

        public void Mock(int num = 5)
        {
            for (int i = 0; i < num; i++)
            {
                var prod = new Product()
                {
                    Id = "P00" + i,
                    Name = "Product" + i,
                    Price = rnd.Next(10,5001),
                    B1 = rnd.Next(1,21),
                    B2 = rnd.Next(1, 21),
                    B3 = rnd.Next(1, 21),
                };

                Products.Add(prod);
            }
        }

    }
}
